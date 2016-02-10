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
    public class DARoles : DAConexionBD
    {
        public DARoles() { }

        public DataTable ConsultarRoles()
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`SP_ConsultarRoles`", conn);

            command.CommandType = CommandType.StoredProcedure;
            conn.Open();
            IDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }

        public DataTable CONSULTA_ROLES_USUARIO(BERoles objEntity)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`SP_CONSULTA_ROLES_USUARIO`", conn);
            command.Parameters.AddWithValue("@Codemp", objEntity.CodEmp);
            command.CommandType = CommandType.StoredProcedure;
            conn.Open();
            IDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }

        public void MODIFICA_ROL_USUARIO(BERoles objESolicitud)
        {
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand cmd = new MySqlCommand("`mecanicsweb`.`SP_MODIFICA_ROL_USUARIO`", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdRol", objESolicitud.Id_Rol);
            cmd.Parameters.AddWithValue("@CodEmp", objESolicitud.CodEmp);
            cmd.Parameters.AddWithValue("@Estado", objESolicitud.EstadoR);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable BusquedaRoles(BERoles objERoles)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`SP_BusquedaRoles`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("@p_Estado", objERoles.Estado, ParameterDirection.Input, System.Data.DbType.String));
            conn.Open();
            IDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }

        public DataTable DetalleRol(BERoles objERoles)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`SP_DetalleRol`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("@p_Id_Rol", objERoles.Id_Rol, ParameterDirection.Input, System.Data.DbType.Int32));
            conn.Open();
            IDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }

        public int GestionRol(string pAccion, BERoles objERoles)
        {
            int resultado = 0;
            MySqlCommand cmd = new MySqlCommand("`mecanicsweb`.`SP_GestionRol`", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@p_Accion", pAccion);
            cmd.Parameters.AddWithValue("@p_Id_Rol", objERoles.Id_Rol);
            cmd.Parameters.AddWithValue("@p_Rol_Nombre", objERoles.Rol_Nombre);
            cmd.Parameters.AddWithValue("@p_Rol_Detalle", objERoles.Rol_Detalle);
            cmd.Parameters.AddWithValue("@p_Estado", objERoles.Estado);
            cmd.Parameters.AddWithValue("@p_UsuarioAuditoria", objERoles.UsuarioAuditoria);

            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de almacenar, borrar o modificar datos", e);
            }

            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return resultado;
        }

        public DataTable NombreRol(BERoles objERoles)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`NombreRol`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("N_ID", objERoles.Id_Rol, ParameterDirection.Input, System.Data.DbType.Int32));
            conn.Open();
            IDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }
    }
}

