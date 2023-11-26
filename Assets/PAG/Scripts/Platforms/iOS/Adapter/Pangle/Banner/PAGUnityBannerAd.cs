#if UNITY_IOS
using System;
using System.Threading;
using PAG.Scripts.Api;
using PAG.Scripts.Api.Constant;
using PAG.Scripts.Common;
using UnityEngine;

namespace PAG.Scripts.Platforms.iOS.Adapter.Pangle
{
    using System;
    using PAG.Scripts.Api;
    using PAG.Scripts.Common;
    using PAG.Scripts.Platforms.iOS;
    using System.Runtime.InteropServices;
    public class PAGUnityBannerAd: PangleIOSBaseAd, IBannerAd
    {
        private PAGBannerRequest bannerRequest;
        //TODO:线程问题需要考虑下
        public void Load(string slotId, PAGBannerRequest request)
        {
            bannerRequest = request;
            adType = 2;
            this.unityAdPtr = (IntPtr)GCHandle.Alloc (this);
            IntPtr ptr = this.unityAdPtr;

            int width = request.Size.Width;
            int height = request.Size.Height;
            
            int x = CalculateMiddleX(width);
            int y = CalculatePositionY(request.Position,height);
            
            LOGWithMessage(System.Reflection.MethodBase.GetCurrentMethod()?.Name,$"calculate-origin:{x},{y}-size:{width},{height}");
            PangleIOS_loadBannerAdData(ptr, 
                slotId,
                request.ToJson(),
                x,
                y,
                width,
                height,
                cs_adDidLoadCallback, 
                cs_adLoadFailCallBack,
                cs_adDidShowCallback,
                cs_adDidClickCallback,
                cs_adDidDismissCallback
                );
            LOGWithMessage(System.Reflection.MethodBase.GetCurrentMethod()?.Name,$"request.position:{request.Position},slotId:{slotId}");
        }

        private int CalculatePositionY(PAGBannerPosition position, int bannerHeight)
        {
            int screenHeight = PangleIOS_getScreenHeight();
            float y = PangleIOS_getScreenSafeTop();
            if (position == PAGBannerPosition.Middle)
            {
                y = (float)((screenHeight - bannerHeight) * 0.5);
            }
            else if (position == PAGBannerPosition.Bottom)
            {
                y = (float)(screenHeight - bannerHeight - PangleIOS_getScreenSafeBottom());
            }
            LOGWithMessage(System.Reflection.MethodBase.GetCurrentMethod()?.Name,$"position:{position},screenHeight:{screenHeight}-y:{y}");
            return (int)y;
        }

        private int CalculateMiddleX(int bannerWidth)
        {
            int screenWidth = PangleIOS_getScreenWidth();
            int x = (int)((screenWidth - bannerWidth) * 0.5);
            LOGWithMessage(System.Reflection.MethodBase.GetCurrentMethod()?.Name,$"screenWidth:{screenWidth}-x:{x}");
            return x;
        }


        public void SetPosition(int x, int y)
        {
            PangleIOS_SetBannerAdPosition(unityAdPtr,x,y);
            LOGWithMessage(System.Reflection.MethodBase.GetCurrentMethod()?.Name,$"x:{x},y:{y}");
        }

        public void SetPosition(PAGBannerPosition position)
        {
            int x = CalculateMiddleX(bannerRequest.Size.Width);
            int y = CalculatePositionY(position, bannerRequest.Size.Height);
            PangleIOS_SetBannerAdPosition(unityAdPtr,x,y);
            LOGWithMessage(System.Reflection.MethodBase.GetCurrentMethod()?.Name,$"position-{position}");
        }
        //MARK: c# - oc
        [DllImport("__Internal")]
        static extern void PangleIOS_loadBannerAdData(IntPtr unityAdPtr,
            string slotId,
            string requestJson,
        int x,
        int y,
        int width,
        int height,
            adDidLoadCallback_delegate successCallback,
            adLoadFailCallBack_delegate failCallback,
            adDidShowCallback_delegate showCallback,
            adDidClickCallback_delegate clickCallback,
            adDidDismissCallback_delegate dismissCallback
        );

        [DllImport("__Internal")]
        static extern void PangleIOS_SetBannerAdPosition(IntPtr unityAdPtr, int x, int y);

        [DllImport("__Internal")]
        static extern int PangleIOS_getScreenWidth();
        [DllImport("__Internal")]
        static extern int PangleIOS_getScreenHeight();
        [DllImport("__Internal")]
        static extern int PangleIOS_getScreenSafeTop();
        [DllImport("__Internal")]
        static extern int PangleIOS_getScreenSafeBottom();
    }
}
#endif