using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BERoles
    {
        #region ATRIBUTOS

        public int Id_Rol { get; set; }
        public string Rol_Nombre { get; set; }
        public string Rol_Detalle { get; set; }
        public string Estado { get; set; }
        public string UsuarioAuditoria { get; set; }
        private string _CodEmp;
        private bool _EstadoR;

        #endregion

        #region ENCAPSULAMIENTO       

        public string CodEmp
        {
            get { return _CodEmp; }
            set { _CodEmp = value; }
        }

        public bool EstadoR
        {
            get { return _EstadoR; }
            set { _EstadoR = value; }
        }

        #endregion
    }
}
