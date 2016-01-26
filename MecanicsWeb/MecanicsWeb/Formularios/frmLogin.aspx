<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="Formularios_frmLogin" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
    .modalBackground
    {
        background-color: Black;
        filter: alpha(opacity=90);
        opacity: 0.8;
    }
    .modalPopup
    {
        background-color: #FFFFFF;
        border-width: 3px;
        border-style: solid;
        border-color: black;
        padding-top: 10px;
        padding-left: 10px;
        width: 300px;
        height: 140px;
    }    
    .st_ModalBackground
    {
	    background-color: #C5C5C5;
	    filter: alpha(opacity=20);
	    opacity: 0.9;
    }
    .st_PanelPopupAjax01
    {   
        border:2px solid #000; 
        border-color:#6699CC;
        background-color:White;
        padding:5px;
    } 
    .Cuadros
    {    
    background-image:url(../App_Themes/img/FondoLogin.png);
    background-repeat:no-repeat; 
    padding: 15px 0px 0px 10px;
    height:210px;
    width:300px
    }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <asp:UpdatePanel ID="upLogin" runat="server" UpdateMode="Always">
        <ContentTemplate>
            <table width="100%">
                <tr>
                    <td align="right" valign="middle" style="padding-right: 35%; height: 530px; ">
                        <table>
                            <tr>
                                <td align="center" style="background-image: url(../App_Themes/img/FondoLogin.png); height:230px; width:300px; background-color:Transparent; background-repeat:no-repeat;" colspan="1" rowspan="1">
                                    <table>
                                        <tr>
                                            <td>
                                                <div class="title1">
                                                    ACCEDE A TU CUENTA
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="UserNameLabel" runat="server">Nombre de usuario:</asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:TextBox ID="txtUsuario" runat="server" Width="200px" MaxLength="150"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="txtUsuario"
                                                    CssClass="failureNotification" ErrorMessage="El nonbre de usuario es obligatorio."
                                                    ToolTip="El nombre de usuario es obligatorio." ValidationGroup="login">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="PasswordLabel" runat="server">Contraseña:</asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:TextBox ID="txtContrasena" runat="server" TextMode="Password" Width="200px"
                                                    MaxLength="80"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="ContrasenaRequerida" runat="server" ControlToValidate="txtContrasena"
                                                    ErrorMessage="La contraseña es obligatoria." CssClass="failureNotification" ToolTip="La contraseña es obligatoria."
                                                    ValidationGroup="login">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                                <div style="margin-right: 27px; margin-top: 10px; z-index: -10;">
                                                    <asp:Button ID="btnIngresar" CssClass="btn-rega" runat="server" Text="Ingresar" OnClick="btnIngresar_Click"
                                                        Style="margin-right: 12px; margin-top: 10px;" />
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="failureNotification"
                ValidationGroup="login" ShowSummary="false" ShowMessageBox="true" />
        </ContentTemplate>
    </asp:UpdatePanel>

    <asp:UpdatePanel ID="upRoles" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <asp:ModalPopupExtender ID="mpdRoles" runat="server" BackgroundCssClass="st_ModalBackground"
            BehaviorID="behavior01" PopupControlID="pnlRoles" TargetControlID="btnPopup01">
            </asp:ModalPopupExtender>               
            <asp:Button Style="display: none;" ID="btnPopup01" SkinID="btninvi" runat="server"></asp:Button>
            <asp:Panel runat="server" ID="pnlRoles" Width="600px" Height="200px" Style="border:2px solid #000; border-color:#6699CC; background-color:White; padding:5px; ">
                <fieldset>
                    <legend style="color: White; border: 1px solid gray; background: #4b6c9e; font-weight: bold; width: 101%; padding: 5px; margin-bottom: 10px; font-size: 14px; line-height: inherit; height: 26px;" >BIENVENIDO</legend>
                    <div class="row">
                        <asp:UpdatePanel ID="upSeleccioneRol" runat="server" UpdateMode="Always">
                            <ContentTemplate>
                                <table width="100%">
                                    <tr>
                                        <td colspan="4">
                                            Por favor seleccione el rol con el que desea ingresar.
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Rol :
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddlRol" runat="server">
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="RolRequired" runat="server" ControlToValidate="ddlRol"
                                                CssClass="failureNotification" ErrorMessage="Seleccione Rol" InitialValue="0"
                                                SetFocusOnError="true" ToolTip="Seleccione Rol" ValidationGroup="RolesGrupo">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Local:
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddlLocal" runat="server">
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlLocal"
                                                CssClass="failureNotification" ErrorMessage="Seleccione Local" InitialValue="0"
                                                SetFocusOnError="true" ToolTip="Seleccione Local" ValidationGroup="RolesGrupo">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" colspan="4">
                                            <asp:Button ID="btnSeleccionar" runat="server" OnClick="btnSeleccionar_Click" Text="Seleccionar"
                                                ToolTip="Seleccionar" ValidationGroup="RolesGrupo" />
                                        </td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </fieldset>
                <br />                
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

