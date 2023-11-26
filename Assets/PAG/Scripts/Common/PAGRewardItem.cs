namespace PAG.Scripts.Common
{
    public class PAGRewardItem
    {
        public int RewardAmount;
        public string RewardName;

        public PAGRewardItem()
        {
        }

        public PAGRewardItem(int amount, string rewardName)
        {
            RewardAmount = amount;
            RewardName = rewardName;
        }
    }
}