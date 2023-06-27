<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="BuscarAlmacen.aspx.cs" Inherits="webVeterinaria.BuscarAlmacen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <fieldset style="width: 500px">
            <legend>REGISTRO DE ALMACEN </legend>
            <table>
                <tr>
                    <td class="auto-style1"></td>
                    <td class="auto-style1">
                        <asp:Label ID="lblBuscar" runat="server" Text="Buscar"></asp:Label>
                        <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
                        <asp:Button ID="BtnSearch" runat="server" Text="Buscar" OnClick="BtnSearch_Click" />
                        <asp:Button ID="BtnListar" runat="server" Text="Listar" OnClick="BtnListar_Click" />
                    </td>
                </tr>

                <asp:GridView ID="grdWcfTest" runat="server" AutoGenerateColumns="False"
                    CellPadding="5" ForeColor="#333333">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:TemplateField HeaderText="Nombre" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:Label ID="lblNombre" runat="server" Text='<%#Eval("NOMBRE")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Presentacion" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:Label ID="lblPresentacion" runat="server" Text='<%#Eval("PRESENTACION")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Precio" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:Label ID="lblPrecio" runat="server" Text='<%#Eval("PRECIO") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Stock" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:Label ID="lblStock" runat="server" Text='<%#Eval("STOCK") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:HyperLink DataNavigateUrlFile="Codigo" DataNavigateUrlFormatString="CRUDALMACEN.aspx?id={0}"
                                    Text="Modificar" runat="server" ShowHeader="False"></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>



                    </Columns>
                </asp:GridView>

            </table>

        </fieldset>
    </div>
</asp:Content>
