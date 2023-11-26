#if UNITY_IOS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using PAG.Scripts.Api;
using UnityEngine;

namespace PAG.Scripts.Platforms.iOS.Adapter.Pangle
{
    class PAGUnityConfig
    {
        internal void Init(PAGConfig config)
        {
            IntPtr configPtr = PangleIOS_shareConfig();
            if (config.AppId != null)
            {
                PangleIOS_configSetAppID(configPtr,config.AppId);
            }

            if (config.AppIconName != null && string.IsNullOrEmpty(config.AppIconName) != false)
            {
                PangleIOS_configSetAppLogoImageString(configPtr,config.AppIconName);
            }
            
            PangleIOS_configSetChildDirected(configPtr,(int)config.ChildDirected);
            PangleIOS_configSetGDPRConsent(configPtr,(int)config.GDPRConsent);
            PangleIOS_configSetDoNotSell(configPtr,(int)config.DoNotSell);
            var them = (int)config.TitleBarTheme;
            if (them == 0 || them == 1)
            {
                PangleIOS_configSetThemeStatus(configPtr,(int)config.TitleBarTheme);
            }
            PangleIOS_configSetDebugLog(configPtr,config.DebugLog);
            
           // Dictionary<string, string> data = UserDataAppendInfo(config.UserData);
           config.UserData["unity_version"] = PAGSdk.PangleSdkVersion;
           var sb = new StringBuilder("[");

           foreach (var kv in config.UserData)
           {
               if (sb.Length > 1)
               {
                   sb.Append(",\n");
               }

               sb.Append("{\"name\":\"" + kv.Key + "\",\"value\":\"" + kv.Value + "\"}");
           }

           sb.Append("]");
           PangleIOS_configSetUserDataString(configPtr,sb.ToString());
            
            PangleIOS_configSetAllowModifyAudioSessionSetting(configPtr,config.allowModifyAudioSessionSetting);
            
        }

        internal int ChildDirected
        {
            get => PangleIOS_configGetChildDirected(IntPtr.Zero);
            set => PangleIOS_configSetChildDirected(IntPtr.Zero, value);
        }

        internal int GdprConsent
        {
            get => PangleIOS_configGetGDPRConsent(IntPtr.Zero);
            set => PangleIOS_configSetGDPRConsent(IntPtr.Zero, value);
        }

        internal int DoNotSell
        {
            get => PangleIOS_configGetDoNotSell(IntPtr.Zero);
            set => PangleIOS_configSetDoNotSell(IntPtr.Zero, value);
        }
        
        internal void SetDebug(bool debug)
        {
            PangleIOS_configSetDebugLog(IntPtr.Zero, debug);
        }

        //c# - > oc
        [DllImport("__Internal")]
        private static extern IntPtr PangleIOS_shareConfig();
        
        [DllImport(dllName:"__Internal")]
        private static  extern void PangleIOS_configSetAppID(IntPtr configPtr, string appID);

        [DllImport(dllName: "__Internal")]
        private static  extern string PangleIOS_configGetAppID(IntPtr configPtr);
        
        [DllImport(dllName: "__Internal")]
        private static  extern void PangleIOS_configSetAppLogoImageString(IntPtr configPtr, string appLogoImageString);

        [DllImport(dllName: "__Internal")]
        private static extern void PangleIOS_configSetChildDirected(IntPtr configPtr, int childDirected);

        [DllImport(dllName: "__Internal")]
        private static extern int PangleIOS_configGetChildDirected(IntPtr configPtr);

        [DllImport(dllName: "__Internal")]
        private static extern void PangleIOS_configSetGDPRConsent(IntPtr configPtr, int GDPRConsent);

        [DllImport(dllName: "__Internal")]
        private static extern int PangleIOS_configGetGDPRConsent(IntPtr configPtr);

        [DllImport(dllName: "__Internal")]
        private static extern void PangleIOS_configSetDoNotSell(IntPtr configPtr, int doNotSell);

        [DllImport(dllName: "__Internal")]
        private static extern int PangleIOS_configGetDoNotSell(IntPtr configPtr);

        [DllImport(dllName: "__Internal")]
        private static extern void PangleIOS_configSetThemeStatus(IntPtr configPtr, int themeStatus);

        [DllImport(dllName: "__Internal")]
        private static extern void PangleIOS_configSetDebugLog(IntPtr configPt, bool debugLog);
        [DllImport(dllName:"__Internal")]
        private static extern void PangleIOS_configSetUserDataString(IntPtr configPt, string userDataString);

        [DllImport(dllName: "__Internal")]
        private static extern string PangleIOS_configGetUserDataString(IntPtr configPt);

        [DllImport(dllName: "__Internal")]
        private static extern void PangleIOS_configSetAllowModifyAudioSessionSetting(IntPtr configPt,
            bool allowModifyAudioSessionSetting);
    }
}
#endif