<%@ Page Title="" Language="C#" MasterPageFile="~/Acceso.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="webVeterinaria.Login" %>
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
            <div class="cold-md-12 border shadow" style="width: 500px; margin-top:20px; height:440px;">
                <div class="tab-pane p-5 justify-content-center px-5" id="newUser-tab">
                    <div class="d-flex justify-content-center">                  
                        <section class="cold-md-8" Style="margin-left: 10px;">
                            <h1 style="color:black; margin-left:40px; margin-top:-20px">Login</h1>
                            <div>
                                <h3 class="mb-0 mt-3" style="color:black; font-size:16px; margin-left:-110px;">Usuario</h3>
                                <asp:TextBox ID="txtUser" runat="server" CssClass="form-control"  Style="margin-left: 75px;" Width="250px"></asp:TextBox>
                            </div>
                            <div>
                                <h3 class="mb-0 mt-3" style="color:black; font-size:16px; margin-left:-85px;">Contraseña</h3>
                                <asp:TextBox ID="txtPass" runat="server" type="password" CssClass="form-control"  Style="margin-left: 75px;" Width="250px"></asp:TextBox>
                            </div>                              
                            <div>
                                <br />
                                <asp:Label ID="lblMensaje" Visible="false" runat="server" Text="Mensaje" CssClass="mb-0 mt-3" Style="color:red; font-size:12px; margin-left:40px;"></asp:Label>
                            </div>
                        </section>       
                    </div>
                    <div class="d-flex justify-content-center">
                        <section class="cold-md-5">
                            <div>
                                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" Style="margin-left: 20px; margin-top: -50px;" CssClass=" btn btn-dark" Height="40px" Width="250px" OnClick="btnIngresar_Click" />                       
                            </div>                    
                        </section>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>
        function noBack() { window.history.forward(1) }
        setTimeout("noBack()", 0);
        noBack();
        window.onload = noBack;
        window.onpageshow = function (evt) { if (evt.persisted) noBack() }
        window.onunload = function () { void (0) }
        if (history.forward(1)) {
            location.replace(history.forward(1))
        }
    </script>
</asp:Content>
