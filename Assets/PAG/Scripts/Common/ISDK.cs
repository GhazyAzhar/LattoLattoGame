using PAG.Scripts.Api;

namespace PAG.Scripts.Common
{
    public interface ISDK
    {
        ///
        /// Starts the Pangle SDK
        /// 
        void Init(PAGConfig config, PAGSdk.InitResultDelegate initResultDelegate);

        ////
        /// The SDK initialization state
        ////
        bool IsInitSuccess();

        void SetChildDirected(int coppa);
        int GetChildDirected();
        void SetDoNotSell(int ccpa);
        int GetDoNotSell();
        void SetGDPRConsent(int gdpr);
        int GetGDPRConsent();
        void SetDebugLog(bool enable);
    }
}