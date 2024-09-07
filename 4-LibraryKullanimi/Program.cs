using _3_ClassLib.Bilgisayarlar;

namespace _4_LibraryKullanimi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Cpu cpu = new Cpu("");
			cpu.Marka = "AMD";

			Anakart anakart = new Anakart();
			
			// abstract classlardan instance alınamaz
			//BaseItem baseItem = new BaseItem();
			//baseItem.Marka = "abc";
			//baseItem.Model = "ads";
			//baseItem.Fiyat = 123;

			Bilgisayar bilgisayar = new Bilgisayar();
			OyuncuBilgisayarı oyuncu = new OyuncuBilgisayarı();
            //bilgisayar.Anakart = anakart;
            //bilgisayar.Cpu = cpu;
            //bilgisayar.Ramlar = new List<Ram>();
            //bilgisayar.Ramlar.Add(new Ram() { Marka="Kingston" });
            //bilgisayar.Ramlar.Add(new Ram() { Marka = "Corsair" });
            //bilgisayar.Diskler = new List<HardDisk>();
            //bilgisayar.Diskler.Add(new HardDisk { DiskTipi = DiskTipi.HDD, Marka = "Seagate" });
            //bilgisayar.EkranKartlari = new List<EkranKarti>();
            //oyuncu = null;

            Console.WriteLine("Oyuncu Bilgisayarı Fiyati : " + oyuncu.FiyatHesapla());
            Console.WriteLine("Bilgisayar Fiyati : " + bilgisayar.FiyatHesapla());

			Console.WriteLine("Hello, World!");
		}
	}
}
