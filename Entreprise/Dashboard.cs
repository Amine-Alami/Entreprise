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
			pictureBox6.BringToFront();
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{
			
		}
		
		public void HideAllUserControls()
		{
			departementUserControl1.Hide();
			employeUserControl1.Hide();
			stageUserControl1.Hide();
			participantUserControl2.Hide();
			pictureBox6.Hide();
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			HideAllUserControls();
			pictureBox6.Show();
			pictureBox6.BringToFront();
		}

		private void btnDepartement_Click(object sender, EventArgs e)
		{
			HideAllUserControls();
			departementUserControl1.Show();
			departementUserControl1.BringToFront();
		}

		private void btnEmploye_Click(object sender, EventArgs e)
		{
			HideAllUserControls();
			employeUserControl1.Show();
			employeUserControl1.BringToFront();

		}

		private void btnStage_Click(object sender, EventArgs e)
		{
			HideAllUserControls();
			stageUserControl1.Show();
			stageUserControl1.BringToFront();
		}

		private void btnParticipant_Click(object sender, EventArgs e)
		{
			HideAllUserControls();
			participantUserControl2.Show();
			participantUserControl2.BringToFront();
		}
	}
}
