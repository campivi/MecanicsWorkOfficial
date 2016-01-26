using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BERolUsuario
    {
        public int Id_RolUsuario { get; set; }
        public int Id_Roles { get; set; }
        public string Cod_Personal { get; set; }
        public string Estado { get; set; }
        public string UsuarioAuditoria { get; set; }
    }
}
