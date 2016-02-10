using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    public class DAConexionBD
    {
        public MySqlConnection cnx;

        public DAConexionBD()
        {
            //CAMBIAR DATOS DE BD
            cnx = new MySqlConnection("Server=127.0.0.1; Database=MECANICSWEB; Uid=Administrador; Pwd=admin");
        }

        public MySqlParameter ObjSqlParameter(string pParameterName, object pValue, System.Data.ParameterDirection pDirection, DbType pDbType)
        {
            MySqlParameter lSqlParameter = new MySqlParameter();
            lSqlParameter.ParameterName = pParameterName;
            lSqlParameter.Value = pValue;
            lSqlParameter.Direction = pDirection;
            lSqlParameter.DbType = pDbType;
            return lSqlParameter;
        }

        public MySqlParameter ObjSqlParameter(string pParameterName, object pValue, System.Data.ParameterDirection pDirection, DbType pDbType, Int32 psize)
        {
            MySqlParameter lSqlParameter = new MySqlParameter();
            lSqlParameter.ParameterName = pParameterName;
            lSqlParameter.Value = pValue;
            lSqlParameter.Direction = pDirection;
            lSqlParameter.DbType = pDbType;
            lSqlParameter.Size = psize;
            return lSqlParameter;
        }

        public void AbrirConexion()
        {
            try
            {
                if (cnx.State == ConnectionState.Broken || cnx.State == ConnectionState.Closed)
                    cnx.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conección", e);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conección", e);
            }
        }
    }
}
