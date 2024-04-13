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
        }

    }
}
