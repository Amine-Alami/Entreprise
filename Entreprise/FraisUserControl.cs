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
using System.Text.RegularExpressions;

namespace Entreprise
{
	public partial class FraisUserControl : UserControl
	{
		SqlDataReader dr;
		SqlCommand cmd = new SqlCommand();
		DataTable dt = new DataTable();
		DataTable dt2 = new DataTable();
		DataTable dt3 = new DataTable();
		int position = 0;
		string value;

		public FraisUserControl()
		{
			InitializeComponent();

			dr = MyClass.SelectAllFrom("Departement");
			dt.Load(dr);
			comboBox1.DataSource = dt;
			comboBox1.DisplayMember = "id";
			comboBox1.ValueMember = "id";
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			dt2.Clear();
			position = comboBox1.SelectedIndex;
			value = comboBox1.SelectedValue.ToString();
			txtNom.Text = dt.Rows[position][1].ToString();
			if(Regex.IsMatch(value, @"\d"))
			{
				if (MyClass.cnx.State == ConnectionState.Open)
					MyClass.cnx.Close();
				MyClass.cnx.Open();
				cmd.Connection = MyClass.cnx;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "SelectStageByDepartement";
				cmd.Parameters.Add(new SqlParameter("@idDep", value));
				dr = cmd.ExecuteReader();
				cmd.Parameters.Clear();
				dt2.Load(dr);
				bunifuCustomDataGrid1.DataSource = dt2;
			}
			float somme = 0;
			for(int i=0;i<bunifuCustomDataGrid1.RowCount;i++)
			{
				//int count = MyClass.GetCount(bunifuCustomDataGrid1.Rows[i].Cells[0].Value.ToString());
				somme = somme + float.Parse(bunifuCustomDataGrid1.Rows[i].Cells[4].Value.ToString());
			}

			TotalGeneral.Text = somme.ToString();
		}

		private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
			{
				bunifuCustomDataGrid1.CurrentRow.Selected = true;

				if (bunifuCustomDataGrid2.Rows.Count != 0)
				{
					dt3.Clear();
				}
				if (MyClass.cnx.State == ConnectionState.Open)
					MyClass.cnx.Close();
				MyClass.cnx.Open();
				cmd.Connection = MyClass.cnx;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "GetParticipants";
				cmd.Parameters.Add(new SqlParameter("@idDep", value));
				cmd.Parameters.Add(new SqlParameter("@idStage", bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value));
				dr = cmd.ExecuteReader();
				cmd.Parameters.Clear();
				dt3.Load(dr);
				bunifuCustomDataGrid2.DataSource = dt3;
			}
			float somme = float.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString()) * bunifuCustomDataGrid2.RowCount;
			Total.Text = somme.ToString();
		}
	}
}
