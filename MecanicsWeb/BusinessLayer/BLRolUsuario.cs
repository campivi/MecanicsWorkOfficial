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
    public class BLRolUsuario
    {
        DARolUsuario objRolUsuario = new DARolUsuario();

        public Object GestionRolUsuario(BERolUsuario objERolUsuario)
        {
            return objRolUsuario.GestionRolUsuario(objERolUsuario);
        }

        public DataTable BusquedaRolUsuario(BERolUsuario objERolUsuario)
        {
            return objRolUsuario.BusquedaRolUsuario(objERolUsuario);
        }

        public DataTable ConsultarRolesDeUsuario(BERolUsuario objERolUsuario)
        {
            return objRolUsuario.ConsultarRolesDeUsuario(objERolUsuario);
        }
    }
}
