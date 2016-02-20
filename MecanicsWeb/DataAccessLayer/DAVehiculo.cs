using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using BusinessEntities;

namespace DataAccessLayer
{
    public class DAVehiculo : DAConexionBD
    {
        public DAVehiculo() { }

        public DataTable ConsultarVehiculo(BEVehiculo objEVehiculo)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`ConsultaVehiculo`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("N_Cliente", objEVehiculo.ID_Cliente, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Placa", objEVehiculo.Placa, ParameterDirection.Input, System.Data.DbType.String));
            conn.Open();
            IDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }

        public Object MantenimientoVehiculo(string ACCION, BEVehiculo objEVehiculo)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`MantenimientoVehiculo`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("N_ID", objEVehiculo.ID_Vehiculo, ParameterDirection.Input, System.Data.DbType.Int16));
            command.Parameters.Add(ObjSqlParameter("N_IDCliente", objEVehiculo.ID_Cliente, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Placa", objEVehiculo.Placa, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Color", objEVehiculo.Color, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Marca", objEVehiculo.Marca, ParameterDirection.Input, System.Data.DbType.Int16));
            command.Parameters.Add(ObjSqlParameter("N_Kilometraje", objEVehiculo.Kilometraje, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Nro_Serie", objEVehiculo.Nro_Serie, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Nro_Motor", objEVehiculo.Nro_Motor, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Anio", objEVehiculo.Anio, ParameterDirection.Input, System.Data.DbType.Int16));
            command.Parameters.Add(ObjSqlParameter("ACCION", ACCION, ParameterDirection.Input, System.Data.DbType.String));

            conn.Open();

            try
            {
                if (ACCION.Equals("AGREGAR") || ACCION.Equals("MODIFICAR"))
                {
                    command.ExecuteNonQuery();
                    return "Exito";
                }
                else
                {
                    IDataReader dr = command.ExecuteReader();
                    dt.Load(dr);
                    return dt;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error interno", e);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable ListarVehiculo(BEVehiculo objEVehiculo)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`ListarVehiculo`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("N_ID", objEVehiculo.ID_Vehiculo, ParameterDirection.Input, System.Data.DbType.String));
            conn.Open();
            IDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }

        public void ActualizaVehiculo(BEVehiculo objEVehiculo)
        {
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`ActualizaVehiculo`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("N_ID", objEVehiculo.ID_Vehiculo, ParameterDirection.Input, System.Data.DbType.Int16));
            command.Parameters.Add(ObjSqlParameter("N_IDCliente", objEVehiculo.ID_Cliente, ParameterDirection.Input, System.Data.DbType.String));

            conn.Open();

            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}

