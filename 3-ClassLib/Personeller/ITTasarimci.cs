﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Personeller
{
	public class ITTasarimci:Personel
	{
        public ITTasarimci()
        {
            Maas = base.Maas * 2;
        }
    }
}
