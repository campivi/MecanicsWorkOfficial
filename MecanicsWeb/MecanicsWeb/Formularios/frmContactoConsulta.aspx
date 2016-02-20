<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="frmContactoConsulta.aspx.cs" Inherits="Formularios_frmContactoConsulta" %>

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
                    <legend>MANTENIMIENTO CONTACTO</legend>
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
                                    Código:</td>
                                <td>
                                    <asp:TextBox ID="tbCodigo" runat="server" Enabled="false"></asp:TextBox> 
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Nombre:</td>
                                <td>
                                    <asp:TextBox ID="tbNombre" runat="server" Width="200px" ></asp:TextBox>
                                    <asp:Label ID="RFV2" runat="server" Text="*"  CssClass="failureNotification" Visible="false" ToolTip="El Nombre es Obligatorio"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Tipo Documento:</td>
                                <td>
                                    <asp:DropDownList ID="ddlTipoDocumento" runat="server"></asp:DropDownList>
                                    <asp:Label ID="RFV3" runat="server" Text="*"  CssClass="failureNotification" Visible="false" ToolTip="El Tipo de Documento es Obligatorio"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    DNI:
                                </td>
                                <td>
                                    <asp:TextBox ID="tbDocumento" runat="server" Width="200px" ></asp:TextBox> 
                                    <asp:Label ID="RFV4" runat="server" Text="*"  CssClass="failureNotification" Visible="false" ToolTip="El Documento es Obligatorio"></asp:Label>                        
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Teléfono:
                                </td>
                                <td>
                                   <asp:TextBox ID="tbTelefono" runat="server" Width="200px" MaxLength="7" ></asp:TextBox>
                                    <asp:Label ID="RFV5" runat="server" Text="*"  CssClass="failureNotification" Visible="false" ToolTip="El Teléfono es Obligatorio"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Celular:
                                </td>
                                <td>
                                    <asp:TextBox ID="tbCelular" runat="server" Width="200px" MaxLength="9" ></asp:TextBox>  
                                    <asp:Label ID="RFV6" runat="server" Text="*"  CssClass="failureNotification" Visible="false" ToolTip="El Celular es Obligatorio"></asp:Label>   
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td align="right">
                                    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" onclick="btnNuevo_Click" />
                                    <asp:Button ID="btnGuardar" runat="server" Enabled="false" Text="Guardar" onclick="btnGuardar_Click" />
                                    <asp:Button ID="btnCerrar" runat="server" Text="Cerrar" onclick="btnCerrar_Click" />
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
                            </ContentTemplate>
                            </asp:UpdatePanel>
                        </table>
                    </div>
              </fieldset> 
            </td>
            <td>
                <fieldset>
                    <legend>CONSULTA CONTACTO</legend>
                    <div class="row">
                        <table width="100%">
                            <tr>
                                <td>  DNI: </td>
                                <td>
                                    <asp:TextBox ID="tbDocumentoSearch" runat="server" Width="300px" ></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td> Nombre: </td>
                                <td>
                                    <asp:TextBox ID="tbNombreSearch" runat="server" Width="300px" ></asp:TextBox>                               
                                </td>                      
                            </tr>  
                         </table>
                         <table width="100%">                        
                             <tr>
                                <td align="right" width="72%"></td> 
                                <td align="right">
                                        <asp:UpdatePanel ID="upBuscar" runat="server" UpdateMode="Conditional">
                                            <ContentTemplate>                                   
                                                <asp:Button ID="btnBuscarContacto" runat="server" Text="Buscar" 
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
                                <asp:GridView ID="dgContacto" runat="server" SkinID="Grid" AutoGenerateColumns="False"
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
                                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" ItemStyle-Width="250px"  >
                                        <ItemStyle Width="250px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Documento" HeaderText="Documento"></asp:BoundField>
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
