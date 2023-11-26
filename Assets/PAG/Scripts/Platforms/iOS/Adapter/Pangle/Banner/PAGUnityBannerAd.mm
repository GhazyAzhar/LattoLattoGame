#import <PAGAdSDK/PAGAdSDK.h>
#import "UnityAppController.h"
#import "PAGUnityBaseAdHandler.h"
#import "PAGUnityAdapterTools.h"
#import "PAGUnityAdHandlerManager.h"

extern "C"{


int PangleIOS_getScreenWidth () {
    __block int width = 0;
    PangleIOS_dispatchSyncMainQueue(^{
        UIViewController *vc = GetAppController().rootViewController;
        width = (int)vc.view.frame.size.width;
    });
    return width;
}

int PangleIOS_getScreenHeight () {
    __block int height = 0;
    PangleIOS_dispatchSyncMainQueue(^{
        UIViewController *vc = GetAppController().rootViewController;
        height = (int)vc.view.frame.size.height;
    });
    return height;
}

int PangleIOS_getScreenSafeBottom() {
    __block int bottom = 0;
    PangleIOS_dispatchSyncMainQueue(^{
        UIViewController *vc = GetAppController().rootViewController;
        bottom = (int)vc.view.safeAreaInsets.bottom;
    });
    return bottom;
}

int PangleIOS_getScreenSafeTop() {
    __block int top = 0;
    PangleIOS_dispatchSyncMainQueue(^{
        UIViewController *vc = GetAppController().rootViewController;
        top = (int)vc.view.safeAreaInsets.top;
    });
    return top;
}

//load Banner ad
void PangleIOS_loadBannerAdData(UnityAd unityAd,
                                const char *slotId,
                                const char *requestJson,
                                int x,
                                int y,
                                int width,
                                int height,
                                AdDidLoadCallback successCallback,
                                AdLoadFailCallBack failCallback,
                                AdDidShowCallback showCallback,
                                AdDidClickCallback clickCallback,
                                AdDidDismissCallback dismissCallback
                                ) {
    PAGBannerAdSize size = kPAGBannerSize320x50;
    if (width == 300 && height == 250) {
        size = kPAGBannerSize300x250;
    }
    else if (width == 728 && height == 90) {
        size = kPAGBannerSize728x90;
    }
    PAGBannerRequest *adRequest = [PAGBannerRequest requestWithBannerSize:size];
    
    NSDictionary *requestDict = PangleIOS_requestJsonObjectFromJsonString(requestJson);
    if (requestDict[PangleIOSRequest_adString]) {
        adRequest.adString = requestDict[PangleIOSRequest_adString];
    }
    if (requestDict[PangleIOSRequest_exterInfo]) {
        NSString *extraInfoJson = requestDict[PangleIOSRequest_exterInfo];
        adRequest.extraInfo = PangleIOS_jsonObjectFromJsonString(extraInfoJson);
    }
    
    NSString *unityAdKey = [PAGUnityAdHandlerManager createKeyUnityAd:unityAd];
    [PAGBannerAd loadAdWithSlotID:PangleIOS_transformNSStringForm(slotId) request:adRequest completionHandler:^(PAGBannerAd * _Nullable bannerAd, NSError * _Nullable error) {
        if (error) {
            if (failCallback) {
                failCallback(unityAd,(int)error.code, error.description.UTF8String);
            }
            return;
        }
        PangleIOS_dispatchSyncMainQueue(^{
            CGRect frame = (CGRect){CGPointMake(x, y),size.size};
            bannerAd.bannerView.frame = frame;
            
            UIViewController *vc = GetAppController().rootViewController;
            bannerAd.rootViewController = vc;
            
            PAGUnityBannerAdHandler *adHandler = [[PAGUnityBannerAdHandler alloc] init];
            adHandler.unityAd = unityAd;
            adHandler.showCallback = showCallback;
            adHandler.clickCallback = clickCallback;
            adHandler.dismissCallback = dismissCallback;
            
            bannerAd.delegate = adHandler;
            adHandler.ad = bannerAd;
            [PAGUnityAdHandlerManager saveAdHandler:adHandler withKey:unityAdKey];
            
            if (successCallback) {
                successCallback(unityAd);
            }
        });
    }];
}

PAGUnityBannerAdHandler* PangleIOS_getBannerAdHandler(UnityAd unityAd) {
    if (!unityAd) return nil;
    NSString *unityAdKey = [PAGUnityAdHandlerManager createKeyUnityAd:unityAd];
    PAGUnityBannerAdHandler *handler = (PAGUnityBannerAdHandler*)[PAGUnityAdHandlerManager handlerWithKey:unityAdKey];
    if (!handler || ![handler isMemberOfClass:[PAGUnityBannerAdHandler class]]) {
        return nil;
    }
    return handler;
}

void PangleIOS_showBannerAd(UnityAd unityAd) {
    PAGUnityBannerAdHandler *handler = PangleIOS_getBannerAdHandler(unityAd);
    if (!handler) return;
    PangleIOS_dispatchSyncMainQueue(^{
        UIViewController *vc = GetAppController().rootViewController;
        PAGBannerAd *ad = (PAGBannerAd *)handler.ad;
        [vc.view addSubview:ad.bannerView];
    });
}

void PangleIOS_SetBannerAdPosition(UnityAd unityAd,int x, int y) {
    PAGUnityBannerAdHandler *handler = PangleIOS_getBannerAdHandler(unityAd);
    if (!handler) return;
    
    PangleIOS_dispatchSyncMainQueue(^{
        PAGBannerAd *ad = (PAGBannerAd *)handler.ad;
        CGRect frame = ad.bannerView.frame;
        frame.origin.x = x;
        frame.origin.y = y;
        ad.bannerView.frame = frame;
    });
}

void PangleIOS_removeBannerView(UnityAd unityAd) {
    PAGUnityBannerAdHandler *handler = PangleIOS_getBannerAdHandler(unityAd);
    if (!handler) return;
    
    PangleIOS_dispatchSyncMainQueue(^{
        PAGBannerAd *ad = (PAGBannerAd *)handler.ad;
        [ad.bannerView removeFromSuperview];
    });
}

}

