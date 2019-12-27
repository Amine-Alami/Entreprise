using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Entreprise
{
	public partial class DepartementUserControl : UserControl
	{
		SqlDataReader dr;
		SqlCommand cmd = new SqlCommand();
		DataTable dt = new DataTable();
		int position;

		public DepartementUserControl()
		{
			InitializeComponent();
			ChargerDataGridView();

			dr = MyClass.SelectAllFrom("Departement");
			if (dr.HasRows)
			{
				dr.Read();
				txtID.Text = dr[0].ToString();
				txtNom.Text = dr[1].ToString();
			}
			else
			{
				vider();
			}
		}

		public void ChargerDataGridView()
		{
			if (bunifuCustomDataGrid1.Rows.Count != 0){
				dt.Clear();
			}
			dr = MyClass.SelectAllFrom("Departement");
			dt.Load(dr);
			bunifuCustomDataGrid1.DataSource = dt;
		}

		public void vider()
		{
			foreach (Control c in this.Controls)
			{
				if (c is TextBox)
					((TextBox)c).Text = string.Empty;
			}
		}
		

		private void btnFirst_Click(object sender, EventArgs e)
		{
			position = 0;
			txtID.Text = dt.Rows[position][0].ToString();
			txtNom.Text = dt.Rows[position][1].ToString();
			bunifuCustomDataGrid1.Rows[position].Selected = true;
			bunifuCustomDataGrid1.FirstDisplayedScrollingRowIndex = bunifuCustomDataGrid1.SelectedRows[0].Index;
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			position--;
			if (position >= 0)
			{
				txtID.Text = dt.Rows[position][0].ToString();
				txtNom.Text = dt.Rows[position][1].ToString();
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
				txtID.Text = dt.Rows[position][0].ToString();
				txtNom.Text = dt.Rows[position][1].ToString();
				bunifuCustomDataGrid1.Rows[position].Selected = true;
				bunifuCustomDataGrid1.FirstDisplayedScrollingRowIndex = bunifuCustomDataGrid1.SelectedRows[0].Index;
			}
			else
				position = dt.Rows.Count - 1;
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			position = dt.Rows.Count - 1;
			txtID.Text = dt.Rows[position][0].ToString();
			txtNom.Text = dt.Rows[position][1].ToString();
			bunifuCustomDataGrid1.Rows[position].Selected = true;
			bunifuCustomDataGrid1.FirstDisplayedScrollingRowIndex = bunifuCustomDataGrid1.SelectedRows[0].Index;
		}

		private void bunifuFlatButton4_Click(object sender, EventArgs e)
		{
			
		}

		private void btnAjouter_Click(object sender, EventArgs e)
		{
			if(txtID.Text != "" && txtNom.Text != "")
			{
				if (MyClass.cnx.State == ConnectionState.Open)
					MyClass.cnx.Close();
				MyClass.cnx.Open();
				cmd.Connection = MyClass.cnx;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "InsertDepartement";
				cmd.Parameters.Add(new SqlParameter("@nomDep", txtNom.Text));
				cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				ChargerDataGridView();
			}
			else{
				MessageBox.Show("Les champs ne doivent pas etre vides !","Error");
			}
		}

		private void btnSupprimer_Click(object sender, EventArgs e)
		{
			try{
				int id = int.Parse(txtID.Text);
				if (txtID.Text != "" && txtNom.Text != "")
				{
					DialogResult result =  MessageBox.Show("Voulez vous vraiment supprimer departement "+txtNom.Text, "Confirmation",MessageBoxButtons.YesNo);
					if(result == DialogResult.Yes){
						if (MyClass.cnx.State == ConnectionState.Open)
							MyClass.cnx.Close();
						MyClass.cnx.Open();
						cmd.Connection = MyClass.cnx;
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.CommandText = "DeleteDepartement";
						cmd.Parameters.Add(new SqlParameter("@idDep", id));
						cmd.ExecuteNonQuery();
						cmd.Parameters.Clear();
						ChargerDataGridView();
					}
				}
				else
				{
					MessageBox.Show("Les champs ne doivent pas etre vides !", "Error");
				}
			}catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnModifier_Click(object sender, EventArgs e)
		{

			if (txtID.Text != "" && txtNom.Text != "")
			{
				DialogResult result = MessageBox.Show("Confirmer la modification ", "Confirmation", MessageBoxButtons.OKCancel);
				if (result == DialogResult.OK)
				{
					if (MyClass.cnx.State == ConnectionState.Open)
						MyClass.cnx.Close();
					MyClass.cnx.Open();
					cmd.Connection = MyClass.cnx;
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "UpdateDepartement";
					cmd.Parameters.Add(new SqlParameter("@idDep", int.Parse(txtID.Text)));
					cmd.Parameters.Add(new SqlParameter("@nomDep", txtNom.Text));
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
			if(bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
			{
				bunifuCustomDataGrid1.CurrentRow.Selected = true;
				txtID.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
				txtNom.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
			}
		}

		private void btnNouveau_Click(object sender, EventArgs e)
		{
			vider();
			int id = MyClass.GetLastid("Departement") + 1;
			txtID.Text = id.ToString();
		}
	}
}
