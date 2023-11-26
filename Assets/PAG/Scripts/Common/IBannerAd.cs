using PAG.Scripts.Api;
using PAG.Scripts.Api.Constant;

namespace PAG.Scripts.Common
{
    public interface IBannerAd : IPAGAd<PAGBannerRequest>
    {
        void SetPosition(int x, int y);
        void SetPosition(PAGBannerPosition position);
    }
}