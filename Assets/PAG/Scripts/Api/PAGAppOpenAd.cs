using PAG.Scripts.Common;

namespace PAG.Scripts.Api
{
    public sealed class PAGAppOpenAd : PAGBaseAd<PAGAppOpenRequest>
    {
        public PAGAppOpenAd(string slotId) : base(slotId, PAGSdk.GetClientFactory().BuildAppOpenAdClient())
        {
        }
    }
}