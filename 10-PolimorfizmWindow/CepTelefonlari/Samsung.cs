﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _10_PolimorfizmWindow.CepTelefonlari
{
	public class Samsung:BasePhone
	{
		public virtual void CallSound()
		{
			using (SoundPlayer player = new SoundPlayer(@"..\..\..\Sounds\samsung.wav"))
			{
				player.Play();
			}
		}
	}
}
