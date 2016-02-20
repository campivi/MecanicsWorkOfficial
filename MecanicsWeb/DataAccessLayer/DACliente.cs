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
    public class DACliente : DAConexionBD
    {
        public DACliente() { }

        public DataTable ConsultarCliente(BECliente objECliente)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`ConsultaCliente`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("N_Documento", objECliente.Documento, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Nombre", objECliente.Nombre, ParameterDirection.Input, System.Data.DbType.String));
            conn.Open();
            IDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }

        public Object MantenimientoCliente(string ACCION, BECliente objECliente)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`MantenimientoCliente`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("N_ID", objECliente.ID_Cliente, ParameterDirection.Input, System.Data.DbType.Int16));
            command.Parameters.Add(ObjSqlParameter("N_IDContacto", objECliente.ID_Contacto, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_IDVehiculo", objECliente.ID_Vehiculo, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Tipo", objECliente.Tipo, ParameterDirection.Input, System.Data.DbType.Int16));
            command.Parameters.Add(ObjSqlParameter("N_Nombre", objECliente.Nombre, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_RazonSocial", objECliente.RazonSocial, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Documento", objECliente.Documento, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Direccion", objECliente.Direccion, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Distrito", objECliente.Distrito, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Telefono", objECliente.Telefono, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Email", objECliente.Email, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_PaginaWeb", objECliente.PaginaWeb, ParameterDirection.Input, System.Data.DbType.String));
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

        public DataTable ListarCliente(BECliente objECliente)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`ListarCliente`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("N_ID", objECliente.ID_Cliente, ParameterDirection.Input, System.Data.DbType.String));
            conn.Open();
            IDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }
    }
}
