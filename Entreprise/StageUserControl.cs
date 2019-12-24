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
	public partial class StageUserControl : UserControl
	{
		SqlDataReader dr;
		SqlCommand cmd = new SqlCommand();
		DataTable dt = new DataTable();
		int position;

		public StageUserControl()
		{
			InitializeComponent();
			ChargerDataGridView();

			dr = MyClass.SelectAllFrom("Stage");
			if (dr.HasRows)
			{
				dr.Read();
				txtID.Text = dr[0].ToString();
				txtNom.Text = dr[1].ToString();
				dateDebut.Value = (DateTime)dr[2];
				dateFin.Value = (DateTime)dr[3];
				txtFrais.Text = dr[4].ToString();
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
			dr = MyClass.SelectAllFrom("Stage");
			dt.Load(dr);
			bunifuCustomDataGrid1.DataSource = dt;
		}

		public void vider()
		{
			foreach (Control c in this.Controls)
			{
				if (c is TextBox)
					((TextBox)c).Text = string.Empty;
				dateDebut.ResetText();
				dateFin.ResetText();
			}
		}

		private void btnFirst_Click(object sender, EventArgs e)
		{
			position = 0;
			txtID.Text = dt.Rows[position][0].ToString();
			txtNom.Text = dt.Rows[position][1].ToString();
			dateDebut.Value = (DateTime)dt.Rows[position][2];
			dateFin.Value = (DateTime)dt.Rows[position][3];
			txtFrais.Text = dt.Rows[position][4].ToString();
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			position--;
			if (position >= 0)
			{
				txtID.Text = dt.Rows[position][0].ToString();
				txtNom.Text = dt.Rows[position][1].ToString();
				dateDebut.Value = (DateTime)dt.Rows[position][2];
				dateFin.Value = (DateTime)dt.Rows[position][3];
				txtFrais.Text = dt.Rows[position][4].ToString();
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
				dateDebut.Value = (DateTime)dt.Rows[position][2];
				dateFin.Value = (DateTime)dt.Rows[position][3];
				txtFrais.Text = dt.Rows[position][4].ToString();
			}
			else
				position = dt.Rows.Count - 1;
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			position = dt.Rows.Count - 1;
			txtID.Text = dt.Rows[position][0].ToString();
			txtNom.Text = dt.Rows[position][1].ToString();
			dateDebut.Value = (DateTime)dt.Rows[position][2];
			dateFin.Value = (DateTime)dt.Rows[position][3];
			txtFrais.Text = dt.Rows[position][4].ToString();
		}

		private void btnNouveau_Click(object sender, EventArgs e)
		{
			vider();
			int id = MyClass.GetLastid("Stage") + 1;
			txtID.Text = id.ToString();
		}

		private void btnSupprimer_Click(object sender, EventArgs e)
		{
			try
			{
				int id = int.Parse(txtID.Text);
				if (txtID.Text != "" && txtNom.Text != "" && txtFrais.Text != "")
				{
					DialogResult result = MessageBox.Show("Voulez vous vraiment supprimer stage " + txtNom.Text, "Confirmation", MessageBoxButtons.YesNo);
					if (result == DialogResult.Yes)
					{
						if (MyClass.cnx.State == ConnectionState.Open)
							MyClass.cnx.Close();
						MyClass.cnx.Open();
						cmd.Connection = MyClass.cnx;
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.CommandText = "DeleteStage";
						cmd.Parameters.Add(new SqlParameter("@idStag", id));
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
			if (txtID.Text != "" && txtNom.Text != "" && txtFrais.Text != "")
			{
				if (MyClass.cnx.State == ConnectionState.Open)
					MyClass.cnx.Close();
				MyClass.cnx.Open();
				cmd.Connection = MyClass.cnx;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "InsertStage";
				cmd.Parameters.Add(new SqlParameter("@nomStag", txtNom.Text));
				cmd.Parameters.Add(new SqlParameter("@frais", txtFrais.Text));
				cmd.Parameters.Add(new SqlParameter("@DateDebut", dateDebut.Value));
				cmd.Parameters.Add(new SqlParameter("@DateFin", dateFin.Value));
				
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
			if (txtID.Text != "" && txtNom.Text != "" && txtFrais.Text != "")
			{
				DialogResult result = MessageBox.Show("Confirmer la modification ", "Confirmation", MessageBoxButtons.OKCancel);
				if (result == DialogResult.OK)
				{
					if (MyClass.cnx.State == ConnectionState.Open)
						MyClass.cnx.Close();
					MyClass.cnx.Open();
					cmd.Connection = MyClass.cnx;
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "UpdateStage";
					cmd.Parameters.Add(new SqlParameter("@idStag", txtID.Text));
					cmd.Parameters.Add(new SqlParameter("@nomStag", txtNom.Text));
					cmd.Parameters.Add(new SqlParameter("@frais", txtFrais.Text));
					cmd.Parameters.Add(new SqlParameter("@DateDebut", dateDebut.Value));
					cmd.Parameters.Add(new SqlParameter("@DateFin", dateFin.Value));

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
				txtID.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
				txtNom.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
				dateDebut.Value = (DateTime)bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[2].Value;
				dateFin.Value = (DateTime)bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[3].Value;
				txtFrais.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
			}
		}
	}
}
