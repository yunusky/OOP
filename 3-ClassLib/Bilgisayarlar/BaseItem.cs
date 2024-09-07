using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Bilgisayarlar
{
	/*
	 * abstract classlardan instance alınamaz. ancak kalitim verebilir.
	 * varlik sebebide kalitim vermektir. yani base class olarak calisir.
	 * */
	public abstract class BaseItem
	{
		public string Marka { get; set; }
		public string Model { get; set; }
		public double Fiyat { get; set; }
	}
}
