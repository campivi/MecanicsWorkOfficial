using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using BusinessEntities;

namespace BusinessLayer
{
    public class BLUsuario
    {
        DAUsuario objUsuario = new DAUsuario();

        public DataTable ConsultarLogin(BEUsuario objEUsuario)
        {
            return objUsuario.ConsultarLogin(objEUsuario);
        }

        public Object MantenimientoUsuario(string ACCION, BEUsuario objEUsuario)
        {
            return objUsuario.MantenimientoUsuario(ACCION, objEUsuario);
        }

        public DataTable ListarUsuario()
        {
            return objUsuario.ListarUsuario();
        }
    }
}
