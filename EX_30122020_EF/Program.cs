using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_30122020_EF
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DistrictDAO district = new DistrictDAO();
            CityDao city = new CityDao();
            City city1 = new City()
                    {
                        id = 1,
                        name = "Afula",
                        disctrict_id = 1,
                        mayor = "Hadad",
                        population = 34561
            };

            District district1 = new District()
            {
                id=1,
                name = "District Israel",
                population = 7954005
            };
            using (Cities_In_DistricsEntities connDB = new Cities_In_DistricsEntities ())
            {
                Console.WriteLine("ALL CITY");
                Console.WriteLine("==============================================================================================");

                city.GetByIdCity(1,connDB);
                city.GetAllCity(connDB);


                Console.WriteLine("ADD CITY");
                Console.WriteLine("==============================================================================================");

                city.AddCity(city1, connDB);

                Console.WriteLine("UPDATE CITY");
                Console.WriteLine("==============================================================================================");

                city.UpdateCity(1,city1, connDB);

                Console.WriteLine("DELETE CITY");
                Console.WriteLine("==============================================================================================");

                city.DeleteCity(2, connDB);

                Console.WriteLine("GET BY ID CITY");
                Console.WriteLine("==============================================================================================");

                city.GetByIdCity(4, connDB);

                Console.WriteLine("ALL CITY");
                Console.WriteLine("==============================================================================================");

                city.AllCities( connDB);

                Console.WriteLine("ALL CITIES MORE THAN NUMBER ENTERED");
                Console.WriteLine("==============================================================================================");

                city.AllCitiesMoreThan( 20000, connDB);

                Console.WriteLine("==============================================================================================");
                Console.WriteLine("==============================================================================================");
               
                Console.WriteLine();
                Console.WriteLine("ALL DISTRICS");
                Console.WriteLine("==============================================================================================");

                district.AddDistrict(district1, connDB);

                Console.WriteLine("Update District");
                Console.WriteLine("==============================================================================================");

                district.UpdateDistrict(1,district1, connDB);

                Console.WriteLine("Delete District");
                Console.WriteLine("==============================================================================================");

                district.DeleteDistrict(3, connDB);

                Console.WriteLine("Get District By Id");
                Console.WriteLine("==============================================================================================");

                district.GetDistrictById(5, connDB);

                Console.WriteLine("Insert Population In To Districts");
                Console.WriteLine("==============================================================================================");

                district.InsertPopulationIntoDistricts(connDB);

                Console.ReadKey();
            }
        }
    }
}
