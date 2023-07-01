using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
   public class OgrenciDal
    {
        public static int OgrenciEkle(EntityOgrenci entityOgrenci)
        {
            SqlCommand komut = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrNumara,OgrFoto,OgrSifre) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", entityOgrenci.AD);
            komut.Parameters.AddWithValue("@p2", entityOgrenci.SOYAD);
            komut.Parameters.AddWithValue("@p3", entityOgrenci.NUMARA);
            komut.Parameters.AddWithValue("@p4", entityOgrenci.FOTOGRAF);
            komut.Parameters.AddWithValue("@p5", entityOgrenci.SIFRE);
            return komut.ExecuteNonQuery();
        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> ogrenci = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("select *from Ogrenci", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ID = Convert.ToInt32(dr["OgrId"].ToString());
                ent.AD = dr["OgrAd"].ToString();
                ent.SOYAD = dr["OgrSoyad"].ToString();
                ent.NUMARA = dr["OgrNumara"].ToString();
                ent.FOTOGRAF = dr["OgrFoto"].ToString();
                ent.SIFRE = dr["OgrSifre"].ToString();
                ent.BAKIYE = Convert.ToDouble(dr["OgrBakiye"].ToString());
                ogrenci.Add(ent);
            }
            dr.Close();
            return ogrenci;
        }
        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut = new SqlCommand("Delete from Ogrenci where OgrId=@p1", Baglanti.bgl);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", parametre);
            return komut.ExecuteNonQuery() > 0;
        }
        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> ogrenci = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("select *from Ogrenci where OgrId=@p1", Baglanti.bgl);
            komut2.Parameters.AddWithValue("@p1", id);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.AD = dr["OgrAd"].ToString();
                ent.SOYAD = dr["OgrSoyad"].ToString();
                ent.NUMARA = dr["OgrNumara"].ToString();
                ent.FOTOGRAF = dr["OgrFoto"].ToString();
                ent.SIFRE = dr["OgrSifre"].ToString();
                ent.BAKIYE = Convert.ToDouble(dr["OgrBakiye"].ToString());
                ogrenci.Add(ent);
            }
            dr.Close();
            return ogrenci;
        }
        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p1,OgrSoyad=@p2,OgrNumara=@p3,OgrFoto=@p4,OgrSifre=@p5 where OgrId=@p6", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", deger.AD);
            komut.Parameters.AddWithValue("@p2", deger.SOYAD);
            komut.Parameters.AddWithValue("@p3", deger.NUMARA);
            komut.Parameters.AddWithValue("@p4", deger.FOTOGRAF);
            komut.Parameters.AddWithValue("@p5", deger.SIFRE);
            komut.Parameters.AddWithValue("@p6", deger.ID);
            return komut.ExecuteNonQuery()>0;
        }
    }
}
