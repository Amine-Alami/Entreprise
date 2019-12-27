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

namespace Entreprise
{
	public partial class DateUserControl : UserControl
	{
		SqlDataReader dr;
		SqlCommand cmd = new SqlCommand();
		DataTable dt = new DataTable();
		DataTable dt2 = new DataTable();
		DataTable dt3 = new DataTable();

		public DateUserControl()
		{
			InitializeComponent();
		}

		private void dateDebut_onValueChanged(object sender, EventArgs e)
		{
			dt.Clear();
			DateTime date = dateDebut.Value;
			string sqlFormattedDate = date.ToString("yyyy-MM-dd");

			if (MyClass.cnx.State == ConnectionState.Open)
				MyClass.cnx.Close();
			MyClass.cnx.Open();
			cmd.Connection = MyClass.cnx;
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "GetStageByDate";
			cmd.Parameters.Add(new SqlParameter("@date", sqlFormattedDate));
			dr = cmd.ExecuteReader();
			cmd.Parameters.Clear();
			dt.Load(dr);
			bunifuCustomDataGrid1.DataSource = dt;
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
				cmd.CommandText = "GetParticipants2";
				cmd.Parameters.Add(new SqlParameter("@idStage", bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value));
				dr = cmd.ExecuteReader();
				cmd.Parameters.Clear();
				dt3.Load(dr);
				bunifuCustomDataGrid2.DataSource = dt3;
			}
			float somme = float.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString()) * bunifuCustomDataGrid2.RowCount;
			TotalGeneral.Text = somme.ToString();
		}
	}
}
