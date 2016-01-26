using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BERolMenu
    {
        public int Id_RolMenu { get; set; }
        public int Id_Rol { get; set; }
        public int Id_Menu { get; set; }
        public string Estado { get; set; }
        public string UsuarioAuditoria { get; set; }
    }
}
