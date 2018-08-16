using Patterns.Strategy;

namespace Patterns
{
    public class RainWearingStrategy : IWearingStrategy
    {
        public string GetClothes()
        {
            return "coat";
        }

        public string GetAccessories()
        {
            return "umbrella";
        }
    }
}