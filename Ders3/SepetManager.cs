using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3
{
    class SepetManager
    {
        //naming convention

        //Tavsiye edilen kısım 
        public void Ekle(Urun urun) // ne ekleyecek onu göstermeye paramaetre denir
        {
            Console.WriteLine("Sepete Eklendi: " + urun.Adi);

        }

        //Tavsiye edilmeyen kısım
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int StokAdedi)
        {
            Console.WriteLine("Sepete Eklendi: " + urunAdi);
        }


    }
}
