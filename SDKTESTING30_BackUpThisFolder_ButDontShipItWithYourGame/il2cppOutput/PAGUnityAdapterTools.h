extern "C" {
    extern NSString * const PangleIOSRequest_exterInfo = @"extraInfo";
    extern NSString * const PangleIOSRequest_adString = @"adString";
    extern NSString * const PangleIOSRequest_timeout = @"timeout";
    NSString* PangleIOS_transformNSStringForm(const char * string);
    void PangleIOS_dispatchSyncMainQueue(void (^block)(void));
    NSDictionary* PangleIOS_jsonObjectFromJsonString(NSString *jsonString);
    NSDictionary* PangleIOS_requestJsonObjectFromJsonString(const char * json);

} 
