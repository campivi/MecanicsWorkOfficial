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

public partial class Formularios_frmClienteConsulta : Base
{
    #region Inicialización

    BLParametria objParametria = new BLParametria();
    BEParametria EParametria = new BEParametria();
    BECliente eCliente = new BECliente();
    BLCliente objCliente = new BLCliente();
    BEContacto eContacto = new BEContacto();
    BLContacto objContacto = new BLContacto();
    BEVehiculo eVehiculo = new BEVehiculo();
    BLVehiculo objVehiculo = new BLVehiculo();

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {
                CargaTipoPersona();

                if (!(Request.QueryString["Cod"] == null))
                {
                    eCliente.ID_Cliente = Request.QueryString["Cod"].ToString();
                    DataTable dtCliente = new DataTable();
                    dtCliente = objCliente.ListarCliente(eCliente);
                    DataRow dr = dtCliente.Rows[0];

                    tbCodigo.Text = dr["ID"].ToString();
                    Session["IDContacto"] = dr["IDContacto"].ToString();
                    Session["IDVehiculo"] = dr["IDVehiculo"].ToString();
                    tbContacto.Text = dr["NombreContacto"].ToString();
                    tbVehiculo.Text = dr["NombreVehiculo"].ToString();
                    ddlTipo.SelectedValue = dr["Tipo"].ToString();
                    tbNombre.Text = dr["Nombre"].ToString();
                    tbRazonSocial.Text = dr["RazonSocial"].ToString();
                    tbDocumento.Text = dr["Documento"].ToString();
                    tbDireccion.Text = dr["Direccion"].ToString();
                    tbDistrito.Text = dr["Distrito"].ToString();
                    tbTelefono.Text = dr["Telefono"].ToString();
                    tbEmail.Text = dr["Email"].ToString();
                    tbPaginaWeb.Text = dr["PaginaWeb"].ToString();

                    btnDetalleVehiculo.Enabled = true;
                    btnDetalleContacto.Enabled = true;
                }

                if (Session["Cliente_IDCliente"].ToString() != "")
                {
                    eCliente.ID_Cliente = Session["Cliente_IDCliente"].ToString();
                    DataTable dtCliente = new DataTable();
                    dtCliente = objCliente.ListarCliente(eCliente);
                    DataRow dr = dtCliente.Rows[0];

                    tbCodigo.Text = dr["ID"].ToString();
                    Session["IDContacto"] = dr["IDContacto"].ToString();
                    Session["IDVehiculo"] = dr["IDVehiculo"].ToString();
                    tbContacto.Text = dr["NombreContacto"].ToString();
                    tbVehiculo.Text = dr["NombreVehiculo"].ToString();
                    ddlTipo.SelectedValue = dr["Tipo"].ToString();
                    tbNombre.Text = dr["Nombre"].ToString();
                    tbRazonSocial.Text = dr["RazonSocial"].ToString();
                    tbDocumento.Text = dr["Documento"].ToString();
                    tbDireccion.Text = dr["Direccion"].ToString();
                    tbDistrito.Text = dr["Distrito"].ToString();
                    tbTelefono.Text = dr["Telefono"].ToString();
                    tbEmail.Text = dr["Email"].ToString();
                    tbPaginaWeb.Text = dr["PaginaWeb"].ToString();

                    btnDetalleVehiculo.Enabled = true;
                    btnDetalleContacto.Enabled = true;
                }

                if (Session["Cliente_IDContacto"].ToString()!="0")
                {
                    eContacto.ID_Contacto = Session["Cliente_IDContacto"].ToString();
                    DataTable dtContacto = new DataTable();
                    dtContacto = objContacto.ListarContacto(eContacto);
                    DataRow dr = dtContacto.Rows[0];

                    eCliente.ID_Contacto = dr["ID"].ToString();
                    tbContacto.Text = dr["Nombre"].ToString();
                }

                if (Session["Cliente_IDVehiculo"].ToString() != "0")
                {
                    eVehiculo.ID_Vehiculo= Session["Cliente_IDVehiculo"].ToString();
                    DataTable dtVehiculo = new DataTable();
                    dtVehiculo = objVehiculo.ListarVehiculo(eVehiculo);
                    DataRow dr = dtVehiculo.Rows[0];

                    eCliente.ID_Vehiculo = dr["ID"].ToString();
                    tbVehiculo.Text = dr["Placa"].ToString();
                }

                if(tbContacto.Text!="" && tbVehiculo.Text != "")
                {
                    ddlTipo.Enabled = true;
                    tbNombre.Enabled = true;
                    tbRazonSocial.Enabled = true;
                    tbDocumento.Enabled = true;
                    tbDireccion.Enabled = true;
                    tbDistrito.Enabled = true;
                    tbTelefono.Enabled = true;
                    tbEmail.Enabled = true;
                    tbPaginaWeb.Enabled = true;
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
        dgCliente.PageIndex = e.NewPageIndex;
        Buscar();
    }

    protected void dgCliente_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Modificar"))
        {
            Response.Redirect("frmClienteConsulta.aspx?Cod=" + e.CommandArgument.ToString());
        }
    }

    protected void dgCliente_RowDataBound(object sender, GridViewRowEventArgs e) { }

    #endregion

    #region POP UP 

    protected void btnBuscarContacto_Click(object sender, EventArgs e)
    {
        Session["FLAG"] = "1";
        Session["Cliente_IDCliente"] = tbCodigo.Text;
        Response.Redirect("frmContactoConsulta.aspx");
    }

    protected void btnDetalleContacto_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmContactoConsulta.aspx?Cod=" + Session["IDContacto"].ToString());
    }

    protected void btnBuscarVehiculo_Click(object sender, EventArgs e)
    {
        Session["FLAG"] = "1";
        Session["Cliente_IDCliente"] = tbCodigo.Text;
        Response.Redirect("frmVehiculoConsulta.aspx");
    }

    protected void btnDetalleVehiculo_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmVehiculoConsulta.aspx?Cod=" + Session["IDVehiculo"].ToString());
    }

    #endregion

    #region MANTENIMIENTO/BUSQUEDA

    public void Buscar()
    {
        try
        {
            eCliente.Nombre = tbNombreSearch.Text.TrimEnd();
            eCliente.Documento = tbDocumentoSearch.Text.TrimEnd();
            DataTable dtCliente = (DataTable)objCliente.ConsultarCliente(eCliente);
            dgCliente.DataSource = dtCliente;
            dgCliente.DataBind();

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
            if (tbCodigo.Text == "") eCliente.ID_Cliente = "0";
            else eCliente.ID_Cliente = tbCodigo.Text.TrimEnd();
            if (Session["Cliente_IDContacto"].ToString() != "0") eCliente.ID_Contacto = Session["Cliente_IDContacto"].ToString();
            else eCliente.ID_Contacto = Session["IDContacto"].ToString();
            if (Session["Cliente_IDVehiculo"].ToString() != "0") eCliente.ID_Vehiculo = Session["Cliente_IDVehiculo"].ToString();
            else eCliente.ID_Vehiculo = Session["IDVehiculo"].ToString();
            eCliente.Tipo = ddlTipo.SelectedValue;
            eCliente.Nombre = tbNombre.Text.TrimEnd();
            eCliente.RazonSocial = tbRazonSocial.Text.TrimEnd();
            eCliente.Documento = tbDocumento.Text.TrimEnd();
            eCliente.Direccion = tbDireccion.Text.TrimEnd();
            eCliente.Distrito = tbDistrito.Text.TrimEnd();
            eCliente.Telefono = tbTelefono.Text.TrimEnd();
            eCliente.Email = tbEmail.Text.TrimEnd();
            eCliente.PaginaWeb = tbPaginaWeb.Text.TrimEnd();

            objCliente.MantenimientoCliente(ACCION, eCliente);

            if (ACCION.Equals(Constantes.ACCION.AGREGAR))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Se insertó el registro con éxito')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Se modificó el registro con éxito')", true);
            }

            ActualizaVehiculo();
            ActualizaContacto();

            EmptyText();
            Session["Cliente_IDContacto"] = "0";
            Session["Cliente_IDVehiculo"] = "0";
            Session["Cliente_IDCliente"] = "";
        }
    }

    private void ActualizaContacto()
    {
        if (tbCodigo.Text == "") eContacto.ID_Cliente = "0";
        else eContacto.ID_Cliente = tbCodigo.Text.TrimEnd();
        eContacto.ID_Contacto = Session["IDContacto"].ToString();
        objContacto.ActualizaContacto(eContacto);
    }

    private void ActualizaVehiculo()
    {
        if (tbCodigo.Text == "") eVehiculo.ID_Cliente = "0";
        else eVehiculo.ID_Cliente = tbCodigo.Text.TrimEnd();
        eVehiculo.ID_Vehiculo = Session["IDVehiculo"].ToString();
        objVehiculo.ActualizaVehiculo(eVehiculo);
    }

    private void CargaTipoPersona()
    {
        DataTable dtParametros = new DataTable();
        EParametria.IDPadre = Constantes.PARAMETRIAS.TIPO_PERSONA;
        dtParametros = objParametria.ConsultarParametriaCod(EParametria);
        Utility.CargaComboSeleccione(ddlTipo, dtParametros, "Ptr_Codigo", "Ptr_Descripcion");
    }

    private bool Verificar()
    {
        int cont = 0;
        if (tbContacto.Text == "") { RFV1.Visible = true; cont++; }
        else RFV1.Visible = false;
        if (tbVehiculo.Text == "") { RFV2.Visible = true; cont++; }
        else RFV2.Visible = false;
        if (ddlTipo.Text == "") { RFV3.Visible = true; cont++; }
        else RFV3.Visible = false;
        if (tbNombre.Text == "") { RFV4.Visible = true; cont++; }
        else RFV4.Visible = false;
        if (tbRazonSocial.Text == "") { RFV5.Visible = true; cont++; }
        else RFV5.Visible = false;
        if (tbDocumento.Text == "") { RFV6.Visible = true; cont++; }
        else RFV6.Visible = false;
        if (tbDireccion.Text == "") { RFV7.Visible = true; cont++; }
        else RFV7.Visible = false;
        if (tbDistrito.Text == "") { RFV8.Visible = true; cont++; }
        else RFV8.Visible = false;
        if (tbTelefono.Text == "") { RFV9.Visible = true; cont++; }
        else RFV9.Visible = false;
        if (tbEmail.Text == "") { RFV10.Visible = true; cont++; }
        else RFV10.Visible = false;
        if (tbPaginaWeb.Text == "") { RFV11.Visible = true; cont++; }
        else RFV11.Visible = false;

        upDatos.Update();
        if (cont > 0) return false;
        else return true;
    }

    private void EmptyText()
    {
        tbCodigo.Text = "";
        tbContacto.Text = "";
        tbVehiculo.Text = "";
        CargaTipoPersona();
        tbNombre.Text = "";
        tbRazonSocial.Text = "";
        tbDocumento.Text = "";
        tbDireccion.Text = "";
        tbDistrito.Text = "";
        tbTelefono.Text = "";
        tbEmail.Text = "";
        tbPaginaWeb.Text = "";

        btnDetalleVehiculo.Enabled = false;
        btnDetalleContacto.Enabled = false;
    }

    #endregion

}