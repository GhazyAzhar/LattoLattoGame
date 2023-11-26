
#import <Foundation/Foundation.h>
#import <PAGAdSDK/PAGAdSDK.h>
#import "PAGUnityNativeCustomView.h"

typedef void* UnityAd;//unity ad
typedef void* PangleSdkAd;//pangle ad
//int

//callback of ad load
typedef void(*AdDidLoadCallback)(UnityAd unityAd);
typedef void (*AdLoadFailCallBack)(UnityAd unityAd, int code, const char *msg);

//callback of ad event
typedef void(*AdDidShowCallback)(UnityAd unityAd);
typedef void(*AdDidClickCallback)(UnityAd unityAd);
typedef void(*AdDidDismissCallback)(UnityAd unityAd);

typedef void (*AdDidEarnRewardCallback)(UnityAd unityA, const char *rewardName, int rewardAmount);
typedef void (*AdEarnRewardFailCallback)(UnityAd unityA, int code, const char *msg);

@interface PAGUnityBaseAdHandler : NSObject<PAGAdDelegate>

@property (nonatomic, assign) UnityAd unityAd;
@property (nonatomic, strong) id<PAGAdProtocol> ad;

@property (nonatomic, assign) AdDidShowCallback showCallback;
@property (nonatomic, assign) AdDidClickCallback clickCallback;
@property (nonatomic, assign) AdDidDismissCallback dismissCallback;

@end

@interface PAGUnityInterstitialAdHandler : PAGUnityBaseAdHandler<PAGLInterstitialAdDelegate>

@end

@interface PAGUnityappOpenAdHandler : PAGUnityBaseAdHandler<PAGLAppOpenAdDelegate>

@end

@interface PAGUnityRewardedAdHandler : PAGUnityBaseAdHandler<PAGRewardedAdDelegate>

@property (nonatomic, assign) AdDidEarnRewardCallback earnRewardCallback;
@property (nonatomic, assign) AdEarnRewardFailCallback earnRewardFailCallback;

@end

@interface PAGUnityBannerAdHandler :  PAGUnityBaseAdHandler<PAGBannerAdDelegate>

@end

@interface PAGUnityNativeAdHandler : PAGUnityBaseAdHandler<PAGLNativeAdDelegate>

@property (nonatomic, strong) PAGUnityNativeCustomView *nativeView;

@end
