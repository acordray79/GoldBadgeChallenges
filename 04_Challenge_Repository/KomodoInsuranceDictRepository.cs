using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Challenge_Repository
{
    public class KomodoInsuranceDictRepository
    {
        Dictionary<int, List<string>> _employeeAccess = new Dictionary<int, List<string>>();

        public void AddToDictionary(KomodoInsurancePOCO access)
        {
            _employeeAccess.Add(access.BadgeID, access.DoorAccess);
        }
        public void ChangeDoors(int badgeID, List<string> doorAccess)
        {
            _employeeAccess[badgeID] = doorAccess;
        }
        public Dictionary<int, List<string>> GetAllBadges()
        {
            return _employeeAccess;
        }
    }
}
