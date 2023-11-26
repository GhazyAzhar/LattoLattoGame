#import "PAGUnityAppOpenAd.h"
#import "PAGUnityinterstitialAd.h"
#import "PAGUnityRewardedAd.h"
#import "PAGUnityAdHandlerManager.h"
#import "PAGUnityBannerAd.h"
#import "PAGUnityNativeAd.h"

extern "C" {
enum PangleIOSAdType {
    native = 1, banner = 2, interstitial = 3, rewarded = 4, appOpen = 5
};
void pangleIOS_loadAdData(int adType,
                          UnityAd unityAd,
                          const char *slotId,
                          const char *requestJson,
                          AdDidLoadCallback successCallback,
                          AdLoadFailCallBack failCallback,
                          AdDidShowCallback showCallback,
                          AdDidClickCallback clickCallback,
                          AdDidDismissCallback dismissCallback) {
    if (adType == rewarded || adType == banner) {//custom load
        return;
    }
    
    if (adType == interstitial) {
        PangleIOS_loadInterstitialAdData(unityAd, slotId, requestJson, successCallback, failCallback, showCallback, clickCallback, dismissCallback);
    }
    else if (adType == appOpen) {
        PangleIOS_loadAppOpenAdData(unityAd, slotId, requestJson, successCallback, failCallback, showCallback, clickCallback, dismissCallback);
    }
    else if (adType == native) {
        PangleIOS_loadNativeAdData(unityAd, slotId, requestJson, successCallback, failCallback, showCallback, clickCallback, dismissCallback);
    }
    
}
void PangleIOS_showAd(int adType, UnityAd unityAd) {
    if (adType == interstitial) {
        PangleIOS_showInterstitialAd(unityAd);
    }
    else if (adType == appOpen) {
        PangleIOS_showAppOpenAd(unityAd);
    }
    else if (adType == rewarded) {
        PangleIOS_showRewardedAd(unityAd);
    }
    else if (adType == banner) {
        PangleIOS_showBannerAd(unityAd);
    }
    else if (adType == native) {
        PangleIOS_showNativeAd(unityAd);
    }
}

void PangleIOS_destroyAd(int adType, UnityAd unityAd) {
    if (adType == banner) {
        PangleIOS_removeBannerView(unityAd);
    }
    else if (adType == native) {
        PangleIOS_removeNativeView(unityAd);
    }
    NSString *unityAdKey = [PAGUnityAdHandlerManager createKeyUnityAd:unityAd];
    [PAGUnityAdHandlerManager removeAdHandlerWithKey:unityAdKey];
}
}
