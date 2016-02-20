using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessEntities;
using BusinessLayer;
using System.Data;

public partial class MasterPage : System.Web.UI.MasterPage
{
    #region Inicialización

    BLMenu objMenu = new BLMenu();
    BLRolUsuario objRolUsuario = new BLRolUsuario();
    BERolUsuario eRolUsuario = new BERolUsuario();

    #endregion

    #region Eventos del MasterPage

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                lblUsuario.Text = "Bienvenido(a): " + Convert.ToString(Session["NOMBRE"]);
                lblPerfil.Text = "Rol: " + Convert.ToString(Session["NombreRol"]);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void ibtChangePass_Click(object sender, ImageClickEventArgs e)
    {
        //Response.Redirect("~/Formularios/frmUsuarioMantenimiento.aspx", false);
    }

    protected void ibtSalir_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Formularios/frmLogin.aspx", false);
    }
    

    #endregion
}
