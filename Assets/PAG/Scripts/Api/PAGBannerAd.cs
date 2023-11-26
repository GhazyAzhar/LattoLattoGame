using PAG.Scripts.Api.Constant;
using PAG.Scripts.Common;
using UnityEngine;

namespace PAG.Scripts.Api
{
    public class PAGBannerAd : PAGBaseAd<PAGBannerRequest>
    {
        private readonly IBannerAd _bannerAdClient;


        /// <summary>
        /// create a banner ad
        /// </summary>
        /// <param name="slotId"></param>
        public PAGBannerAd(string slotId) : base(slotId, PAGSdk.GetClientFactory().BuildBannerAdClient())
        {
            _bannerAdClient = (IBannerAd) ADClient;
        }
        /// <summary>
        /// set position for banner 
        /// </summary>
        /// <param name="x">position x</param>
        /// <param name="y">position y</param>
        public void SetPosition(int x, int y)
        {
            _bannerAdClient?.SetPosition(x, y);
        }

        /// <summary>
        /// set position for banner
        /// </summary>
        /// <param name="position"></param>
        public void SetPosition(PAGBannerPosition position)
        {
            _bannerAdClient?.SetPosition(position);
        }
    }
}