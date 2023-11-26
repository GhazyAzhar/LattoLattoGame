using System.Collections.Generic;
using PAG.Example;
using PAG.Scripts.Api;
using PAG.Scripts.Api.Constant;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public static class PAGExampleController
{
    private static BannerController _bannerController;
    private static AppOpenAdController _appOpenAdController;
    private static NativeAdController _nativeAdController;
    private static InterstitialAdController _interstitialAdController;
    private static RewardController _rewardAdController;

    private const string ADAppID =
#if UNITY_IOS
        "5000546";
#else
        "5001121";
#endif

    // Interstitial Ad
    public const string InterstitialSlotId =
#if UNITY_IOS
        "945113164";
#else
        "945113166";

#endif
    // Rewarded Ad
    public const string RewardedSlotId =
#if UNITY_IOS
        "900546319";
#else
        "901121430";
#endif

    // Banner Ad
    public const string Banner300X250SlotId =
#if UNITY_IOS
        "945509778";
#else
        "945509744";

#endif
    public const string Banner320X50SlotId =
#if UNITY_IOS
        "945509778";
#else
        "945666755";
#endif

    // App Open
    public const string AppOpenSlotId = "890000008";

    // Native
    public const string NativeSlotId =
#if UNITY_IOS
        "900546910";
#else
        "945092256";
#endif

    #region Init and setting

    static PAGExampleController()
    {
        PAGSdk.OnInitFinish += (result, code, message) =>
        {
            Debug.Log($"result = {result}, error code = {code}, message = {message}");
        };
    }

    public static void Init()
    {
        var config = new PAGConfig.Builder()
            .SetAppId(ADAppID)
            .SetDebugLog(true)
            .SetUserData(new Dictionary<string, string> {["app_name"] = "Pangle Demo"})
            .Build();
        PAGSdk.Init(config);
    }

    #endregion

    #region AppOpenAd

    public static void LoadAndShowAppOpenAd(string slotId)
    {
        _appOpenAdController?.DestroyAd();
        _appOpenAdController = new AppOpenAdController(slotId);
        _appOpenAdController.LoadAppOpenAd();
    }

    #endregion

    #region Banner

    public static void LoadBanner(PAGBannerSize bannerSize)
    {
        _bannerController?.DestroyBanner();
        string slotId = Banner320X50SlotId;
        if (PAGBannerSize.BANNER_W_300_H_250.Equals(bannerSize))
        {
            slotId = Banner300X250SlotId;
        }

        _bannerController = new BannerController(slotId, bannerSize);
        _bannerController.LoadBanner();
    }

    public static void ShowBannerAd()
    {
        _bannerController?.ShowBanner();
    }

    public static void SetBannerPosition(PAGBannerPosition position)
    {
        _bannerController?.SetBannerPosition(position);
    }

    public static void SetBannerPosition(int x, int y)
    {
        if (x >= 0 && y >= 0)
        {
            _bannerController?.SetBannerPosition(x, y);
        }
    }

    public static void DestroyBanner()
    {
        _bannerController?.DestroyBanner();
    }

    #endregion

    #region NativeAd

    public static void LoadNativeAd()
    {
        _nativeAdController?.DestroyNativeAd();
        _nativeAdController = new NativeAdController(NativeSlotId);
        _nativeAdController?.LoadNativeAd();
    }

    public static void SetNativeAdPosition(int x, int y)
    {
        _nativeAdController?.SetPosition(x, y);
    }

    public static void ShowNativeAd()
    {
        _nativeAdController?.ShowNativeAd();
    }

    public static void DestroyNativeAd()
    {
        _nativeAdController?.DestroyNativeAd();
    }

    #endregion

    #region Interstitial

    public static void LoadInterstitialAd(string slotId)
    {
        _interstitialAdController?.DestroyInterstitialAd();
        _interstitialAdController = new InterstitialAdController(slotId);
        _interstitialAdController.LoadInterstitialAd();
    }

    public static void ShowInterstitialAd()
    {
        _interstitialAdController?.ShowInterstitialAd();
    }

    #endregion

    #region Reward

    public static void LoadRewardAd(string slotId)
    {
        _rewardAdController?.DestroyRewardAd();
        _rewardAdController = new RewardController(slotId);
        _rewardAdController.LoadRewardAd();
    }

    public static void ShowRewardAd()
    {
        _rewardAdController?.ShowRewardAd();
    }

    #endregion
}