namespace Delegate
{
    public class Generator
    {
        public delegate void PriceChange(int Price);
        public PriceChange PriceChangeHandler { get; set; } // через свойство регистрируем ссылку на метод

        public void Start()
        {
           
            bool repeat= true;

            while (repeat==true) 
            {
                string go = Console.ReadLine();

                int priceVTB = (new Random()).Next(100);
                PriceChangeHandler(priceVTB);  // оповестим о новой цене 
                Thread.Sleep(2000);

                if (go.ToUpper() != "Y") // как прервать поток
                {
                    repeat = false;
                }
            }


        }
    }
}
