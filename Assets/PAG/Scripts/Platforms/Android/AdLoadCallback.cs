#if UNITY_ANDROID
using System;
using UnityEngine;

namespace PAG.Scripts.Platforms.Android
{
    public class AdLoadCallback : AndroidJavaProxy
    {
        private readonly Action onLoad;
        private readonly Action<int, string> onLoadFailed;

        public AdLoadCallback(Action onLoad, Action<int, string> onLoadFailed) : base(
            AndroidPlatformTool.ClassPackage + ".PAGAdLoadListener")
        {
            this.onLoad = onLoad;
            this.onLoadFailed = onLoadFailed;
        }

        public void onError(int code, string message)
        {
            onLoadFailed?.Invoke(code, message);
        }

        public void onAdLoaded()
        {
            onLoad?.Invoke();
        }
    }
}
#endif