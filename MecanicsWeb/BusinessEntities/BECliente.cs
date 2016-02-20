using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BECliente
    {
        public string ID_Cliente { get; set; }
        public string ID_Contacto { get; set; }
        public string ID_Vehiculo { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Distrito { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string PaginaWeb { get; set; }
        public string UsuarioAuditoria { get; set; }
    }
}
