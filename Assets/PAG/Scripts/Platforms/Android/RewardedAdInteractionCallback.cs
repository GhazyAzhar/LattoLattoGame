#if UNITY_ANDROID
using System;
using PAG.Scripts.Common;
using UnityEngine;

namespace PAG.Scripts.Platforms.Android
{
    public class RewardedAdInteractionCallback : AdInteractionCallback
    {
        private event Action<PAGRewardItem> OnUserEarnedReward;
        private event Action<int, string> OnUserEarnedRewardFail;
        private const string ListenerName = AndroidPlatformTool.ClassPackage + ".RewardedAdInteractionListenerWrapper";

        public RewardedAdInteractionCallback(Action onAdShowed, Action onAdClicked, Action onAdDismissed,
            Action<PAGRewardItem> userEarnedReward, Action<int, string> userEarnedRewardFail) : base(
            onAdShowed, onAdClicked, onAdDismissed, ListenerName)
        {
            OnUserEarnedReward = userEarnedReward;
            OnUserEarnedRewardFail = userEarnedRewardFail;
        }

        void onUserEarnedReward(AndroidJavaObject item)
        {
            var result = new PAGRewardItem();
            if (item != null)
            {
                var amount = item.Call<int>("getRewardAmount");
                var rewardName = item.Call<string>("getRewardName");
                result.RewardAmount = amount;
                result.RewardName = rewardName;
            }

            OnUserEarnedReward?.Invoke(result);
        }

        void onUserEarnedRewardFail(int code, string msg)
        {
            OnUserEarnedRewardFail?.Invoke(code, msg);
        }
    }
}
#endif