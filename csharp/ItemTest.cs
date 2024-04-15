using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class ItemTest
    {


        /*
        public void brie()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(2, Items[0].Quality);

            IList<Item> Items1 = new List<Item> { new Item { Name = "Aged Brie", SellIn = 30, Quality = 30 } };
            app = new GildedRose(Items1);
            app.UpdateQuality();
            Assert.AreEqual(29, Items1[0].SellIn);
            Assert.AreEqual(31, Items1[0].Quality);

            IList<Item> Items2 = new List<Item> { new Item { Name = "Aged Brie", SellIn = 7, Quality = 7 } };
            app = new GildedRose(Items2);
            app.UpdateQuality();
            Assert.AreEqual(6, Items2[0].SellIn);
            Assert.AreEqual(8, Items2[0].Quality);

            IList<Item> Items3 = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 1 } };
            app = new GildedRose(Items3);
            app.UpdateQuality();
            Assert.AreEqual(0, Items3[0].SellIn);
            Assert.AreEqual(2, Items3[0].Quality);

            IList<Item> Items4 = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 1 } };
            app = new GildedRose(Items4);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items4[0].SellIn);
            Assert.AreEqual(3, Items4[0].Quality);

            IList<Item> Items5 = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 50 } };
            app = new GildedRose(Items5);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items5[0].SellIn);
            Assert.AreEqual(50, Items5[0].Quality);

            IList<Item> Items6 = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 80 } };
            app = new GildedRose(Items6);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items6[0].SellIn);
            Assert.AreEqual(80, Items6[0].Quality);
        }


        [Test]
        public void concert()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(0, Items[0].Quality);

            IList<Item> Items1 = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 30, Quality = 30 } };
            app = new GildedRose(Items1);
            app.UpdateQuality();
            Assert.AreEqual(29, Items1[0].SellIn);
            Assert.AreEqual(31, Items1[0].Quality);

            IList<Item> Items2 = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 7, Quality = 7 } };
            app = new GildedRose(Items2);
            app.UpdateQuality();
            Assert.AreEqual(6, Items2[0].SellIn);
            Assert.AreEqual(9, Items2[0].Quality);

            IList<Item> Items4 = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 5 } };
            app = new GildedRose(Items4);
            app.UpdateQuality();
            Assert.AreEqual(2, Items4[0].SellIn);
            Assert.AreEqual(8, Items4[0].Quality);

            IList<Item> Items5 = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 50 } };
            app = new GildedRose(Items5);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items5[0].SellIn);
            Assert.AreEqual(0, Items5[0].Quality);

            IList<Item> Items6 = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 80 } };
            app = new GildedRose(Items6);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items6[0].SellIn);
            Assert.AreEqual(0, Items6[0].Quality);
        }
       
        */
        [Test]
        public void normalitemasobject()
        {
            ItemNormal Item1 = new ItemNormal { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 0 };
            Item1.UpdateQuality();
            Assert.AreEqual(-1, Item1.SellIn);
            Assert.AreEqual(0, Item1.Quality);

            ItemNormal Item2 = new ItemNormal { Name = "Elixir of the Mongoose", SellIn = 30, Quality = 30 };
            Item2.UpdateQuality();
            Assert.AreEqual(29, Item2.SellIn);
            Assert.AreEqual(29, Item2.Quality);

            ItemNormal Item3 = new ItemNormal { Name = "Elixir of the Mongoose", SellIn = 7, Quality = 7 };
            Item3.UpdateQuality();
            Assert.AreEqual(6, Item3.SellIn);
            Assert.AreEqual(6, Item3.Quality);

            ItemNormal Item4 = new ItemNormal { Name = "Elixir of the Mongoose", SellIn = 3, Quality = 5 };
            Item4.UpdateQuality();
            Assert.AreEqual(2, Item4.SellIn);
            Assert.AreEqual(4, Item4.Quality);

            ItemNormal Item5 = new ItemNormal { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 50 };
            Item5.UpdateQuality();
            Assert.AreEqual(-1, Item5.SellIn);
            Assert.AreEqual(48, Item5.Quality);

            ItemNormal Item6 = new ItemNormal { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 80 };
            Item6.UpdateQuality();
            Assert.AreEqual(-1, Item6.SellIn);
            Assert.AreEqual(78, Item6.Quality);

        }


        [Test]
        public void sulfurasobject()
        {
            Itemsulfuras Item1 = new Itemsulfuras { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 0 } ;
            Item1.UpdateQuality();
            Assert.AreEqual(0, Item1.SellIn);
            Assert.AreEqual(0, Item1.Quality);

            Itemsulfuras Item2 = new Itemsulfuras { Name = "Sulfuras, Hand of Ragnaros", SellIn = 30, Quality = 30 };
            Item2.UpdateQuality();
            Assert.AreEqual(30, Item2.SellIn);
            Assert.AreEqual(30, Item2.Quality);


            Itemsulfuras Item3 = new Itemsulfuras { Name = "Sulfuras, Hand of Ragnaros", SellIn = 7, Quality = 7 };
            Item3.UpdateQuality();
            Assert.AreEqual(7, Item3.SellIn);
            Assert.AreEqual(7, Item3.Quality);

            Itemsulfuras Item4 = new Itemsulfuras { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 1 };
            Item4.UpdateQuality();
            Assert.AreEqual(0, Item4.SellIn);
            Assert.AreEqual(1, Item4.Quality);

            Itemsulfuras Item5 = new Itemsulfuras { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 50 };
            Item5.UpdateQuality();
            Assert.AreEqual(0, Item5.SellIn);
            Assert.AreEqual(50, Item5.Quality);

            Itemsulfuras Item6 = new Itemsulfuras { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 };
            Item6.UpdateQuality();
            Assert.AreEqual(0, Item6.SellIn);
            Assert.AreEqual(80, Item6.Quality);
           
        }





    }
}
