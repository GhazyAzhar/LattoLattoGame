using System;
using PAG.Scripts.Api.Constant;
using UnityEngine;

namespace PAG.Scripts.Api
{
    [Serializable]
    public class PAGBannerRequest : PAGRequest
    {
        [SerializeField()]
        private PAGBannerSize size; 
        public PAGBannerSize Size => size;

        public PAGBannerPosition Position { get; }

        public PAGBannerRequest(PAGBannerSize size, PAGBannerPosition position = PAGBannerPosition.Bottom)
        {
            this.size = size;
            this.Position = position;
        }
    }
}