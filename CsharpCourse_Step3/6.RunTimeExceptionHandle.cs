using System;

namespace RuntimeExceptionHandle
{
    class car
    {
        public static void CarInfo(string brandName, int modelNum)
        {
            Console.WriteLine("Welcome to Volkswagen Showroom");

            string carBrand = brandName;

            try
            {
                carBrand = brandName.ToUpper();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Test1");
            }

            string[] models = { "Virtus", "Taigun" };

            string modelName = "";
            try
            {
                modelName = models[modelNum];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Test2");
            }

            if (carBrand == "VOLKSWAGEN" && modelName == "Virtus")
            {
                Console.WriteLine("Price around 15 Lacs");
            }
            else
            {
                Console.WriteLine("Price is not available as of now");
            }
            Console.WriteLine("Show room Timings are 10AM to 9PM");
            Console.WriteLine("Any Questions Contact Customer Care");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string brand = null;
            int modelnum = 6;
            car.CarInfo(brand, modelnum);
        }
    }
}