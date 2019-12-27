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
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();

			HideAllUserControls();
			pictureBox6.Show();
			
		}
		
		public void HideAllUserControls()
		{
			departementUserControl1.Hide();
			employeUserControl1.Hide();
			stageUserControl1.Hide();
			participantUserControl2.Hide();
			fraisUserControl1.Hide();
			dateUserControl1.Hide();
			pictureBox6.Hide();
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			HideAllUserControls();
			pictureBox6.Show();
			
		}

		private void btnDepartement_Click(object sender, EventArgs e)
		{
			HideAllUserControls();
			departementUserControl1.Show();
			
		}

		private void btnEmploye_Click(object sender, EventArgs e)
		{
			HideAllUserControls();
			employeUserControl1.Show();
			

		}

		private void btnStage_Click(object sender, EventArgs e)
		{
			HideAllUserControls();
			stageUserControl1.Show();
			
		}

		private void btnParticipant_Click(object sender, EventArgs e)
		{
			HideAllUserControls();
			participantUserControl2.Show();
			
		}

		public async void WaitSomeTime()
		{
			await Task.Delay(1);
			
		}

		public void panelSlideIN()
		{
			while (panel1.Width > 138)
			{
				//WaitSomeTime();
				panel1.Width = panel1.Width - 1;
			}
			
		}

		public void panelSlideOUT()
		{
			while (panel1.Width < 298)
			{
				//WaitSomeTime();
				panel1.Width = panel1.Width + 1;
			}
		}

		private void bunifuFlatButton1_MouseLeave(object sender, EventArgs e)
		{
			panelSlideIN();
		}

		private void bunifuFlatButton1_MouseHover(object sender, EventArgs e)
		{
			panelSlideOUT();
		}

		private void bunifuFlatButton2_MouseHover(object sender, EventArgs e)
		{
			panelSlideOUT();
		}

		private void bunifuFlatButton2_MouseLeave(object sender, EventArgs e)
		{
			panelSlideIN();
		}

		private void bunifuFlatButton1_Click(object sender, EventArgs e)
		{
			HideAllUserControls();
			fraisUserControl1.Show();
		}

		private void bunifuFlatButton2_Click(object sender, EventArgs e)
		{
			HideAllUserControls();
			dateUserControl1.Show();
		}
	}
}
