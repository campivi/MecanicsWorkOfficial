using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BEVehiculo
    {
        public string ID_Vehiculo { get; set; }
        public string ID_Cliente { get; set; }
        public string Placa { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }
        public string Kilometraje { get; set; }
        public string Nro_Serie { get; set; }
        public string Nro_Motor { get; set; }
        public string Anio { get; set; }
        public string UsuarioAuditoria { get; set; }
    }
}
