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
    public class BLVehiculo
    {
        DAVehiculo objVehiculo = new DAVehiculo();

        public DataTable ConsultarVehiculo(BEVehiculo objEVehiculo)
        {
            return objVehiculo.ConsultarVehiculo(objEVehiculo);
        }

        public Object MantenimientoVehiculo(string ACCION, BEVehiculo objEVehiculo)
        {
            return objVehiculo.MantenimientoVehiculo(ACCION, objEVehiculo);
        }
    }
}
