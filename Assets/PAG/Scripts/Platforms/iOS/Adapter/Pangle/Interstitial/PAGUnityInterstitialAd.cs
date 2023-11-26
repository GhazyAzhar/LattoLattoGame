#if UNITY_IOS
using PAG.Scripts.Api;
using PAG.Scripts.Common;

namespace PAG.Scripts.Platforms.iOS.Adapter.Pangle
{

    class PAGUnityinterstitialAd : PangleIOSBaseAd, IPAGInterstitialAd
    {
        public void Load(string slotId, PAGInterstitialRequest request)
        {
            adType = 3;
            LoadAdData(slotId,request);
        }
    }
}
#endif
