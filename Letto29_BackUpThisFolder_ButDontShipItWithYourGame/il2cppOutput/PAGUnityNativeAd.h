#import "PAGUnityBaseAdHandler.h"

extern "C" {

    //load Native ad
    void PangleIOS_loadNativeAdData(UnityAd unityAd,
                                    const char *slotId,
                                    const char *requestJson,
                                    AdDidLoadCallback successCallback,
                                    AdLoadFailCallBack failCallback,
                                    AdDidShowCallback showCallback,
                                    AdDidClickCallback clickCallback,
                                    AdDidDismissCallback dismissCallback
                                    );
    void PangleIOS_showNativeAd(UnityAd unityAd);
    void PangleIOS_removeNativeView(UnityAd unityAd);
}
