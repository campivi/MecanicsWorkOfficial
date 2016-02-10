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
    public class BLMenu
    {
        DAMenu objMenu = new DAMenu();

        public DataTable ConsultarMenu(BEMenu objEMEnu, BERolMenu eRolMenu)
        {
            return objMenu.ConsultarMenu(objEMEnu, eRolMenu);
        }
    }
}
