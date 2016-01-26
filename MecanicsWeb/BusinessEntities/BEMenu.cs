using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BEMenu
    {
        public int Id_Menu { get; set; }
        public int Id_Padre { get; set; }
        public string Nombre { get; set; }
        public string Pagina { get; set; }
        public string Orden { get; set; }
        public string Estado { get; set; }
        public string UsuarioAuditoria { get; set; }
    }
}
