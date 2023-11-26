using System;
using PAG.Scripts.Api;

namespace PAG.Scripts.Common
{
    public class PAGBaseAd<T> where T : PAGRequest
    {
        /// <summary>
        /// event for load ad success
        /// </summary>
        public event Action OnLoad;

        /// <summary>
        /// load ad failed with error code and error message
        /// </summary>
        public event Action<int, string> OnLoadFailed;

        /// <summary>
        /// event for ad impression
        /// </summary>
        public event Action OnAdShowed;

        /// <summary>
        /// event for ad be clicked
        /// </summary>
        public event Action OnAdClicked;

        /// <summary>
        /// event for ad be closed
        /// </summary>
        public event Action OnAdDismissed;

        private readonly string _slotId;

        private bool _isAdLoaded;

        protected readonly IPAGAd<T> ADClient;

        public bool CallbackOnMainThread { get; set; } = true;

        protected PAGBaseAd(string id, IPAGAd<T> adClient)
        {
            _slotId = id;
            ADClient = adClient;
            InitEvent(ADClient);
        }

        private void InitEvent(IPAGAd<T> adClient)
        {
            adClient.OnLoad += InvokeOnLoad;
            adClient.OnLoadFailed += InvokeOnLoadFailed;

            adClient.OnAdShowed += InvokeOnAdShowed;
            adClient.OnAdClicked += InvokeOnAdClicked;
            adClient.OnAdDismissed += InvokeOnAdDismissed;
        }

        public void Load(T request)
        {
            if (_isAdLoaded)
            {
                InvokeOnLoad();
            }
            if (string.IsNullOrEmpty(_slotId))
            {
                InvokeOnLoadFailed(-1, "slotId must be not null");
                return;
            }

            if (!PAGSdk.IsInitSuccess())
            {
                InvokeOnLoadFailed(-1, "sdk has not init");
                return;
            }
            ADClient?.Load(_slotId, request);
        }

        public virtual void Show()
        {
            _isAdLoaded = false;
            ADClient?.Show();
        }

        public void DestroyAd()
        {
            ADClient?.Destroy();
        }

        public bool IsLoaded()
        {
            return _isAdLoaded;
        }

        private void InvokeOnLoad()
        {
            OnLoad?.Invoke();
            _isAdLoaded = true;
        }

        protected void InvokeOnLoadFailed(int errorCode, string errorMessage)
        {
            if (CallbackOnMainThread)
            {
                PAGDispatcher.PostTask((() => { OnLoadFailed?.Invoke(errorCode, errorMessage); }));
            }
            else
            {
                OnLoadFailed?.Invoke(errorCode, errorMessage);
            }
        }


        private void InvokeOnAdShowed()
        {
            if (CallbackOnMainThread)
            {
                PAGDispatcher.PostTask((() => { OnAdShowed?.Invoke(); }));
            }
            else
            {
                OnAdShowed?.Invoke();
            }
        }

        private void InvokeOnAdClicked()
        {
            if (CallbackOnMainThread)
            {
                PAGDispatcher.PostTask((() => { OnAdClicked?.Invoke(); }));
            }
            else
            {
                OnAdClicked?.Invoke();
            }
        }

        private void InvokeOnAdDismissed()
        {
            if (CallbackOnMainThread)
            {
                PAGDispatcher.PostTask((() => { OnAdDismissed?.Invoke(); }));
            }
            else
            {
                OnAdDismissed?.Invoke();
            }
        }
    }
}