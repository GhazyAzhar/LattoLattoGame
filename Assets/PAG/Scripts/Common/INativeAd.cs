using PAG.Scripts.Api;

namespace PAG.Scripts.Common
{
    public interface INativeAd : IPAGAd<PAGNativeRequest>
    {
        void SetPosition(int x, int y);
    }
}