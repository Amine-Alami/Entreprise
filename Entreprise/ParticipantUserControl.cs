using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Entreprise
{
	public partial class ParticipantUserControl : UserControl
	{
		SqlDataReader dr;
		SqlCommand cmd = new SqlCommand();
		DataTable dt = new DataTable();
		DataTable dt2 = new DataTable();
		DataTable dt3 = new DataTable();
		int position;

		public ParticipantUserControl()
		{
			InitializeComponent();
			ChargerDataGridView();

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

			
			dr = MyClass.SelectAllFrom("Participer");
			if (dr.HasRows)
			{
				dr.Read();
				cbEmp.Text = dr[0].ToString();
				cbStage.Text = dr[1].ToString();
			}
			else
			{
				vider();
			}

			
		}

		public void ChargerDataGridView()
		{
			if (bunifuCustomDataGrid1.Rows.Count != 0)
			{
				dt.Clear();
			}
			dr = MyClass.SelectAllFrom("Participer");
			dt.Load(dr);
			bunifuCustomDataGrid1.DataSource = dt;
		}

		public void vider()
		{
			foreach (Control c in this.Controls)
			{
				cbEmp.Text = null;
				cbStage.Text = null;
			}
		}

		private void btnFirst_Click(object sender, EventArgs e)
		{
			position = 0;
			cbEmp.Text = dt.Rows[position][0].ToString();
			cbStage.Text = dt.Rows[position][1].ToString();
			bunifuCustomDataGrid1.Rows[position].Selected = true;
			bunifuCustomDataGrid1.FirstDisplayedScrollingRowIndex = bunifuCustomDataGrid1.SelectedRows[0].Index;
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			position--;
			if (position >= 0)
			{
				cbEmp.Text = dt.Rows[position][0].ToString();
				cbStage.Text = dt.Rows[position][1].ToString();
				bunifuCustomDataGrid1.Rows[position].Selected = true;
				bunifuCustomDataGrid1.FirstDisplayedScrollingRowIndex = bunifuCustomDataGrid1.SelectedRows[0].Index;
			}
			else
				position = 0;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			position++;
			if (position <= dt.Rows.Count - 1)
			{
				cbEmp.Text = dt.Rows[position][0].ToString();
				cbStage.Text = dt.Rows[position][1].ToString();
				bunifuCustomDataGrid1.Rows[position].Selected = true;
				bunifuCustomDataGrid1.FirstDisplayedScrollingRowIndex = bunifuCustomDataGrid1.SelectedRows[0].Index;
			}
			else
				position = dt.Rows.Count - 1;
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			position = dt.Rows.Count - 1;
			cbEmp.Text = dt.Rows[position][0].ToString();
			cbStage.Text = dt.Rows[position][1].ToString();
			bunifuCustomDataGrid1.Rows[position].Selected = true;
			bunifuCustomDataGrid1.FirstDisplayedScrollingRowIndex = bunifuCustomDataGrid1.SelectedRows[0].Index;
		}

		private void btnNouveau_Click(object sender, EventArgs e)
		{
			vider();
		}

		private void btnSupprimer_Click(object sender, EventArgs e)
		{
			try
			{
				
				if (cbEmp.Text != "" && cbStage.Text != "")
				{
					DialogResult result = MessageBox.Show("Voulez vous vraiment supprimer cette participation ", "Confirmation", MessageBoxButtons.YesNo);
					if (result == DialogResult.Yes)
					{
						if (MyClass.cnx.State == ConnectionState.Open)
							MyClass.cnx.Close();
						MyClass.cnx.Open();
						cmd.Connection = MyClass.cnx;
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.CommandText = "DeleteParticipe";
						cmd.Parameters.Add(new SqlParameter("@idEmp", cbEmp.Text));
						cmd.Parameters.Add(new SqlParameter("@idStag", cbStage.Text));
						cmd.ExecuteNonQuery();
						cmd.Parameters.Clear();
						ChargerDataGridView();
					}
				}
				else
				{
					MessageBox.Show("Les champs ne doivent pas etre vides !", "Error");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnAjouter_Click(object sender, EventArgs e)
		{
			if (cbEmp.Text != "" && cbStage.Text != "")
			{
				if (MyClass.cnx.State == ConnectionState.Open)
					MyClass.cnx.Close();
				MyClass.cnx.Open();
				cmd.Connection = MyClass.cnx;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "InsertParticipe";
				cmd.Parameters.Add(new SqlParameter("@idEmp", cbEmp.Text));
				cmd.Parameters.Add(new SqlParameter("@idStag", cbStage.Text));
				
				cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				ChargerDataGridView();
			}
			else
			{
				MessageBox.Show("Les champs ne doivent pas etre vides !", "Error");
			}
		}
		

		private void btnModifier_Click(object sender, EventArgs e)
		{
			NewForm f = new NewForm();
			f.ShowDialog();
			
			if (cbEmp.Text != "" && cbStage.Text != "")
			{
				DialogResult result = MessageBox.Show("Confirmer la modification ", "Confirmation", MessageBoxButtons.OKCancel);
				if (result == DialogResult.OK)
				{
					if (MyClass.cnx.State == ConnectionState.Open)
						MyClass.cnx.Close();
					MyClass.cnx.Open();
					cmd.Connection = MyClass.cnx;
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "UpdateParticipe";
					

					cmd.Parameters.Add(new SqlParameter("@LastidEmp", cbEmp.Text));
					cmd.Parameters.Add(new SqlParameter("@LastidStag", cbStage.Text));
					cmd.Parameters.Add(new SqlParameter("@NewidEmp", NewForm.NewIDEmp));
					cmd.Parameters.Add(new SqlParameter("@NewidStag", NewForm.NewIDStage));
					
					cmd.ExecuteNonQuery();
					cmd.Parameters.Clear();
					ChargerDataGridView();
				}
			}
			else
			{
				MessageBox.Show("Les champs ne doivent pas etre vides !", "Error");
			}
		}

		private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
			{
				bunifuCustomDataGrid1.CurrentRow.Selected = true;
				cbEmp.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
				cbStage.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
				
			}
		}
	}
}
