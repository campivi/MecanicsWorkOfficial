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
    public class DAContacto: DAConexionBD
    {
        public DAContacto() { }

        public DataTable ConsultarContacto(BEContacto objEContacto)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`ConsultaContacto`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("N_Nombre", objEContacto.Nombre, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Documento", objEContacto.Documento, ParameterDirection.Input, System.Data.DbType.String));
            conn.Open();
            IDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }

        public Object MantenimientoContacto(string ACCION, BEContacto objEContacto)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`MantenimientoContacto`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("N_ID", objEContacto.ID_Contacto, ParameterDirection.Input, System.Data.DbType.Int16));
            command.Parameters.Add(ObjSqlParameter("N_IDCliente", objEContacto.ID_Cliente, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Nombre", objEContacto.Nombre, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_TipoDocumento", objEContacto.TipoDocumento, ParameterDirection.Input, System.Data.DbType.Int16));
            command.Parameters.Add(ObjSqlParameter("N_Documento", objEContacto.Documento, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Telefono", objEContacto.Telefono, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Celular", objEContacto.Celular, ParameterDirection.Input, System.Data.DbType.String));
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

        public DataTable ListarContacto(BEContacto objEContacto)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`ListarContacto`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("N_ID", objEContacto.ID_Contacto, ParameterDirection.Input, System.Data.DbType.String));
            conn.Open();
            IDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }

        public void ActualizaContacto(BEContacto objEContacto)
        {
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`ActualizaContacto`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("N_ID", objEContacto.ID_Contacto, ParameterDirection.Input, System.Data.DbType.Int16));
            command.Parameters.Add(ObjSqlParameter("N_IDCliente", objEContacto.ID_Cliente, ParameterDirection.Input, System.Data.DbType.String));

            conn.Open();

            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
