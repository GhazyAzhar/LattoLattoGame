using PAG.Scripts.Api;
using UnityEngine;

namespace PAG.Example
{
    public class InterstitialAdController
    {
        private readonly PAGInterstitialAd _interstitialAd;

        public InterstitialAdController(string slotId)
        {
            _interstitialAd = new PAGInterstitialAd(slotId);
            _interstitialAd.OnLoad += (() => { Debug.Log("[PAGInterstitial]-[Load]:success"); });
            _interstitialAd.OnLoadFailed += ((code, msg) =>
            {
                Debug.Log($"[PAGInterstitial]-[Load]:failed, code ={code}, error message = {msg}");
            });

            _interstitialAd.OnAdShowed += (() => { Debug.Log("[PAGInterstitial]-[interaction]:show"); });
            _interstitialAd.OnAdClicked += (() => { Debug.Log("[PAGInterstitial]-[interaction]:click"); });
            _interstitialAd.OnAdDismissed += (() => { Debug.Log("[PAGInterstitial]-[interaction]:dismiss"); });
        }

        public void LoadInterstitialAd()
        {
            _interstitialAd?.Load(new PAGInterstitialRequest());
        }

        public void ShowInterstitialAd()
        {
            _interstitialAd?.Show();
        }

        public void DestroyInterstitialAd()
        {
            _interstitialAd?.DestroyAd();
        }
    }
}