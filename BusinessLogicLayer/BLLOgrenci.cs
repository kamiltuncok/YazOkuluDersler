using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.AD!=null && p.SOYAD != null && p.NUMARA != null && p.SIFRE != null && p.FOTOGRAF != null)
            {
                return OgrenciDal.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<EntityOgrenci> BLLListele()
        {
            return OgrenciDal.OgrenciListesi();
        }
        public static bool OgrenciSilBLL(int p)
        {
            if (p>=0)
            {
                return OgrenciDal.OgrenciSil(p);
            }
            return false;
        }
        public static List<EntityOgrenci> BLLDetay(int p)
        {
            return OgrenciDal.OgrenciDetay(p);
        }
        public static bool OgrenciGuncelleBLL(EntityOgrenci p)
        {
            if (p.AD != null && p.SOYAD != null && p.NUMARA != null && p.SIFRE != null && p.FOTOGRAF != null && p.ID>0)
            {
                return OgrenciDal.OgrenciGuncelle(p);
            }
            return false;
        }
    }

}
