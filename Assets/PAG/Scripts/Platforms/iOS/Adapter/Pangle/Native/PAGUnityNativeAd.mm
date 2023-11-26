#import <PAGAdSDK/PAGAdSDK.h>
#import "UnityAppController.h"
#import "PAGUnityBaseAdHandler.h"
#import "PAGUnityAdapterTools.h"
#import "PAGUnityAdHandlerManager.h"
#import "PAGUnityNativeCustomView.h"

//TODO 1.释放的问题

extern "C"{

PAGUnityNativeAdHandler* PangleIOS_getNativeAdHandler(UnityAd unityAd) {
    if (!unityAd) return nil;
    NSString *unityAdKey = [PAGUnityAdHandlerManager createKeyUnityAd:unityAd];
    PAGUnityNativeAdHandler *handler = (PAGUnityNativeAdHandler*)[PAGUnityAdHandlerManager handlerWithKey:unityAdKey];
    if (!handler || ![handler isMemberOfClass:[PAGUnityNativeAdHandler class]]) {
        return nil;
    }
    return handler;
}

//load Native ad
void PangleIOS_loadNativeAdData(UnityAd unityAd,
                                const char *slotId,
                                const char *requestJson,
                                AdDidLoadCallback successCallback,
                                AdLoadFailCallBack failCallback,
                                AdDidShowCallback showCallback,
                                AdDidClickCallback clickCallback,
                                AdDidDismissCallback dismissCallback
                                ) {
    PAGNativeRequest *adRequest = [PAGNativeRequest request];
    NSDictionary *requestDict = PangleIOS_requestJsonObjectFromJsonString(requestJson);
    if (requestDict[PangleIOSRequest_adString]) {
        adRequest.adString = requestDict[PangleIOSRequest_adString];
    }
    if (requestDict[PangleIOSRequest_exterInfo]) {
        NSString *extraInfoJson = requestDict[PangleIOSRequest_exterInfo];
        adRequest.extraInfo = PangleIOS_jsonObjectFromJsonString(extraInfoJson);
    }
    
    NSString *unityAdKey = [PAGUnityAdHandlerManager createKeyUnityAd:unityAd];
    [PAGLNativeAd loadAdWithSlotID:PangleIOS_transformNSStringForm(slotId) request:adRequest completionHandler:^(PAGLNativeAd * _Nullable nativeAd, NSError * _Nullable error) {
        if (error) {
            if (failCallback) {
                failCallback(unityAd,(int)error.code, error.description.UTF8String);
            }
            return;
        }
        PangleIOS_dispatchSyncMainQueue(^{
            UIViewController *vc = GetAppController().rootViewController;
            PAGUnityNativeCustomView *nativeView = [[PAGUnityNativeCustomView alloc] initWithFrame:CGRectMake(0, 100, vc.view.frame.size.width, 500)];
            
            PAGUnityNativeAdHandler *adHandler = [[PAGUnityNativeAdHandler alloc] init];
            adHandler.nativeView = nativeView;
            adHandler.unityAd = unityAd;
            adHandler.showCallback = showCallback;
            adHandler.clickCallback = clickCallback;
            adHandler.dismissCallback = dismissCallback;
            
            nativeAd.delegate = adHandler;
            nativeAd.rootViewController = vc;
            [nativeAd registerContainer:nativeView withClickableViews:nativeView.clickAbleViews];
            
            adHandler.ad = nativeAd;
            [PAGUnityAdHandlerManager saveAdHandler:adHandler withKey:unityAdKey];
            
            if (successCallback) {
                successCallback(unityAd);
            }
        });
    }];
}

void PangleIOS_showNativeAd(UnityAd unityAd) {
    PAGUnityNativeAdHandler *handler = PangleIOS_getNativeAdHandler(unityAd);
    if (!handler) return;
    
    PangleIOS_dispatchSyncMainQueue(^{
        PAGLNativeAd *ad = (PAGLNativeAd *)handler.ad;
        [handler.nativeView refreshWithNativeAd:ad];
        
        UIViewController *vc = GetAppController().rootViewController;
        [vc.view addSubview:handler.nativeView];
    });
}

void PangleIOS_setNativeAdPosition(UnityAd unityAd,int x, int y) {
    PAGUnityNativeAdHandler *handler = PangleIOS_getNativeAdHandler(unityAd);
    if (!handler) return;
    
    PangleIOS_dispatchSyncMainQueue(^{
        CGRect frame = handler.nativeView.frame;
        frame.origin = CGPointMake(x, y);
        handler.nativeView.frame = frame;
    });
}

void PangleIOS_removeNativeView(UnityAd unityAd) {
    PAGUnityNativeAdHandler *handler = PangleIOS_getNativeAdHandler(unityAd);
    if (!handler) return;
    
    PangleIOS_dispatchSyncMainQueue(^{
        UIView *view = handler.nativeView;
        [view removeFromSuperview];
    });
}

}

