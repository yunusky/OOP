﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Personeller
{
	public class InsanKaynaklari : Personel
	{
		public InsanKaynaklari()
		{
			Maas = base.Maas * 2;
		}

		public void IsAlımGorusmesiYap()
		{

		}

		public void BordoHazirla() { }

		public void OryantasyonuSagla()
		{

		}

		public void IStenCikart()
		{

		}
	}
}
