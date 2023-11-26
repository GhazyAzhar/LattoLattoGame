namespace PAG.Scripts.Common
{
    public interface IClientFactory
    {
        ISDK BuildSDKClient();
        IBannerAd BuildBannerAdClient();
        INativeAd BuildNativeAdClient();
        IPAGInterstitialAd BuildInterstitialAdClient();
        IPAGAppOpenAd BuildAppOpenAdClient();
        IPAGRewardedAd BuildRewardedAdClient();
    }
}