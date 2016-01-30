<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="frmVehiculoMantenimiento.aspx.cs" Inherits="Formularios_frmVehiculoMantenimiento" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
            
  <fieldset>
        <legend>MANTENIMIENTO VEHICULOS</legend>

        <div class="row">
        <asp:UpdatePanel ID="upMantenimiento" runat="server" UpdateMode="Conditional">
	    <ContentTemplate>
            <table width="100%">
                <tr>
                    <td>
                        Código Vehículo :
                    </td>
                    <td>
                        <asp:TextBox ID="tbCodigo" runat="server" Width="100px"></asp:TextBox> 
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbCodigo"
                         ErrorMessage="El código es Obligatorio" CssClass="failureNotification" SetFocusOnError="true" 
                         ToolTip="El código es Obligatorio">*</asp:RequiredFieldValidator>                           
                    </td>
                </tr>

                <tr>
                    <td>
                        Cliente:</td>
                    <td>
                        <asp:TextBox ID="tbCliente" runat="server" Width="200px" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="NombresRequired" runat="server" ControlToValidate="tbCliente"
                         ErrorMessage="El Cliente es Obligatorio" CssClass="failureNotification" SetFocusOnError="true" 
                         ToolTip="El Cliente es Obligatorio">*</asp:RequiredFieldValidator>                           
                    </td>
                </tr>
                <tr>
                    <td>
                        Placa:
                    </td>
                    <td>
                        <asp:TextBox ID="tbPlaca" runat="server" Width="200px" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbPlaca"
                         ErrorMessage="La Placa es Obligatoria" CssClass="failureNotification" SetFocusOnError="true" 
                         ToolTip="La Placa es Obligatoria">*</asp:RequiredFieldValidator>                           
                    </td>
                    <td>
                        Color:
                    </td>
                    <td>
                       <asp:TextBox ID="tbColor" runat="server" Width="200px" ></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbColor"
                         ErrorMessage="El Color Materno es Obligatorio" CssClass="failureNotification" SetFocusOnError="true" 
                         ToolTip="El Color Materno es Obligatorio">*</asp:RequiredFieldValidator>
                    </td>
                    
                </tr>

                <tr>
                    <td>
                        Marca:
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlMarca" runat="server"></asp:DropDownList> 
                        <asp:RequiredFieldValidator ID="TipoDocumentoRequired" runat="server" ControlToValidate="ddlMarca"
                         ErrorMessage="Seleccione Marca de Vehículo" CssClass="failureNotification" InitialValue = "0"
                         ToolTip="Seleccione Marca de Vehículo">*</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        Kilometraje:</td>
                    <td>
                        <asp:TextBox ID="tbKilometraje" runat="server" Width="200px" MaxLength="10" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="NroDocumentoRequired" runat="server" ControlToValidate="tbKilometraje"
                            ErrorMessage="El Kilometraje es Obligatorio" CssClass="failureNotification" SetFocusOnError="true" 
                            ToolTip="El Kilometraje es Obligatorio">*</asp:RequiredFieldValidator>        
                    </td>
                </tr>

                <tr>
                    <td>
                        N° de Serie:</td>
                    <td>
                       <asp:TextBox ID="tbSerie" runat="server" Width="200px" MaxLength="7"></asp:TextBox>     
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbSerie"
                         ErrorMessage="El Número de Serie es Obligatorio" CssClass="failureNotification" SetFocusOnError="true" 
                         ToolTip="El Número de Serie es Obligatorio">*</asp:RequiredFieldValidator>                              
                    </td>
                    <td>
                        N° de Motor</td>
                    <td>
                       <asp:TextBox ID="tbMotor" runat="server" Width="200px" ></asp:TextBox>     
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="tbMotor"
                         ErrorMessage="El Número de Motor es Obligatorio" CssClass="failureNotification" SetFocusOnError="true" 
                         ToolTip="El Número de Motor es Obligatorio">*</asp:RequiredFieldValidator>                              
                    </td>
                </tr>

                <tr>
                    <td>
                        Año:</td>
                    <td>
                       <asp:TextBox ID="tbAnio" runat="server" Width="200px" MaxLength="9"></asp:TextBox>    
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="tbAnio"
                         ErrorMessage="El Año del Vehículo es Obligatorio" CssClass="failureNotification" SetFocusOnError="true" 
                         ToolTip="El Año del Vehículo es Obligatorio">*</asp:RequiredFieldValidator>                               
                    </td>                    
                </tr>

                
                <tr>
                    <td colspan="6"></td>
                </tr>        
                   
                <tr>
                    <td colspan="4" align="right">
                        <asp:Button ID="btnNuevo" runat="server" Text="Aceptar" ToolTip="Aceptar" 
                            onclick="btnNuevo_Click" />                                

                        <asp:Button ID="btnCerrar" runat="server" Text="Salir" ToolTip="Salir" 
                            onclick="btnCerrar_Click" CausesValidation="False" />
                    </td>
                </tr>
                </table>
                </ContentTemplate>
            </asp:UpdatePanel>   
        </div>

  </fieldset> 
</asp:Content>

