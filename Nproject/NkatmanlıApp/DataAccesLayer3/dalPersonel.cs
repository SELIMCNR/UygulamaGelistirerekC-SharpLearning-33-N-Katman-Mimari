using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccesLayer3
{
   public class dalPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut1 = new SqlCommand("Select * From TblBılgı", baglanti.baglan);
            if(komut1.Connection.State!=  System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();  
            while(dr.Read())
            {
                EntityPersonel ent = new EntityPersonel(); ;
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Name = dr["AD"].ToString();
                ent.Surname = dr["SOYAD"].ToString() ;
                ent.City = dr["SEHİR"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Maas = short.Parse( dr["MAAS"].ToString());
                degerler.Add(ent);
               
            
            }
            dr.Close();
            return degerler;
        }

        public static int PersonelEkle(EntityPersonel personel)
        {
            SqlCommand komut2 = new SqlCommand("insert into TblBılgı " +
                "(AD,SOYAD,GOREV,SEHİR,MAAS) VALUES (@P1,@P2,@P3,@P4,@P5)",
                baglanti.baglan);

            if(komut2.Connection.State!= System.Data.ConnectionState.Open)
            {
                komut2.Connection.Open();
            }

            komut2.Parameters.AddWithValue("@P1", personel.Name);
            komut2.Parameters.AddWithValue("@P2",personel.Surname);
            komut2.Parameters.AddWithValue("@P3", personel.Gorev);
            komut2.Parameters.AddWithValue("@P4", personel.City);
            komut2.Parameters.AddWithValue("@p5", personel.Maas);
           return komut2.ExecuteNonQuery();
        }  

        public static bool PersonelSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("DELETE FROM TblBılgı where ID=@p1",baglanti.baglan);
            if(komut3.Connection.State != System.Data.ConnectionState.Open)
            {
                komut3.Connection.Open();
            }

            komut3.Parameters.AddWithValue("@P1",p);
            return komut3.ExecuteNonQuery()>0;
        }

        public static bool PersonelGuncelle(EntityPersonel ent)
        {
            SqlCommand komut4 = new SqlCommand("Update TblBılgı set " +
                "AD=@P1,SOYAD=@P2,MAAS=@P3,SEHİR=@P4,GOREV=@P5 WHERE ID = @P6",baglanti.baglan);
            {
                }

            if (komut4.Connection.State != System.Data.ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", ent.Name);
            komut4.Parameters.AddWithValue("@P2", ent.Surname);
            komut4.Parameters.AddWithValue("@P3", ent.Maas);
            komut4.Parameters.AddWithValue("@P4", ent.City);
            komut4.Parameters.AddWithValue("@p5", ent.Gorev);
            komut4.Parameters.AddWithValue("@p6", ent.Id);

            return komut4.ExecuteNonQuery()>0;

        }
    
        
    }
}
