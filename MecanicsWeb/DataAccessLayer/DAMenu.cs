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
    public class DAMenu : DAConexionBD
    {
        public DAMenu() { }


        public DataTable ConsultarMenu(BEMenu eMenu, BERolMenu eRolMenu)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`ConsultarMenu`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("N_IDRol", eRolMenu.Id_Rol, ParameterDirection.Input, System.Data.DbType.Int32));
            command.Parameters.Add(ObjSqlParameter("N_IDPadre", eMenu.Id_Padre, ParameterDirection.Input, System.Data.DbType.Int32));
            conn.Open();
            IDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }
    }
}
