using System;
using System.Collections.Generic;
using System.Text;
using PAG.Scripts.Api;
using PAG.Scripts.Api.Constant;
using UnityEngine;
using UnityEngine.UI;

public class MainUIController : MonoBehaviour
{
    #region Init and setting

    private void Start()
    {
        appOpenAdSlotId.text = PAGExampleController.AppOpenSlotId;
        rewardAdSlotId.text = PAGExampleController.RewardedSlotId;
        interstitialAdSlotId.text = PAGExampleController.InterstitialSlotId;
    }

    public void InitPangleSdk()
    {
        PAGExampleController.Init();
    }

    public void SetGDPR(Toggle toggle)
    {
        PAGConfig.SetGDPRConsent(toggle.isOn
            ? PAGGDPRConsentType.PAGGDPRConsentTypeConsent
            : PAGGDPRConsentType.PAGGDPRConsentTypeNoConsent);
    }

    public void SetCCPA(Toggle toggle)
    {
        PAGConfig.SetDoNotSell(toggle.isOn
            ? PAGDoNotSellType.PAGDoNotSellTypeNotSell
            : PAGDoNotSellType.PAGDoNotSellTypeSell);
    }

    public void SetCOPPA(Toggle toggle)
    {
        PAGConfig.SetChildDirected(
            toggle.isOn
                ? PAGChildDirectedType.PAGChildDirectedTypeChild
                : PAGChildDirectedType.PAGChildDirectedTypeNonChild);
    }

    public void SetDebugLog(Toggle toggle)
    {
        PAGConfig.SetDebugLog(toggle.isOn);
    }

    #endregion

    #region AppOpen Ad

    public InputField appOpenAdSlotId;

    public void LoadAppOpenAd()
    {
        string slotId = appOpenAdSlotId.text;
        PAGExampleController.LoadAndShowAppOpenAd(slotId);
    }

    #endregion

    #region Banner

    public InputField bannerPositionX;
    public InputField bannerPositionY;

    private PAGBannerSize _bannerSize = PAGBannerSize.BANNER_W_320_H_50;


    public void LoadBanner()
    {
        PAGExampleController.LoadBanner(_bannerSize);
    }

    public void ShowBanner()
    {
        //change banner position if need
        // PAGExampleController.SetBannerPosition(PAGBannerPosition.Top);
        // PAGExampleController.SetBannerPosition(50,300);
        PAGExampleController.ShowBannerAd();
    }

    public void DestroyBanner()
    {
        PAGExampleController.DestroyBanner();
    }

    public void SetBannerPosition()
    {
        if (int.TryParse(bannerPositionX.text, out var x) && int.TryParse(bannerPositionY.text, out var y))
        {
            PAGExampleController.SetBannerPosition(x, y);
        }
    }

    public void OnBannerSizeChanged(Dropdown dropdown)
    {
        switch (dropdown.value)
        {
            case 0:
                _bannerSize = PAGBannerSize.BANNER_W_320_H_50;
                break;
            case 1:
                _bannerSize = PAGBannerSize.BANNER_W_300_H_250;
                break;
            default:
                _bannerSize = PAGBannerSize.BANNER_W_728_H_90;
                break;
        }
    }

    public void SetBannerPosition(Dropdown dropdown)
    {
        var position = (PAGBannerPosition) dropdown.value;
        PAGExampleController.SetBannerPosition(position);
    }

    #endregion

    #region Native Ad

    public InputField nativePositionX;
    public InputField nativePositionY;

    public void SetNativePosition()
    {
        if (int.TryParse(nativePositionX.text, out var x) && int.TryParse(nativePositionY.text, out var y))
        {
            PAGExampleController.SetNativeAdPosition(x, y);
        }
    }

    public void LoadNativeAd()
    {
        PAGExampleController.LoadNativeAd();
    }

    public void ShowNativeAd()
    {
        PAGExampleController.ShowNativeAd();
    }

    public void DestroyNativeAd()
    {
        PAGExampleController.DestroyNativeAd();
    }

    #endregion

    #region InterstitialAd

    public InputField interstitialAdSlotId;

    public void LoadInterstitialAd()
    {
        PAGExampleController.LoadInterstitialAd(interstitialAdSlotId.text);
    }

    public void ShowInterstitialAd()
    {
        PAGExampleController.ShowInterstitialAd();
    }

    #endregion

    #region Reward

    public InputField rewardAdSlotId;

    public void LoadRewardAd()
    {
        PAGExampleController.LoadRewardAd(rewardAdSlotId.text);
    }

    public void ShowRewardAd()
    {
        PAGExampleController.ShowRewardAd();
    }

    #endregion
}