using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Challenge_Repository
{
    public class KomodoInsurancePOCO
    {
        public int BadgeID { get; set; }
        public List<string> DoorAccess { get; set; }

        public KomodoInsurancePOCO() { }
        public KomodoInsurancePOCO(int badgeID, List<string> doorAccess)
        {
            BadgeID = badgeID;
            DoorAccess = doorAccess;
        }
    }
}
