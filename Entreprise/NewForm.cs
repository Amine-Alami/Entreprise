using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Entreprise
{
	public partial class NewForm : Form
	{
		public static string NewIDEmp;
		public static string NewIDStage;

		SqlDataReader dr;
		DataTable dt2 = new DataTable();
		DataTable dt3 = new DataTable();

		public NewForm()
		{
			InitializeComponent();

			dr = MyClass.SelectAllFrom("Employe");
			dt2.Load(dr);
			cbEmp.DataSource = dt2;
			cbEmp.DisplayMember = "id";
			cbEmp.ValueMember = "id";

			dr = MyClass.SelectAllFrom("Stage");
			dt3.Load(dr);
			cbStage.DataSource = dt3;
			cbStage.DisplayMember = "id";
			cbStage.ValueMember = "id";
		}

		private void btnNouveau_Click(object sender, EventArgs e)
		{
			NewIDEmp = cbEmp.Text;
			NewIDStage = cbStage.Text;
			this.Hide();
		}
	}
}
