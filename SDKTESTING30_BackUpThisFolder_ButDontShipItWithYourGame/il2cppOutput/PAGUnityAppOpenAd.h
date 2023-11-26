#import "PAGUnityBaseAdHandler.h"
extern "C" {

    //load appOpen Ad
    void PangleIOS_loadAppOpenAdData(UnityAd unityAd,
                                     const char *slotId,
                                     const char *requestJson,
                                     AdDidLoadCallback successCallback,
                                     AdLoadFailCallBack failCallback,
                                     AdDidShowCallback showCallback,
                                     AdDidClickCallback clickCallback,
                                     AdDidDismissCallback dismissCallback);
    //show open ad
    void PangleIOS_showAppOpenAd(UnityAd unityAd);
}
