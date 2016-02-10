using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BEParametria
    {
        public Int32 ID_Parametria { get; set; }
        public Int32 IDPadre { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }
        public string Estado { get; set; }

        public BEParametria()
        {
            Descripcion = "";
            Estado = "";
        }
    }
}