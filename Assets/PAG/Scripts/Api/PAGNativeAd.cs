using PAG.Scripts.Common;

namespace PAG.Scripts.Api
{
    public class PAGNativeAd : PAGBaseAd<PAGNativeRequest>
    {
        public PAGNativeAd(string slotId) : base(slotId, PAGSdk.GetClientFactory().BuildNativeAdClient())
        {
        }

        public void SetPosition(int x, int y)
        {
            ((INativeAd) ADClient)?.SetPosition(x, y);
        }
    }
}