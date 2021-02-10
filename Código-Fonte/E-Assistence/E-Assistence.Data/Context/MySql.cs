using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using MySql.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace E_Assistence.Data.Context
{
	public class MySql
	{ 
		public MySql(string connectionString)
		{
			MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

			try
			{
				mySqlConnection.Open();
			}
			catch (Exception ex)
			{
				ex.Message.ToString();
				
			}

			if (mySqlConnection.State == ConnectionState.Open)
			{
				// MySqlDataAdapter mAdapter = new MySqlDataAdapter("SELECT * FROM Pessoas", mySqlConnection);


			}
			else
			{
				mySqlConnection.Close();
			}

		

		}
	}
	
}
