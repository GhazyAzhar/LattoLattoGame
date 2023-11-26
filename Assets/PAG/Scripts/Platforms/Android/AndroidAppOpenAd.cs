#if UNITY_ANDROID
using System;
using PAG.Scripts.Api;
using PAG.Scripts.Common;
using UnityEngine;

namespace PAG.Scripts.Platforms.Android
{
    internal class AndroidAppOpenAd : IPAGAppOpenAd
    {
        public event Action OnLoad;
        public event Action<int, string> OnLoadFailed;
        public event Action OnAdShowed;
        public event Action OnAdClicked;
        public event Action OnAdDismissed;

        private const string AppOpenClassName = AndroidPlatformTool.ClassPackage + ".PAGAppOpenAdWrapper";
        private readonly AndroidJavaObject appOenAdWrapper;

        internal AndroidAppOpenAd()
        {
            this.appOenAdWrapper = new AndroidJavaObject(AppOpenClassName);
        }

        public void Load(string slotId, PAGAppOpenRequest request)
        {
            appOenAdWrapper?.Call("loadAd", slotId, request?.ToJson(), new AdLoadCallback(OnLoad, OnLoadFailed));
        }

        public bool IsLoaded()
        {
            return appOenAdWrapper != null && appOenAdWrapper.Call<bool>("isLoaded");
        }

        public void Show()
        {
            appOenAdWrapper?.Call("showAd", AndroidPlatformTool.GetGameActivity(),
                new AdInteractionCallback(OnAdShowed, OnAdClicked, OnAdDismissed));
        }

        public void Destroy()
        {
            appOenAdWrapper?.Call("destroy");
        }
    }
}
#endif