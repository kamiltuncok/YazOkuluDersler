using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
   public class BLLDers
    {
        public static List<EntityDersler> BLLListele()
        {
            return DersDal.DersListesi();
        }
        public static int TalepEkleBLL(EntityBasvuruForm p)
        {
            if (p.BASOGRID != null && p.BASDERSID != null)
            {
                return DersDal.TalepEkle(p);
            }
            return -1;
        }
    }
}
