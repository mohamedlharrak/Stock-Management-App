using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gestion_De_Stock.DAL
{
    class DataAccessLayer
    {
        SqlConnection SqlConnection; // Object the connetion
        // this constrectur inisialize the connection object
        public DataAccessLayer()
        {
            SqlConnection = new SqlConnection(@"Server = .\SQLEXPRESS; Database = Gestion_DB; Integrated Security = true");
        }
        //open conx
        public void Open()
        {
            if (SqlConnection.State!=ConnectionState.Open)
            {
                SqlConnection.Open();
            }
        }
        //Close conx
        public void Close()
        {
            if (SqlConnection.State == ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }
        //Read data from database
        public DataTable SelectData(String Stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Stored_procedure;
            sqlcmd.Connection = SqlConnection;
            if (param != null)
            {
                for(int i=0; i<param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // insert, update, and delet data from database
        public void ExecuteCommand(String Stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Stored_procedure;
            sqlcmd.Connection = SqlConnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }
    }
}
