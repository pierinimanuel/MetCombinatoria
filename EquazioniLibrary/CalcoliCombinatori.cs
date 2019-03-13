using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
	public static class CalcoliCombinatori
	{
		public static long Fattoriale(int num)
		{
			if (num < 0)
			{
				num = num * (-1);
			}
			long fattoriale = 1;
			for (int i = num; i > 0; i--)
			{
				fattoriale = fattoriale * i;
			}

			return fattoriale;
		}
	}
}