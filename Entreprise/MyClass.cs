using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entreprise
{
	class MyClass
	{
		public static SqlConnection cnx = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Entreprise;Integrated Security=True");
		public static SqlCommand cmd = new SqlCommand();
		public static SqlDataReader dr;
		public static DataTable dt = new DataTable();

		public static int GetLastid(string nom)
		{
			int id;
			if (cnx.State == ConnectionState.Open)
				cnx.Close();
			cnx.Open();
			cmd.Connection = cnx;
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "GetLastId";
			cmd.Parameters.Add(new SqlParameter("@tableName", nom));
			dr = cmd.ExecuteReader();
			dt.Load(dr);
			id = int.Parse(dt.Rows[0][0].ToString());
			cmd.Parameters.Clear();
			return id;
		}

		public static SqlDataReader SelectAllFrom(string nom)
		{
			if (cnx.State == ConnectionState.Open)
				cnx.Close();
			cnx.Open();
			cmd.Connection = cnx;
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SelectALL"+nom;
			dr = cmd.ExecuteReader();

			return dr;
		}

		public static SqlDataReader GetAllId(string nom)
		{
			if (cnx.State == ConnectionState.Open)
				cnx.Close();
			cnx.Open();
			cmd.Connection = cnx;
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "GetAllId" + nom;
			dr = cmd.ExecuteReader();

			return dr;
		}
	}
}
