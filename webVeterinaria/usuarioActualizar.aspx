<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="usuarioActualizar.aspx.cs" Inherits="webVeterinaria.usuarioActualizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
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
                        <asp:Label ID="lblTítulo" runat="server" Text="Actualizar Usuario" Font-Size="35px" font-weight="bold;"></asp:Label>
                    </strong>
                    <br />
                  
                    <div class="mensaje">
                        <asp:Label ID="lblmensaje" runat="server" Text="Mensaje" Visible="false" CssClass="auto-style1" font-weight="500"></asp:Label>
            
                    </div>
                </div>
                <div class="d-flex justify-content-center">
                    <section class="cold-md-5" Style="margin-left: 10px;">
                        <div>
                            <p class="mb-0 mt-3">Id</p>
                            <div class="input-group w-20">
                                    
                                    <asp:TextBox ID="txtId" runat="server" CssClass="input form-control mr-sm-0"  type="search"></asp:TextBox>
                                <asp:Button ID="btn_buscar" runat="server" Text="Buscar" CssClass="mr-sm-1 btn btn-primary" OnClick="btn_buscar_Click" />
                                    
                                </div>
                           
                        </div>
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
                        <br />
                        <br />
                        <br />
                        <div>
                            <asp:Button ID="Button1" runat="server" Text="Guardar" Style=" margin-top: 40px;" CssClass=" btn btn-dark" OnClientClick="return ValidarCampo();" Height="40px" Width="270px"  />
                           
                        </div>
                        
                    </section>                  
                </div>
            

            </div>
        </div>
    </div>
    </div>
</asp:Content>
