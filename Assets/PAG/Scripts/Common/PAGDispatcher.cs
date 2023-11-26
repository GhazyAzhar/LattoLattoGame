namespace PAG.Scripts.Common
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    /// <summary>
    /// The unity thread dispatcher.
    /// </summary>
    [DisallowMultipleComponent]
    internal sealed class PAGDispatcher : MonoBehaviour
    {
        private static bool _instanceCreated;

        // The thread safe task queue.
        private static readonly List<Action> PostTasks = new List<Action>();

        // The executing buffer.
        private static readonly List<Action> Executing = new List<Action>();

        static PAGDispatcher()
        {
            CreateInstance();
        }

        /// <summary>
        /// Work thread post a task to the main thread.
        /// </summary>
        public static void PostTask(Action task)
        {
            lock (PostTasks)
            {
                PostTasks.Add(task);
            }
        }

        /// <summary>
        /// Start to run this dispatcher.
        /// </summary>
        [RuntimeInitializeOnLoadMethod]
        private static void CreateInstance()
        {
            if (_instanceCreated || !Application.isPlaying) return;
            var go = new GameObject(
                "PAGDispatcher", typeof(PAGDispatcher));
            DontDestroyOnLoad(go);
            _instanceCreated = true;
        }

        private void OnDestroy()
        {
            lock (PostTasks)
            {
                PostTasks.Clear();
            }

            Executing.Clear();
        }

        private void Update()
        {
            lock (PostTasks)
            {
                if (PostTasks.Count > 0)
                {
                    Executing.AddRange(PostTasks);
                    PostTasks.Clear();
                }
            }

            foreach (var task in Executing)
            {
                try
                {
                    task();
                }
                catch (Exception e)
                {
                    Debug.LogError(e.Message, this);
                }
            }

            Executing.Clear();
        }
    }
}