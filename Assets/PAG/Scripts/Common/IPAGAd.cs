using System;
using PAG.Scripts.Api;

namespace PAG.Scripts.Common
{
    public interface IPAGAd<in T> : IClientBidding where T : PAGRequest
    {
        event Action OnLoad;
        event Action<int, string> OnLoadFailed;
        event Action OnAdShowed;
        event Action OnAdClicked;
        event Action OnAdDismissed;
        void Load(string slotId, T request);
        bool IsLoaded();
        void Show();
        void Destroy();
    }
}