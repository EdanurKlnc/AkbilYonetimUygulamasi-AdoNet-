

using AkbilYntmIsKatmani;
using System.Collections;

using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AkbilYntmVeriKatmani
{
    public class SqlVeritabaniIslemleri : IVeritabaniIslemleri
    {
        public string BaglantiCumlesi { get ; set; }

        private SqlConnection baglanti;
        private SqlCommand komut;

        public SqlVeritabaniIslemleri()
        {
            BaglantiCumlesi = GenelIslemler.SinifSQLBaglantiCumlesi;
            baglanti = new SqlConnection(BaglantiCumlesi);
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }
        public SqlVeritabaniIslemleri(string baglantiCumle) //parametre olan hali
        {
            BaglantiCumlesi = baglantiCumle;
            baglanti = new SqlConnection(BaglantiCumlesi);
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }
        private void BaglantiyiAc()
        {
            baglanti.ConnectionString = BaglantiCumlesi;

            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }
        }
        public int KomutIsle(string eklemeyadaGuncellemeCumlesi)
        {
            try
            {
                using (baglanti) // using => kaynağı kullanıp blok bitince imha eder
                {
                    komut.CommandType = CommandType.Text;
                    komut.CommandText = eklemeyadaGuncellemeCumlesi;
                    BaglantiyiAc();
                    int etkilenenSatirSayisi = komut.ExecuteNonQuery();
                    return etkilenenSatirSayisi;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string VeriEklemeCumlesiOlustur(string tabloAdi, Dictionary<string, object> kolonlar)
        {
            try
            {
                //insert into TabloAdi (kolonlar) values (degerler)
                string sorgu = string.Empty;
                string sutunlar = string.Empty;
                string degerler = string.Empty;

                foreach (var item in kolonlar)
                {
                    sutunlar += $"{item.Key},";
                    degerler += $"{item.Value},";

                }
                //en sondaki ,'den  kurtulmamız için trim kullanalım. Trim boşlukları keser ve TrimEnd en sondakini keser
                sutunlar = sutunlar.TrimEnd(',');
                degerler = degerler.TrimEnd(',');


                sorgu = $" insert into {tabloAdi} ({sutunlar}) values ({degerler})";
                return sorgu;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable VeriGetir(string tabloAdi, string kolonlar = "*", string? kosullar = null)
        {
            try
            {
                using (baglanti)
                {
                    string sorgu = $"select {kolonlar} from {tabloAdi}";
                    if (!string.IsNullOrEmpty(kosullar))
                    {
                        sorgu += $" where {kosullar}";

                    }
                    komut.CommandText = sorgu;
                    SqlDataAdapter adp = new SqlDataAdapter(komut);
                    BaglantiyiAc();
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    return dt;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string VeriGuncellemeCumlesiOlustur(string tabloAdi, Hashtable kolonlar, string? kosullar = null)
        {
            try
            {
                //update tabloadi set col= deger...., where kosullar
                string sorgu = string.Empty, setler = string.Empty;
                foreach (var item in kolonlar)
                {
                    setler += $"{item}={kolonlar[item]},";
                }
                setler = setler.Trim().TrimEnd(',');

                sorgu = $"update {tabloAdi} set {setler}";
                if (!string.IsNullOrEmpty(kosullar))
                {
                    sorgu += $" where{kosullar}";
                }
                return sorgu;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Hashtable VeriOku(string tabloAdi, string[] kolonlar, string? kosullar = null)
        {
            try
            {
                Hashtable sonuc = new Hashtable();
                string sutunlar = string.Empty;

                //kolonlara , ekleyeceğiz
                StringBuilder sb = new StringBuilder();

                foreach (var item in kolonlar)
                {
                    sb.Append($"{item} ,");
                }
                sutunlar = sb.ToString().TrimEnd(',');

                string sorgu = $"select {sutunlar} from {tabloAdi} ";
                if (!string.IsNullOrEmpty(kosullar))
                {
                    sorgu += $" where {kosullar}";  //sorgu cümlesini where.. ekle
                }
                using (baglanti)
                {
                    komut.CommandText = sorgu;
                    BaglantiyiAc();
                    SqlDataReader okuyucu = komut.ExecuteReader();
                    if (okuyucu.HasRows)
                    {
                        while (okuyucu.Read())
                        {
                            /*  for (int i= 0; i <kolonlar.Length; i++)
                              {
                                  sonuc.Add(kolonlar[i], okuyucu[kolonlar[i]]);
                              }*/
                            foreach (var item in kolonlar)
                            {
                                    sonuc.Add(item, okuyucu[item]);
                                
                            }
                        }
                    }
                }

                return sonuc;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int VeriSil(string tabloAdi, string? kosullar = null)
        {
            try
            {
                using (baglanti)
                {
                    string sorgu = $"delete from {tabloAdi}";
                    if (!string.IsNullOrEmpty(kosullar))
                    {
                        sorgu += $"where {kosullar}";
                    }
                    komut.CommandText = sorgu;
                    BaglantiyiAc();
                    int silinenSatirSayisi = komut.ExecuteNonQuery();
                    return silinenSatirSayisi;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
