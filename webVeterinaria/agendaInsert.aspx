<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="agendaInsert.aspx.cs" Inherits="webVeterinaria.agendaInsert" %>
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
                            <p class="mb-0 mt-3">Descripcion</p>
                            <asp:TextBox ID="TextBox2" runat="server" type="password" CssClass="form-control"></asp:TextBox>
                                        
                                </div>
                           
                      
                        <div>
                            <p class="mb-0 mt-3">Hora</p>
                                <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>              
                           
                                               
                        </div>
                        <div>
                            <p class="mb-0 mt-5">Cliente</p>
                            <asp:TextBox ID="txtCliente" runat="server" type="password" CssClass="form-control"></asp:TextBox>
                        </div>
                                                                
                    </section>
                    <section class="cold-md-5" Style="margin-left: 80px;">                                            
                        <div >
                            <p class="mb-0 mt-3">Estado</p>
                            <asp:DropDownList ID="cbxEstadoEv" Style="width:300px;" CssClass="btn btn-white btn-sm dropdown-toggle" runat="server" ></asp:DropDownList>
                        </div>
                        <div>
                            <p class="mb-0 mt-4" >Hora</p>
                            <asp:TextBox ID="txtHora" runat="server" CssClass="time form-control" TextMode="Time"></asp:TextBox>
                        </div>
                        <div style="margin-top:50px">
                            <p class="mb-0 mt-0">Motivo</p>
                            <asp:DropDownList ID="cbxMotivoEv" Style="width:300px;" CssClass="btn btn-white btn-sm dropdown-toggle" runat="server"></asp:DropDownList>
                        </div>
                        <div class="mt-3">
                            <asp:Button ID="btnReg" runat="server" Text="Registrar" Style="margin-top: 40px;" CssClass=" btn btn-dark" Height="40px" Width="300px" />                          
                        </div>
                        
                    </section>                  
                </div>
            </div>
        </div>
    </div>
    </div>
       
</asp:Content>
