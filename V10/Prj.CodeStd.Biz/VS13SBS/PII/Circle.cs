using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prj.CodeStd.Biz.VS13SBS.PII
{
	public class Circle
	{
		public int radius;

		double Area()
		{
			return Math.PI * radius * radius;
		}
	}
}
