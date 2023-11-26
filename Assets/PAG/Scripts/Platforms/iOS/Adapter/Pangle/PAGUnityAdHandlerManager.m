#import "PAGUnityAdHandlerManager.h"

@interface PAGUnityAdHandlerManager()

@property (nonatomic, strong) dispatch_semaphore_t semaphore;
@property (nonatomic, strong) NSMutableDictionary *dictionary;

@end

@implementation PAGUnityAdHandlerManager

+ (instancetype)sharedInstance {
    static PAGUnityAdHandlerManager *manager = nil;
    static dispatch_once_t onceToken;
    dispatch_once(&onceToken, ^{
        manager = [[PAGUnityAdHandlerManager alloc] init];
    });
    return manager;
}

- (instancetype)init
{
    self = [super init];
    if (self) {
        self.dictionary = [NSMutableDictionary new];
        self.semaphore = dispatch_semaphore_create(1);
    }
    return self;
}

+ (void)saveAdHandler:(PAGUnityBaseAdHandler *)adhandler withKey:(NSString *)key {
    if (!adhandler || key.length == 0) {
        return;
    }
    PAGUnityAdHandlerManager *manager = [PAGUnityAdHandlerManager sharedInstance];
    dispatch_semaphore_wait(manager.semaphore, DISPATCH_TIME_FOREVER);
    [manager.dictionary setObject:adhandler forKey:key];
    dispatch_semaphore_signal(manager.semaphore);
}

+ (void)removeAdHandlerWithKey:(NSString *)key {
    if (key.length == 0) {
        return;
    }
    PAGUnityAdHandlerManager *manager = [PAGUnityAdHandlerManager sharedInstance];
    dispatch_semaphore_wait(manager.semaphore, DISPATCH_TIME_FOREVER);
    [manager.dictionary removeObjectForKey:key];
    dispatch_semaphore_signal(manager.semaphore);
}

+ (NSString *)createKeyUnityAd:(UnityAd)unityAd {
    return [NSString stringWithFormat:@"%p",unityAd];
}

+ (nullable PAGUnityBaseAdHandler *)handlerWithKey:(NSString *)key {
    if (key.length == 0) {
        return nil;
    }
    PAGUnityAdHandlerManager *manager = [PAGUnityAdHandlerManager sharedInstance];
    dispatch_semaphore_wait(manager.semaphore, DISPATCH_TIME_FOREVER);
    PAGUnityBaseAdHandler *handler = [manager.dictionary objectForKey:key];
    dispatch_semaphore_signal(manager.semaphore);
    return handler;
}

+ (void)printList {
    NSLog(@"pangle-ios-list:%@",[PAGUnityAdHandlerManager sharedInstance].dictionary);
}

@end
