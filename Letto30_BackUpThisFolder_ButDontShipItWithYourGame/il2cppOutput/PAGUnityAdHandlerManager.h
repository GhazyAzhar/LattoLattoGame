
#import <Foundation/Foundation.h>
#import "PAGUnityBaseAdHandler.h"

NS_ASSUME_NONNULL_BEGIN

@interface PAGUnityAdHandlerManager : NSObject

+ (void)saveAdHandler:(PAGUnityBaseAdHandler *)adhandler withKey:(NSString *)key;

+ (void)removeAdHandlerWithKey:(NSString *)key;

+ (NSString *)createKeyUnityAd:(UnityAd)unityAd;

+ (nullable PAGUnityBaseAdHandler *)handlerWithKey:(NSString *)key;

+ (void)printList;

@end

NS_ASSUME_NONNULL_END
