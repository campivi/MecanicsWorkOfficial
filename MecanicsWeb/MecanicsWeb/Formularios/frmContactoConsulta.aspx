<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="frmContactoConsulta.aspx.cs" Inherits="Formularios_frmVehiculoConsulta" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .FormTable {
            width: 467px;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            width: 98%;
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
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    Cliente:</td>
                                <td>
                                    <asp:TextBox ID="tbCliente" runat="server" Width="200px"></asp:TextBox> 
                                    <asp:Button ID="btnBuscarCliente" runat="server" Text="Button" />
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
                                    DNI:
                                </td>
                                <td>
                                    <asp:TextBox ID="tbDNI" runat="server" Width="200px" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbPlaca"
                                     ErrorMessage="La Placa es Obligatoria" CssClass="failureNotification" SetFocusOnError="true" 
                                     ToolTip="La Placa es Obligatoria">*</asp:RequiredFieldValidator>                           
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Teléfono:
                                </td>
                                <td>
                                   <asp:TextBox ID="tbTelefono" runat="server" Width="200px" ></asp:TextBox>
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbColor"
                                     ErrorMessage="El Color Materno es Obligatorio" CssClass="failureNotification" SetFocusOnError="true" 
                                     ToolTip="El Color Materno es Obligatorio">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Celular:
                                </td>
                                <td>
                                    <asp:TextBox ID="tbCelular" runat="server" Width="200px" MaxLength="10" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="NroDocumentoRequired0" runat="server" ControlToValidate="tbKilometraje"
                                        ErrorMessage="El Kilometraje es Obligatorio" CssClass="failureNotification" SetFocusOnError="true" 
                                        ToolTip="El Kilometraje es Obligatorio">*</asp:RequiredFieldValidator>        
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
                                <td class="auto-style3" colspan="2">
                                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" />
                                    <asp:Button ID="btnEditar" runat="server" Text="Editar" />
                                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
                                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
                                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>  
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
                    <legend>CONSULTA CONTACTO</legend>
                    <div class="row">
                        <table width="100%">
                            <tr>
                                <td>
                                    Buscar por:
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlBuscar" runat="server" Height="16px" Width="121px">
                                        <asp:ListItem></asp:ListItem>
                                        <asp:ListItem>DNI</asp:ListItem>
                                        <asp:ListItem>Nombre</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:TextBox ID="tbBuscar" runat="server" Width="300px" ></asp:TextBox>                               
                                </td>                      
                            </tr>  
                         </table>
                         <table width="50%">                        
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
                <table class="auto-style4">
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
                                        <asp:BoundField DataField="Cliente" HeaderText="DNI" ItemStyle-Width="250px"  >
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
