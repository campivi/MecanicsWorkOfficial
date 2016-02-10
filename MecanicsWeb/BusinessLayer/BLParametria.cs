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
    public class BLParametria
    {
        DAParametria objParametria = new DAParametria();

        public DataTable ConsultarParametriaCod(BEParametria objEParametria)
        {
            return objParametria.ConsultarParametriaCod(objEParametria);
        }
    }
}
