
#import "PAGUnityBaseAdHandler.h"
#import "PAGUnityAdHandlerManager.h"

@implementation PAGUnityBaseAdHandler

- (void)adDidShow:(id<PAGAdProtocol>)ad {
    if (self.showCallback) {
        self.showCallback(self.unityAd);
    }
}

- (void)adDidClick:(id<PAGAdProtocol>)ad {
    if (self.clickCallback) {
        self.clickCallback(self.unityAd);
    }
}

- (void)adDidDismiss:(id<PAGAdProtocol>)ad {
    if (self.dismissCallback) {
        self.dismissCallback(self.unityAd);
    }
    NSString *unityAdKey = [PAGUnityAdHandlerManager createKeyUnityAd:self.unityAd];
    [PAGUnityAdHandlerManager removeAdHandlerWithKey:unityAdKey];
}

- (void)dealloc {
    NSLog(@"Pangle-iOS-[PAGUnityBaseAdHandler]-[dealloc]");
}

@end


@implementation PAGUnityInterstitialAdHandler

@end

@implementation PAGUnityappOpenAdHandler

@end

@implementation PAGUnityRewardedAdHandler

- (void)rewardedAd:(PAGRewardedAd *)rewardedAd userDidEarnReward:(PAGRewardModel *)rewardModel {
    if (self.earnRewardCallback) {
        self.earnRewardCallback(self.unityAd,rewardModel.rewardName.UTF8String,(int)rewardModel.rewardAmount);
    }
}

- (void)rewardedAd:(PAGRewardedAd *)rewardedAd userEarnRewardFailWithError:(NSError *)error {
    if (self.earnRewardFailCallback) {
        self.earnRewardFailCallback(self.unityAd,(int)error.code,error.description.UTF8String);
    }
}

@end

@implementation PAGUnityBannerAdHandler

@end

@implementation PAGUnityNativeAdHandler

- (void)adDidDismiss:(id<PAGAdProtocol>)ad {
    [self.nativeView removeFromSuperview];
    [super adDidDismiss:ad];
}

@end
