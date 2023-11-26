#if UNITY_EDITOR
using System;
using PAG.Scripts.Api;
using PAG.Scripts.Api.Constant;
using PAG.Scripts.Common;
using UnityEngine;

namespace PAG.Scripts.Platforms.Dummy
{
    class DummyBannerAd : IBannerAd
    {
        public event Action OnLoad;
        public event Action<int, string> OnLoadFailed;
        public event Action OnAdShowed;
        public event Action OnAdClicked;
        public event Action OnAdDismissed;

        public void Load(string slotId, PAGBannerRequest request)
        {
            Debug.Log($"dummy banner ad Load(slotId = {slotId}, {request.GetType()}), {request.Size}");
        }

        public bool IsLoaded()
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            Debug.Log("dummy banner ad Show()");
        }

        public void SetPosition(int x, int y)
        {
            Debug.Log($"dummy banner ad SetPosition({x}, {y})");
        }

        public void SetPosition(PAGBannerPosition position)
        {
            Debug.Log($"dummy banner ad SetPosition(position = {position})");
        }

        public void Hide()
        {
            Debug.Log("dummy banner ad Hide()");
        }

        public void Destroy()
        {
            Debug.Log("dummy banner ad Destroy()");
        }
    }
}
#endif