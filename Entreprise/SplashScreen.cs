using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entreprise
{
	public partial class SplashScreen : Form
	{
		

		public SplashScreen()
		{
			InitializeComponent();
			
			timer2.Interval = 1;
			timer2.Start();
			
		}
		
		private void timer1_Tick(object sender, EventArgs e)
		{
			
			//if(panel1.Width < 600){
			//	panel1.Width += 15;
			//}else{
			//	timer1.Stop();
			//	timer2.Interval = 1;
			//	timer2.Start();
			//}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			if (panel3.Width < 800)
			{
				panel3.Width += 3;
			}
			else
			{
				timer2.Stop();
				Dashboard d = new Dashboard();
				d.Show();
				this.Hide();
			}
		}
	}
}
