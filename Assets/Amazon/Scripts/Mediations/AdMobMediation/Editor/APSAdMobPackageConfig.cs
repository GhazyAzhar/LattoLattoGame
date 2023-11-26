public class APSAdMobPackageConfig : AmazonPackageConfig
{
    public const string VERSION = "1.6.0";

    public override string Name
    {
        get { return "admob_adapter"; }
    }

    public override string Version
    {
        get { return VERSION; }
    }
}
