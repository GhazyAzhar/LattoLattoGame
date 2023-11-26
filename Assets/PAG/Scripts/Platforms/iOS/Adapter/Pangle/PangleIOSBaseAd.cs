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
    public class PangleIOSBaseAd : IPAGAd<PAGRequest>
    {
        public event Action OnLoad;
        public event Action<int, string> OnLoadFailed;
        public event Action OnAdShowed;
        public event Action OnAdClicked;
        public event Action OnAdDismissed;
        public void Load(string slotId, PAGRequest request)
        {
            
        }
        
        protected void LoadAdData(string slotId, PAGRequest request) {
            this.unityAdPtr = (IntPtr)GCHandle.Alloc (this);
            IntPtr ptr = this.unityAdPtr;
            
            pangleIOS_loadAdData(adType, 
                ptr, 
                slotId,
                request.ToJson(), 
                cs_adDidLoadCallback, 
                cs_adLoadFailCallBack,
                cs_adDidShowCallback,
                cs_adDidClickCallback,
                cs_adDidDismissCallback
            );
            LOGWithMessage(System.Reflection.MethodBase.GetCurrentMethod()?.Name,$"slotId:{slotId},request{request}");
        }

        public bool IsLoaded()
        {
            return pangleAdLoaded;
        }

        public virtual void Show()
        {
            LOGWithMessage("Show");
            PangleIOS_showAd(adType,this.unityAdPtr);
        }

       

        public void Destroy()
        {
            PangleIOS_destroyAd(adType,unityAdPtr);
            if (unityAdPtr != IntPtr.Zero)
            {
                GCHandle unityAdhandle = (GCHandle)this.unityAdPtr;
                unityAdhandle.Free();
            }
            unityAdPtr = IntPtr.Zero;
            LOGWithMessage(System.Reflection.MethodBase.GetCurrentMethod()?.Name,$"unityPtr:{unityAdPtr}");
        }
        

        protected void LOGWithMessage(string method)
        {
            LOGWithMessage(method,string.Empty);
        }
        protected void LOGWithMessage(string method,string msg)
        {
            //native = 1, banner = 2, interstitial = 3, rewarded = 4, appOpen = 5
            int adtype = adType;
            string adTypeString = "unknown";
            if (adtype == 1)
            {
                adTypeString = "native";
            }
            else if (adtype == 2)
            {
                adTypeString = "banner";
            }
            else if (adtype == 3)
            {
                adTypeString = "interstitial";
            }
            else if (adtype == 4)
            {
                adTypeString = "rewarded";
            }
            else if (adtype == 5)
            {
                adTypeString = "appOpen";
            }

            //System.Reflection.MethodBase.GetCurrentMethod()?.Name
            Type classType = this.GetType();
            string className = $"{adTypeString}-{classType.Name}";
            PAGUnityTools.LOGWithMessage(className,method,msg);
        }

        protected static PangleIOSBaseAd GetUnityAd(IntPtr unityAdPtr)
        {
            GCHandle handle = (GCHandle) unityAdPtr;
            PangleIOSBaseAd unityAd = handle.Target as PangleIOSBaseAd;
            // handle.Free ();
            return unityAd;
        }

        protected int adType = 0;
        private bool pangleAdLoaded = false;
        protected IntPtr unityAdPtr = IntPtr.Zero;
        //MARK:  c --> oc
        [DllImport("__Internal")]
        static extern void pangleIOS_loadAdData(int adType, 
            IntPtr unityAdPtr, 
            string slotId,
            string requestJson,
        adDidLoadCallback_delegate successCallback,
            adLoadFailCallBack_delegate failCallback,
        adDidShowCallback_delegate showCallback,
            adDidClickCallback_delegate clickCallback,
            adDidDismissCallback_delegate dismissCallback);
        [DllImport("__Internal")]
        static extern void PangleIOS_showAd(int adType,IntPtr unityAdPtr);

        [DllImport("__Internal")]
        static extern void PangleIOS_destroyAd(int adType, IntPtr unityAdPtr);

        //callback method 
        protected delegate void adDidLoadCallback_delegate(IntPtr unityAdPtr);
        protected delegate void adLoadFailCallBack_delegate(IntPtr unityAdPtr, int code, string msg);
        
        protected delegate void adDidShowCallback_delegate(IntPtr unityAdPtr);
        protected delegate void adDidClickCallback_delegate(IntPtr unityAdPtr);
        protected delegate void adDidDismissCallback_delegate(IntPtr unityAdPtr);

        [MonoPInvokeCallback(typeof(adDidLoadCallback_delegate))]
        protected static void cs_adDidLoadCallback(IntPtr unityAdPtr)
        {
            PangleIOSBaseAd unityAd = PangleIOSBaseAd.GetUnityAd(unityAdPtr);
            if (unityAd == null)
            {
                return;
            }
            unityAd.pangleAdLoaded = true;
            unityAd.OnLoad?.Invoke();
            unityAd.LOGWithMessage("cs_adDidLoad");
        }

        [MonoPInvokeCallback(typeof(adLoadFailCallBack_delegate))]
        protected static void cs_adLoadFailCallBack(IntPtr unityAdPtr, int code, string msg)
        {
         
            PangleIOSBaseAd unityAd = PangleIOSBaseAd.GetUnityAd(unityAdPtr);
            if (unityAd.OnLoadFailed != null)
            {
                unityAd.OnLoadFailed(code, msg);
            }
            unityAd.LOGWithMessage("cs_adLoadFail",$"code:{code},msg:{msg}");
        }

        [MonoPInvokeCallback(typeof(adDidShowCallback_delegate))]
        protected static void cs_adDidShowCallback(IntPtr unityAdPtr)
        {
            PangleIOSBaseAd unityAd = PangleIOSBaseAd.GetUnityAd(unityAdPtr);
             if (unityAd == null)
             {
                 return;
             }
             unityAd.OnAdShowed?.Invoke();
             unityAd.LOGWithMessage($"cs_show");
        }

        [MonoPInvokeCallback(typeof(adDidClickCallback_delegate))]
        protected static void cs_adDidClickCallback(IntPtr unityAdPtr)
        {
            PangleIOSBaseAd unityAd = PangleIOSBaseAd.GetUnityAd(unityAdPtr);
            if (unityAd == null)
            {
                return;
            }
            unityAd.OnAdClicked?.Invoke();
            unityAd.LOGWithMessage("cs_click");
        }

        [MonoPInvokeCallback(typeof(adDidDismissCallback_delegate))]
        protected static void cs_adDidDismissCallback(IntPtr unityAdPtr)
        {
            PangleIOSBaseAd unityAd = PangleIOSBaseAd.GetUnityAd(unityAdPtr);
            if (unityAd == null)
            {
                return;
            }
            unityAd.OnAdDismissed?.Invoke();
            unityAd.LOGWithMessage("cs_dismiss");   
        }
    }
}
#endif