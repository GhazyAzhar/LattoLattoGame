#import <PAGAdSDK/PAGAdSDK.h>
#import <UIKit/UIKit.h>
#import "PAGUnityAdapterTools.h"

extern "C" {

PAGConfig* PangleIOS_shareConfig() {
    return [PAGConfig shareConfig];
}
PAGConfig* PangleIOS_GetConfig(void* __nullable config){
    PAGConfig *pagConfig = config ? (__bridge PAGConfig*)config : nil;
    if (!pagConfig) {
        pagConfig = [PAGConfig shareConfig];
    }
    return pagConfig;
}
//AppID
void PangleIOS_configSetAppID(void* config, const char* appID) {
    PangleIOS_GetConfig(config).appID = PangleIOS_transformNSStringForm(appID);
}

const char* PangleIOS_configGetAppID(void* config) {
    return PangleIOS_GetConfig(config).appID.UTF8String;
}

//childDirected
void PangleIOS_configSetChildDirected(void* config, PAGChildDirectedType childDirected) {
    PangleIOS_GetConfig(config).childDirected = childDirected;
}

PAGChildDirectedType PangleIOS_configGetChildDirected(void* config) {
    return PangleIOS_GetConfig(config).childDirected;
}

//GDPRConsent
void PangleIOS_configSetGDPRConsent(void* config, PAGGDPRConsentType GDPRConsent) {
    PangleIOS_GetConfig(config).GDPRConsent = GDPRConsent;
}

PAGGDPRConsentType PangleIOS_configGetGDPRConsent(void* config) {
    return PangleIOS_GetConfig(config).GDPRConsent;;
}

//doNotSell
void PangleIOS_configSetDoNotSell(void* config, PAGDoNotSellType doNotSell) {
    PangleIOS_GetConfig(config).doNotSell = doNotSell;
}

PAGDoNotSellType PangleIOS_configGetDoNotSell(void* config) {
    return PangleIOS_GetConfig(config).doNotSell;
}

//themeStatus
void PangleIOS_configSetThemeStatus(void* config, PAGAdSDKThemeStatus themeStatus) {
    PangleIOS_GetConfig(config).themeStatus = themeStatus;
}

PAGAdSDKThemeStatus PangleIOS_configGetThemeStatus(void* config) {
    return PangleIOS_GetConfig(config).themeStatus;
}

//debugLog
void PangleIOS_configSetDebugLog(void* config, bool debugLog) {
    PangleIOS_GetConfig(config).debugLog = debugLog;
}

bool PangleIOS_configGetDebugLog(void* config) {
    return PangleIOS_GetConfig(config).debugLog;
}

//appLogoImage
void PangleIOS_configSetAppLogoImageString(void* config, const char* appLogoImageString) {
    NSString *imageName = PangleIOS_transformNSStringForm(appLogoImageString);
    PangleIOS_GetConfig(config).appLogoImage = [UIImage imageNamed:imageName];
}

UIImage* PangleIOS_configGetAppLogoImageString(void* config) {
    return PangleIOS_GetConfig(config).appLogoImage;
}

//userDataString
void PangleIOS_configSetUserDataString(void* config, const char* userDataString) {
    PangleIOS_GetConfig(config).userDataString = PangleIOS_transformNSStringForm(userDataString);
}

const char* PangleIOS_configGetUserDataString(void* config) {
    return PangleIOS_GetConfig(config).userDataString.UTF8String;
}

//allowModifyAudioSessionSetting
void PangleIOS_configSetAllowModifyAudioSessionSetting(void* config, bool allowModifyAudioSessionSetting) {
    PangleIOS_GetConfig(config).allowModifyAudioSessionSetting = allowModifyAudioSessionSetting;
}

bool PangleIOS_configGetAllowModifyAudioSessionSetting(void* config) {
    return PangleIOS_GetConfig(config).allowModifyAudioSessionSetting;
}

}
