using System;
using System.Collections.Generic;


namespace csharp
{
    public class Program
    {
        // add trivial change
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
				// this conjured item does not work properly yet
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            IList<Item> ItemsBrie = new List<Item> { };
            IList<Item> ItemsSulfuras = new List<Item> { };
            IList<Item> ItemsNormal = new List<Item> { };
            foreach (var item in Items)
                if (item.Name == "Aged Brie")
                {
                    ItemsBrie.Add(item);
                }
                else if (item.Name == "Sulfuras, Hand of Ragnaros")
                {
                    ItemsSulfuras.Add(item);
                }
                else
                {
                    ItemsNormal.Add(item);
                }
            IGildedRoseStrategy strategy;
            strategy = new GildedRoseBrie(ItemsBrie);
            strategy = new GildedRoseSulfuras(ItemsSulfuras);
            strategy = new GildedRoseNormal(ItemsNormal);

            /*
            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");
                foreach (var item in Items)
                {
                    IGildedRoseStrategy strategy;
                    if (item.Name == "Aged Brie")
                    {
                        strategy = new GildedRoseBrie(Items);
                    }
                    else
                    {
                        strategy = new GildedRoseNormal(Items);
                    }
                    // Create a context with the selected strategy
                    var context = new GildedRoseContext(strategy);
                    // Update the quality using the context
                    context.UpdateQuality();


                }

                
            }
            */
            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");

                var context = new GildedRoseContext(strategy);
                    // Update the quality using the context
                context.UpdateQuality();



            }





        }
    }
}
            

       
