using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccesLayer3;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return dalPersonel.PersonelListesi();
        } 
        public static int LLPersonelEkle(EntityPersonel personel)
        {
            if(personel.Name != "" && personel.Surname !="" && personel.Maas>=3500&& personel.Name.Length>=3)
            {

                return dalPersonel.PersonelEkle(personel);

            }
            else
            {
                return -1;
            }
        }
   
        public static bool LLPersonelSil(int per)
        {
            if (per >= 1)
            {
                return dalPersonel.PersonelSil(per);    
            }
            else { return false; }
        }

        public static bool LLPersonelGuncelle(EntityPersonel ent)
        {
            if (ent.Name.Length >= 3 && ent.Name!="" && ent.Maas>=4500 )
            {
                return dalPersonel.PersonelGuncelle(ent);
            }
            else
            {
                return false;
            }
        }
    }
}
