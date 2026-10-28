using System;

namespace MultipltCatchExceptionHandle
{
    class car
    {
        public static void CarInfo(string brandName, int modelNum)
        {
            Console.WriteLine("Welcome to Volkswagen Showroom");

            try
            {


                string carBrand = brandName;

                if(carBrand ==  null || carBrand == "")
                {
                    throw new NullReferenceException();
                }

                carBrand = brandName.ToUpper();

                string[] models = { "Virtus", "Taigun" };

                string modelName = models[modelNum];

                if (carBrand == "VOLKSWAGEN" && modelName == "Virtus")
                {
                    Console.WriteLine("Price around 15 Lacs");
                }
                else
                {
                    Console.WriteLine("Price is not available as of now");
                }

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Show room Timings are 10AM to 9PM");
                Console.WriteLine("Any Questions Contact Customer Care");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string brand = "volkswagen";
            int modelnum = 6;
            car.CarInfo(brand, modelnum);
        }
    }
}