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


    }
}
