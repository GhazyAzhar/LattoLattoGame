#if UNITY_ANDROID
using System;
using PAG.Scripts.Api;
using PAG.Scripts.Common;
using UnityEngine;

namespace PAG.Scripts.Platforms.Android
{
    internal class AndroidRewardedAd : IPAGRewardedAd
    {
        public event Action OnLoad;
        public event Action<int, string> OnLoadFailed;
        public event Action OnAdShowed;
        public event Action OnAdClicked;
        public event Action OnAdDismissed;

        public event Action<PAGRewardItem> OnUserEarnedReward;
        public event Action<int, string> OnUserEarnedRewardFail;

        private const string RewardedClassName = AndroidPlatformTool.ClassPackage + ".PAGRewardedAdWrapper";
        private readonly AndroidJavaObject rewardedAdWrapper;

        public AndroidRewardedAd()
        {
            rewardedAdWrapper = new AndroidJavaObject(RewardedClassName);
        }

        public void Load(string slotId, PAGRewardedRequest request)
        {
            rewardedAdWrapper?.Call("loadAd", slotId, request.ToJson(), new AdLoadCallback(OnLoad, OnLoadFailed));
        }

        public bool IsLoaded()
        {
            return rewardedAdWrapper != null && rewardedAdWrapper.Call<bool>("isLoaded");
        }

        public void Show()
        {
            rewardedAdWrapper?.Call("showAd", AndroidPlatformTool.GetGameActivity(),
                new RewardedAdInteractionCallback(OnAdShowed, OnAdClicked, OnAdDismissed, OnUserEarnedReward,
                    OnUserEarnedRewardFail));
        }

        public void Destroy()
        {
            rewardedAdWrapper?.Call("destroy");
        }
    }
}
#endif