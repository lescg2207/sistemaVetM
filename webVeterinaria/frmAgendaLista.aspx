<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="frmAgendaLista.aspx.cs" Inherits="webVeterinaria.frmAgendaLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        body {
            margin: 40px 10px;
            padding: 0;
            font-family: Arial, Helvetica Neue, Helvetica, sans-serif;
            font-size: 14px;
        }

        
        div .conte{
           font-family: UltimaAlt;
        }
        div .cold-md-8{
               background:white;
        }
    </style>
    <div class="conte">
        <div class="container d-flex justify-content-center mt-3">
            <div class="cold-md-8 border shadow" style="width: 930px;">
                <div class="tab-pane p-3 justify-content-center px-3" id="newUser-tab">
                    <div id="calendar-container">
                        <div id="calendar"></div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script>
        function convertirFechaHora(fechaHora) {
            var timestamp = fechaHora.match(/\d+/)[0];
            var fecha = new Date(parseInt(timestamp));
            return fecha;
        }

        $(document).ready(function () {
            $.ajax({
                url: 'http://localhost:55676/serviceAgenda.svc/ObtenerEventos',
                type: 'GET',
                dataType: 'json',
                success: function (response) {
                    $('#calendar').fullCalendar({                     
                        header: {
                            left: 'prev,next,today',
                            center: 'title',
                            right: 'month,agendaWeek,agendaDay'
                        },                        
                        events: response.map(function (evento) {
                            return {
                                title: evento.Titulo,
                                start: convertirFechaHora(evento.FechaInicio),
                                end: convertirFechaHora(evento.FechaFin),
                                color: evento.Color
                            };
                        }),
                        eventClick: function (calEvent, jsEvent, view) {
                            alert('Evento: ' + calEvent.title + '\nFecha de inicio: ' + calEvent.start.format() + '\nFecha de fin: ' + calEvent.end.format());
                        },
                        locale: 'es' 
                    });
                },
                error: function (xhr, status, error) {
                    console.log('Error al obtener los eventos: ' + error);
                }
            });
        });
    </script>
</asp:Content>
