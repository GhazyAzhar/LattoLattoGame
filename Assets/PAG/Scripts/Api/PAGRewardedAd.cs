using System;
using PAG.Scripts.Common;

namespace PAG.Scripts.Api
{
    public class PAGRewardedAd : PAGBaseAd<PAGRewardedRequest>
    {
        public event Action<PAGRewardItem> OnUserEarnedReward;
        public event Action<int, string> OnUserEarnedRewardFail;

        public PAGRewardedAd(string id) : base(id, PAGSdk.GetClientFactory().BuildRewardedAdClient())
        {
            var rewardedAdClient = (IPAGRewardedAd) ADClient;

            rewardedAdClient.OnUserEarnedReward += InvokeOnUserEarnedReward;
            rewardedAdClient.OnUserEarnedRewardFail += InvokeOnUserEarnedRewardFail;
        }

        private void InvokeOnUserEarnedReward(PAGRewardItem item)
        {
            if (CallbackOnMainThread)
            {
                PAGDispatcher.PostTask((() => { OnUserEarnedReward?.Invoke(item); }));
            }
            else
            {
                OnUserEarnedReward?.Invoke(item);
            }
        }

        private void InvokeOnUserEarnedRewardFail(int code, string msg)
        {
            if (CallbackOnMainThread)
            {
                PAGDispatcher.PostTask((() => { OnUserEarnedRewardFail?.Invoke(code, msg); }));
            }
            else
            {
                OnUserEarnedRewardFail?.Invoke(code, msg);
            }
        }
    }
}