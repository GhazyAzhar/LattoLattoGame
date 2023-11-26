
#import <PAGAdSDK/PAGAdSDK.h>

extern "C" {
    
    typedef void (*PangleSDKInitSuccessCallBack)(void* unitySDK);
    typedef void (*PangleSDKInitFailCallBack)(void* unitySDK, int code, const char *msg);
    
    void PangleIOS_initSDK(void* unitySDK, PangleSDKInitSuccessCallBack successCallback,PangleSDKInitFailCallBack failCallback) {
        PAGConfig *config = [PAGConfig shareConfig];
        [PAGSdk startWithConfig:config completionHandler:^(BOOL success, NSError * _Nonnull error) {
            if (success) {
                successCallback(unitySDK);
                return;
            }
            failCallback(unitySDK,(int)error.code,error.description.UTF8String);
        }];
    }
    
    bool PangleIOS_sdkInitializationState() {
    return PAGSdk.initializationState == PAGSDKInitializationStateReady;
    }
    
}
