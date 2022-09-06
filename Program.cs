using System;
using System.Linq;

namespace CarDealer
{
    class Program
    {
        public static void marka()
        {
            Console.Write("Brand name: ");
            string araba_marka = Console.ReadLine();
            var allcars = new[]
            {
                new Cars("Toyota", "Supra", "Sport",2017, 1200,40000M),
                new Cars("Honda","Accord","Sedan",2021,252,32000M),
                new Cars("BMW", "720M", "Sport",2021, 602,70000M),
                new Cars("Audi","S8", "Sport",2021,563,50000M),
                new Cars("Ferrari","F40", "Sport" ,1991,471 ,399150M),
                new Cars("Mercedes","S560","Sedan",2020,463,100000M),
                new Cars("Honda", "Civic","Sedan", 2005,160, 1500M),
                new Cars("Kia","Sedona","Jeep",2017,300,30000M),
                new Cars("Kia","Forte","Sedan",2006,201,2000M),
                new Cars("Subaru", "Forester","Jeep", 2002,165, 2500M),
                new Cars("Hynudai","Sonata","Sedan",2010,249,5000M),
                new Cars("Lexus", "SC300","Sport", 2010,288, 4000M),
                new Cars("Cadillac","Escalade","Jeep",2009,403,7000M)
            };

            var marka_arabalar =
                from car in allcars
                where (car.carname == araba_marka)
                select car;
            string mark = "Brand";
            string mode = "Model";
            string tu = "Kind";
            string yi = "Year";
            string bg = "HP";
            string fiya = "Price";
            Console.WriteLine($"{mark,-10} {mode,-10} {tu,-10} {yi,-10} {bg,-10} {fiya,-10}");
            Console.WriteLine($"\n");
            foreach (var mycar in marka_arabalar)
            {
                Console.WriteLine($"{mycar}");
            }
            Console.ReadLine();
            Console.Clear();

        }

        public static void model()
        {
            Console.Write("Model name: ");
            string araba_model = Console.ReadLine();
            var allcars = new[]
            {
                new Cars("Toyota", "Supra", "Sport",2017, 1200,40000M),
                new Cars("Honda","Accord","Sedan",2021,252,32000M),
                new Cars("BMW", "720M", "Sport",2021, 602,70000M),
                new Cars("Audi","S8", "Sport",2021,563,50000M),
                new Cars("Ferrari","F40", "Sport" ,1991,471 ,399150M),
                new Cars("Mercedes","S560","Sedan",2020,463,100000M),
                new Cars("Honda", "Civic","Sedan", 2005,160, 1500M),
                new Cars("Kia","Sedona","Jeep",2017,300,30000M),
                new Cars("Kia","Forte","Sedan",2006,201,2000M),
                new Cars("Subaru", "Forester","Jeep", 2002,165, 2500M),
                new Cars("Hynudai","Sonata","Sedan",2010,249,5000M),
                new Cars("Lexus", "SC300","Sport", 2010,288, 4000M),
                new Cars("Cadillac","Escalade","Jeep",2009,403,7000M)
            };

            var model_arabalar =
                from car in allcars
                where (car.carmodel == araba_model)
                select car;
            string mark = "Brand";
            string mode = "Model";
            string tu = "Kind";
            string yi = "Year";
            string bg = "HP";
            string fiya = "Price";
            Console.WriteLine($"{mark,-10} {mode,-10} {tu,-10} {yi,-10} {bg,-10} {fiya,-10}");
            Console.WriteLine($"\n");
            foreach (var mycar in model_arabalar)
            {
                Console.WriteLine($"{mycar}");
            }
            Console.ReadLine();
            Console.Clear();

        }

        public static void tur()
        {
            Console.Write("Kind: ");
            string araba_tur = Console.ReadLine();
            var allcars = new[]
            {
                new Cars("Toyota", "Supra", "Sport",2017, 1200,40000M),
                new Cars("Honda","Accord","Sedan",2021,252,32000M),
                new Cars("BMW", "720M", "Sport",2021, 602,70000M),
                new Cars("Audi","S8", "Sport",2021,563,50000M),
                new Cars("Ferrari","F40", "Sport" ,1991,471 ,399150M),
                new Cars("Mercedes","S560","Sedan",2020,463,100000M),
                new Cars("Honda", "Civic","Sedan", 2005,160, 1500M),
                new Cars("Kia","Sedona","Jeep",2017,300,30000M),
                new Cars("Kia","Forte","Sedan",2006,201,2000M),
                new Cars("Subaru", "Forester","Jeep", 2002,165, 2500M),
                new Cars("Hynudai","Sonata","Sedan",2010,249,5000M),
                new Cars("Lexus", "SC300","Sport", 2010,288, 4000M),
                new Cars("Cadillac","Escalade","Jeep",2009,403,7000M)
            };

            var tur_arabalar =
                from car in allcars
                where (car.cartur == araba_tur)
                select car;
            string mark = "Brand";
            string mode = "Model";
            string tu = "Kind";
            string yi = "Year";
            string bg = "HP";
            string fiya = "Price";
            Console.WriteLine($"{mark,-10} {mode,-10} {tu,-10} {yi,-10} {bg,-10} {fiya,-10}");
            Console.WriteLine($"\n");
            foreach (var mycar in tur_arabalar)
            {
                Console.WriteLine($"{mycar}");
            }
            Console.ReadLine();
            Console.Clear();

        }

        public static void yilindain_itibaren()
        {
            Console.Write("Kac yilindan sonrasi icin bakiyorsunuz? ");
            int yili = Convert.ToInt32(Console.ReadLine());
            var allcars = new[]
            {
                new Cars("Toyota", "Supra", "Sport",2017, 1200,40000M),
                new Cars("Honda","Accord","Sedan",2021,252,32000M),
                new Cars("BMW", "720M", "Sport",2021, 602,70000M),
                new Cars("Audi","S8", "Sport",2021,563,50000M),
                new Cars("Ferrari","F40", "Sport" ,1991,471 ,399150M),
                new Cars("Mercedes","S560","Sedan",2020,463,100000M),
                new Cars("Honda", "Civic","Sedan", 2005,160, 1500M),
                new Cars("Kia","Sedona","Jeep",2017,300,30000M),
                new Cars("Kia","Forte","Sedan",2006,201,2000M),
                new Cars("Subaru", "Forester","Jeep", 2002,165, 2500M),
                new Cars("Hynudai","Sonata","Sedan",2010,249,5000M),
                new Cars("Lexus", "SC300","Sport", 2010,288, 4000M),
                new Cars("Cadillac","Escalade","Jeep",2009,403,7000M)
            };

            var cars =
                from car in allcars
                where (car.year > yili)
                select car;
            string mark = "Brand";
            string mode = "Model";
            string tu = "Kind";
            string yi = "Year";
            string bg = "HP";
            string fiya = "Price";
            Console.WriteLine($"{mark,-10} {mode,-10} {tu,-10} {yi,-10} {bg,-10} {fiya,-10}");
            Console.WriteLine($"\n");
            foreach (var mycar in cars)
            {
                Console.WriteLine($"{mycar}");
            }
            Console.ReadLine();
            Console.Clear();

        }

        public static void beygir()
        {
            Console.Write("Minimum horse power: ");
            int min_bg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maximum horse power: ");
            int max_bg = Convert.ToInt32(Console.ReadLine());
            var allcars = new[]
            {
                new Cars("Toyota", "Supra", "Sport",2017, 1200,40000M),
                new Cars("Honda","Accord","Sedan",2021,252,32000M),
                new Cars("BMW", "720M", "Sport",2021, 602,70000M),
                new Cars("Audi","S8", "Sport",2021,563,50000M),
                new Cars("Ferrari","F40", "Sport" ,1991,471 ,399150M),
                new Cars("Mercedes","S560","Sedan",2020,463,100000M),
                new Cars("Honda", "Civic","Sedan", 2005,160, 1500M),
                new Cars("Kia","Sedona","Jeep",2017,300,30000M),
                new Cars("Kia","Forte","Sedan",2006,201,2000M),
                new Cars("Subaru", "Forester","Jeep", 2002,165, 2500M),
                new Cars("Hynudai","Sonata","Sedan",2010,249,5000M),
                new Cars("Lexus", "SC300","Sport", 2010,288, 4000M),
                new Cars("Cadillac","Escalade","Jeep",2009,403,7000M)
            };

            var cars =
                from car in allcars
                where (car.carHP >= min_bg) && (car.carHP <= max_bg)
                select car;

            string mark = "Brand";
            string mode = "Model";
            string tu = "Kind";
            string yi = "Year";
            string bg = "HP";
            string fiya = "Price";
            Console.WriteLine($"{mark,-10} {mode,-10} {tu,-10} {yi,-10} {bg,-10} {fiya,-10}");
            Console.WriteLine($"\n");
            foreach (var mycar in cars)
            {
                Console.WriteLine($"{mycar}");
            }
            Console.ReadLine();
            Console.Clear();

        }

        public static void fiyat()
        {
            Console.Write("Minimum cost: ");
            int min_fiyat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maximum cost: ");
            int max_fiyat = Convert.ToInt32(Console.ReadLine());
            var allcars = new[]
            {
                new Cars("Toyota", "Supra", "Sport",2017, 1200,40000M),
                new Cars("Honda","Accord","Sedan",2021,252,32000M),
                new Cars("BMW", "720M", "Sport",2021, 602,70000M),
                new Cars("Audi","S8", "Sport",2021,563,50000M),
                new Cars("Ferrari","F40", "Sport" ,1991,471 ,399150M),
                new Cars("Mercedes","S560","Sedan",2020,463,100000M),
                new Cars("Honda", "Civic","Sedan", 2005,160, 1500M),
                new Cars("Kia","Sedona","Jeep",2017,300,30000M),
                new Cars("Kia","Forte","Sedan",2006,201,2000M),
                new Cars("Subaru", "Forester","Jeep", 2002,165, 2500M),
                new Cars("Hynudai","Sonata","Sedan",2010,249,5000M),
                new Cars("Lexus", "SC300","Sport", 2010,288, 4000M),
                new Cars("Cadillac","Escalade","Jeep",2009,403,7000M)
            };

            var cars =
                from car in allcars
                where (car.cost > min_fiyat) && (car.cost <= max_fiyat)
                select car;
            string mark = "Brand";
            string mode = "Model";
            string tu = "Kind";
            string yi = "Year";
            string bg = "HP";
            string fiya = "Price";
            Console.WriteLine($"{mark,-10} {mode,-10} {tu,-10} {yi,-10} {bg,-10} {fiya,-10}");
            Console.WriteLine($"\n");
            foreach (var mycar in cars)
            {
                Console.WriteLine($"{mycar}");
            }
            Console.ReadLine();
            Console.Clear();

        }


        static void Main(string[] args)
        {
            int cont = 1;
            string menu = "0] Exit\n1] Choose by Brand \n2] Choose by Model \n3] Choose by Kind \n4] From .... year till today \n5] Choose by HP\n6] Choose by Price\n";
            while(cont > 0)
            {
                Console.WriteLine(menu + "\n");
                Console.Write("Choose: ");
                int secenek = Convert.ToInt32(Console.ReadLine());
                if (secenek == 0)
                {
                    cont--;
                }
                else if (secenek == 1)
                {
                    Console.Clear();
                    marka();
                }
                else if (secenek == 2)
                {
                    Console.Clear();
                    model();
                }
                else if (secenek == 3)
                {
                    Console.Clear();
                    tur();
                }
                else if (secenek == 4)
                {
                    Console.Clear();
                    yilindain_itibaren();
                }
                else if (secenek == 5)
                {
                    Console.Clear();
                    beygir();
                }
                else if(secenek == 6){
                    Console.Clear();
                    fiyat();
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
