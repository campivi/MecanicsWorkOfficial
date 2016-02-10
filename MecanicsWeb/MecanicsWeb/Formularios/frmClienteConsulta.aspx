<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="frmClienteConsulta.aspx.cs" Inherits="Formularios_frmVehiculoConsulta" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .FormTable {
            width: 467px;
        }
        .auto-style3 {
            height: 28px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            text-align: center;
            height: 22px;
        }
        .auto-style6 {
            margin-left: 0px;
        }
        .auto-style7 {
            text-align: left;
        }
        .auto-style8 {
            width: 90px;
            text-align: left;
        }
        .auto-style9 {
            width: 97%;
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
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    Tipo:</td>
                                <td>
                                    <asp:DropDownList ID="ddlTipo" runat="server" Height="18px" Width="125px">
                                        <asp:ListItem></asp:ListItem>
                                        <asp:ListItem>NATURAL</asp:ListItem>
                                        <asp:ListItem>JURÍDICO</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbCodigo"
                                     ErrorMessage="El código es Obligatorio" CssClass="failureNotification" SetFocusOnError="true" 
                                     ToolTip="El código es Obligatorio">*</asp:RequiredFieldValidator>                           
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Nombre:</td>
                                <td>
                                    <asp:TextBox ID="tbNombre" runat="server" Width="200px" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="NombresRequired" runat="server" ControlToValidate="tbCliente"
                                     ErrorMessage="El Cliente es Obligatorio" CssClass="failureNotification" SetFocusOnError="true" 
                                     ToolTip="El Cliente es Obligatorio">*</asp:RequiredFieldValidator>                           
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Razón Social:
                                </td>
                                <td>
                                    <asp:TextBox ID="tbRazonSocial" runat="server" Width="200px" ></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    DNI/RUC:
                                </td>
                                <td>
                                   <asp:TextBox ID="tbID" runat="server" Width="200px" ></asp:TextBox>
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbColor"
                                     ErrorMessage="El Color Materno es Obligatorio" CssClass="failureNotification" SetFocusOnError="true" 
                                     ToolTip="El Color Materno es Obligatorio">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">
                                    Dirección:
                                </td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="tbDireccion" runat="server" Width="200px" MaxLength="10" ></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Distrito:</td>
                                <td>
                                    <asp:DropDownList ID="ddlDistrito" runat="server" Height="18px" Width="130px">
                                        <asp:ListItem></asp:ListItem>
                                        <asp:ListItem>Lima</asp:ListItem>
                                        <asp:ListItem>Callao</asp:ListItem>
                                        <asp:ListItem>San Borja</asp:ListItem>
                                        <asp:ListItem>Miraflores</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Teléfono:</td>
                                <td>
                                   <asp:TextBox ID="tbTelefono" runat="server" Width="200px" MaxLength="7"></asp:TextBox>     
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Email</td>
                                <td>
                                   <asp:TextBox ID="tbEmail" runat="server" Width="200px" ></asp:TextBox>     
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Pagina Web:</td>
                                <td>
                                   <asp:TextBox ID="tbPaginaWeb" runat="server" Width="200px" MaxLength="9"></asp:TextBox>    
                                </td>  
                            </tr>
                            <tr>
                                <td>Contacto:</td>
                                <td>
                                   <asp:TextBox ID="tbContacto" runat="server" Width="200px" MaxLength="9"></asp:TextBox>    
                                    <asp:Button ID="btAgregarContacto" runat="server" Text="Agregar" />
                                </td>
                            </tr>
                            <tr>
                                <td>Vehículo:</td>
                                <td>
                                   <asp:TextBox ID="tbVehiculo" runat="server" Width="200px" MaxLength="9"></asp:TextBox>    
                                    <asp:Button ID="btnAgregarVehiculo" runat="server" Text="Agregar" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4"></td>
                                <td class="auto-style4">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style5" colspan="2">
                                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" />
                                    <asp:Button ID="btnEditar" runat="server" Text="Editar" />
                                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
                                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
                                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                                </td>
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
                    <legend>CONSULTA CLIENTES</legend>
                    <div class="row">
                        <table width="100%">
                            <tr>
                                <td class="auto-style8">
                                    Buscar por:</td>
                                <td>
                                    <asp:DropDownList ID="ddlBuscar" runat="server" CssClass="auto-style6" Height="16px" Width="167px">
                                        <asp:ListItem></asp:ListItem>
                                        <asp:ListItem>Nombre</asp:ListItem>
                                        <asp:ListItem>DNI/RUC</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">
                                    &nbsp;</td>
                                <td class="auto-style7">
                                    <asp:TextBox ID="tbBuscar" runat="server" Width="230px"></asp:TextBox>
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
                <table class="auto-style9">
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
                                        <asp:TemplateField HeaderText="Nombre">
                                            <ItemTemplate>
                                                <asp:Label ID="lblID" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ID") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>                                                            
                                        <asp:BoundField DataField="Cliente" HeaderText="DNI/RUC" ItemStyle-Width="250px"  >
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
