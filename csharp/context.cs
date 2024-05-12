/* using csharp;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
namespace csharp
{
    public class Context
    {
        
        private readonly IEnumerable<IGildedRoseStrategy> GildedRoseStrategies;


        public Context(IEnumerable<IGildedRoseStrategy> GildedRoseStrategies)
        {
            this.GildedRoseStrategies = GildedRoseStrategies;
        }


        public void ShowInventory(IList<Item> Items)
          {
            IGildedRoseStrategy app = GildedRoseStrategies.;

          }

     }
}

*/


using System.Collections.Generic;

namespace csharp
{
   /* public interface IGildedRoseStrategy
    {
        void UpdateQuality(IList<Item> items);
    }
*/

    public class GildedRoseContext
    {
        private readonly IGildedRoseStrategy _strategy;

        public GildedRoseContext(IGildedRoseStrategy strategy)
        {
            _strategy = strategy;
        }

        public void UpdateQuality()
        {
            _strategy.UpdateQuality();
        }
    }
/*
    public class GildedRoseBrie : IGildedRoseStrategy
    {
        public void UpdateQuality(IList<Item> items)
        {
            for (var i = 0; i < items.Count; i++)
            {
                if (items[i].Name == "Aged Brie")
                {
                    if (items[i].Quality < 50)
                    {
                        if (items[i].SellIn >= 1)
                        {
                            items[i].Quality = items[i].Quality + 1;
                        }
                        else
                        {
                            items[i].Quality = items[i].Quality + 2;
                        }
                    }
                    items[i].SellIn--;
                }
            }
        }
    }
*/
}



