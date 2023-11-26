#if UNITY_ANDROID

using PAG.Scripts.Api;
using PAG.Scripts.Common;
using UnityEngine;

namespace PAG.Scripts.Platforms.Android
{
    class PAGSdkClient : ISDK
    {
        private const string SDKClientClassName = AndroidPlatformTool.ClassPackage + ".PAGSDKManager";
        private const string InitMethod = "init";
        private const string InitSuccessMethod = "isInitSuccess";
        private const string InitListenerInterfaceName = AndroidPlatformTool.ClassPackage + ".PAGInitListener";

        public void Init(PAGConfig config, PAGSdk.InitResultDelegate initResultDelegate)
        {
            InvokeNativeMethod(InitMethod, AndroidPlatformTool.GetGameActivity(),
                AndroidPlatformTool.GetPAGConfig(config),
                new InitCallBack(initResultDelegate));
        }

        public bool IsInitSuccess()
        {
            return InvokeNativeMethod<bool>(InitSuccessMethod);
        }

        public void SetChildDirected(int coppa)
        {
            InvokeNativeMethod("setChildDirected", coppa);
        }

        public int GetChildDirected()
        {
            return InvokeNativeMethod<int>("getChildDirected");
        }

        public void SetDoNotSell(int ccpa)
        {
            InvokeNativeMethod("setDoNotSell", ccpa);
        }

        public int GetDoNotSell()
        {
            return InvokeNativeMethod<int>("getDoNotSell");
        }

        public void SetGDPRConsent(int gdpr)
        {
            InvokeNativeMethod("setGDPRConsent", gdpr);
        }

        public int GetGDPRConsent()
        {
            return InvokeNativeMethod<int>("getGDPRConsent");
        }

        public void SetDebugLog(bool enable)
        {
            InvokeNativeMethod("setDebugLog", enable);
        }

        private static void InvokeNativeMethod(string methodName, params object[] args)
        {
            new AndroidJavaClass(SDKClientClassName).CallStatic(methodName, args);
        }

        private static T InvokeNativeMethod<T>(string methodName, params object[] args)
        {
            return new AndroidJavaClass(SDKClientClassName).CallStatic<T>(methodName, args);
        }

        private class InitCallBack : AndroidJavaProxy
        {
            private event PAGSdk.InitResultDelegate InitListener;

            public InitCallBack(PAGSdk.InitResultDelegate initResultDelegate) : base(InitListenerInterfaceName)
            {
                this.InitListener = initResultDelegate;
            }


            public void success()
            {
                InitListener?.Invoke(true, 0, null);
            }

            public void fail(int code, string msg)
            {
                InitListener?.Invoke(false, code, msg);
            }
        }
    }
}
#endif