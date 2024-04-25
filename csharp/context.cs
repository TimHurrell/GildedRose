using System;
namespace csharp
{
    public class Context
    {
        private IGildedRoseStrategy? _GildedRoseStrategy;

        public void SetStrategy(IGildedRoseStrategy strategy)
        {
            _GildedRoseStrategy = strategy;
        }

    }
}
