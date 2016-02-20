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
    public class BLCliente
    {
        DACliente objCliente = new DACliente();

        public DataTable ConsultarCliente(BECliente objECliente)
        {
            return objCliente.ConsultarCliente(objECliente);
        }

        public Object MantenimientoCliente(string ACCION, BECliente objECliente)
        {
            return objCliente.MantenimientoCliente(ACCION, objECliente);
        }

        public DataTable ListarCliente(BECliente objECliente)
        {
            return objCliente.ListarCliente(objECliente);
        }
    }
}
