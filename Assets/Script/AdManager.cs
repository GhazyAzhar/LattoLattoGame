using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.Events;
using GoogleMobileAds.Common;
using GoogleMobileAdsMediationTestSuite.Api;
using UnityEngine.UI;
using System;



public class AdManager : MonoBehaviour
{
    private BannerView bannerView;
    private InterstitialAd interstitial;
    private float deltaTime = 0.0f;
    private static string outputMessage = string.Empty;

    [System.Obsolete]

    // public  static string outputMessage {
    //     set {outputMessage = value;}
    // }

    public void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });

        this.RequestBanner();
        this.RequestInterstitial();
        // this.ShowMediationTestSuite();
 
        MediationTestSuite.OnMediationTestSuiteDismissed += this.HandleMediationTestSuiteDismissed;
    }
    
    private void RequestBanner()
    {
        #if UNITY_ANDROID
                string adUnitId = "ca-app-pub-2026236094667216/2044967037";
        #elif UNITY_IPHONE
                string adUnitId = "";
        #else
                string adUnitId = "unexpected_platform";
        #endif

        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // //Mediation test suitew
        //     MediationTestSuite.AdRequest = new AdRequest.Builder()
        //     .AddTestDevice("e0e24e2c-77ad-4cb2-b703-737a63d7a566")
        //     .Build();
        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }


    private void RequestInterstitial()
    {
        #if UNITY_ANDROID
                string adUnitId = "ca-app-pub-2026236094667216/3814065426";
        #elif UNITY_IPHONE
                string adUnitId = "";
        #else
                string adUnitId = "unexpected_platform";
        #endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLoaded event received");
    }

    public void HandleOnAdOpening(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpening event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
    }



    public void Show_InterstitialAd()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
        else
        {
            print("Ad is not show!");
        }
    }

    private void ShowMediationTestSuite()
    {
        // #if UNITY_ANDROID
                string appId = "ca-app-pub-2026236094667216~8713746340";
        // #elif UNITY_IPHONE
        //         string adUnitId = "";
        // #else
        //         string adUnitId = "unexpected_platform";
        // #endif
        MediationTestSuite.Show(appId);
        // MediationTestSuite.Show();
    }

    public void HandleMediationTestSuiteDismissed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleMediationTestSuiteDismissed event received");
    }

    public void onGUI()
    {
        GUIStyle style = new GUIStyle();

        Rect rect = new Rect(0, 0, Screen.width, Screen.height);
        style. alignment = TextAnchor.LowerRight;
        style.fontSize = (int)(Screen.height * 0.06);
        style.normal.textColor = new Color(0.0f, 0.0f, 0.5f, 1.0f);
        float fps = 1.0f / this.deltaTime;
        string text = string.Format("{0:0.} fps", fps);
        GUI.Label(rect, text, style);

        // Puts basic button onto the screen.
        GUI.skin.button.fontSize = (int)(0.035f * Screen.width);
        float buttonWidth = 0.5f * Screen.width;
        float buttonHeight = 0.3f * Screen.height;
        float columnOnePosition = 0.1f * Screen.width;
        float columnTwoPosition = 0.55f *  Screen.width;

        Rect buttonRect = new Rect(
            columnOnePosition,
            0.25f * Screen.height,
            buttonWidth,
            buttonHeight);
        if (GUI.Button(buttonRect, "Show\nMediation Test Suite"))
        {
            ShowMediationTestSuite();
        }
        Rect textOutputRect = new Rect(
            columnTwoPosition,
            0.925f * Screen.height,
            buttonWidth,
            0.05f * Screen.height);
        GUI.Label(textOutputRect, outputMessage);
    }

    public void adMediation()
    {
        
        ShowMediationTestSuite();
    }
}
