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
    public class DAUsuario : DAConexionBD
    {
        public DAUsuario() { }

        public DataTable ConsultarLogin(BEUsuario objEUsuario)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`ConsultaLogin`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("N_Login", objEUsuario.Login, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_Password", objEUsuario.Password, ParameterDirection.Input, System.Data.DbType.String));
            conn.Open();
            IDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }

        public Object MantenimientoUsuario(string ACCION, BEUsuario objEUsuario)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`MantenimientoUsuario`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("N_ID", objEUsuario.ID_Usuario, ParameterDirection.Input, System.Data.DbType.Int16));
            command.Parameters.Add(ObjSqlParameter("N_IDPersonal", objEUsuario.ID_Personal, ParameterDirection.Input, System.Data.DbType.Int16));
            command.Parameters.Add(ObjSqlParameter("N_Login", objEUsuario.Login, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_LPassword", objEUsuario.Password, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("N_IDRol", objEUsuario.Id_Perfil, ParameterDirection.Input, System.Data.DbType.Int16));
            command.Parameters.Add(ObjSqlParameter("N_Estado", objEUsuario.Estado, ParameterDirection.Input, System.Data.DbType.Int16));
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

        public DataTable ListarUsuario()
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`SP_ListarUsuario`", conn);

            command.CommandType = CommandType.StoredProcedure;
            conn.Open();
            IDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }

    }
}
