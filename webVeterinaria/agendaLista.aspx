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
        $(document).ready(function () {
            $('#calendar').fullCalendar({
                events: function (start, end, timezone, callback) {
                    // Realizar una solicitud a la base de datos para obtener los eventos
                    // Utiliza el proveedor de datos de SQL Server para conectarte a la base de datos y ejecutar la consulta
                    var connString = "cadena_de_conexión_a_tu_base_de_datos";
                    var query = "SELECT IdEvento, Titulo, FechaInicio, FechaFin FROM Eventos";

                    $.ajax({
                        url: "ruta_a_tu_pagina_de_servidor.aspx/ObtenerEventos",
                        type: "POST",
                        data: JSON.stringify({ connectionString: connString, query: query }),
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (data) {
                            // Procesar los datos recibidos y convertirlos al formato requerido por FullCalendar
                            var eventos = [];

                            for (var i = 0; i < data.d.length; i++) {
                                eventos.push({
                                    id: data.d[i].id,
                                    title: data.d[i].title,
                                    start: data.d[i].star,
                                    end: data.d[i].end
                                });
                            }

                            callback(eventos);
                        }
                    });
                }
            });
        });
        

          

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
