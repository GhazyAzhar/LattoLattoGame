#if UNITY_ANDROID
using System;
using PAG.Scripts.Api;
using PAG.Scripts.Common;
using UnityEngine;

namespace PAG.Scripts.Platforms.Android
{
    internal class AndroidNativeAd : INativeAd
    {
        public event Action OnLoad;
        public event Action<int, string> OnLoadFailed;
        public event Action OnAdShowed;
        public event Action OnAdClicked;
        public event Action OnAdDismissed;

        private const string NativeBridgeClassName = AndroidPlatformTool.ClassPackage + ".PAGNativeAdWrapper";
        private const string NativeViewIdProvider = AndroidPlatformTool.ClassPackage + ".NativeViewIdProvider";

        private readonly AndroidJavaObject nativeBridge;

        public AndroidNativeAd()
        {
            nativeBridge = new AndroidJavaObject(NativeBridgeClassName);
        }

        public void Load(string slotId, PAGNativeRequest request)
        {
            nativeBridge?.Call("loadAd", slotId, request?.ToJson(), new AdLoadCallback(OnLoad, OnLoadFailed));
        }

        public bool IsLoaded()
        {
            return nativeBridge != null && nativeBridge.Call<bool>("isLoaded");
        }

        public void Show()
        {
            nativeBridge?.Call("showAd", AndroidPlatformTool.GetGameActivity(),
                new AndroidJavaObject(NativeViewIdProvider),
                new AdInteractionCallback(OnAdShowed, OnAdClicked, OnAdDismissed));
        }

        public void Destroy()
        {
            nativeBridge?.Call("destroy", AndroidPlatformTool.GetGameActivity());
        }

        public void SetPosition(int x, int y)
        {
            nativeBridge?.Call("setPosition", x, y);
        }
    }
}
#endif