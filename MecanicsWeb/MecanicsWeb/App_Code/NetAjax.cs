using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

public class NetAjax
{
    public static void JsLanzarExecutarScriptRecargarPagina(Page oPage, System.Type type, String key, String script, Boolean CabeceraScript)
    {
        ScriptManager.RegisterClientScriptBlock(oPage, type, key, script, CabeceraScript);
    }

    public static void JsLanzarExecutarScriptRecargarPagina(Page oPage, String key, String script, Boolean CabeceraScript)
    {
        ScriptManager.RegisterClientScriptBlock(oPage, oPage.GetType(), key, script, CabeceraScript);
    }

    public static void JsLanzarExecutarScriptRecargarPagina(System.Web.UI.Control oControl, System.Type type, String key, String script, Boolean CabeceraScript)
    {
        ScriptManager.RegisterClientScriptBlock(oControl, type, key, script, CabeceraScript);
    }

    public static void JsLanzarExecutarScriptRecargarPagina(System.Web.UI.Control oControl, String key, String script, Boolean CabeceraScript)
    {
        ScriptManager.RegisterClientScriptBlock(oControl, oControl.GetType(), key, script, CabeceraScript);
    }

    public static void RegistroControlPostBackControlAsync(ScriptManager oScriptManager, System.Web.UI.Control oControl)
    {
        oScriptManager.RegisterAsyncPostBackControl(oControl);
    }


    public static void JsMensajeAlert(Page oPage, String sMensaje)
    {
        string strMensaje = JsMensajeAlert(sMensaje);
        JsLanzarExecutarScriptRecargarPagina(oPage, "MensajeAlertWeb", strMensaje, true);
    }

    public static void JsMensajeAlert(Page oPage, String sMensaje, String MensajeNombre)
    {
        string strMensaje = JsMensajeAlert(sMensaje);
        JsLanzarExecutarScriptRecargarPagina(oPage, MensajeNombre, strMensaje, true);
    }

    public static String JsMensajeAlert(String mensaje)
    {
        return ("alert('" + mensaje + "'); ");
    }

}
