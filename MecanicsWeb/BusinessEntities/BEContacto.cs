using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BEContacto
    {
        public string ID_Contacto { get; set; }
        public string ID_Cliente { get; set; }
        public string Nombre { get; set; }
        public string TipoDocumento { get; set; }
        public string Documento { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string UsuarioAuditoria { get; set; }
    }
}
