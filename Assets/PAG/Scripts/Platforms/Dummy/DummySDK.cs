#if UNITY_EDITOR
using PAG.Scripts.Api;
using PAG.Scripts.Common;
using UnityEngine;

namespace PAG.Scripts.Platforms.Dummy
{
    class DummySDK : ISDK
    {
        public void Init(PAGConfig config, PAGSdk.InitResultDelegate initResultDelegate)
        {
            initResultDelegate?.Invoke(true, 0, null);
        }

        public bool IsInitSuccess()
        {
            return true;
        }

        public void SetChildDirected(int coppa)
        {
            Debug.Log($"dummy sdk SetCOPPA({coppa})");
        }

        public int GetChildDirected()
        {
            return -1;
        }

        public void SetDoNotSell(int ccpa)
        {
            Debug.Log($"dummy sdk SetCCPA({ccpa})");
        }

        public int GetDoNotSell()
        {
            return -1;
        }

        public void SetGDPRConsent(int gdpr)
        {
            Debug.Log($"dummy sdk SetGDPR({gdpr})");
        }

        public int GetGDPRConsent()
        {
            return -1;
        }

        public void SetDebugLog(bool enable)
        {
            Debug.Log($"dummy sdk SetDebugLog({enable})");
        }
    }
}
#endif