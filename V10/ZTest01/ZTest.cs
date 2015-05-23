using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TBiz = Prj.CodeStd.Biz;
//using TBiz.VS13SBS.PII = Prj.CodeStd.Biz.VS13SBS.PII;

namespace ZTest01
{
	public partial class ZTest : Form
	{
		#region // Constructors and Destructors:
		public ZTest()
		{
			InitializeComponent();
		}
		#endregion

		#region // TestMix:
		private void btnTestMix_Click(object sender, EventArgs e)
		{
			try
			{
				TestMix_01_CallService();
			}
			catch (Exception)
			{				
				throw;
			}
		}
		#endregion

		#region // TestMix_01_CallService:
		private void TestMix_01_CallService()
		{
			////
			bool bTest = false;

			////
			if (!bTest)
			{
				////
				TBiz.VS13SBS.PII.Circle c = new TBiz.VS13SBS.PII.Circle();
				c.radius = 28;
				TBiz.VS13SBS.PII.Circle d;
				d = c;	
				////
				d.radius = d.radius - 1;

				////
				int nTotal = TBiz.VS13SBS.PII.Circle.SumParams(new int[] {2, 4});

			}			
		}
		#endregion
		
		
	}
}
