using PAG.Scripts.Api;
using UnityEngine;

namespace PAG.Example
{
    public class NativeAdController
    {
        private readonly PAGNativeAd _nativeAd;

        public NativeAdController(string slotId)
        {
            _nativeAd = new PAGNativeAd(slotId);
            _nativeAd.OnLoad += (() => { Debug.Log("[PAGNative]-[Load]:success"); });
            _nativeAd.OnLoadFailed += ((code, msg) =>
            {
                Debug.Log($"[PAGNative]-[Load]:failed, code ={code}, error message = {msg}");
            });

            _nativeAd.OnAdShowed += (() => { Debug.Log("[PAGNative]-[interaction]:show"); });
            _nativeAd.OnAdClicked += (() => { Debug.Log("[PAGNative]-[interaction]:click"); });
            _nativeAd.OnAdDismissed += (() => { Debug.Log("[PAGNative]-[interaction]:dismiss"); });
        }

        public void LoadNativeAd()
        {
            _nativeAd?.Load(new PAGNativeRequest());
        }

        public void SetPosition(int x, int y)
        {
            _nativeAd?.SetPosition(x, y);
        }

        public void ShowNativeAd()
        {
            _nativeAd?.Show();
        }

        public void DestroyNativeAd()
        {
            _nativeAd?.DestroyAd();
        }
    }
}