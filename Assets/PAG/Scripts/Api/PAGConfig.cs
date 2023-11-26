using System;
using System.Collections.Generic;
using PAG.Scripts.Api.Constant;

namespace PAG.Scripts.Api
{
    public class PAGConfig
    {
        /// <summary>
        /// App logo image name. If set, it will be displayed in the App open ad.
        /// </summary>
        internal string AppIconName { get; }

        /// <summary>
        /// the unique identifier of the App
        /// </summary>
        internal string AppId { get; }

        /// <summary>
        /// Custom set the debugLog to print debug Log.
        /// debugLog NO: close debug log, YES: open debug log.
        /// </summary>
        internal bool DebugLog { get; }

        /// <summary>
        /// the COPPA of the user, COPPA is the short of Children's Online Privacy Protection Rule,
        /// the interface only works in the United States.
        /// Coppa 0 adult, 1 child
        /// You can change its value at any time
        /// </summary>
        internal PAGChildDirectedType ChildDirected { get; }

        /// <summary>
        /// Custom set the GDPR of the user,GDPR is the short of General Data Protection Regulation,the interface only works in The European.
        /// GDPR 0 close privacy protection, 1 open privacy protection
        /// You can change its value at any time
        /// </summary>
        internal PAGGDPRConsentType GDPRConsent { get; }

        /// <summary>
        /// Custom set the CCPA of the user,CCPA is the short of General Data Protection Regulation,the interface only works in USA.
        /// CCPA  0: "sale" of personal information is permitted, 1: user has opted out of "sale" of personal information -1: default
        /// </summary>
        internal PAGDoNotSellType DoNotSell { get; }

        /// <summary>
        /// Set whether to use the TextureView to play video: true yes, false no
        /// </summary>
        internal bool? IsUseTextureView { get; }

        /// <summary>
        /// This parameter is optional. Whether multiple processes are supported：The value can be true or false. The default value is false
        /// </summary>
        internal bool IsSupportMultiProcess { get; }

        internal string PackageName { get; }

        internal Dictionary<string,string> UserData { get; set; }

        internal TitleBarTheme TitleBarTheme { get; }
        internal bool allowModifyAudioSessionSetting { get; }

        private PAGConfig(PAGConfig.Builder builder)
        {
            AppId = builder.AppId;
            AppIconName = builder.AppIconName;
            DebugLog = builder.DebugLog;
            ChildDirected = builder.ChildDirected;
            GDPRConsent = builder.GDPRConsent;
            DoNotSell = builder.DoNotSell;
            IsUseTextureView = builder.IsUseTextureView;
            IsSupportMultiProcess = builder.IsSupportMultiProcess;
            UserData = builder.UserData;
            PackageName = builder.PackageName;
            TitleBarTheme = builder.TitleBarTheme;
            allowModifyAudioSessionSetting = builder.allowModifyAudioSessionSetting;

        }

        public static void SetChildDirected(PAGChildDirectedType type)
        {
            PAGSdk.SDK.SetChildDirected(Convert.ToInt32(type));
        }

        public static PAGChildDirectedType GetChildDirected()
        {
            return (PAGChildDirectedType) PAGSdk.SDK.GetChildDirected();
        }

        public static void SetDoNotSell(PAGDoNotSellType type)
        {
            PAGSdk.SDK.SetDoNotSell(Convert.ToInt32(type));
        }

        public static PAGDoNotSellType GetDoNotSell()
        {
            return (PAGDoNotSellType) PAGSdk.SDK.GetDoNotSell();
        }

        public static void SetGDPRConsent(PAGGDPRConsentType gdpr)
        {
            PAGSdk.SDK.SetGDPRConsent(Convert.ToInt32(gdpr));
        }

        public static PAGGDPRConsentType GetGDPRConsent()
        {
            return (PAGGDPRConsentType) PAGSdk.SDK.GetGDPRConsent();
        }

        public static void SetDebugLog(bool enable)
        {
            PAGSdk.SDK.SetDebugLog(enable);
        }

        public class Builder
        {
            internal string AppId;

            internal string AppIconName;

            internal bool DebugLog;


            internal PAGChildDirectedType ChildDirected = PAGChildDirectedType.PAGChildDirectedTypeDefault;


            internal PAGGDPRConsentType GDPRConsent = PAGGDPRConsentType.PAGGDPRConsentTypeDefault;


            internal PAGDoNotSellType DoNotSell = PAGDoNotSellType.PAGDoNotSellTypeDefault;


            internal bool IsUseTextureView;

            internal bool IsSupportMultiProcess;

            internal Dictionary<string,string> UserData;

            internal string PackageName;

            internal TitleBarTheme TitleBarTheme = TitleBarTheme.Light;

            internal bool allowModifyAudioSessionSetting = false;

            public Builder SetAppId(string appid)
            {
                this.AppId = appid;
                return this;
            }

            public Builder SetAppIconName(string iconName)
            {
                this.AppIconName = iconName;
                return this;
            }

            public Builder SetDebugLog(bool debugLog)
            {
                this.DebugLog = debugLog;
                return this;
            }

            public Builder SetChildDirected(PAGChildDirectedType childDirected)
            {
                this.ChildDirected = childDirected;
                return this;
            }

            public Builder SetGDPRConsent(PAGGDPRConsentType GDPRConsent)
            {
                this.GDPRConsent = GDPRConsent;
                return this;
            }

            public Builder SetDoNotSell(PAGDoNotSellType doNotSell)
            {
                this.DoNotSell = doNotSell;
                return this;
            }

            public Builder SetUseTextureView(bool useTextureView)
            {
                this.IsUseTextureView = useTextureView;
                return this;
            }

            public Builder SetSupportMultiProcess(bool supportMultiProcess)
            {
                this.IsSupportMultiProcess = supportMultiProcess;
                return this;
            }

            public Builder SetUserData(Dictionary<string,string> userDate)
            {
                this.UserData = userDate;
                return this;
            }

            public Builder SetPackageName(string packageName)
            {
                this.PackageName = packageName;
                return this;
            }

            public Builder SetTitleBarTheme(TitleBarTheme theme)
            {
                this.TitleBarTheme = theme;
                return this;
            }


            public PAGConfig Build()
            {
                return new PAGConfig(this);
            }
        }
    }
}