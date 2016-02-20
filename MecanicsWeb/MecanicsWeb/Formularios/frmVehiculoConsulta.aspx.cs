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

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {
                CargaMarca();

                if (Session["FLAG"].ToString() != "0")
                {
                    btnGuardar.Enabled = true;
                }

                    if (!(Request.QueryString["Cod"] == null))
                {
                    eVehiculo.ID_Vehiculo = Request.QueryString["Cod"].ToString();
                    DataTable dtVehiculo = new DataTable();
                    dtVehiculo = objVehiculo.ListarVehiculo(eVehiculo);
                    DataRow dr = dtVehiculo.Rows[0];

                    tbCodigo.Text = dr["ID"].ToString();
                    tbPlaca.Text = dr["Placa"].ToString();
                    tbColor.Text = dr["Color"].ToString();
                    ddlMarca.SelectedValue = dr["Marca"].ToString();
                    tbKilometraje.Text = dr["Kilometraje"].ToString();
                    tbSerie.Text = dr["Nro_Serie"].ToString();
                    tbMotor.Text = dr["Nro_Motor"].ToString();
                    tbAnio.Text = dr["Anio"].ToString();

                    btnGuardar.Enabled = true;
                }
            }

        }
        catch (Exception ex)
        {
            throw new Exception("Error de carga de datos", ex);
        }
    }

    #region BOTONES

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
        Session["Cliente_IDContacto"] = "0";
        Session["Cliente_IDVehiculo"] = "0";
        Session["Cliente_IDCliente"] = "";
        Response.Redirect("frmFormularioInicio.aspx");
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (tbCodigo.Text == "") Mantenimiento(Constantes.ACCION.AGREGAR);
        else Mantenimiento(Constantes.ACCION.MODIFICAR);
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        EmptyText();
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
            Response.Redirect("frmVehiculoConsulta.aspx?Cod=" + e.CommandArgument.ToString());
        }
        if (e.CommandName.Equals("Seleccionar"))
        {
            if (Session["FLAG"].ToString() != "0")
            {
                Session["Cliente_IDVehiculo"] = e.CommandArgument.ToString();
                Session["FLAG"] = "0";
                Response.Redirect("frmClienteConsulta.aspx");
            }
        }
    }

    protected void dgCliente_RowDataBound(object sender, GridViewRowEventArgs e) { }

    #endregion

    #region MANTENIMIENTO/BUSQUEDA

    public void Buscar()
    {
        try
        {
            eVehiculo.ID_Cliente = tbClienteSearch.Text.TrimEnd();
            eVehiculo.Placa = tbPlacaSearch.Text.TrimEnd();
            DataTable dtVehiculo = (DataTable)objVehiculo.ConsultarVehiculo(eVehiculo);
            dgVehiculo.DataSource = dtVehiculo;
            dgVehiculo.DataBind();

            up.Update();
        }
        catch (Exception ex)
        {
            AlertaJS("Error Interno : " + ex.Message);
        }
    }

    private void Mantenimiento(string ACCION)
    {
        if (Verificar() == true)
        {
            if (tbCodigo.Text == "") eVehiculo.ID_Vehiculo = "0";
            else eVehiculo.ID_Vehiculo = tbCodigo.Text.TrimEnd();
            eVehiculo.ID_Cliente = "0";
            eVehiculo.Placa = tbPlaca.Text.TrimEnd();
            eVehiculo.Anio = tbAnio.Text.TrimEnd();
            eVehiculo.Color = tbColor.Text.TrimEnd();
            eVehiculo.Kilometraje = tbKilometraje.Text.TrimEnd();
            eVehiculo.Marca = ddlMarca.SelectedValue;
            eVehiculo.Nro_Serie = tbSerie.Text.TrimEnd();
            eVehiculo.Nro_Motor = tbMotor.Text.TrimEnd();

            objVehiculo.MantenimientoVehiculo(ACCION, eVehiculo);

            if (ACCION.Equals(Constantes.ACCION.AGREGAR))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Se insertó el registro con éxito')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Se modificó el registro con éxito')", true);
            }

            EmptyText();
        }
    }

    private void CargaMarca()
    {
        DataTable dtParametros = new DataTable();
        EParametria.IDPadre = Constantes.PARAMETRIAS.MARCA;
        dtParametros = objParametria.ConsultarParametriaCod(EParametria);
        Utility.CargaComboSeleccione(ddlMarca, dtParametros, "Ptr_Codigo", "Ptr_Descripcion");
    }

    private bool Verificar()
    {
        int cont = 0;
        if (tbPlaca.Text == "") { RFV2.Visible = true; cont++; }
        else RFV2.Visible = false;
        if (tbColor.Text == "") { RFV3.Visible = true; cont++; }
        else RFV3.Visible = false;
        if (ddlMarca.Text == "") { RFV4.Visible = true; cont++; }
        else RFV4.Visible = false;
        if (tbKilometraje.Text == "") { RFV5.Visible = true; cont++; }
        else RFV5.Visible = false;
        if (tbSerie.Text == "") { RFV6.Visible = true; cont++; }
        else RFV6.Visible = false;
        if (tbMotor.Text == "") { RFV7.Visible = true; cont++; }
        else RFV7.Visible = false;
        if (tbAnio.Text == "") { RFV8.Visible = true; cont++; }
        else RFV8.Visible = false;

        upDatos.Update();
        if (cont > 0) return false;
        else return true;
        
    }

    private void EmptyText()
    {
        tbCodigo.Text = "";
        tbPlaca.Text = "";
        tbColor.Text = "";
        CargaMarca();
        tbKilometraje.Text = "";
        tbSerie.Text = "";
        tbMotor.Text = "";
        tbAnio.Text = "";

        btnGuardar.Enabled = true;
    }

    #endregion

}