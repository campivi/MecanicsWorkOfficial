<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="frmClienteConsulta.aspx.cs" Inherits="Formularios_frmClienteConsulta" %>

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
                    <legend>MANTENIMIENTO CLIENTES</legend>
                    <div class="row">
                        <table width="100%">
                            <asp:UpdatePanel ID="upDatos" runat="server" UpdateMode="Conditional">
                            <ContentTemplate> 
                            <tr>
                                <td>Código:</td>
                                <td>
                                    <asp:TextBox ID="tbCodigo" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Contacto:</td>
                                <td>
                                    <asp:TextBox ID="tbContacto" runat="server" Width="200px"></asp:TextBox>    
                                    <asp:Button ID="btnAgregarContacto" runat="server" text="Agregar" OnClick="btnBuscarContacto_Click" />
                                    <asp:Button ID="btnDetalleContacto" runat="server" text="Detalle" Enabled="false" OnClick="btnDetalleContacto_Click" />
                                    <asp:Label ID="RFV1" runat="server" Text="*"  CssClass="failureNotification" Visible="false" ToolTip="El Contacto es Obligatorio"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Vehículo:</td>
                                <td>
                                    <asp:TextBox ID="tbVehiculo" runat="server" Width="200px" ></asp:TextBox>    
                                    <asp:Button ID="btnAgregarVehiculo" runat="server" text="Agregar" OnClick="btnBuscarVehiculo_Click" />
                                    <asp:Button ID="btnDetalleVehiculo" runat="server" text="Detalle" Enabled="false" OnClick="btnDetalleVehiculo_Click" />
                                    <asp:Label ID="RFV2" runat="server" Text="*"  CssClass="failureNotification" Visible="false" ToolTip="El Vehiculo es Obligatorio"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Tipo:</td>
                                <td>
                                    <asp:DropDownList ID="ddlTipo" runat="server" Enabled="false" Width="125px"></asp:DropDownList>                        
                                    <asp:Label ID="RFV3" runat="server" Text="*"  CssClass="failureNotification" Visible="false" ToolTip="El Tipo de Cliente es Obligatorio"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Nombre:</td>
                                <td>
                                    <asp:TextBox ID="tbNombre" runat="server" Enabled="false" Width="200px" ></asp:TextBox>
                                    <asp:Label ID="RFV4" runat="server" Text="*"  CssClass="failureNotification" Visible="false" ToolTip="El Nombre es Obligatorio"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Razón Social:
                                </td>
                                <td>
                                    <asp:TextBox ID="tbRazonSocial" runat="server" Enabled="false" Width="200px" ></asp:TextBox>
                                    <asp:Label ID="RFV5" runat="server" Text="*"  CssClass="failureNotification" Visible="false" ToolTip="El Razon Social es Obligatorio"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    DNI/RUC:
                                </td>
                                <td>
                                   <asp:TextBox ID="tbDocumento" runat="server" Enabled="false" Width="200px" MaxLength="12"></asp:TextBox>
                                   <asp:Label ID="RFV6" runat="server" Text="*"  CssClass="failureNotification" Visible="false" ToolTip="El Documento es Obligatorio"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Dirección:
                                </td>
                                <td>
                                    <asp:TextBox ID="tbDireccion" runat="server" Enabled="false" Width="200px"  ></asp:TextBox>
                                    <asp:Label ID="RFV7" runat="server" Text="*"  CssClass="failureNotification" Visible="false" ToolTip="La Dirección es Obligatoria"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Distrito:</td>
                                <td>
                                    <asp:TextBox ID="tbDistrito" runat="server" Enabled="false" Width="200px" ></asp:TextBox>
                                    <asp:Label ID="RFV8" runat="server" Text="*"  CssClass="failureNotification" Visible="false" ToolTip="El Distrito es Obligatorio"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Teléfono:</td>
                                <td>
                                   <asp:TextBox ID="tbTelefono" runat="server" Enabled="false" Width="200px" MaxLength="9"></asp:TextBox>
                                   <asp:Label ID="RFV9" runat="server" Text="*"  CssClass="failureNotification" Visible="false" ToolTip="El Teléfono es Obligatorio"></asp:Label>     
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Email</td>
                                <td>
                                   <asp:TextBox ID="tbEmail" runat="server" Enabled="false" Width="200px" ></asp:TextBox>
                                    <asp:Label ID="RFV10" runat="server" Text="*"  CssClass="failureNotification" Visible="false" ToolTip="El Email es Obligatorio"></asp:Label>     
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Pagina Web:</td>
                                <td>
                                   <asp:TextBox ID="tbPaginaWeb" runat="server" Enabled="false" Width="200px" ></asp:TextBox>
                                    <asp:Label ID="RFV11" runat="server" Text="*"  CssClass="failureNotification" Visible="false" ToolTip="La Página Web es Obligatoria"></asp:Label>    
                                </td>  
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td align="right">
                                    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" onclick="btnNuevo_Click" />
                                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" onclick="btnGuardar_Click" />
                                    <asp:Button ID="btnCerrar" runat="server" Text="Cerrar" onclick="btnCerrar_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            </ContentTemplate>
                            </asp:UpdatePanel>
                        </table>
                    </div>
              </fieldset> 
            </td>
            <td>
                <fieldset>
                    <legend>CONSULTA CLIENTES</legend>
                    <div class="row">
                        <table width="100%">
                            <tr>
                                <td> Nombre:</td>
                                <td>
                                    <asp:TextBox ID="tbNombreSearch" runat="server" Width="250px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td> DNI/RUC:</td>
                                <td>
                                    <asp:TextBox ID="tbDocumentoSearch" runat="server" Width="200px"></asp:TextBox>
                                </td>                      
                            </tr>  
                         </table>
                         <table width="100%">                        
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
                <table width="100%">
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="grilla">
                                <asp:UpdatePanel ID="up" runat="server" UpdateMode="Conditional" >
                                <ContentTemplate>
                                <asp:GridView ID="dgCliente" runat="server" SkinID="Grid" AutoGenerateColumns="False"
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
                                        <asp:BoundField DataField="Nombre" HeaderText="Nombre"></asp:BoundField>     
                                        <asp:BoundField DataField="Tipo" HeaderText="Tipo"></asp:BoundField>                                                      
                                        <asp:BoundField DataField="Documento" HeaderText="DNI/RUC" ItemStyle-Width="250px"  >
                                        <ItemStyle Width="250px" />
                                        </asp:BoundField>
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
