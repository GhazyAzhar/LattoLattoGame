#if UNITY_EDITOR
using PAG.Scripts.Common;

namespace PAG.Scripts.Platforms.Dummy
{
    class DummyClientFactory : IClientFactory
    {
        public ISDK BuildSDKClient()
        {
            return new DummySDK();
        }

        public IBannerAd BuildBannerAdClient()
        {
            return new DummyBannerAd();
        }

        public INativeAd BuildNativeAdClient()
        {
            return new DummyNativeAdClient();
        }

        public IPAGAppOpenAd BuildAppOpenAdClient()
        {
            return new DummyAppOpenAdClient();
        }

        public IPAGInterstitialAd BuildInterstitialAdClient()
        {
            return new DummyInterstitialAdClient();
        }

        public IPAGRewardedAd BuildRewardedAdClient()
        {
            return new DummyRewardedAdClient();
        }
    }
}
#endif