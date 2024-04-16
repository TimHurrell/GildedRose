using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class ItemTest
    {



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



        [Test]
        public void brieobject()
        {
            Itembrie Item1 = new Itembrie { Name = "Aged Brie", SellIn = 0, Quality = 0 };
            Item1.UpdateQuality();
            Assert.AreEqual(-1, Item1.SellIn);
            Assert.AreEqual(2, Item1.Quality);

            Itembrie Item2 = new Itembrie { Name = "Aged Brie", SellIn = 30, Quality = 30 };
            Item2.UpdateQuality();
            Assert.AreEqual(29, Item2.SellIn);
            Assert.AreEqual(31, Item2.Quality);

            Itembrie Item3 = new Itembrie { Name = "Aged Brie", SellIn = 7, Quality = 7 };
            Item3.UpdateQuality();
            Assert.AreEqual(6, Item3.SellIn);
            Assert.AreEqual(8, Item3.Quality);

            Itembrie Item4 = new Itembrie { Name = "Aged Brie", SellIn = 1, Quality = 1 };
            Item4.UpdateQuality();
            Assert.AreEqual(0, Item4.SellIn);
            Assert.AreEqual(2, Item4.Quality);

            Itembrie Item5 = new Itembrie { Name = "Aged Brie", SellIn = 0, Quality = 1 };
            Item5.UpdateQuality();
            Assert.AreEqual(-1, Item5.SellIn);
            Assert.AreEqual(3, Item5.Quality);

            Itembrie Item6 = new Itembrie { Name = "Aged Brie", SellIn = 0, Quality = 50 };
            Item6.UpdateQuality();
            Assert.AreEqual(-1, Item6.SellIn);
            Assert.AreEqual(50, Item6.Quality);

            Itembrie Item7 = new Itembrie { Name = "Aged Brie", SellIn = 0, Quality = 80 };
            Item7.UpdateQuality();
            Assert.AreEqual(-1, Item7.SellIn);
            Assert.AreEqual(80, Item7.Quality);


        }

        [Test]
        public void ticketobject()
        {
            Itemticket Item1 = new Itemticket { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 0 };
            Item1.UpdateQuality();
            Assert.AreEqual(-1, Item1.SellIn);
            Assert.AreEqual(0, Item1.Quality);

            Itemticket Item2 = new Itemticket { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 30, Quality = 30 };
            Item2.UpdateQuality();
            Assert.AreEqual(29, Item2.SellIn);
            Assert.AreEqual(31, Item2.Quality);

            Itemticket Item3 = new Itemticket { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 7, Quality = 7 };
            Item3.UpdateQuality();
            Assert.AreEqual(6, Item3.SellIn);
            Assert.AreEqual(9, Item3.Quality);

            Itemticket Item4 = new Itemticket { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 5 };
            Item4.UpdateQuality();
            Assert.AreEqual(2, Item4.SellIn);
            Assert.AreEqual(8, Item4.Quality);

            Itemticket Item5 = new Itemticket { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 50 };
            Item5.UpdateQuality();
            Assert.AreEqual(-1, Item5.SellIn);
            Assert.AreEqual(0, Item5.Quality);

            Itemticket Item6 = new Itemticket { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 80 };
            Item6.UpdateQuality();
            Assert.AreEqual(-1, Item6.SellIn);
            Assert.AreEqual(0, Item6.Quality);

           


        }





    }

}
