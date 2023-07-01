using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using System.Data;

namespace DataAccessLayer
{
    public class DersDal
    {
        public static List<EntityDersler> DersListesi()
        {
            List<EntityDersler> dersler = new List<EntityDersler>();
            SqlCommand komut2 = new SqlCommand("select *from Dersler", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityDersler ent = new EntityDersler();
                ent.ID = Convert.ToInt32(dr["DersId"].ToString());
                ent.DERSAD = dr["DersAd"].ToString();
                ent.MİN = int.Parse(dr["DersMinKontenjan"].ToString());
                ent.MAX = int.Parse(dr["DersMaxKontenjan"].ToString());
                dersler.Add(ent);
            }
            dr.Close();
            return dersler;
        }
        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("insert into BasvuruForm (OgrenciId,DersId) values (@p1,@p2)", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", parametre.BASOGRID);
            komut.Parameters.AddWithValue("@p2", parametre.BASDERSID);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }
    }
}
