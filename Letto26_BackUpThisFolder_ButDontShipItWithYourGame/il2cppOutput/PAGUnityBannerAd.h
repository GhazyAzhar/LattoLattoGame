#import "PAGUnityBaseAdHandler.h"

extern "C" {

    //load banner Ad
    void PangleIOS_loadBannerAdData(UnityAd unityAd,
                                    const char *slotId,
                                    const char *requestJson,
                                    int x,
                                    int y,
                                    int width,
                                    int height,
                                    AdDidLoadCallback successCallback,
                                    AdLoadFailCallBack failCallback,
                                    AdDidShowCallback showCallback,
                                    AdDidClickCallback clickCallback,
                                    AdDidDismissCallback dismissCallback
                                    );
    //show banner ad
    void PangleIOS_showBannerAd(UnityAd unityAd);
    void PangleIOS_SetBannerAdPosition(UnityAd unityAd,int x, int y);
    void PangleIOS_removeBannerView(UnityAd unityAd);
}
