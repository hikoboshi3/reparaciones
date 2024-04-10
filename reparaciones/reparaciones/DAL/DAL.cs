using Microsoft.AspNetCore;

using System.Buffers.Text;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using Microsoft.SqlServer;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text.Json;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Modelos.Entidades;

namespace reparaciones.DAL
{
    public class DAL
    {

        private DataContextADO con = new DataContextADO();

        public Int64 AltaAutomovil(Modelos.Entidades.Automovil auto)
        {
            Int64 i = 0;
            string baseDatos = "DB";
            DataTable _dt = new DataTable();

           SqlConnection connection = new SqlConnection(con.connString[baseDatos]);

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Automovil_I";
                cmd.Parameters.AddWithValue("@Marca", auto.marca);
                cmd.Parameters.AddWithValue("@Modelo", auto.modelo);
                cmd.Parameters.AddWithValue("@Patente", auto.patente);
                cmd.Parameters.AddWithValue("@Tipo", auto.tipo);
                cmd.Parameters.AddWithValue("@CantidadPuertas", auto.cantidad_puertas);
                _dt.Load(cmd.ExecuteReader());

                i= Convert.ToInt64(_dt.Rows[0][0].ToString());
            }
            catch(Exception e)
            { 
                i=  0;
            }
            return i; 
        }

        public Int64 AltaMoto(Modelos.Entidades.Moto moto)
        {
            Int64 i = 0;
            string baseDatos = "DB";
            DataTable _dt = new DataTable();

            SqlConnection connection = new SqlConnection(con.connString[baseDatos]);

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Moto_I";
                cmd.Parameters.AddWithValue("@Marca", moto.marca);
                cmd.Parameters.AddWithValue("@Modelo", moto.modelo);
                cmd.Parameters.AddWithValue("@Patente", moto.patente);
                cmd.Parameters.AddWithValue("@Cilindrada", moto.cilindrada);
                _dt.Load(cmd.ExecuteReader());

                i = Convert.ToInt64(_dt.Rows[0][0].ToString());
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }

        public string GetRepuestos()
        {
            string baseDatos = "DB";
            DataTable _dt = new DataTable();

            SqlConnection connection = new SqlConnection(con.connString[baseDatos]);
 
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetRepuestos";
                _dt.Load(cmd.ExecuteReader());

                return  _dt.Rows[0][0].ToString();
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public Int64 IngresarPresupuesto(Modelos.Entidades.Presupuesto _presupuesto)
        {
            Int64 i = 0;
            string baseDatos = "DB";
            DataTable _dt = new DataTable();

            SqlConnection connection = new SqlConnection(con.connString[baseDatos]);

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Presupuesto_I";
                cmd.Parameters.Add("@Id", SqlDbType.BigInt).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@Nombre", _presupuesto.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", _presupuesto.Apellido);
                cmd.Parameters.AddWithValue("@Email", _presupuesto.Email);
                cmd.Parameters.AddWithValue("@IdVehiculo", _presupuesto.IdVehiculo);
                cmd.Parameters.AddWithValue("@Total", _presupuesto.Total);

                cmd.ExecuteNonQuery();
   
                i = Convert.ToInt32(cmd.Parameters[0].Value);
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }

        public Int64 IngresarDesperfecto(Modelos.Entidades.Desperfecto _desperfecto)
        {
            Int64 i = 0;
            string baseDatos = "DB";
            DataTable _dt = new DataTable();

            SqlConnection connection = new SqlConnection(con.connString[baseDatos]);

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Desperfecto_I";
                cmd.Parameters.Add("@Id", SqlDbType.BigInt).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@IdPresupuesto", _desperfecto.idPresupuesto);
                cmd.Parameters.AddWithValue("@Descripcion", _desperfecto.Descripcion);
                cmd.Parameters.AddWithValue("@ManoDeObra", _desperfecto.ManoDeObra);
                cmd.Parameters.AddWithValue("@Tiempo", _desperfecto.Tiempo);

                cmd.ExecuteNonQuery();

                i = Convert.ToInt64(cmd.Parameters[0].Value);
            }
            catch (Exception e)
            { 
                i = 0;
            }
            return i;
        }

        public void DesperfectoRepuesto(Int64 IdDesperfecto, Int64 IdRepuesto)
        {
            string baseDatos = "DB";
            DataTable _dt = new DataTable();

            SqlConnection connection = new SqlConnection(con.connString[baseDatos]);

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DesperfectoRepuesto_I";
                cmd.Parameters.AddWithValue("@IdDesperfecto", IdDesperfecto);
                cmd.Parameters.AddWithValue("@IdRepuesto", IdRepuesto);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
        }

        public void ActualizarPresupuesto(Presupuesto _presupuesto)
        {
            string baseDatos = "DB";
            DataTable _dt = new DataTable();

            SqlConnection connection = new SqlConnection(con.connString[baseDatos]);

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Presupuesto_U";
                cmd.Parameters.AddWithValue("@IdPresupuesto", _presupuesto.Id);
                cmd.Parameters.AddWithValue("@TotalRepuestos", _presupuesto.TotalRepuestos);
                cmd.Parameters.AddWithValue("@TotalManoDeObra", _presupuesto.TotalManoDeObra);
                cmd.Parameters.AddWithValue("@TotalTiempo", _presupuesto.TotalTiempo);
                cmd.Parameters.AddWithValue("@Total", _presupuesto.Total);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
        }
    }
}
