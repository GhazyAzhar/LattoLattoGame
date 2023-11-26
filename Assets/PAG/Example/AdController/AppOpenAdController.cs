using PAG.Scripts.Api;
using UnityEngine;

namespace PAG.Example
{
    public class AppOpenAdController
    {
        private readonly PAGAppOpenAd _appOpenAd;

        public AppOpenAdController(string slotId)
        {
            _appOpenAd = new PAGAppOpenAd(slotId)
            {
                CallbackOnMainThread = false
            };
            _appOpenAd.OnLoad += (() =>
            {
                Debug.Log("[PAGAppOpen]-[Load]:successfully");
                ShowAppOpenAd();
            });
            _appOpenAd.OnLoadFailed += ((code, msg) =>
            {
                Debug.Log($"[PAGAppOpen]-[Load]:failed， code ={code}, error message = {msg}");
            });

            _appOpenAd.OnAdShowed += (() => { Debug.Log("[PAGAppOpen]-[interaction]:show"); });
            _appOpenAd.OnAdClicked += (() => { Debug.Log("[PAGAppOpen]-[interaction]:click"); });
            _appOpenAd.OnAdDismissed += (() => { Debug.Log("[PAGAppOpen]-[interaction]:dismiss"); });
        }

        public void LoadAppOpenAd()
        {
            var request = new PAGAppOpenRequest
            {
                Timeout = 5000
            };
            _appOpenAd?.Load(request);
        }

        public void ShowAppOpenAd()
        {
            _appOpenAd?.Show();
        }

        public void DestroyAd()
        {
            _appOpenAd?.DestroyAd();
        }
    }
}