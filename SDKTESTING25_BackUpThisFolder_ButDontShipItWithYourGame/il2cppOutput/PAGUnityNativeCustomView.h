#import <UIKit/UIKit.h>


@class PAGLNativeAd;
@interface PAGUnityNativeCustomView : UIView

- (void)refreshWithNativeAd:(PAGLNativeAd *)nativeAd;

- (NSArray<UIView *> *)clickAbleViews;

@end
