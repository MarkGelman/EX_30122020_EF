using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_30122020_EF
{
    interface IDistrictDAO
    {
        void GetAllDistrict(Cities_In_DistricsEntities connDB);
        void AddDistrict(District t, Cities_In_DistricsEntities connDB);
        void UpdateDistrict(int id, District c, Cities_In_DistricsEntities connDB);
        void DeleteDistrict(int id, Cities_In_DistricsEntities connDB);
        void GetDistrictById(int id, Cities_In_DistricsEntities connDB);
        void InsertPopulationIntoDistricts(Cities_In_DistricsEntities connDB);
    }
}
