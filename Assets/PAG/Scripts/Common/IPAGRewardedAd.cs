using System;
using PAG.Scripts.Api;

namespace PAG.Scripts.Common
{
    public interface IPAGRewardedAd : IPAGAd<PAGRewardedRequest>
    {
        event Action<PAGRewardItem> OnUserEarnedReward;
        event Action<int, string> OnUserEarnedRewardFail;
    }
}