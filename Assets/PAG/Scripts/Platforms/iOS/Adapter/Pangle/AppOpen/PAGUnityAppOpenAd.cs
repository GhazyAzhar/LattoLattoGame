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
    
    public class PAGUnityAppOpenAd : PangleIOSBaseAd, IPAGAppOpenAd
    {
        public void Load(string slotId, PAGAppOpenRequest request)
        {
            adType = 5;
            LoadAdData(slotId,request);
        }
    }
}

#endif
