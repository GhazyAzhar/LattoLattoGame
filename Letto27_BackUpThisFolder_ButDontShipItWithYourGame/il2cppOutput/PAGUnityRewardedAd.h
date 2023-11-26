#import "PAGUnityBaseAdHandler.h"

extern "C" {
    //load rewarded Ad
    void PangleIOS_loadRewardedAdData(UnityAd unityAd,
                                      const char *slotId,
                                      const char *requestJson,
                                      AdDidLoadCallback successCallback,
                                      AdLoadFailCallBack failCallback,
                                      AdDidShowCallback showCallback,
                                      AdDidClickCallback clickCallback,
                                      AdDidDismissCallback dismissCallback,
                                      AdDidEarnRewardCallback earnCallback,
                                      AdEarnRewardFailCallback earnFailCallback);
    //show open ad
    void PangleIOS_showRewardedAd(UnityAd unityAd);
}
