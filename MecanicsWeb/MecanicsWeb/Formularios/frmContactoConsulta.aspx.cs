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

public partial class Formularios_frmContactoConsulta : Base
{
    #region Inicialización

    BLParametria objParametria = new BLParametria();
    BEParametria EParametria = new BEParametria();
    BEContacto eContacto = new BEContacto();
    BLContacto objContacto = new BLContacto();

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {
                CargaTipoDocumento();

                if (Session["FLAG"].ToString() != "0")
                {
                    btnGuardar.Enabled = true;
                }

                    if (!(Request.QueryString["Cod"] == null))
                {
                    eContacto.ID_Contacto = Request.QueryString["Cod"].ToString();
                    DataTable dtContacto = new DataTable();
                    dtContacto = objContacto.ListarContacto(eContacto);
                    DataRow dr = dtContacto.Rows[0];

                    tbCodigo.Text = dr["ID"].ToString();
                    tbNombre.Text = dr["Nombre"].ToString();
                    ddlTipoDocumento.SelectedValue = dr["TipoDocumento"].ToString();
                    tbDocumento.Text = dr["Documento"].ToString();
                    tbTelefono.Text = dr["Telefono"].ToString();
                    tbCelular.Text = dr["Celular"].ToString();
                    
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

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        EmptyText();
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

    protected void dgCliente_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        dgContacto.PageIndex = e.NewPageIndex;
        Buscar();
    }

    protected void dgCliente_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Modificar"))
        {
            Response.Redirect("frmContactoConsulta.aspx?Cod=" + e.CommandArgument.ToString());
        }
        if (e.CommandName.Equals("Seleccionar"))
        {
            if (Session["FLAG"].ToString() != "0")
            {
                Session["Cliente_IDContacto"] = e.CommandArgument.ToString();
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
            eContacto.Nombre = tbNombreSearch.Text.TrimEnd();
            eContacto.Documento = tbDocumentoSearch.Text.TrimEnd();
            DataTable dtContacto = (DataTable)objContacto.ConsultarContacto(eContacto);
            dgContacto.DataSource = dtContacto;
            dgContacto.DataBind();

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
            if (tbCodigo.Text == "") eContacto.ID_Contacto = "0";
            else eContacto.ID_Contacto = tbCodigo.Text.TrimEnd();
            eContacto.ID_Cliente = "0";
            eContacto.Nombre = tbNombre.Text.TrimEnd();
            eContacto.TipoDocumento = ddlTipoDocumento.SelectedValue;
            eContacto.Documento = tbDocumento.Text.TrimEnd();
            eContacto.Telefono = tbTelefono.Text.TrimEnd();
            eContacto.Celular = tbCelular.Text.TrimEnd();

            objContacto.MantenimientoContacto(ACCION, eContacto);
            
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

    private void CargaTipoDocumento()
    {
        DataTable dtParametros = new DataTable();
        EParametria.IDPadre = Constantes.PARAMETRIAS.TIPO_DOC;
        dtParametros = objParametria.ConsultarParametriaCod(EParametria);
        Utility.CargaComboSeleccione(ddlTipoDocumento, dtParametros, "Ptr_Codigo", "Ptr_Descripcion");
    }

    private bool Verificar()
    {
        int cont = 0;
        
        if (tbNombre.Text == "") { RFV2.Visible = true; cont++; }
        else RFV2.Visible = false;
        if (ddlTipoDocumento.Text == "") { RFV3.Visible = true; cont++; }
        else RFV3.Visible = false;
        if (tbDocumento.Text == "") { RFV4.Visible = true; cont++; }
        else RFV4.Visible = false;
        if (tbTelefono.Text == "") { RFV5.Visible = true; cont++; }
        else RFV5.Visible = false;
        if (tbCelular.Text == "") { RFV6.Visible = true; cont++; }
        else RFV6.Visible = false;

        upDatos.Update();
        if (cont > 0) return false;
        else return true;
    }

    private void EmptyText()
    {
        tbCodigo.Text = "";
        tbNombre.Text = "";
        CargaTipoDocumento();
        tbDocumento.Text = "";
        tbTelefono.Text = "";
        tbCelular.Text = "";
        btnGuardar.Enabled = false;
    }

    #endregion

}