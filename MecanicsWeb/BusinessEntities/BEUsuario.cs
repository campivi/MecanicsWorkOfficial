using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BEUsuario
    {
        public string ID_Usuario { get; set; }
        public string ID_Personal { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string OldPassword { get; set; }
        public string Nombre { get; set; }
        public int Id_Perfil { get; set; }
        public string Estado { get; set; }
    }
}