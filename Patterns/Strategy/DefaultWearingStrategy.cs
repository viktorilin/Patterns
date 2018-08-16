namespace Patterns.Strategy
{
    public class DefaultWearingStrategy : IWearingStrategy
    {
        public string GetClothes()
        {
            return "default";
        }

        public string GetAccessories()
        {
            return "default";
        }
    }
}