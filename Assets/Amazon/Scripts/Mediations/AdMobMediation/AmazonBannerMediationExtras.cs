using System.Collections.Generic;

public class AmazonBannerMediationExtras : AmazonMediationExtras {
    public AmazonBannerMediationExtras (bool isSmartBanner, string refreshID, AmazonAds.AdResponse responce = null) : base () {
        if( responce != null ){
            Dictionary<string, string> extr = responce.GetRendering(isSmartBanner, refreshID);
            Extras = extr;
        } else {
            Extras.Add("amazon_request_queue",refreshID);
            if( isSmartBanner ){
                Extras.Add("expected_width","0");
                Extras.Add("expected_height","0");
            }
        }
    }

    public override string AndroidMediationExtraBuilderClassName {
        get { return "com.amazon.unityplugin.UnityBannerAdMobMediation"; }
    }
}