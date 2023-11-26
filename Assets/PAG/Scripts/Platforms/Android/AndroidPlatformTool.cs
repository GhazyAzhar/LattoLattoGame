#if UNITY_ANDROID

using System;
using System.Collections.Generic;
using System.Text;
using PAG.Scripts.Api;
using PAG.Scripts.Api.Constant;
using UnityEngine;

namespace PAG.Scripts.Platforms.Android
{
    internal static class AndroidPlatformTool
    {
        public const string ClassPackage = "com.bytedance.sdk.openadsdk.unity";
        private const string UnityPlayerClassName = "com.unity3d.player.UnityPlayer";
        private const string CurrentActivityMethod = "currentActivity";
        private const string ResourceUtilClassName = ClassPackage + ".ResourceUtil";

        public static AndroidJavaObject GetGameActivity()
        {
            return new AndroidJavaClass(UnityPlayerClassName).GetStatic<AndroidJavaObject>(CurrentActivityMethod);
        }

        public static AndroidJavaObject GetPAGConfig(PAGConfig config)
        {
            var builder = new AndroidJavaObject("com.bytedance.sdk.openadsdk.api.init.PAGConfig$Builder");
            if (config != null)
            {
                void CallNativeFunction<T>(string methodName, T arg)
                {
                    builder.Call<AndroidJavaObject>(methodName, arg);
                }

                if (config.UserData == null)
                {
                    config.UserData = new Dictionary<string, string>();
                }

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
                CallNativeFunction("setUserData", sb.ToString());
                if (!string.IsNullOrEmpty(config.AppId))
                {
                    CallNativeFunction("appId", config.AppId);
                }

                if (config.DebugLog) //default value is false
                {
                    CallNativeFunction("debugLog", true);
                }

                if (!string.IsNullOrEmpty(config.AppIconName))
                {
                    var result = new AndroidJavaClass(ResourceUtilClassName).Call<int>("GetImageIdByName",
                        GetGameActivity(),
                        config.AppIconName);
                    if (result > 0)
                    {
                        CallNativeFunction("appIcon", result);
                    }
                }

                if (config.ChildDirected != PAGChildDirectedType.PAGChildDirectedTypeDefault)
                {
                    //set value when is not default value
                    CallNativeFunction("setChildDirected", Convert.ToInt32(config.ChildDirected));
                }

                if (config.GDPRConsent != PAGGDPRConsentType.PAGGDPRConsentTypeDefault)
                {
                    //set value when is not default value
                    CallNativeFunction("setGDPRConsent", Convert.ToInt32(config.GDPRConsent));
                }

                if (config.DoNotSell != PAGDoNotSellType.PAGDoNotSellTypeDefault)
                {
                    //set value when is not default value
                    CallNativeFunction("setDoNotSell", Convert.ToInt32(config.DoNotSell));
                }

                if (config.IsUseTextureView != null)
                {
                    CallNativeFunction("useTextureView", config.IsUseTextureView);
                }

                if (!string.IsNullOrEmpty(config.PackageName))
                {
                    CallNativeFunction("setPackageName", config.PackageName);
                }

                //TitleBarTheme.Light is the default value ,no need to set
                if (config.TitleBarTheme != TitleBarTheme.Light)
                {
                    CallNativeFunction("titleBarTheme", Convert.ToInt32(config.TitleBarTheme));
                }
            }

            return builder.Call<AndroidJavaObject>("build");
        }

        public static AndroidJavaObject GetAdRequest(PAGRequest request)
        {
            switch (request)
            {
                case PAGBannerRequest _:
                    break;
                case PAGNativeRequest _:
                    break;
                case PAGAppOpenRequest _:
                    break;
                case PAGInterstitialRequest _:
                    break;
                case PAGRewardedRequest _:
                    break;
            }

            return null;
        }

        public static void CallMethodOnMainThread(Action task)
        {
            GetGameActivity()?.Call("runOnUiThread", new AndroidJavaRunnable(task));
        }
    }
}
#endif