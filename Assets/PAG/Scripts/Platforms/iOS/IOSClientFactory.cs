#if UNITY_IOS
using PAG.Scripts.Common;
using PAG.Scripts.Platforms.iOS;
using PAG.Scripts.Platforms.iOS.Adapter.Pangle;
using PAG.Scripts.Platforms.iOS.Adapter.Pangle.Native;

namespace PAG.Scripts.Platforms.iOS
{
    class IOSClientFactory : IClientFactory
    {

        public ISDK BuildSDKClient()
        {
            return new PAGUnitySdk();
        }

        public IBannerAd BuildBannerAdClient()
        {
            return new PAGUnityBannerAd();
        }

        public INativeAd BuildNativeAdClient()
        {
            return new PAGUnityNativeAd();
        }

        public IPAGInterstitialAd BuildInterstitialAdClient()
        {
            return new PAGUnityinterstitialAd();
        }

        public IPAGAppOpenAd BuildAppOpenAdClient()
        {
            return new PAGUnityAppOpenAd();
        }
        
        public IPAGRewardedAd BuildRewardedAdClient()
        {
            return new PAGUnityRewardedAd();
        }
    }
}
#endif