#if UNITY_EDITOR
using System;
using PAG.Scripts.Api;
using PAG.Scripts.Common;
using UnityEngine;

namespace PAG.Scripts.Platforms.Dummy
{
    class DummyInterstitialAdClient : IPAGInterstitialAd
    {
        public event Action OnLoad;
        public event Action<int, string> OnLoadFailed;
        public event Action OnAdShowed;
        public event Action OnAdClicked;
        public event Action OnAdDismissed;


        public void Load(string slotId, PAGInterstitialRequest request)
        {
            Debug.Log($"dummy interstitial ad Load(slotId = {slotId}, {request.GetType()})");
        }

        public bool IsLoaded()
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            Debug.Log("dummy interstitial ad Show()");
        }

        public void Destroy()
        {
            Debug.Log("dummy interstitial ad Destroy()");
        }
    }
}
#endif