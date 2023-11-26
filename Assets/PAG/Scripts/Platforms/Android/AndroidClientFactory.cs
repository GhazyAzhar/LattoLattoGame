#if UNITY_ANDROID

using PAG.Scripts.Common;

namespace PAG.Scripts.Platforms.Android
{
    class AndroidClientFactory : IClientFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ISDK BuildSDKClient()
        {
            return new PAGSdkClient();
        }

        public IBannerAd BuildBannerAdClient()
        {
            return new AndroidBannerAd();
        }

        public INativeAd BuildNativeAdClient()
        {
            return new AndroidNativeAd();
        }

        public IPAGInterstitialAd BuildInterstitialAdClient()
        {
            return new AndroidInterstitialAd();
        }

        public IPAGAppOpenAd BuildAppOpenAdClient()
        {
            return new AndroidAppOpenAd();
        }

        public IPAGRewardedAd BuildRewardedAdClient()
        {
            return new AndroidRewardedAd();
        }
    }
}
#endif