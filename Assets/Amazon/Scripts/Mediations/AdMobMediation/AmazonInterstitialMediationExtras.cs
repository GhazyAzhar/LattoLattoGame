using System;
using System.Collections.Generic;

public class AmazonInterstitialMediationExtras : AmazonMediationExtras {
    public AmazonInterstitialMediationExtras () : base () { }

    public AmazonInterstitialMediationExtras (Dictionary<string, string> extr) : base () {
        Extras = extr;
    }

    public override string AndroidMediationExtraBuilderClassName {
        get { return "com.amazon.unityplugin.UnityInterstitialAdMobMediation"; }
    }
}