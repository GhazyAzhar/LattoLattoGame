using PAG.Scripts.Api;
using UnityEngine;

namespace PAG.Example
{
    public class RewardController
    {
        private readonly PAGRewardedAd rewardedAd;

        public RewardController(string slotId)
        {
            rewardedAd = new PAGRewardedAd(slotId);
            rewardedAd.OnLoad += (() => { Debug.Log("[PAGRewarded]-[load]:successfully"); });
            rewardedAd.OnLoadFailed += ((code, msg) =>
            {
                Debug.Log($"[PAGRewarded]-[load]:failed, code ={code}, error message = {msg}");
            });

            rewardedAd.OnAdShowed += (() => { Debug.Log("[PAGRewarded]-[interaction]:show"); });
            rewardedAd.OnAdClicked += (() => { Debug.Log("[PAGRewarded]-[interaction]:click"); });
            rewardedAd.OnAdDismissed += (() => { Debug.Log("[PAGRewarded]-[interaction]:dismiss"); });
            rewardedAd.OnUserEarnedReward += (item =>
            {
                Debug.Log(
                    $"[PAGRewarded]-[interaction]:User earned reward, amount = {item.RewardAmount}, reward name ={item.RewardName}");
            });
            rewardedAd.OnUserEarnedRewardFail += ((code, message) =>
            {
                Debug.Log(
                    $"[PAGRewarded]-[interaction]:User earned reward failed, error code =  {code}, message = {message}");
            });
        }

        public void LoadRewardAd()
        {
            var request = new PAGRewardedRequest
            {
                ExtraInfoJson = "{\n" +
                                "  \"media_extra\": \"custom media extra\",\n" +
                                "  \"custom_key\": \"custom_value\",\n" +
                                "  \"custom_extra\": {\n" +
                                "    \"key1\": \"value1\"\n" +
                                "  }\n" +
                                "}"
            };

            rewardedAd?.Load(request);
        }

        public void ShowRewardAd()
        {
            rewardedAd?.Show();
        }

        public void DestroyRewardAd()
        {
            rewardedAd?.DestroyAd();
        }
    }
}