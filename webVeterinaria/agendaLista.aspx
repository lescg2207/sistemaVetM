<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="agendaLista.aspx.cs" Inherits="webVeterinaria.agendaLista" %>
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
        <div class="cold-md-12 border shadow" style="width: 1000px;">
            <div class="tab-pane p-5 justify-content-center px-5" id="newUser-tab">
                    <div id='calendar'></div>
                </div>
            </div>
             
        </div>
    </div>
    <script>

        

          

                var events = '/serviceAgenda.svc/ListadoAgenda';


                var calendarEl = document.getElementById('calendar');
                var calendar = new FullCalendar.Calendar(calendarEl, {
                    editable: true,
                    selectable: true,
                    businessHours: true,
                    dayMaxEvents: true,
                    events: events

                });

                calendar.render();
       

            
        
    </script>
</asp:Content>
