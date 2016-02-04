using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessEntities;
using BusinessLayer;
using System.Data;

public partial class Formulario_frmFormularioInicio : Base
{
    #region Inicialización

    BLMenu objMenu = new BLMenu();
    BLRolUsuario objRolUsuario = new BLRolUsuario();
    BERolUsuario eRolUsuario = new BERolUsuario();

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                ListaMenu();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    #region Metodos y Funciones Privadas

    public void ListaMenu()
    {
        MenuItem menu = new MenuItem();
        BEMenu eMenu = new BEMenu();
        BERolMenu eRolMenu = new BERolMenu();
        DataTable dt = new DataTable();

        eRolUsuario.Cod_Personal = Session["IDPERSONAL"].ToString();

        try
        {
            eRolMenu.Id_Rol = Convert.ToInt32(Session["RolElegido"].ToString());
            eMenu.Id_Padre = 0;

            dt = objMenu.ConsultarMenu(eMenu, eRolMenu);
            if (dt.Rows.Count > 0)
            {
                Session["NewRol"] = Convert.ToInt32(Session["RolElegido"].ToString());
                CargaMenu(dt);
            }
        }
        catch (Exception ex)
        {
            NetAjax.JsMensajeAlert(this.Page, ex.Message);
        }
    }

    public void CargaMenu(DataTable dt)
    {
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            MenuItem menuItem = new MenuItem();

            menuItem.Value = dt.Rows[i]["ID"].ToString();
            menuItem.Text = dt.Rows[i]["Nombre"].ToString();
            menuItem.NavigateUrl = dt.Rows[i]["Pagina"].ToString();
            menuItem.Selectable = false;
            DataTable dt2 = new DataTable();
            BEMenu eMenu = new BEMenu();
            BERolMenu eRolMenu = new BERolMenu();
            eRolMenu.Id_Rol = Convert.ToInt32(Session["NewRol"]);
            eMenu.Id_Padre = Convert.ToInt32(dt.Rows[i].ItemArray[0].ToString());
            dt2 = objMenu.ConsultarMenu(eMenu, eRolMenu);

            NavigationMenu.Items.Add(menuItem);
            AddMenuItem(menuItem, dt2);
        }
    }

    public void AddMenuItem(MenuItem menuItem, DataTable dt)
    {
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            MenuItem newmenuItem = new MenuItem();

            newmenuItem.Value = dt.Rows[i].ItemArray[0].ToString();
            newmenuItem.Text = dt.Rows[i].ItemArray[2].ToString();
            newmenuItem.NavigateUrl = dt.Rows[i].ItemArray[3].ToString();

            menuItem.ChildItems.Add(newmenuItem);
        }
    }

    #endregion
}
