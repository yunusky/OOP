using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Bilgisayarlar
{
	public class Bilgisayar
	{
		public Anakart Anakart { get; set; }
		public Cpu Cpu { get; set; }
		public List<Ram> Ramlar { get; set; }
        public List<EkranKarti> EkranKartlari { get; set; }
        public List<HardDisk> Diskler { get; set; }

        //Kurucu metod yada yapici metod da denir
        //Terminolojide constructor olarak gecer.
        //eger Propertylere ilk deger atamasi yapilmis ise 
        //once propertyler e deger atanir sonra constructor calistirilir.
        //Constructorlar class ismi ile aynı olmak zorundadırlar.
        //constructorların geri dönüş tipi yoktur.
        public Bilgisayar()
        {
            Cpu = new Cpu("Amd");
            Ramlar = new List<Ram>() { new Ram { Fiyat = 5} , new Ram { Fiyat = 5 } };
            EkranKartlari = new List<EkranKarti>() { new EkranKarti {Fiyat=10 } };
            Diskler = new List<HardDisk>() { new HardDisk { Fiyat=30 } };
            Anakart = new Anakart();
        }

		public double FiyatHesapla()
		{
			double toplamTutar = 0;
			foreach (var ram in Ramlar)
			{
				toplamTutar +=  ram.Fiyat;
			}
			foreach (var disk in Diskler)
			{
				toplamTutar +=  disk.Fiyat;
			}
			foreach (var ekran in EkranKartlari)
			{
				toplamTutar += ekran.Fiyat;
			}
			toplamTutar += Anakart.Fiyat;
			toplamTutar += Cpu.Fiyat;

			return toplamTutar;
		}
	}
}
