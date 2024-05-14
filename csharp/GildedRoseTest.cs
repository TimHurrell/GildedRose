using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        /*public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("fixme", Items[0].Name);
            //
            //
            //
            //
        }
        */

       
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
        public void GRbrie()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 } };
            GildedRoseBrie app = new GildedRoseBrie(Items);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(2, Items[0].Quality);

            IList<Item> Items1 = new List<Item> { new Item { Name = "Aged Brie", SellIn = 30, Quality = 30 } };
            app = new GildedRoseBrie(Items1);
            app.UpdateQuality();
            Assert.AreEqual(29, Items1[0].SellIn);
            Assert.AreEqual(31, Items1[0].Quality);

            IList<Item> Items2 = new List<Item> { new Item { Name = "Aged Brie", SellIn = 7, Quality = 7 } };
            app = new GildedRoseBrie(Items2);
            app.UpdateQuality();
            Assert.AreEqual(6, Items2[0].SellIn);
            Assert.AreEqual(8, Items2[0].Quality);

            IList<Item> Items3 = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 1 } };
            app = new GildedRoseBrie(Items3);
            app.UpdateQuality();
            Assert.AreEqual(0, Items3[0].SellIn);
            Assert.AreEqual(2, Items3[0].Quality);

            IList<Item> Items4 = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 1 } };
            app = new GildedRoseBrie(Items4);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items4[0].SellIn);
            Assert.AreEqual(3, Items4[0].Quality);

            IList<Item> Items5 = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 50 } };
            app = new GildedRoseBrie(Items5);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items5[0].SellIn);
            Assert.AreEqual(50, Items5[0].Quality);

            IList<Item> Items6 = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 80 } };
            app = new GildedRoseBrie(Items6);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items6[0].SellIn);
            Assert.AreEqual(80, Items6[0].Quality);
        }

        [Test]
        public void sulfuras()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].SellIn);
            Assert.AreEqual(0, Items[0].Quality);

            IList<Item> Items1 = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 30, Quality = 30 } };
            app = new GildedRose(Items1);
            app.UpdateQuality();
            Assert.AreEqual(30, Items1[0].SellIn);
            Assert.AreEqual(30, Items1[0].Quality);

            IList<Item> Items2 = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 7, Quality = 7 } };
            app = new GildedRose(Items2);
            app.UpdateQuality();
            Assert.AreEqual(7, Items2[0].SellIn);
            Assert.AreEqual(7, Items2[0].Quality);

            IList<Item> Items4 = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 1 } };
            app = new GildedRose(Items4);
            app.UpdateQuality();
            Assert.AreEqual(0, Items4[0].SellIn);
            Assert.AreEqual(1, Items4[0].Quality);

            IList<Item> Items5 = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 50 } };
            app = new GildedRose(Items5);
            app.UpdateQuality();
            Assert.AreEqual(0, Items5[0].SellIn);
            Assert.AreEqual(50, Items5[0].Quality);

            IList<Item> Items6 = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
            app = new GildedRose(Items6);
            app.UpdateQuality();
            Assert.AreEqual(0, Items6[0].SellIn);
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
        [Test]
        public void normalitem()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(0, Items[0].Quality);

            IList<Item> Items1 = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 30, Quality = 30 } };
            app = new GildedRose(Items1);
            app.UpdateQuality();
            Assert.AreEqual(29, Items1[0].SellIn);
            Assert.AreEqual(29, Items1[0].Quality);

            IList<Item> Items2 = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 7, Quality = 7 } };
            app = new GildedRose(Items2);
            app.UpdateQuality();
            Assert.AreEqual(6, Items2[0].SellIn);
            Assert.AreEqual(6, Items2[0].Quality);

            IList<Item> Items4 = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 3, Quality = 5 } };
            app = new GildedRose(Items4);
            app.UpdateQuality();
            Assert.AreEqual(2, Items4[0].SellIn);
            Assert.AreEqual(4, Items4[0].Quality);

            IList<Item> Items5 = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 50 } };
            app = new GildedRose(Items5);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items5[0].SellIn);
            Assert.AreEqual(48, Items5[0].Quality);

            IList<Item> Items6 = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 80 } };
            app = new GildedRose(Items6);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items6[0].SellIn);
            Assert.AreEqual(78, Items6[0].Quality);
        }
        [Test]
        public void GRnormalitem()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 0 } };
            GildedRoseNormal app = new GildedRoseNormal(Items);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(0, Items[0].Quality);

            IList<Item> Items1 = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 30, Quality = 30 } };
            app = new GildedRoseNormal(Items1);
            app.UpdateQuality();
            Assert.AreEqual(29, Items1[0].SellIn);
            Assert.AreEqual(29, Items1[0].Quality);

            IList<Item> Items2 = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 7, Quality = 7 } };
            app = new GildedRoseNormal(Items2);
            app.UpdateQuality();
            Assert.AreEqual(6, Items2[0].SellIn);
            Assert.AreEqual(6, Items2[0].Quality);

            IList<Item> Items4 = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 3, Quality = 5 } };
            app = new GildedRoseNormal(Items4);
            app.UpdateQuality();
            Assert.AreEqual(2, Items4[0].SellIn);
            Assert.AreEqual(4, Items4[0].Quality);

            IList<Item> Items5 = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 50 } };
            app = new GildedRoseNormal(Items5);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items5[0].SellIn);
            Assert.AreEqual(48, Items5[0].Quality);

            IList<Item> Items6 = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 80 } };
            app = new GildedRoseNormal(Items6);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items6[0].SellIn);
            Assert.AreEqual(78, Items6[0].Quality);
        }

        //
    }
}
