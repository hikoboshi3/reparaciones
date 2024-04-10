using Microsoft.AspNetCore;

using System.Buffers.Text;
using System.Data;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.RegularExpressions;


namespace reparaciones.DAL
{
    public class persistencia
    {
        private DataContextADO con = new DataContextADO();
        public string Empresa()
        {

            string baseDatos = "DB";

            DataTable _dt = new DataTable();
            SqlConnection connection = new SqlConnection(con.connString[baseDatos]);
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetDesperfecto";
            // cmd.Parameters.Add("@id", SqlDbType.BigInt).Direction = ParameterDirection.Output;
            // cmd.Parameters.AddWithValue("@cod_empresa", "185641");

            _dt.Load(cmd.ExecuteReader());
            return _dt.Rows[0][0].ToString();


        }


    }
}
