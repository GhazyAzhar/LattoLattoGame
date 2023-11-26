#if UNITY_ANDROID
using System;
using PAG.Scripts.Api;
using PAG.Scripts.Common;
using UnityEngine;

namespace PAG.Scripts.Platforms.Android
{
    internal class AndroidInterstitialAd : IPAGInterstitialAd
    {
        public event Action OnLoad;
        public event Action<int, string> OnLoadFailed;
        public event Action OnAdShowed;
        public event Action OnAdClicked;
        public event Action OnAdDismissed;

        private const string InterstitialClassName = AndroidPlatformTool.ClassPackage + ".PAGInterstitialAdWrapper";
        private readonly AndroidJavaObject interstitialAdWrapper;

        public AndroidInterstitialAd()
        {
            interstitialAdWrapper = new AndroidJavaObject(InterstitialClassName);
        }

        public void Load(string slotId, PAGInterstitialRequest request)
        {
            interstitialAdWrapper?.Call("loadAd", slotId, request?.ToJson(), new AdLoadCallback(OnLoad, OnLoadFailed));
        }

        public bool IsLoaded()
        {
            return interstitialAdWrapper != null && interstitialAdWrapper.Call<bool>("isLoaded");
        }

        public void Show()
        {
            interstitialAdWrapper?.Call("showAd", AndroidPlatformTool.GetGameActivity(),
                new AdInteractionCallback(OnAdShowed, OnAdClicked, OnAdDismissed));
        }

        public void Destroy()
        {
            interstitialAdWrapper?.Call("destroy");
        }
    }
}
#endif