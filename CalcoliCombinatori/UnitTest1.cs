﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcoliCombinatori.Test
{
	[TestClass]
	public class CalcoliCombinatori
	{
		[DataTestMethod]
		[DataRow(5, 120)]
		[DataRow(-4, 24)]
		[DataRow(0, 1)]
		[DataRow(1, 1)]
		[DataRow(10, 3628800)]
		[DataRow(20, 2432902008176640000)]
		public void TestFattoriale(int num, long fattorialeAsp)
		{
			long fattoriale = EquazioniLibrary.CalcoliCombinatori.Fattoriale(num);
			Assert.AreEqual(fattorialeAsp, fattoriale);
		}
	}
}