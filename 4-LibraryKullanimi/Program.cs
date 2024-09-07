using _3_ClassLib.Bilgisayarlar;

namespace _4_LibraryKullanimi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Cpu cpu = new Cpu();
			cpu.Marka = "AMD";

			Anakart anakart = new Anakart();
			
			// abstract classlardan instance alınamaz
			//BaseItem baseItem = new BaseItem();
			//baseItem.Marka = "abc";
			//baseItem.Model = "ads";
			//baseItem.Fiyat = 123;



			Console.WriteLine("Hello, World!");
		}
	}
}
