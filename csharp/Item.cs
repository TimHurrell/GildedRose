namespace csharp
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }  
    }

    public class ItemNormal : Item
    {

      
        // Method to update the quality
        public void UpdateQuality()
        {

            if (Quality > 0)
            {
                if (SellIn > 0)
                {
                    Quality--;
                }
                else
                {
                    Quality = Quality - 2;
                }
            }
           
            SellIn--;
        }
    }

    public class Itemsulfuras : ItemNormal
    {


        // Method to update the quality
        public new void UpdateQuality()
        {

        }
    }


    public class Itembrie : ItemNormal
    {


        // Method to update the quality
        public new void UpdateQuality()
        {
            if (Quality < 50)
            {
                if (SellIn >= 1)
                { Quality = Quality + 1; }
                else
                { Quality = Quality + 2; }

            }
            SellIn--;
        }
    }


    public class Itemticket : ItemNormal
    {


        // Method to update the quality
        public new void UpdateQuality()
        {
            if (Quality < 50)
            {
                if (SellIn <= 3)
                { Quality = Quality + 3; }
                else if (SellIn <= 10)
                { Quality = Quality + 2; }
                else 
                { Quality = Quality + 1; }

            }
            if (SellIn <= 0)
            { Quality = 0;
            }

            SellIn--;
        }
    }

}
