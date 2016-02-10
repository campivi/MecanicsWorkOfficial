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
    public class DARolUsuario : DAConexionBD
    {
        public DARolUsuario() { }

        public Object GestionRolUsuario(BERolUsuario objRolUsuario)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`SP_MODIFICA_ROL_USUARIO`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("@p_Id_Roles", objRolUsuario.Id_Roles, ParameterDirection.Input, System.Data.DbType.Int32));
            command.Parameters.Add(ObjSqlParameter("@p_Cod_Personal", objRolUsuario.Cod_Personal, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("@p_Estado", objRolUsuario.Estado, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("@p_UsuarioAuditoria", objRolUsuario.UsuarioAuditoria, ParameterDirection.Input, System.Data.DbType.String));

            conn.Open();

            try
            {
                if (objRolUsuario.Estado.Equals("1") || objRolUsuario.Estado.Equals("2"))
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

        public DataTable BusquedaRolUsuario(BERolUsuario objERolUsuario)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("[Movilidad].SP_BusquedaAsignacionRoles", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("@p_Estado", objERolUsuario.Estado, ParameterDirection.Input, System.Data.DbType.String));
            command.Parameters.Add(ObjSqlParameter("@p_Id_Roles", objERolUsuario.Id_Roles, ParameterDirection.Input, System.Data.DbType.Int32));

            conn.Open();
            IDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }
        /**/
        public DataTable ConsultarRolesDeUsuario(BERolUsuario objERolUsuario)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`ListarRolesUsuario`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("N_IDPersonal", objERolUsuario.Cod_Personal, ParameterDirection.Input, System.Data.DbType.String));
            conn.Open();
            IDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }
    }
}

