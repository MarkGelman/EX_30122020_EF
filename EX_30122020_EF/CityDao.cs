using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_30122020_EF
{
    class CityDao:ICityDAO
    { 
      

        public void AllCities(Cities_In_DistricsEntities connDB)
        {
            var cities = from c in connDB.Cities
                         select c.name;

        }

       
        public void AddCity(City city, Cities_In_DistricsEntities connDB)
        {
            connDB.Cities.Add(city);
        }

        public void DeleteCity(int id, Cities_In_DistricsEntities connDB)
        {
            City city = connDB.Cities.FirstOrDefault(d => d.id == id);
            connDB.Cities.Remove(city);
        }

        public void GetAllCity(Cities_In_DistricsEntities connDB)
        {
            connDB.Cities.ToList().ForEach(_ => Console.WriteLine(JsonConvert.SerializeObject(_)));

        }

        public void GetByIdCity(int id, Cities_In_DistricsEntities connDB)
        {
            City district = connDB.Cities.FirstOrDefault(d => d.id == id);
            Console.WriteLine(JsonConvert.SerializeObject(district));
        }

        public void UpdateCity(int id, City c, Cities_In_DistricsEntities connDB)
        {
            DeleteCity(id,connDB);
            AddCity(c,connDB);
        }

        public void AllCitiesMoreThan(int numberPeople, Cities_In_DistricsEntities connDB)
        {
                connDB.Cities.Where(c => c.population > numberPeople).ToList().ForEach(c => Console.WriteLine($"{c.population}\n"));
          
        }
    }
}
