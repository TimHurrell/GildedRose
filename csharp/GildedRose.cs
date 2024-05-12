using System;
using System.Collections.Generic;

namespace csharp
{

    public interface IGildedRoseStrategy
    {
        //IList<Item> Items { get; }
        public void UpdateQuality();
        
    }
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }

                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != "Aged Brie")
                    {
                        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
            }
        }
    }

    public class GildedRoseBrie : IGildedRoseStrategy
    {
        IList<Item> Items;
        public GildedRoseBrie(IList<Item> Items)
        {
            this.Items = Items;
        }
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Quality < 50)

                {
                    if (Items[i].SellIn >= 1)
                    { Items[i].Quality = Items[i].Quality + 1; }
                    else
                    { Items[i].Quality = Items[i].Quality + 2; }

                }
                Items[i].SellIn--;
            }
                
        }

    }

    public class GildedRoseNormal : IGildedRoseStrategy
    {
        IList<Item> Items;
        public GildedRoseNormal(IList<Item> Items)
        {
            this.Items = Items;
        }
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Quality < 50)

                {
                    if (Items[i].SellIn <= 3)
                    { Items[i].Quality = Items[i].Quality + 3; }
                    else if (Items[i].SellIn <= 10)
                    { Items[i].Quality = Items[i].Quality + 2; }
                    else
                    { Items[i].Quality = Items[i].Quality + 1; }

                }
                if (Items[i].SellIn <= 0)
                { Items[i].Quality = 0; }
                Items[i].SellIn--;
            }
                
        }

    }
}

