#import <PAGAdSDK/PAGAdSDK.h>
#import "UnityAppController.h"
#import "PAGUnityBaseAdHandler.h"
#import "PAGUnityAdapterTools.h"
#import "PAGUnityAdHandlerManager.h"

extern "C"{

//load interstitial ad
void PangleIOS_loadInterstitialAdData(UnityAd unityAd,
                                      const char *slotId,
                                      const char *requestJson,
                                      AdDidLoadCallback successCallback,
                                      AdLoadFailCallBack failCallback,
                                      AdDidShowCallback showCallback,
                                      AdDidClickCallback clickCallback,
                                      AdDidDismissCallback dismissCallback
                                      ) {
    PAGInterstitialRequest *adRequest = [PAGInterstitialRequest request];
    NSDictionary *requestDict = PangleIOS_requestJsonObjectFromJsonString(requestJson);
    if (requestDict[PangleIOSRequest_adString]) {
        adRequest.adString = requestDict[PangleIOSRequest_adString];
    }
    if (requestDict[PangleIOSRequest_exterInfo]) {
        NSString *extraInfoJson = requestDict[PangleIOSRequest_exterInfo];
        adRequest.extraInfo = PangleIOS_jsonObjectFromJsonString(extraInfoJson);
    }
    
    NSString *unityAdKey = [PAGUnityAdHandlerManager createKeyUnityAd:unityAd];
    [PAGLInterstitialAd loadAdWithSlotID:PangleIOS_transformNSStringForm(slotId) request:adRequest completionHandler:^(PAGLInterstitialAd * _Nullable interstitialAd, NSError * _Nullable error) {
        if (error) {
            if (failCallback) {
                failCallback(unityAd,(int)error.code, error.description.UTF8String);
            }
            return;
        }
        
        PAGUnityInterstitialAdHandler *adHandler = [[PAGUnityInterstitialAdHandler alloc] init];
        adHandler.unityAd = unityAd;
        adHandler.showCallback = showCallback;
        adHandler.clickCallback = clickCallback;
        adHandler.dismissCallback = dismissCallback;
        
        interstitialAd.delegate = adHandler;
        adHandler.ad = interstitialAd;
        [PAGUnityAdHandlerManager saveAdHandler:adHandler withKey:unityAdKey];
        
        if (successCallback) {
            successCallback(unityAd);
        }
    }];
}

PAGUnityInterstitialAdHandler* PangleIOS_getInterstitialAdHandler(UnityAd unityAd) {
    if (!unityAd) return nil;
    NSString *unityAdKey = [PAGUnityAdHandlerManager createKeyUnityAd:unityAd];
    PAGUnityInterstitialAdHandler *handler = (PAGUnityInterstitialAdHandler*)[PAGUnityAdHandlerManager handlerWithKey:unityAdKey];
    if (!handler || ![handler isMemberOfClass:[PAGUnityInterstitialAdHandler class]]) {
        return nil;
    }
    return handler;
}

void PangleIOS_showInterstitialAd(UnityAd unityAd) {
    PAGUnityInterstitialAdHandler *handler = PangleIOS_getInterstitialAdHandler(unityAd);
    if (!handler) return;
    
    PangleIOS_dispatchSyncMainQueue(^{
        UIViewController *vc = GetAppController().rootViewController;
        PAGLInterstitialAd *ad = (PAGLInterstitialAd *)handler.ad;
        [ad presentFromRootViewController:vc];
    });
    
}

}

