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

}
