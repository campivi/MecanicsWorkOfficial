<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="frmVehiculoConsulta.aspx.cs" Inherits="Formularios_frmVehiculoConsulta" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .FormTable {
            width: 467px;
        }
    </style>
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

    <table width="100%">
        <tr>
            <td class="FormTable">
                <fieldset>
                    <legend>MANTENIMIENTO VEHICULOS</legend>
                    <div class="row">
                        <table width="100%">
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
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
                                    <asp:TextBox ID="TextBox1" runat="server" Width="200px" ></asp:TextBox>
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
                                    <asp:TextBox ID="TextBox2" runat="server" Width="200px" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbPlaca"
                                     ErrorMessage="La Placa es Obligatoria" CssClass="failureNotification" SetFocusOnError="true" 
                                     ToolTip="La Placa es Obligatoria">*</asp:RequiredFieldValidator>                           
                                </td>
                            </tr>
                            <tr>
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
                            </tr>
                            <tr>
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
                            </tr>
                            <tr>
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
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </div>
              </fieldset> 
            </td>
            <td>
                <fieldset>
                    <legend>CONSULTA VEHICULO</legend>
                    <div class="row">
                        <table width="100%">
                            <tr>
                                <td>
                                    Cliente :
                                </td>
                                <td>
                                    <asp:TextBox ID="tbCliente" runat="server" Width="100px" MaxLength="10"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Placa :
                                </td>
                                <td>
                                    <asp:TextBox ID="tbPlaca" runat="server" Width="300px" ></asp:TextBox>                               
                                </td>                      
                            </tr>  
                         </table>
                         <table width="50%">                        
                             <tr>
                                <td align="right" width="72%"></td> 
                                <td align="right">
                                        <asp:UpdatePanel ID="upBuscar" runat="server" UpdateMode="Conditional">
                                            <ContentTemplate>                                   
                                                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" 
                                                 ToolTip="Iniciar Busqueda" onclick="btnBuscar_Click"  />
                                              </ContentTemplate>
                                        </asp:UpdatePanel>
                                </td>
                             </tr>
                         </table>
                        </div>
                </fieldset>
                <table width="50%">
                    <tr>
                        <td>
                            <asp:UpdatePanel ID="UpLabel" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>    
                                    <fieldset>
                                        <legend>Resultados de la Búsqueda</legend>
                                        <div class="row">
                                            <asp:Label ID="lblContador" runat="server" Text=""></asp:Label>
                                        </div>
                                    </fieldset>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="grilla">
                                <asp:UpdatePanel ID="up" runat="server" UpdateMode="Conditional" >
                                <ContentTemplate>
                                <asp:GridView ID="dgVehiculo" runat="server" SkinID="Grid" AutoGenerateColumns="False"
                                    Width="100%" EmptyDataText="No se encuentran datos" 
                                        onpageindexchanging="dgCliente_PageIndexChanging"  
                                        onrowcommand="dgCliente_RowCommand" onrowdatabound="dgCliente_RowDataBound" >
                                    <HeaderStyle BackColor="#0B3861" Font-Bold="True" ForeColor="White" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="ibModificar" runat="server" ImageUrl="~/App_Themes/Menu/2.png" SkinID="imgEdit" CommandName="Modificar" ToolTip="Modificar"
                                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "ID") %>'>
                                                </asp:ImageButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>   
                                        <asp:TemplateField HeaderText="ID">
                                            <ItemTemplate>
                                                <asp:Label ID="lblID" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ID") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>                                                            
                                        <asp:BoundField DataField="Cliente" HeaderText="Cliente" ItemStyle-Width="250px"  >
                                        <ItemStyle Width="250px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Marca" HeaderText="Marca"></asp:BoundField>
                                        <asp:BoundField DataField="Placa" HeaderText="Placa" ></asp:BoundField>
                                        <asp:BoundField DataField="UltFecha" HeaderText="Fecha de última revisión" ></asp:BoundField>
                                    </Columns>
                                </asp:GridView>
                                </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>

    
</asp:Content>
