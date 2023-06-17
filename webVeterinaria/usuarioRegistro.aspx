<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="usuarioRegistro.aspx.cs" Inherits="webVeterinaria.usuarioRegistro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <style>
       div .conte{
           font-family: UltimaAlt;
       }
       div .cold-md-12{
           background:white;
       }
    </style>
    <div class="conte">
        <div class="container d-flex justify-content-center mt-5">
        <div class="cold-md-12 border shadow" style="width: 800px;">
            <div class="tab-pane p-5 justify-content-center px-5" id="newUser-tab">
                <div class="text-center my-3">
                    <strong>
                        <asp:Label ID="lblTítulo" runat="server" Text="Nuevo Usuario" Font-Size="35px" font-weight="bold;"></asp:Label>
                    </strong>
                    <br />
                    <div class="mensaje">
                        <asp:Label ID="lblmensaje" runat="server" Text="Mensaje" Visible="false" CssClass="auto-style1" font-weight="500"></asp:Label>
                    </div>
                </div>
                <div class="d-flex justify-content-center">
                    <section class="cold-md-5" Style="margin-left: 10px;">
                        <div>
                            <p class="mb-0 mt-3">Usuario</p>
                            <asp:TextBox ID="txtUser" runat="server" CssClass="form-control" ></asp:TextBox>
                        </div>
                        <div>
                            <p class="mb-0 mt-3">Contraseña</p>
                            <asp:TextBox ID="txtPass" runat="server" type="password" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div>
                            <p class="mb-0 mt-3">Nombres</p>
                            <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div>
                            <p class="mb-0 mt-3">Correo</p>
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                       
                    </section>
                    <section class="cold-md-5" Style="margin-left: 80px;">                      
                        <div>
                            <p class="mb-0 mt-3" >Celular</p>
                            <asp:TextBox ID="txtContact" runat="server" CssClass="form-control" ></asp:TextBox>
                        </div>
                        <div >
                            <p class="mb-0 mt-3">Tipo</p>
                            <asp:DropDownList ID="cbxTipoUsu" Style="width:220px;" CssClass="btn btn-white btn-sm dropdown-toggle" runat="server" ></asp:DropDownList>
                        </div>
                        <div style="margin-top:50px">
                            <p class="mb-0 mt-3">Estado</p>
                            <asp:DropDownList ID="cbxEstadoUsu" Style="width:220px;" CssClass="btn btn-white btn-sm dropdown-toggle" runat="server"></asp:DropDownList>
                        </div>
                        
                    </section>                  
                </div>
                <div class="d-flex justify-content-center">
                    <section class="cold-md-5">
                        <div>
                            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" Style="margin-left: 20px; margin-top: 40px;" CssClass=" btn btn-dark" OnClientClick="return ValidarCampo();" Height="40px" Width="250px" OnClick="btnRegistrar_Click" />
                           
                        </div>
                        
                    </section>
                    <section class="cold-md-5">
                        <div>
                            <asp:Button ID="btnCancelar" runat="server" Text="Regresar" Style="margin-left: 50px; margin-top: 40px;" CssClass=" btn btn-secondary" Height="40px" Width="250px" />
                        </div>
                    </section>
                </div>

            </div>
        </div>
    </div>
    </div>
</asp:Content>
