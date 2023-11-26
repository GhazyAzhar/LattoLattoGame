using PAG.Scripts.Common;

namespace PAG.Scripts.Api
{
    public static class PAGSdk
    {
        public const string PangleSdkVersion = "4.6.0.2";
        
        private static IClientFactory _clientFactory;

        private static ISDK _sdk;

        internal static ISDK SDK
        {
            get
            {
                if (_sdk == null)
                {
                    _sdk = GetClientFactory().BuildSDKClient();
                }

                return _sdk;
            }
        }

        internal static IClientFactory GetClientFactory()
        {
            if (_clientFactory != null)
            {
                return _clientFactory;
            }

            _clientFactory =
#if UNITY_EDITOR
                new PAG.Scripts.Platforms.Dummy.DummyClientFactory();
#elif !UNITY_EDITOR && UNITY_ANDROID
                new PAG.Scripts.Platforms.Android.AndroidClientFactory();
#elif !UNITY_EDITOR && UNITY_IOS
                new PAG.Scripts.Platforms.iOS.IOSClientFactory();
#else
                null;
            throw new PlatformNotSupportedException();
#endif
            return _clientFactory;
        }

        public delegate void InitResultDelegate(bool result, int errorCode, string message);

        public static event InitResultDelegate OnInitFinish;

        /// Starts the Pangle SDK
        /// @warning Call this method as early as possible to reduce  ad request fail.
        /// @param config SDK configuration
        /// @param callback Callback for starting the Pangle SDK
        /// ////
        public static void Init(PAGConfig config)
        {
            if (IsInitSuccess())
            {
                OnInitFinish?.Invoke(true, 0, null);
                return;
            }

            SDK.Init(config, ((result, code, message) => { OnInitFinish?.Invoke(result, code, message); }));
        }

        ////
        /// The SDK initialization state
        ////
        public static bool IsInitSuccess()
        {
            return SDK.IsInitSuccess();
        }

        ///////
        /// Pangle SDK version
        /// ////
        public static string GetSDKVersion()
        {
            return PangleSdkVersion;
        }
    }
}