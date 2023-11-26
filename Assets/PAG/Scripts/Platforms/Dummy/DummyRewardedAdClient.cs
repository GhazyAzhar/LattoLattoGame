#if UNITY_EDITOR
using System;
using PAG.Scripts.Api;
using PAG.Scripts.Common;
using UnityEngine;

namespace PAG.Scripts.Platforms.Dummy
{
    class DummyRewardedAdClient : IPAGRewardedAd
    {
        public event Action OnLoad;
        public event Action<int, string> OnLoadFailed;
        public event Action OnAdShowed;
        public event Action OnAdClicked;
        public event Action OnAdDismissed;
        public event Action<PAGRewardItem> OnUserEarnedReward;
        public event Action<int, string> OnUserEarnedRewardFail;

        public void Load(string slotId, PAGRewardedRequest request)
        {
            Debug.Log($"dummy reward ad Load(slotId = {slotId}, {request.GetType()})");
        }

        public bool IsLoaded()
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            Debug.Log("dummy reward ad Show()");
        }

        public void Destroy()
        {
            Debug.Log("dummy reward ad Destroy()");
        }
    }
}
#endif