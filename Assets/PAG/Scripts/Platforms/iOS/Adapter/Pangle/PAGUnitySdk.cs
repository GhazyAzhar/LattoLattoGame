#if UNITY_IOS
using AOT;
using UnityEngine;

namespace PAG.Scripts.Platforms.iOS.Adapter.Pangle
{
    using System;
    using PAG.Scripts.Api;
    using PAG.Scripts.Common;
    using PAG.Scripts.Platforms.iOS;
    using System.Runtime.InteropServices;
    class PAGUnitySdk : ISDK
    {
        private PAGUnityConfig _pagUnityConfig;
        private PAGSdk.InitResultDelegate resultDelegate;
        public void Init(PAGConfig config, PAGSdk.InitResultDelegate initResultDelegate)
        {
            resultDelegate = initResultDelegate;
            _pagUnityConfig = new PAGUnityConfig();
            _pagUnityConfig.Init(config);
            IntPtr ptr = (IntPtr)GCHandle.Alloc(this);
            PangleIOS_initSDK(ptr,cs_successCallback,cs_failCallback);
            PAGUnityTools.LOGWithMessage("PAGUnitySdk","init","");
        }

        public bool IsInitSuccess()
        {
            return PangleIOS_sdkInitializationState();
        }

        public void SetChildDirected(int coppa)
        {
            this._pagUnityConfig.ChildDirected = coppa;
        }

        public int GetChildDirected()
        {
            return _pagUnityConfig.ChildDirected;
        }

        public void SetDoNotSell(int ccpa)
        {
            _pagUnityConfig.DoNotSell = ccpa;
        }

        public int GetDoNotSell()
        {
            return _pagUnityConfig.DoNotSell;
        }

        public void SetGDPRConsent(int gdpr)
        {
            _pagUnityConfig.GdprConsent = gdpr;
        }

        public int GetGDPRConsent()
        {
            return _pagUnityConfig.GdprConsent;
        }

        public void SetDebugLog(bool enable)
        {
           _pagUnityConfig.SetDebug(enable);

        }
        
        private static PAGUnitySdk GetUnitySdk(IntPtr unitySdkPtr)
        {
            GCHandle handle = (GCHandle) unitySdkPtr;
            PAGUnitySdk unitysdk = handle.Target as PAGUnitySdk;
            return unitysdk;
        }

        [DllImport("__Internal")]
        static extern void PangleIOS_initSDK(IntPtr unitySDK,SuccessCallbackDelegate successCallback,
            FailCallbackDelegate failCallback);

        [DllImport("__Internal")]
        static extern bool PangleIOS_sdkInitializationState();

        private delegate void SuccessCallbackDelegate(IntPtr unitySDK);
        private delegate void FailCallbackDelegate(IntPtr unitySDK, int code, string msg);
        
        [MonoPInvokeCallback(typeof(SuccessCallbackDelegate))]
        private static void cs_successCallback(IntPtr unitySDK)
        {
            PAGUnitySdk sdk = GetUnitySdk(unitySDK);
            sdk.resultDelegate(true, 0, "");
            PAGUnityTools.LOGWithMessage("PAGUnitySdk","cs_successCallback","init");
        }
        
        [MonoPInvokeCallback(typeof(FailCallbackDelegate))]
        private static void cs_failCallback(IntPtr unitySDK,int code, string msg)
        {
            PAGUnitySdk sdk = GetUnitySdk(unitySDK);
            sdk.resultDelegate(false, code, msg);
            PAGUnityTools.LOGWithMessage("PAGUnitySdk","cs_failCallback","init");
        }
    }
    
        }
#endif