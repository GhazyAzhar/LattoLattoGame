using PAG.Scripts.Common;

namespace PAG.Scripts.Api
{
    public class PAGInterstitialAd : PAGBaseAd<PAGInterstitialRequest>
    {
        public PAGInterstitialAd(string slotId) : base(slotId, PAGSdk.GetClientFactory().BuildInterstitialAdClient())
        {
        }
    }
}