namespace Delegate
{
    public class Generator
    {
        public delegate void PriceChange(int Price);
        public PriceChange PriceChangeHandler { get; set; } // через свойство можно зарегистрировать ссылку на метод

        public void Start()
        {
            string go = Console.ReadLine();
            bool repeat= true;
            while (repeat) // бесконечный цикл
            {
                int priceVTB = (new Random()).Next(100);
                PriceChangeHandler(priceVTB);  // оповестим о новой цене 
                Thread.Sleep(2000);

      
                if (go.ToUpper() != "Д")
                {
                    repeat = false;
                }

            }
        }
    }
}
