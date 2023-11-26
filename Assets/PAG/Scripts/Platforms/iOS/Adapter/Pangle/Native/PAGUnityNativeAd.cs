#if UNITY_IOS
using System;
using System.Runtime.InteropServices;
using PAG.Scripts.Api;
using PAG.Scripts.Common;
using UnityEngine;

namespace PAG.Scripts.Platforms.iOS.Adapter.Pangle.Native
{
    public class PAGUnityNativeAd : PangleIOSBaseAd, INativeAd
    {
        public void Load(string slotId, PAGNativeRequest request)
        {
            adType = 1;
            LoadAdData(slotId,request);
        }
        
        public override void Show()
        {
            PangleIOS_setNativeAdPosition(unityAdPtr,nativeX,nativeY);
            base.Show();
        }
        
        public void SetPosition(int x, int y)
        {
            nativeX = x;
            nativeY = y;
            PangleIOS_setNativeAdPosition(unityAdPtr,x,y);
            LOGWithMessage(System.Reflection.MethodBase.GetCurrentMethod()?.Name,$"x:{x}-y:{y}");
        }

        private int nativeX;
        private int nativeY;

        [DllImport("__Internal")]
        static extern void PangleIOS_setNativeAdPosition(IntPtr unityAdPtr, int x, int y);
    }
}
#endif