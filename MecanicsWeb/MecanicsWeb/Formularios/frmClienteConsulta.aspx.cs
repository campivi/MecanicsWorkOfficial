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

public partial class Formularios_frmVehiculoConsulta : Base
{
    #region Inicialización

    BLParametria objParametria = new BLParametria();
    BEParametria EParametria = new BEParametria();
    BEVehiculo eVehiculo = new BEVehiculo();
    BLVehiculo objVehiculo = new BLVehiculo();

    #endregion

    #region Eventos del Formulario

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {
                CargaMarca();
            }

        }
        catch (Exception ex)
        {
            throw new Exception("Error de carga de datos", ex);
        }
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("fmrVehiculoMantenimiento.aspx");
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        try
        {
            Buscar();
        }
        catch (Exception ex)
        {
            AlertaJS("Error Interno : " + ex.Message);
        }
    }

    protected void btnCerrar_Click(object sender, EventArgs e)
    {
        Response.Redirect("fmrFormularioInicio.aspx");
    }

    protected void dgCliente_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        dgVehiculo.PageIndex = e.NewPageIndex;
        Buscar();
    }

    protected void dgCliente_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Modificar"))
        {
            Response.Redirect("fmrMantenimientoPersonal.aspx?Cod=" + e.CommandArgument.ToString());
        }
    }

    protected void dgCliente_RowDataBound(object sender, GridViewRowEventArgs e) { }

    #endregion

    #region Metodos y Funciones Privadas

    public void Buscar()
    {
        try
        {
            eVehiculo.Cliente = tbCliente.Text.TrimEnd();
            if (tbPlaca.Text == "") eVehiculo.Placa = "0";
            else eVehiculo.NumDocumento = tbPlaca.Text.TrimEnd();
            DataTable dtVehiculo = (DataTable)objVehiculo.ConsultarPersonal(eVehiculo);
            dgVehiculo.DataSource = dtVehiculo;
            dgVehiculo.DataBind();

            lblContador.Text = "Registros encontrados (" + dtVehiculo.Rows.Count.ToString() + ")";
            up.Update();
            UpLabel.Update();
        }
        catch (Exception ex)
        {
            AlertaJS("Error Interno : " + ex.Message);
        }
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
        EParametria.IDPadre = Constantes.PARAMETRIAS.RELACION;//MARCA
        dtParametros = objParametria.ConsultarParametriaCod(EParametria);
        Utility.CargaComboSeleccione(ddlMarca, dtParametros, "Ptr_Codigo", "Ptr_Descripcion");
    }

    #endregion

}