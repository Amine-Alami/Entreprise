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
	public partial class EmployeUserControl : UserControl
	{
		SqlDataReader dr;
		SqlCommand cmd = new SqlCommand();
		DataTable dt = new DataTable();
		DataTable dt2 = new DataTable();
		int position;

		public EmployeUserControl()
		{
			InitializeComponent();
			ChargerDataGridView();

			dr = MyClass.SelectAllFrom("Employe");
			if (dr.HasRows)
			{
				dr.Read();
				txtID.Text = dr[0].ToString();
				comboBox1.Text = dr[1].ToString();
				txtNom.Text = dr[2].ToString();
				txtGrade.Text = dr[3].ToString();
				txtSalaire.Text = dr[4].ToString();
				byte[] byteBLOBData = (byte[])dr[5];
				btnPhoto.Image = ToImage(byteBLOBData);
			}
			else
			{
				vider();
			}

			dr = MyClass.SelectAllFrom("Departement");
			dt2.Load(dr);
			comboBox1.DataSource = dt2;
			comboBox1.DisplayMember = "id";
			comboBox1.ValueMember = "id";
		}

		public static Image ToImage(byte[] data)
		{
			if (data == null)
			{
				return null;
			}
			Image img;
			using (MemoryStream stream = new MemoryStream(data))
			{
				using (Image temp = Image.FromStream(stream))
				{
					img = new Bitmap(temp);
				}
			}
			return img;
		}

		public void ChargerDataGridView()
		{
			if (bunifuCustomDataGrid1.Rows.Count != 0)
			{
				dt.Clear();
			}
			dr = MyClass.SelectAllFrom("Employe");
			dt.Load(dr);
			bunifuCustomDataGrid1.DataSource = dt;
		}

		public void vider()
		{
			foreach (Control c in this.Controls)
			{
				if (c is TextBox)
					((TextBox)c).Text = string.Empty;
				comboBox1.Text = null;
				btnPhoto.ImageLocation = @"C:/Users/hp/Desktop/EntrepriseIcons/user-2493635_640.png";
			}
		}

		private void btnFirst_Click(object sender, EventArgs e)
		{
			position = 0;
			txtID.Text = dt.Rows[position][0].ToString();
			comboBox1.Text = dt.Rows[position][1].ToString();
			txtNom.Text = dt.Rows[position][2].ToString();
			txtGrade.Text = dt.Rows[position][3].ToString();
			txtSalaire.Text = dt.Rows[position][4].ToString();
			byte[] byteBLOBData = (byte[])dt.Rows[position][5];
			btnPhoto.Image = ToImage(byteBLOBData);
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			position--;
			if (position >= 0)
			{
				txtID.Text = dt.Rows[position][0].ToString();
				comboBox1.Text = dt.Rows[position][1].ToString();
				txtNom.Text = dt.Rows[position][2].ToString();
				txtGrade.Text = dt.Rows[position][3].ToString();
				txtSalaire.Text = dt.Rows[position][4].ToString();
				byte[] byteBLOBData = (byte[])dt.Rows[position][5];
				btnPhoto.Image = ToImage(byteBLOBData);
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
				comboBox1.Text = dt.Rows[position][1].ToString();
				txtNom.Text = dt.Rows[position][2].ToString();
				txtGrade.Text = dt.Rows[position][3].ToString();
				txtSalaire.Text = dt.Rows[position][4].ToString();
				byte[] byteBLOBData = (byte[])dt.Rows[position][5];
				btnPhoto.Image = ToImage(byteBLOBData);
			}
			else
				position = dt.Rows.Count - 1;
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			position = dt.Rows.Count - 1;
			txtID.Text = dt.Rows[position][0].ToString();
			comboBox1.Text = dt.Rows[position][1].ToString();
			txtNom.Text = dt.Rows[position][2].ToString();
			txtGrade.Text = dt.Rows[position][3].ToString();
			txtSalaire.Text = dt.Rows[position][4].ToString();
			byte[] byteBLOBData = (byte[])dt.Rows[position][5];
			btnPhoto.Image = ToImage(byteBLOBData);
		}

		private void btnNouveau_Click(object sender, EventArgs e)
		{
			vider();
			int id = MyClass.GetLastid("Employe") + 1;
			txtID.Text = id.ToString();
		}

		private void btnSupprimer_Click(object sender, EventArgs e)
		{
			try
			{
				int id = int.Parse(txtID.Text);
				if (txtID.Text != "" && txtNom.Text != "" && txtGrade.Text != "" && txtSalaire.Text != "")
				{
					DialogResult result = MessageBox.Show("Voulez vous vraiment supprimer employée " + txtNom.Text, "Confirmation", MessageBoxButtons.YesNo);
					if (result == DialogResult.Yes)
					{
						if (MyClass.cnx.State == ConnectionState.Open)
							MyClass.cnx.Close();
						MyClass.cnx.Open();
						cmd.Connection = MyClass.cnx;
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.CommandText = "DeleteEmploye";
						cmd.Parameters.Add(new SqlParameter("@idEmp", id));
						cmd.ExecuteNonQuery();
						cmd.Parameters.Clear();
						ChargerDataGridView();
					}
				}
				else
				{
					MessageBox.Show("Les champs ne doivent pas etre vides !", "Error");
				}
			}catch (Exception ex){
				MessageBox.Show(ex.Message);
			}
		}

		private void btnAjouter_Click(object sender, EventArgs e)
		{
			if (txtID.Text != "" && txtNom.Text != "" && txtGrade.Text != "" && txtSalaire.Text != "")
			{
				if (MyClass.cnx.State == ConnectionState.Open)
					MyClass.cnx.Close();
				MyClass.cnx.Open();
				cmd.Connection = MyClass.cnx;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "InsertEmploye";
				cmd.Parameters.Add(new SqlParameter("@idDep", comboBox1.Text));
				cmd.Parameters.Add(new SqlParameter("@nomEmp", txtNom.Text));
				cmd.Parameters.Add(new SqlParameter("@gradEmp", txtGrade.Text));
				cmd.Parameters.Add(new SqlParameter("@salaire", txtSalaire.Text));
				
				byte[] data;
				using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
				{
					btnPhoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
					data = stream.ToArray();
				}
				cmd.Parameters.Add(new SqlParameter("@photoEmp", data));
				cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				ChargerDataGridView();
			}
			else
			{
				MessageBox.Show("Les champs ne doivent pas etre vides !", "Error");
			}
		}

		private void btnPhoto_Click(object sender, EventArgs e)
		{
			OpenFileDialog opnfd = new OpenFileDialog();
			opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png;)|*.jpg;*.jpeg;.*.gif;*.png;*.ico;";
			if (opnfd.ShowDialog() == DialogResult.OK)
			{
				btnPhoto.Image = new Bitmap(opnfd.FileName);
			}
		}

		private void btnModifier_Click(object sender, EventArgs e)
		{
			if (txtID.Text != "" && txtNom.Text != "" && txtGrade.Text != "" && txtSalaire.Text != "")
			{
				DialogResult result = MessageBox.Show("Confirmer la modification ", "Confirmation", MessageBoxButtons.OKCancel);
				if (result == DialogResult.OK)
				{
					if (MyClass.cnx.State == ConnectionState.Open)
						MyClass.cnx.Close();
					MyClass.cnx.Open();
					cmd.Connection = MyClass.cnx;
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "UpdateEmploye";
					cmd.Parameters.Add(new SqlParameter("@idEmp", txtID.Text));
					cmd.Parameters.Add(new SqlParameter("@idDep", comboBox1.Text));
					cmd.Parameters.Add(new SqlParameter("@nomEmp", txtNom.Text));
					cmd.Parameters.Add(new SqlParameter("@gradEmp", txtGrade.Text));
					cmd.Parameters.Add(new SqlParameter("@salaire", txtSalaire.Text));
					byte[] data;
					using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
					{
						btnPhoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
						data = stream.ToArray();
					}
					cmd.Parameters.Add(new SqlParameter("@photoEmp", data));
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
				comboBox1.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
				txtNom.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
				txtGrade.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
				txtSalaire.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
				byte[] byteBLOBData = (byte[])bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[5].Value;
				btnPhoto.Image = ToImage(byteBLOBData);
			}
		}
	}
}
