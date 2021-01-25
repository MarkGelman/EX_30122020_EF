using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_30122020_EF
{
    interface ICityDAO
    {
        void GetAllCity(Cities_In_DistricsEntities connDB);
        void AddCity(City t, Cities_In_DistricsEntities connDB);
        void UpdateCity(int id, City c, Cities_In_DistricsEntities connDB);
        void DeleteCity(int id, Cities_In_DistricsEntities connDB);
        void GetByIdCity(int id, Cities_In_DistricsEntities connDB);
        void AllCities(Cities_In_DistricsEntities connDB);
        void AllCitiesMoreThan(int numberPeople, Cities_In_DistricsEntities connDB);
    }
}
