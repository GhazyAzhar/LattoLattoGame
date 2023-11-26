#import <PAGAdSDK/PAGAdSDK.h>
#import "UnityAppController.h"
#import "PAGUnityBaseAdHandler.h"
#import "PAGUnityAdapterTools.h"
#import "PAGUnityAdHandlerManager.h"

extern "C" {

//load rewarded Ad
void PangleIOS_loadRewardedAdData(UnityAd unityAd,
                                  const char *slotId,
                                  const char *requestJson,
                                  AdDidLoadCallback successCallback,
                                  AdLoadFailCallBack failCallback,
                                  AdDidShowCallback showCallback,
                                  AdDidClickCallback clickCallback,
                                  AdDidDismissCallback dismissCallback,
                                  AdDidEarnRewardCallback earnCallback,
                                  AdEarnRewardFailCallback earnFailCallback) {
    PAGRewardedRequest *adRequest = [PAGRewardedRequest request];
    NSDictionary *requestDict = PangleIOS_requestJsonObjectFromJsonString(requestJson);
    if (requestDict[PangleIOSRequest_adString]) {
        adRequest.adString = requestDict[PangleIOSRequest_adString];
    }
    if (requestDict[PangleIOSRequest_exterInfo]) {
        NSString *extraInfoJson = requestDict[PangleIOSRequest_exterInfo];
        adRequest.extraInfo = PangleIOS_jsonObjectFromJsonString(extraInfoJson);
    }
    NSString *unityAdKey = [PAGUnityAdHandlerManager createKeyUnityAd:unityAd];
    [PAGRewardedAd loadAdWithSlotID:PangleIOS_transformNSStringForm(slotId) request:adRequest completionHandler:^(PAGRewardedAd * _Nullable rewardedAd, NSError * _Nullable error) {
        if (error) {
            if (failCallback) {
                failCallback(unityAd,(int)error.code, error.description.UTF8String);
            }
            return;
        }
        
        PAGUnityRewardedAdHandler *adHandler = [[PAGUnityRewardedAdHandler alloc] init];
        adHandler.unityAd = unityAd;
        adHandler.showCallback = showCallback;
        adHandler.clickCallback = clickCallback;
        adHandler.dismissCallback = dismissCallback;
        adHandler.earnRewardCallback = earnCallback;
        adHandler.earnRewardFailCallback = earnFailCallback;
        
        rewardedAd.delegate = adHandler;
        adHandler.ad = rewardedAd;
        [PAGUnityAdHandlerManager saveAdHandler:adHandler withKey:unityAdKey];
        if (successCallback) {
            successCallback(unityAd);
        }
    }];
    
}

PAGUnityRewardedAdHandler* PangleIOS_getRewardedAdHandler(UnityAd unityAd) {
    if (!unityAd) return nil;
    NSString *unityAdKey = [PAGUnityAdHandlerManager createKeyUnityAd:unityAd];
    PAGUnityRewardedAdHandler *handler = (PAGUnityRewardedAdHandler*)[PAGUnityAdHandlerManager handlerWithKey:unityAdKey];
    if (!handler || ![handler isMemberOfClass:[PAGUnityRewardedAdHandler class]]) {
        return nil;
    }
    return handler;
}

//show open ad
void PangleIOS_showRewardedAd(UnityAd unityAd) {
    PAGUnityRewardedAdHandler *handler = PangleIOS_getRewardedAdHandler(unityAd);
    if (!handler) return;
    
    PangleIOS_dispatchSyncMainQueue(^{
        UIViewController *vc = GetAppController().rootViewController;
        PAGRewardedAd *ad = (PAGRewardedAd *)handler.ad;
        [ad presentFromRootViewController:vc];
    });
}

}
