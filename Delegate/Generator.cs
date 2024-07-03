namespace Delegate
{
    public class Generator
    {
        public delegate void PriceChange(int Price);
        public PriceChange PriceChangeHandler { get; set; }

        public void Start()
        {
            while (true)
            {
                int priceVTB = (new Random()).Next(100);
                PriceChangeHandler(priceVTB);   
                Thread.Sleep(2000);
            }
        }
    }
}
