using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Bilgisayarlar
{
	public class OyuncuBilgisayarı
	{
		public Anakart Anakart { get; set; } = new Anakart();
		public Cpu Cpu { get; set; } = new Cpu("Intel","I9",8,5000);
		public List<Ram> Ramlar { get; set; } = new List<Ram>();
		public List<EkranKarti> EkranKartlari { get; set; } = new List<EkranKarti>();
		public List<HardDisk> Diskler { get; set; } = new List<HardDisk>();
		public int Adet { get; set; }
		public string Aciklama { get; set; } = string.Empty;

        public OyuncuBilgisayarı()
        {
			Anakart.Marka = "Gigabyte";
			Cpu.Marka = "Asus";
        }

		public bool RamEkle(Ram ram)
		{
			Ramlar.Add(ram);
			return true;
		}
		public bool DiskEkle(HardDisk hardDisk)
		{
			Diskler.Add(hardDisk);
			return true;
		}

		public double FiyatHesapla()
		{
			double toplamTutar = 0;
			foreach (var ram in Ramlar)
			{
				toplamTutar += toplamTutar + ram.Fiyat;
			}
			foreach (var disk in Diskler)
			{
				toplamTutar += toplamTutar + disk.Fiyat;
			}
			foreach (var ekran in EkranKartlari)
			{
				toplamTutar += toplamTutar + ekran.Fiyat;
			}
			toplamTutar += Anakart.Fiyat;
			toplamTutar += Cpu.Fiyat;

			return toplamTutar;
		}
    }
}
