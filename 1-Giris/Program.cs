﻿namespace _1_Giris
{
	public struct Kisi
	{
		public string Ad;
		public string Soyad;
		string _TcNo;
		public string Gsm;

		//Kontrollu veri girisi. Tc numarası illa 11 karakter olacak
		public void SetTcNo(string value)
		{
			if (!string.IsNullOrEmpty(value) && value.Length == 11)
			{
				_TcNo = value;
			}
		}

		// TcNo'nun son 4 hanesini gostermek

		public string GetTcNo()
		{
			if (string.IsNullOrEmpty(_TcNo))
				return _TcNo.Substring(7);
			else return "";
		}

	}
	public class Personel
	{
		string _TcNo;
		string _Ad;
		public string Ad
		{
			get
			{
				return _Ad;
			}
			set
			{
				if (!string.IsNullOrEmpty(_Ad)) _Ad = value;
			}
		}
		public string Soyad { get; set; }
		public string TcNo
		{
			get
			{
				if (!string.IsNullOrEmpty(_TcNo))
					return _TcNo.Substring(7);
				else return "";
			}
			set
			{
				if (!string.IsNullOrEmpty(value) && _TcNo.Length == 11)
					_TcNo = value;
			}
		}
		public string Gsm { get; set; } = string.Empty;
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			#region Struct ile Calismak
			Kisi kisi = new Kisi();
			kisi.Ad = "Ali";
			kisi.Soyad = "Yilmaz";
			kisi.SetTcNo("12312312312");
			Console.WriteLine(kisi.GetTcNo());
			#endregion

			#region Class ile Calismak 
			Personel personel = new Personel();
			personel.Ad = "Veli";

			#endregion

		}
	}
}
