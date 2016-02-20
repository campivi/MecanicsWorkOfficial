<%@ Page Title="" Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="frmFormularioInicio.aspx.cs" Inherits="Formulario_frmFormularioInicio" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            width: 254px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    
    <table class="auto-style1">
        <tr>
            <td class="auto-style3" style="background-color:#3a4f63 ">
                <div class="clear hideSkiplink">
                        <asp:Menu ID="NavigationMenu" MaximumDynamicDisplayLevels="2" runat="server" CssClass="menu"
                        EnableViewState="false" IncludeStyleBlock="false" Orientation="Vertical">
                        </asp:Menu>
                </div>
            </td>
            <td align="center" valign="middle" style=" height:530px; background-image: url(../App_Themes/img/Fondo.png);">
                <table style="border-collapse: collapse; text-align: center">
                    <tr style="text-align: center">
                        <td align="center" colspan="1" rowspan="1" class="CuadrosInicio">
                            
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>            
</asp:Content>
