<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrudAlmacen.aspx.cs" Inherits="webVeterinaria.CrudAlmacen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset style="width: 500px">
                <legend>REGISTRO DE ALMACEN </legend>
                <table>
                    <tr>
                        <td>NOMBRE</td>
                        <td>
                            <asp:TextBox ID="txtNombre" runat="server" Style="margin-right: 59px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>PRESENTACION</td>
                        <td>
                            <asp:TextBox ID="txtPresentacion" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>PRECIO</td>
                        <td>
                            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>STOCK</td>
                        <td>
                            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>ESTADO</td>
                        <td>
                            <asp:DropDownList ID="ddlEstado" runat="server">
                                <asp:ListItem Value="0">Seleccione un Estado</asp:ListItem>
                                <asp:ListItem Value="1">Activo</asp:ListItem>
                                <asp:ListItem Value="2">Inactivo</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td class="style1">
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit"
                                OnClick="btnSubmit_Click" />
                            <asp:Button ID="btnCancel" runat="server" Text="Cancel"
                                OnClick="btnCancel_Click" />
                        </td>
                    </tr>




                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="lblStatus" runat="server" Text="" Style="color: #FF3300"></asp:Label>
                        </td>
                    </tr>

                    <tr>
                        <td>&nbsp;</td>
                        <td class="style1">
                            <asp:Button ID="BtnSearch" runat="server" Text="Buscar" OnClick="BtnSearch_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:GridView ID="grdWcfTest" runat="server" AutoGenerateColumns="False" DataKeyNames="IDITEM"
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

                                    <asp:TemplateField HeaderText="Edit" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="imgBtn" runat="server" CausesValidation="false" CommandArgument='<%#Eval("IDITEM") %>'
                                                OnCommand="imgEdit_Command" ImageUrl="~/Images/editar2.png"
                                                ToolTip="Edit" />
                                        </ItemTemplate>

                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Delete" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">

                                        <ItemTemplate>
                                            <asp:ImageButton ID="imgDel" runat="server" CausesValidation="false" CommandArgument='<%#Eval("IDITEM") %>'
                                                CommandName="Delete" OnCommand="imgDel_Command" ImageUrl="~/Images/eliminar2.png"
                                                ToolTip="Delete" OnClientClick="return confirm('ESTAS SEGURO QUE QUIERES ELIMINAR?')" />
                                        </ItemTemplate>

                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:TemplateField>
                                </Columns>
                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </fieldset>
        </div>
    </form>
</body>
</html>
