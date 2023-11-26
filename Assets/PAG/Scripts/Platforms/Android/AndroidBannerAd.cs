#if UNITY_ANDROID
using System;
using PAG.Scripts.Api;
using PAG.Scripts.Api.Constant;
using PAG.Scripts.Common;
using UnityEngine;

namespace PAG.Scripts.Platforms.Android
{
    class AndroidBannerAd : IBannerAd
    {
        private const string BannerBridgeClassName = AndroidPlatformTool.ClassPackage + ".PAGBannerAdWrapper";

        private readonly AndroidJavaObject bannerBridge;

        public AndroidBannerAd()
        {
            bannerBridge = new AndroidJavaObject(BannerBridgeClassName);
        }


        public event Action OnLoad;
        public event Action<int, string> OnLoadFailed;
        public event Action OnAdShowed;
        public event Action OnAdClicked;
        public event Action OnAdDismissed;

        public void Load(string slotId, PAGBannerRequest request)
        {
            if (request == null)
            {
                return;
            }

            bannerBridge?.Call("loadAd", slotId,  Convert.ToInt32(request.Position), request.ToJson(),
                new AdLoadCallback(OnLoad, OnLoadFailed));
        }

        public bool IsLoaded()
        {
            return bannerBridge != null && bannerBridge.Call<bool>("isLoaded");
        }

        public void Show()
        {
            bannerBridge?.Call("showAd", AndroidPlatformTool.GetGameActivity(),
                new AdInteractionCallback(OnAdShowed, OnAdClicked, OnAdDismissed));
        }

        public void Destroy()
        {
            bannerBridge?.Call("destroy", AndroidPlatformTool.GetGameActivity());
        }

        public void SetPosition(int x, int y)
        {
            bannerBridge?.Call("setPosition", x, y);
        }

        public void SetPosition(PAGBannerPosition position)
        {
            bannerBridge?.Call("setPositionType", Convert.ToInt32(position));
        }
    }
}
#endif