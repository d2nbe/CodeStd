using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prj.CodeStd.Biz.VS13SBS.PII
{
	public class Circle
	{
		////
		public int radius;

		////
		double Area()
		{
			return Math.PI * radius * radius;
		}

		public static int SumParams(params int[] nArrayValues)
		{
			int nTotal = 0;
			foreach (int nValue in nArrayValues)
			{
				nTotal += nValue;
			}
			return nTotal;
		}
	}
}
