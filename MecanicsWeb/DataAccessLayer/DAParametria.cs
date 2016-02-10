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
    public class DAParametria : DAConexionBD
    {
        public DAParametria() { }

        public DataTable ConsultarParametriaCod(BEParametria objEParametria)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
            MySqlCommand command = new MySqlCommand("`mecanicsweb`.`ListarParametros`", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(ObjSqlParameter("N_IDPadre", objEParametria.IDPadre, ParameterDirection.Input, System.Data.DbType.Int32));
            conn.Open();
            IDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }
    }
}
