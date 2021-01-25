using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_30122020_EF
{
    class DistrictDAO: IDistrictDAO
    {
 

        public void AddDistrict(District district,Cities_In_DistricsEntities connDB)
        {
            connDB.Districts.Add(district);
        }

        public void DeleteDistrict(int id, Cities_In_DistricsEntities connDB)
        {
            District district = connDB.Districts.FirstOrDefault(d => d.id == id);
            connDB.Districts.Remove(district);
        }

        public void GetAllDistrict(Cities_In_DistricsEntities connDB)
        {
            connDB.Districts.ToList().ForEach(d => Console.WriteLine(JsonConvert.SerializeObject(d)));
        }

        public void GetDistrictById(int id, Cities_In_DistricsEntities connDB)
        {
            District district = connDB.Districts.FirstOrDefault(d => d.id == id);
            Console.WriteLine(JsonConvert.SerializeObject(district));
        }

        public void UpdateDistrict(int id, District district, Cities_In_DistricsEntities connDB)
        {
            DeleteDistrict(id,connDB);
            AddDistrict(district,connDB);
        }

        public void InsertPopulationIntoDistricts(Cities_In_DistricsEntities connDB)
        {
            long i = 1;

            for (; i <= connDB.Districts.Count(); i++)
            {
                District district = connDB.Districts.FirstOrDefault(d => d.id == i);
                district.population = connDB.Cities.Where(c => c.disctrict_id == i).Sum(c => (int)c.population);
            }
        }
    }
}
