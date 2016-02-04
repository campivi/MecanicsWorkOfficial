<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="frmVehiculoConsulta.aspx.cs" Inherits="Formularios_frmVehiculoConsulta" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

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
                    <td>
                        Marca :
                    </td>
                    <td>
                        <asp:DropDownList ID="dllMarca" runat="server"></asp:DropDownList>
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
                <tr>
                    <td colspan="4"></td>
                </tr>   
             </table>

                <table width="100%">                        
                 <tr>
                    <td align="right" width="72%"></td>
                    <td align="right">
                            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" 
                             ToolTip="Nuevo Personal" onclick="btnNuevo_Click" />  
                    </td>   
                    <td align="right">
                            <asp:UpdatePanel ID="upBuscar" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>                                   
                                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" 
                                     ToolTip="Iniciar Busqueda" onclick="btnBuscar_Click"  />
                                  </ContentTemplate>
                            </asp:UpdatePanel>
                    </td>
                     <td align="right">
                            <asp:Button ID="btnCerrar" runat="server" Text="Cerrar" ToolTip="Salir" onclick="btnCerrar_Click" />
                    </td>
                 </tr>
                </table>
          
        </div>
    </fieldset>
    <table width="100%">
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
</asp:Content>
