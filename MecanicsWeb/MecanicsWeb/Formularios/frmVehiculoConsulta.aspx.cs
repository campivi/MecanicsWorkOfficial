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
                CargaMarcas();
                Buscar();
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

    private void CargaMarcas()
    {
        DataTable dtParametros = new DataTable();
        EParametria.IDPadre = Constantes.PARAMETRIAS.ESTADO;
        dtParametros = objParametria.ConsultarParametriaCod(EParametria);
        Utility.CargaComboTodos(dllMarca, dtParametros, "Ptr_Codigo", "Ptr_Descripcion");
    }

    public void Buscar()
    {
        try
        {
            eVehiculo.Cliente = tbCliente.Text.TrimEnd();
            if (tbPlaca.Text == "") eVehiculo.Placa = "0";
            else eVehiculo.NumDocumento = tbPlaca.Text.TrimEnd();
            if (dllMarca.SelectedValue == "") eVehiculo.Marca = 0;
            else eVehiculo.Marca = Convert.ToInt32(dllMarca.SelectedValue);
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

}