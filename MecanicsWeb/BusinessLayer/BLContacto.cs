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
    public class BLContacto
    {
        DAContacto objContacto = new DAContacto();

        public DataTable ConsultarContacto(BEContacto objEContacto)
        {
            return objContacto.ConsultarContacto(objEContacto);
        }

        public Object MantenimientoContacto(string ACCION, BEContacto objEContacto)
        {
            return objContacto.MantenimientoContacto(ACCION, objEContacto);
        }

        public DataTable ListarContacto(BEContacto objEContacto)
        {
            return objContacto.ListarContacto(objEContacto);
        }

        public void ActualizaContacto(BEContacto objEContacto)
        {
            objContacto.ActualizaContacto(objEContacto);
        }
    }
}
