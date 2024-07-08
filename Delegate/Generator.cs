namespace Delegate
{
    public class Generator
    {
        public delegate void PriceChange(int Price);
        public PriceChange PriceChangeHandler { get; set; } // через свойство регистрируем ссылку на метод

        public void Start()
        {

            bool repeat = true;
    


            while (true) // безконечный цикл
            {


                int priceVTB = (new Random()).Next(100);
                PriceChangeHandler(priceVTB);  // оповестим о новой цене 
                Thread.Sleep(2000);


            }


        }
    }
}
