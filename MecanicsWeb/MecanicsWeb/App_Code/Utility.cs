using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI.WebControls;

public class Utility
{
    public Utility()
    { }

    public static string MostrarResultadoBusqueda(DataTable dtblDatos)
    {

        int iCount = dtblDatos.Rows.Count;
        string resultado = string.Empty;

        resultado = "Registros Encontrados: " + iCount.ToString("#0");

        return resultado;
    }

    public static string TextoVacio(string s)
    {
        if (String.IsNullOrEmpty(s))
            return "0";
        else
            return s;
    }

    public static void CargaComboTodos(DropDownList combo, DataTable dt, string valor, string texto)
    {
        combo.DataSource = dt;
        combo.DataValueField = valor;
        combo.DataTextField = texto;
        combo.DataBind();
        combo.Items.Insert(0, new ListItem("--TODOS--", "0"));
    }

    public static void CargaComboSeleccione(DropDownList combo, DataTable dt, string valor, string texto)
    {
        combo.DataSource = dt;
        combo.DataValueField = valor;
        combo.DataTextField = texto;
        combo.DataBind();
        combo.Items.Insert(0, new ListItem("--SELECCIONE--", "0"));
    }

}