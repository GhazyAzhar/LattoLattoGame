using PAG.Scripts.Api;
using PAG.Scripts.Api.Constant;
using UnityEngine;

namespace PAG.Example
{
    public class BannerController
    {
        private readonly PAGBannerAd _bannerAd;
        private readonly PAGBannerSize _bannerSize;

        public BannerController(string slotId, PAGBannerSize bannerSize)
        {
            _bannerSize = bannerSize;
            _bannerAd = new PAGBannerAd(slotId);
            _bannerAd.OnLoad += (() => { Debug.Log("[PAGBanner]-[Load]:successfully"); });
            _bannerAd.OnLoadFailed += ((code, msg) =>
            {
                Debug.Log($"[PAGBanner]-[Load]:failed, errorCode ={code}, error message = {msg}");
            });

            _bannerAd.OnAdShowed += (() => { Debug.Log("[PAGBanner]-[interaction]:show"); });
            _bannerAd.OnAdClicked += (() => { Debug.Log("[PAGBanner]-[interaction]:click"); });
            _bannerAd.OnAdDismissed += (() => { Debug.Log("[PAGBanner]-[interaction]:dismiss"); });
        }

        public void LoadBanner()
        {
            _bannerAd?.Load(new PAGBannerRequest(_bannerSize));
        }

        public void ShowBanner()
        {
            _bannerAd?.Show();
        }

        public void SetBannerPosition(PAGBannerPosition position)
        {
            _bannerAd?.SetPosition(position);
        }

        public void SetBannerPosition(int x, int y)
        {
            _bannerAd?.SetPosition(x, y);
        }

        public void DestroyBanner()
        {
            _bannerAd?.DestroyAd();
        }
    }
}