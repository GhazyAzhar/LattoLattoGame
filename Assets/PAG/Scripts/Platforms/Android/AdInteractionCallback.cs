#if UNITY_ANDROID

using System;
using UnityEngine;

namespace PAG.Scripts.Platforms.Android
{
    public class AdInteractionCallback : AndroidJavaProxy
    {
        private readonly Action OnAdShowed;
        private readonly Action OnAdDismissed;
        private readonly Action OnAdClicked;
        private const string ListenerName = AndroidPlatformTool.ClassPackage + ".AdInteractionListenerWrapper";

        public AdInteractionCallback(Action onAdShowed, Action onAdClicked, Action onAdDismissed,
            string listenerName = ListenerName) : base(listenerName)
        {
            OnAdShowed = onAdShowed;
            OnAdDismissed = onAdDismissed;
            OnAdClicked = onAdClicked;
        }

        public void onAdShowed()
        {
            OnAdShowed?.Invoke();
        }

        public void onAdDismissed()
        {
            OnAdDismissed?.Invoke();
        }

        public void onAdClicked()
        {
            OnAdClicked?.Invoke();
        }
    }
}
#endif