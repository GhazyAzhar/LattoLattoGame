using System;
using UnityEngine;

namespace PAG.Scripts.Api.Constant
{
    [Serializable]
    public struct PAGBannerSize
    {
        public static readonly PAGBannerSize BANNER_W_320_H_50 = new PAGBannerSize(320,50);
        public static readonly PAGBannerSize BANNER_W_300_H_250 = new PAGBannerSize(300,250);
        public static readonly PAGBannerSize BANNER_W_728_H_90 = new PAGBannerSize(728,90);//This size is support for pad

        [SerializeField] private int width;
        [SerializeField] private int height;
        public int Width => width;
        public int Height => height;

        public PAGBannerSize(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}