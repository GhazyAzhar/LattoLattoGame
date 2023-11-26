using System;
using System.Collections.Generic;
using AmazonAds;
using GoogleMobileAds.Api;
using UnityEngine;
public class AmazonAdMobDemo : MonoBehaviour {

#if UNITY_ANDROID // Android IDs
    private string interstitialAdUnitIdAdMob = "ca-app-pub-8591556795074074/8643234517";
    private string bannerAdUnitIdAdMob = "ca-app-pub-8591556795074074/2302801842";
  
    public string amazonApiKey = "7873ab072f0647b8837748312c7b8b5a";
    public string amazonInterstitialId = "394133e6-27fe-477d-816b-4a00cdaa54b6";
    public string amazonBannerId = "ed3b9f16-4497-4001-be7d-2e8ca679ee73"; //320x50
#else // IOS IDs

    private string interstitialAdUnitIdAdMob = "ca-app-pub-8591556795074074/6542635030";
    private string bannerAdUnitIdAdMob = "ca-app-pub-8591556795074074/6217802609";

    public string amazonApiKey = "c5f20fe6e37146b08749d09bb2b6a4dd";
    public string amazonInterstitialId = "424c37b6-38e0-4076-94e6-0933a6213496";
    public string amazonBannerId = "88e6293b-0bf0-43fc-947b-925babe7bf3f"; //320x50
    public string amazonVideoId = "05474a0b-d343-471c-bdb0-07a9ed643074";
#endif
    public UnityEngine.UI.Button isInitializedBut;

    private InterstitialAd interstitialAdMob;

    private BannerView bannerViewAdMob;
    private BannerView smartBannerViewAdMob;

    private bool isAdMobInitialized = false;

    private APSInterstitialAdRequest interstitialAmazon;
    private APSBannerAdRequest bannerAmazon;
    private APSBannerAdRequest smartBannerAmazon;
    
    private bool autoRefresh = false;
    string slotGroupName = "defaultSlot";

    public void SetAutoRefresh (bool flag) {
        autoRefresh = flag;
    }

    public void InitializeAdmob () {
        MobileAds.Initialize (initStatus => { isAdMobInitialized = true; });
        RequestConfiguration requestConfiguration = new RequestConfiguration.Builder ()
            .SetTestDeviceIds (new List<String> () { "557F41272FA85BABA407A40A0D33A7DA" })
            .build ();
        MobileAds.SetRequestConfiguration (requestConfiguration);

        Amazon.Initialize (amazonApiKey);
        Amazon.EnableTesting (true);
        Amazon.EnableLogging (true);
        Amazon.UseGeoLocation (true);
        Amazon.IsLocationEnabled();
        Amazon.SetAdNetworkInfo(new AdNetworkInfo(DTBAdNetwork.ADMOB));
        Amazon.AddCustomAttribute("sessDuration", "11");
        Amazon.AddCustomAttribute("contentURL", "TEST_URL");
#if UNITY_IOS
        Amazon.SetAPSPublisherExtendedIdFeatureEnabled(true);
#endif

        SlotGroup group = new SlotGroup (slotGroupName);
        group.AddSlot (new AmazonAds.AdSize (320, 50, amazonBannerId));
        Amazon.AddSlotGroup (group);
    }

    public void IsInitialized(){
        if (isInitializedBut == null ) return;
        if( Amazon.IsInitialized() ) {
            isInitializedBut.GetComponent<UnityEngine.UI.Image>().color = Color.green;
        } else {
            isInitializedBut.GetComponent<UnityEngine.UI.Image>().color = Color.red;
        }
    }

    public void RequestInterstitial () {
        interstitialAdMob = new InterstitialAd (interstitialAdUnitIdAdMob);
        interstitialAdMob.OnAdLoaded += OnInterstitialAdLoaded;

        APSInterstitialAdRequest newInterstitialRequest = new APSInterstitialAdRequest (amazonInterstitialId);
        newInterstitialRequest.onFailed += HandleAmazonInterstitialFailed;
        newInterstitialRequest.onSuccess += HandleAmazonInterstitialSuccess;
        newInterstitialRequest.LoadAd ();
    }

    public void HandleAmazonInterstitialFailed (string errorMsg) { }

    public void HandleAmazonInterstitialSuccess (AmazonAds.AdResponse response) {
        AmazonInterstitialMediationExtras extras = new AmazonInterstitialMediationExtras (response.GetRendering ());
        #if UNITY_IOS // Only for iOS, if admob test account is used.
                extras.Extras.Remove("amznSlots");
                extras.Extras.Add("amznSlots", "Label");
        #endif
        GoogleMobileAds.Api.AdRequest request = new GoogleMobileAds.Api.AdRequest.Builder ()
            .AddMediationExtras (extras)
            .Build ();
        interstitialAdMob.LoadAd (request);
    }

    public void OnInterstitialAdLoaded (object sender, EventArgs args) {
        interstitialAdMob.Show ();
    }

    public void RequestBanner () {
        if( bannerViewAdMob != null ) bannerViewAdMob.Destroy();
        bannerViewAdMob = new BannerView (bannerAdUnitIdAdMob, GoogleMobileAds.Api.AdSize.Banner, AdPosition.Top);
        bannerViewAdMob.OnAdLoaded += OnBannerAdLoaded;
        bannerViewAdMob.OnAdFailedToLoad += OnBannerAdFailedToLoad;
        
        bannerAmazon = new APSBannerAdRequest (320, 50, amazonBannerId);
        bannerAmazon.onFailed += HandleAmazonBannerFailed;
        bannerAmazon.onSuccess += HandleAmazonBannerSuccess;
        bannerAmazon.LoadAd ();
    }

    public void HandleAmazonBannerFailed (string errorMsg) { 
        AmazonBannerMediationExtras extras = new AmazonBannerMediationExtras (false, bannerAmazon.AutoRefreshID ());
        #if UNITY_IOS // Only for iOS, if admob test account is used.
                extras.Extras.Remove("amznSlots");
                extras.Extras.Add("amznSlots", "Label");
        #endif
        GoogleMobileAds.Api.AdRequest request = new GoogleMobileAds.Api.AdRequest.Builder ()
            .AddMediationExtras (extras)
            .Build ();
        bannerViewAdMob.LoadAd (request);
        bannerViewAdMob.Show ();
    }

    public void HandleAmazonBannerSuccess (AmazonAds.AdResponse response) {
        AmazonBannerMediationExtras extras = new AmazonBannerMediationExtras (false, bannerAmazon.AutoRefreshID (),response);
        #if UNITY_IOS // Only for iOS, if admob test account is used.
                extras.Extras.Remove("amznSlots");
                extras.Extras.Add("amznSlots", "Label");
        #endif
        GoogleMobileAds.Api.AdRequest request = new GoogleMobileAds.Api.AdRequest.Builder ()
            .AddMediationExtras (extras)
            .Build ();

        bannerViewAdMob.LoadAd (request);
        bannerViewAdMob.Show ();
    }

  
    public void RequestSmartBanner () {
        if( smartBannerViewAdMob != null ) smartBannerViewAdMob.Destroy();
        smartBannerViewAdMob = new BannerView (bannerAdUnitIdAdMob, GoogleMobileAds.Api.AdSize.SmartBanner, AdPosition.Bottom);
        smartBannerViewAdMob.OnAdLoaded += OnSmartBannerAdLoaded;
        smartBannerViewAdMob.OnAdFailedToLoad += OnSmartBannerAdFailedToLoad;

        smartBannerAmazon = new APSBannerAdRequest (slotGroupName);
        smartBannerAmazon.onFailed += HandleAmazonSmartBannerFailed;
        smartBannerAmazon.onSuccess += HandleAmazonSmartBannerSuccess;
        smartBannerAmazon.LoadSmartBanner ();
    }

    public void HandleAmazonSmartBannerFailed (string errorMsg) { 
        AmazonBannerMediationExtras extras = new AmazonBannerMediationExtras (true, smartBannerAmazon.AutoRefreshID ());
        #if UNITY_IOS // Only for iOS, if admob test account is used.
                extras.Extras.Remove("amznSlots");
                extras.Extras.Add("amznSlots", "Label");
        #endif
        GoogleMobileAds.Api.AdRequest request = new GoogleMobileAds.Api.AdRequest.Builder ()
            .AddMediationExtras (extras)
            .Build ();

        smartBannerViewAdMob.LoadAd (request);
        smartBannerViewAdMob.Show ();
    }

    public void HandleAmazonSmartBannerSuccess (AmazonAds.AdResponse response) {
        AmazonBannerMediationExtras extras = new AmazonBannerMediationExtras (true, smartBannerAmazon.AutoRefreshID (), response);
        #if UNITY_IOS // Only for iOS, if admob test account is used.
                extras.Extras.Remove("amznSlots");
                extras.Extras.Add("amznSlots", "Label");
        #endif
        GoogleMobileAds.Api.AdRequest request = new GoogleMobileAds.Api.AdRequest.Builder ()
            .AddMediationExtras (extras)
            .Build ();
        smartBannerViewAdMob.LoadAd (request);
        smartBannerViewAdMob.Show ();
    }

    
    public void OnBannerAdLoaded (object sender, EventArgs args) {
        
    }

    
    public void OnBannerAdFailedToLoad (object sender, EventArgs args) {
        
    }

    
    public void OnSmartBannerAdLoaded (object sender, EventArgs args) {
        
    }

    
    public void OnSmartBannerAdFailedToLoad (object sender, EventArgs args) {
        
    }

    void OnApplicationPause(bool isPaused) {                 
        Amazon.OnApplicationPause(isPaused);
    }
}
