#if UNITY_EDITOR
using System;
using PAG.Scripts.Api;
using PAG.Scripts.Common;
using UnityEngine;

namespace PAG.Scripts.Platforms.Dummy
{
    class DummyNativeAdClient : INativeAd
    {
        public event Action OnLoad;
        public event Action<int, string> OnLoadFailed;
        public event Action OnAdShowed;
        public event Action OnAdClicked;
        public event Action OnAdDismissed;


        public void Load(string slotId, PAGNativeRequest request)
        {
            Debug.Log($"dummy native ad Load(slotId = {slotId}, {request.GetType()})");
        }

        public bool IsLoaded()
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            Debug.Log("dummy native ad Show()");
        }

        public void Destroy()
        {
            Debug.Log("dummy native ad Destroy()");
        }

        public void SetPosition(int x, int y)
        {
            Debug.Log($"dummy native ad SetPosition({x}, {y})");
        }
    }
}
#endif