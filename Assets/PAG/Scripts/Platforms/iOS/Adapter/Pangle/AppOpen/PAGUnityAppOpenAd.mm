#import <PAGAdSDK/PAGAdSDK.h>
#import "UnityAppController.h"
#import "PAGUnityBaseAdHandler.h"
#import "PAGUnityAdapterTools.h"

#import "PAGUnityAdHandlerManager.h"

extern "C" {

//load appOpen Ad
void PangleIOS_loadAppOpenAdData(UnityAd unityAd,
                                 const char *slotId,
                                 const char *requestJson,
                                 AdDidLoadCallback successCallback,
                                 AdLoadFailCallBack failCallback,
                                 AdDidShowCallback showCallback,
                                 AdDidClickCallback clickCallback,
                                 AdDidDismissCallback dismissCallback){
    PAGAppOpenRequest *adRequest = [PAGAppOpenRequest request];
    
    NSDictionary *requestDict = PangleIOS_requestJsonObjectFromJsonString(requestJson);
    if (requestDict[PangleIOSRequest_adString]) {
        adRequest.adString = requestDict[PangleIOSRequest_adString];
    }
    if (requestDict[PangleIOSRequest_exterInfo]) {
        NSString *extraInfoJson = requestDict[PangleIOSRequest_exterInfo];
        adRequest.extraInfo = PangleIOS_jsonObjectFromJsonString(extraInfoJson);
    }
    if (requestDict[PangleIOSRequest_timeout]) {
        adRequest.timeout = [requestDict[PangleIOSRequest_timeout] doubleValue] / 1000;
    }
    
    NSString *unityAdKey = [PAGUnityAdHandlerManager createKeyUnityAd:unityAd];
    [PAGLAppOpenAd loadAdWithSlotID:PangleIOS_transformNSStringForm(slotId) request:adRequest completionHandler:^(PAGLAppOpenAd * _Nullable appOpenAd, NSError * _Nullable error) {
        if (error) {
            if (failCallback) {
                failCallback(unityAd,(int)error.code, error.description.UTF8String);
            }
            return;
        }
        
        PAGUnityappOpenAdHandler *adHandler = [[PAGUnityappOpenAdHandler alloc] init];
        adHandler.unityAd = unityAd;
        adHandler.showCallback = showCallback;
        adHandler.clickCallback = clickCallback;
        adHandler.dismissCallback = dismissCallback;
        
        appOpenAd.delegate = adHandler;
        adHandler.ad = appOpenAd;
        [PAGUnityAdHandlerManager saveAdHandler:adHandler withKey:unityAdKey];
        if (successCallback) {
            successCallback(unityAd);
        }
    }];
}

PAGUnityappOpenAdHandler* PangleIOS_getAppOpenAdHandler(UnityAd unityAd) {
    if (!unityAd) return nil;
    NSString *unityAdKey = [PAGUnityAdHandlerManager createKeyUnityAd:unityAd];
    PAGUnityappOpenAdHandler *handler = (PAGUnityappOpenAdHandler*)[PAGUnityAdHandlerManager handlerWithKey:unityAdKey];
    if (!handler || ![handler isMemberOfClass:[PAGUnityappOpenAdHandler class]]) {
        return nil;
    }
    return handler;
}


//show open ad
void PangleIOS_showAppOpenAd(UnityAd unityAd) {
    PAGUnityappOpenAdHandler *handler = PangleIOS_getAppOpenAdHandler(unityAd);
    if (!handler) return;
    
    PangleIOS_dispatchSyncMainQueue(^{
        UIViewController *vc = GetAppController().rootViewController;
        PAGLAppOpenAd *ad = (PAGLAppOpenAd *)handler.ad;
        [ad presentFromRootViewController:vc];
    });
}

}
