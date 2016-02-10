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
    public class BLRoles
    {
        DARoles objRoles = new DARoles();

        public DataTable ConsultarRoles()
        {
            return objRoles.ConsultarRoles();
        }

        public DataTable CONSULTA_ROLES_USUARIO(BERoles objEntity)
        {
            return objRoles.CONSULTA_ROLES_USUARIO(objEntity);
        }

        public void MODIFICA_ROL_USUARIO(BERoles objESolicitud)
        {
            objRoles.MODIFICA_ROL_USUARIO(objESolicitud);
        }

        public DataTable BusquedaRoles(BERoles objERoles)
        {
            return objRoles.BusquedaRoles(objERoles);
        }

        public DataTable DetalleRol(BERoles objERoles)
        {
            return objRoles.DetalleRol(objERoles);
        }

        public int GestionRol(string pAccion, BERoles objERoles)
        {
            return objRoles.GestionRol(pAccion, objERoles);
        }

        public DataTable NombreRol(BERoles objERoles)
        {
            return objRoles.NombreRol(objERoles);
        }
    }
}
