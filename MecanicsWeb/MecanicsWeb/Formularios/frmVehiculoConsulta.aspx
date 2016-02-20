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
                            <asp:UpdatePanel ID="upDatos" runat="server" UpdateMode="Conditional">
                            <ContentTemplate> 
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    Código Vehículo :
                                </td>
                                <td>
                                    <asp:TextBox ID="tbCodigo" runat="server" Width="100px" Enabled="false"></asp:TextBox>                          
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Placa:
                                </td>
                                <td>
                                    <asp:TextBox ID="tbPlaca" runat="server" Width="200px" ></asp:TextBox>
                                    <asp:Label ID="RFV2" runat="server" Text="*" CssClass="failureNotification" Visible="false" ToolTip="La Placa es Obligatoria"></asp:Label>                         
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Color:
                                </td>
                                <td>
                                   <asp:TextBox ID="tbColor" runat="server" Width="200px" ></asp:TextBox>
                                   <asp:Label ID="RFV3" runat="server" Text="*" CssClass="failureNotification" Visible="false" ToolTip="El Color es Obligatorio"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Marca:
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlMarca" runat="server" Width="200px"></asp:DropDownList>
                                    <asp:Label ID="RFV4" runat="server" Text="*" CssClass="failureNotification" Visible="false" ToolTip="Seleccione Marca de Vehículo"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Kilometraje:</td>
                                <td>
                                    <asp:TextBox ID="tbKilometraje" runat="server" Width="200px" MaxLength="10" ></asp:TextBox>
                                    <asp:Label ID="RFV5" runat="server" Text="*" CssClass="failureNotification" Visible="false" ToolTip="El Kilometraje es Obligatorio"></asp:Label>   
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    N° de Serie:</td>
                                <td>
                                   <asp:TextBox ID="tbSerie" runat="server" Width="200px"></asp:TextBox>     
                                   <asp:Label ID="RFV6" runat="server" Text="*" CssClass="failureNotification" Visible="false" ToolTip="El Número de Serie es Obligatorio"></asp:Label>                              
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    N° de Motor</td>
                                <td>
                                   <asp:TextBox ID="tbMotor" runat="server" Width="200px" ></asp:TextBox>     
                                   <asp:Label ID="RFV7" runat="server" Text="*" CssClass="failureNotification" Visible="false" ToolTip="El Número de Motor es Obligatorio"></asp:Label>                                
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Año:</td>
                                <td>
                                   <asp:TextBox ID="tbAnio" runat="server" Width="200px" MaxLength="4"></asp:TextBox>    
                                   
                                   <asp:Label ID="RFV8" runat="server" Text="*" CssClass="failureNotification" Visible="false" ToolTip="El Año del Vehículo es Obligatorio"></asp:Label>                                 
                                   
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
                                <td align="right">
                                    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" onclick="btnNuevo_Click" />
                                    <asp:Button ID="btnGuardar" runat="server" Enabled="false" Text="Guardar" onclick="btnGuardar_Click" />
                                    <asp:Button ID="btnCerrar" runat="server" Text="Cerrar" onclick="btnCerrar_Click" />
                                </td>
                            </tr>
                            </ContentTemplate>
                            </asp:UpdatePanel>
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
                                    <asp:TextBox ID="tbClienteSearch" runat="server" Width="250px" MaxLength="10"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Placa :
                                </td>
                                <td>
                                    <asp:TextBox ID="tbPlacaSearch" runat="server" Width="200px" ></asp:TextBox>                               
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
                                <asp:GridView ID="dgVehiculo" runat="server" SkinID="Grid" AutoGenerateColumns="False"
                                    Width="100%" EmptyDataText="No se encuentran datos" 
                                        onpageindexchanging="dgCliente_PageIndexChanging"  
                                        onrowcommand="dgCliente_RowCommand" onrowdatabound="dgCliente_RowDataBound" >
                                    <HeaderStyle BackColor="#0B3861" Font-Bold="True" ForeColor="White" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="ibSeleccionar" runat="server" ImageUrl="~/App_Themes/Menu/11.png" Width="16px" Height="16px" SkinID="imgEdit" CommandName="Seleccionar" ToolTip="Seleccionar"
                                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "ID") %>'>
                                                </asp:ImageButton>
                                            </ItemTemplate>
                                        </asp:TemplateField> 
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
                                        <asp:BoundField DataField="IDCliente" HeaderText="Cliente" ItemStyle-Width="250px"  >
                                        <ItemStyle Width="250px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Marca" HeaderText="Marca"></asp:BoundField>
                                        <asp:BoundField DataField="Placa" HeaderText="Placa" ></asp:BoundField>
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
