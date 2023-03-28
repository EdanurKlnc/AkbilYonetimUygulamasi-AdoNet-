using System.Collections;
using System.Data;

namespace AkbilYntmVeriKatmani
{
    //interface oluşturmadaki amaç,ilerde kullanılan veritabani değiştirilmek istenirse bütün projede değişim yapmak yerine interfacede değişim yapmak
    public interface IVeritabaniIslemleri
    {
        //CRUD : Create Read Update Delete
        string BaglantiCumlesi { get; set; }
        DataTable VeriGetir(string tabloAdi, string kolonlar="*", string? kosullar = null);

        int VeriSil(string tabloAdi, string? kosullar = null); 

        int KomutIsle(string eklemeyadaGuncellemeCumlesi); // sadece excutenonquery

        string VeriEklemeCumlesiOlustur(string tabloAdi, Dictionary<string, object>kolonlar);

        string VeriGuncellemeCumlesiOlustur(string tabloAdi, Hashtable kolonlar, string? kosullar = null);

        Hashtable VeriOku(string tabloAdi, string[] kolonlar, string? kosullar = null);


    }
}
