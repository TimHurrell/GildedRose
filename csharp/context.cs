using System;
using System.Collections.Generic;
namespace csharp
{
    public class Context
    {
        private IGildedRoseStrategy? _GildedRoseStrategy;
        private readonly IEnumerable<IGildedRoseStrategy> GildedRoseStrategies;


        public Context(IEnumerable<IGildedRoseStrategy> GildedRoseStrategies)
        {
            this.GildedRoseStrategies = GildedRoseStrategies;
        }

    }
}
