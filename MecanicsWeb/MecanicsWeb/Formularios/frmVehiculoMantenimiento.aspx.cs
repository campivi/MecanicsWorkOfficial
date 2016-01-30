using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using BusinessEntities;
using DataAccessLayer;
using System.Data;

public partial class Formularios_frmVehiculoMantenimiento : Base
{
    #region Inicialización

    BLVehiculo objVehiculo = new BLVehiculo();
    BLParametria objParametria = new BLParametria();
    BEParametria eParametria = new BEParametria();
    BLRoles objRoles = new BLRoles();
    BEVehiculo eVehiculo = new BEVehiculo();

    #endregion

    #region Eventos del Formulario

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {
                CargaMarca();

                if (!(Request.QueryString["Cod"] == null))
                {
                    DataTable dtVehiculo = new DataTable();

                    eVehiculo.Codigo = Request.QueryString["Cod"].ToString();
                    dtVehiculo = (DataTable)objVehiculo.ListarVehiculo(eVehiculo);
                    DataRow dr = dtVehiculo.Rows[0];

                    tbCodigo.Text = dr["ID"].ToString();
                    tbPlaca.Text = dr["Placa"].ToString();
                    tbAnio.Text = dr["Anio"].ToString();
                    tbColor.Text = dr["Color"].ToString();
                    tbKilometraje.Text = dr["Kilometraje"].ToString();
                    ddlMarca.SelectedValue = dr["Marca"].ToString();
                    tbSerie.Text = dr["Serie"].ToString();
                    tbMotor.Text = dr["Motor"].ToString();
                    tbCliente.Text = dr["Cliente"].ToString();
                }
            }

        }
        catch (Exception ex)
        {
            NetAjax.JsMensajeAlert(this.Page, "Error Interno : " + ex.Message);
        }
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        try
        {
            if (Request.QueryString["Cod"] != null)
            {
                Mantenimiento(Constantes.GESTION.MODIFICAR);
            }
            else
            {
                Mantenimiento(Constantes.GESTION.AGREGAR);
            }
            
        }
        catch (Exception ex)
        {
            NetAjax.JsMensajeAlert(this.Page, "Error Interno : " + ex.Message);
        }
    }

    protected void btnCerrar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmVehiculoConsulta.aspx");
    }

    #endregion

    #region Metodos Privados

    private void Mantenimiento(string ACCION)
    {
        if (tbCodigo.Text == "") eVehiculo.Codigo = "0"; 
        else eVehiculo.Codigo = tbCodigo.Text.TrimEnd();
        eVehiculo.Placa = tbPlaca.Text.TrimEnd();
        eVehiculo.Anio = tbAnio.Text.TrimEnd();
        eVehiculo.Color = tbColor.Text.TrimEnd();
        eVehiculo.Kilometraje = tbKilometraje.Text.TrimEnd();
        eVehiculo.Marca = Convert.ToInt16(ddlMarca.SelectedValue);
        eVehiculo.Serie = tbSerie.Text.TrimEnd();
        eVehiculo.Motor = tbMotor.Text.TrimEnd();
        eVehiculo.Cliente = tbCliente.Text.TrimEnd();
        
        objVehiculo.GestionVehiculo(eVehiculo, ACCION);

        if (ACCION.Equals(Constantes.GESTION.AGREGAR))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Se insertó el registro con éxito')", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Se modificó el registro con éxito')", true);
        }
    }
    
    private void CargaMarca()
    {
        DataTable dtParametros = new DataTable();
        eParametria.IDPadre = Constantes.PARAMETRIAS.RELACION;//MARCA
        dtParametros = objParametria.ConsultarParametriaCod(eParametria);
        Utility.CargaComboSeleccione(ddlMarca, dtParametros, "Ptr_Codigo", "Ptr_Descripcion");
    }

    #endregion
}