#if UNITY_IOS

using System.Collections.Generic;
using AOT;
using UnityEngine;

namespace PAG.Scripts.Platforms.iOS.Adapter.Pangle
{
    using System;
    using PAG.Scripts.Api;
    using PAG.Scripts.Common;
    using PAG.Scripts.Platforms.iOS;
    using System.Runtime.InteropServices;
    
    public class PAGUnityRewardedAd : PangleIOSBaseAd, IPAGRewardedAd
    {
        public event Action<PAGRewardItem> OnUserEarnedReward;
        public event Action<int, string> OnUserEarnedRewardFail;
        
        public void Load(string slotId, PAGRewardedRequest request)
        {
            adType = 4;
            this.unityAdPtr = (IntPtr)GCHandle.Alloc (this);
            IntPtr ptr = this.unityAdPtr;
            
            PangleIOS_loadRewardedAdData(ptr,
                slotId,
                request.ToJson(), 
                cs_adDidLoadCallback, 
                cs_adLoadFailCallBack,
                cs_adDidShowCallback,
                cs_adDidClickCallback,
                cs_adDidDismissCallback, 
                cs_adDidEarnRewardCallback, 
                cs_adEarnRewardFailCallback);
            LOGWithMessage(System.Reflection.MethodBase.GetCurrentMethod()?.Name,$"slotId:{slotId},request{request}");
        }
        // c-> oc
        [DllImport("__Internal")]
        static extern void PangleIOS_loadRewardedAdData(IntPtr unityAd,
        string slotId,
        string requestJson,
        adDidLoadCallback_delegate successCallback,
        adLoadFailCallBack_delegate failCallback,
        adDidShowCallback_delegate showCallback,
        adDidClickCallback_delegate clickCallback,
        adDidDismissCallback_delegate dismissCallback,
            adDidEarnRewardCallback_delegate earnCallback,
        adEarnRewardFailCallback_delegate earnFailCallback);

        private delegate void adDidEarnRewardCallback_delegate(IntPtr unityAdPtr,string rewardName, int rewardAmount);
        protected delegate void adEarnRewardFailCallback_delegate(IntPtr unityAdPtr, int code, string msg);

        [MonoPInvokeCallback(typeof(adDidEarnRewardCallback_delegate))]
        private static void cs_adDidEarnRewardCallback(IntPtr unityAdPtr, string rewardName, int rewardAmount)
        {
            PAGUnityRewardedAd unityAd = PangleIOSBaseAd.GetUnityAd(unityAdPtr) as PAGUnityRewardedAd;
            if (unityAd == null)
            {
                return;
            }
            unityAd.OnUserEarnedReward?.Invoke(new PAGRewardItem(rewardAmount,rewardName));
            unityAd.LOGWithMessage(System.Reflection.MethodBase.GetCurrentMethod()?.Name,$"name:{rewardName}-amount:{rewardAmount}");
        }
        
        [MonoPInvokeCallback(typeof(adEarnRewardFailCallback_delegate))]
        private static void cs_adEarnRewardFailCallback(IntPtr unityAdPtr, int code, string msg)
        {
            PAGUnityRewardedAd unityAd = PangleIOSBaseAd.GetUnityAd(unityAdPtr) as PAGUnityRewardedAd;
            if (unityAd == null)
            {
                return;
            }
            unityAd.OnUserEarnedRewardFail?.Invoke(code,msg);
            unityAd.LOGWithMessage(System.Reflection.MethodBase.GetCurrentMethod()?.Name,$"code:{code}-msg:{msg}");
        }
        
    }
}

#endif