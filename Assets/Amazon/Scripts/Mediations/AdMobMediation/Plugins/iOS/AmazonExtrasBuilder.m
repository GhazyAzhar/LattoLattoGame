#import "AmazonExtrasBuilder.h"
#import <AmazonManager.h>
@implementation AmazonExtrasBuilder

NSString *const useFetchManager = @"useFetchManager";
NSString *const parsingDate = @"load_start";

- (id<GADAdNetworkExtras>)adNetworkExtrasWithDictionary:
(NSDictionary<NSString *, NSString *> *)extras {
    GADCustomEventExtras *amazonExtras = [[GADCustomEventExtras alloc] init];
    if( [extras objectForKey:useFetchManager] == nil){
        NSString *amznSlots  = [extras objectForKey:@"amznSlots"];
        NSString *mediationHints  = [extras objectForKey:@"mediationHints"];
        NSError * err;
        NSData *data =[mediationHints dataUsingEncoding:NSUTF8StringEncoding];
        NSMutableDictionary * mediationHintsDict;
        if(data!=nil){
            mediationHintsDict = (NSMutableDictionary *)[NSJSONSerialization JSONObjectWithData:data options:NSJSONReadingMutableContainers error:&err];
            
        }
        
        NSString *dateString = mediationHintsDict[parsingDate];
        NSDateFormatter *dateFormatter = [[NSDateFormatter alloc] init];
        [dateFormatter setDateFormat:@"dd-MM-yyyy"];
        NSDate *dateFromString = [dateFormatter dateFromString:dateString];
        [mediationHintsDict setValue:dateFromString forKey:parsingDate];
        //if err != error
        [amazonExtras setExtras:mediationHintsDict forLabel:amznSlots];
    } else {
        //we will get extras from fetchManager
    }
    return amazonExtras;
}

@end
