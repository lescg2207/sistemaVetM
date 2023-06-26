<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="frmAgendaLista.aspx.cs" Inherits="webVeterinaria.frmAgendaLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        body {
          max-width:auto;
          max-height:auto;
            padding: 0;
            font-family: Arial, Helvetica Neue, Helvetica, sans-serif;
            font-size: 12px;
        }

        
        div .conte{
           font-family: UltimaAlt;
        }
        div .cold-md-8{
               background:white;
        }
        div .calendar-container{
            max-width:auto;
            max-height:auto;
        }
    </style>
    <div class="conte">
        <div class="container d-flex justify-content-center mt-3">
            <div class="cold-md-8 border shadow" ">
                <div class="tab-pane p-3 justify-content-center px-3" id="newUser-tab" style="width: 1000px;>
                    <div id="calendar-container" >
                        <div id="calendar" ></div>
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
                                color: evento.Color,
                                cliente: evento.Cliente,
                                observacion: evento.Observacion
                            };
                        }),
                        eventClick: function (calEvent) {
                            Swal.fire({
                                title: 'Motivo: ' + calEvent.title,
                                html: 'Cliente: ' + calEvent.cliente + '<br>Hora de inicio: ' + calEvent.start.format('HH:mm') + '<br>Hora de fin: ' + calEvent.end.format('HH:mm') + '<br>Observacion: ' + calEvent.observacion,
                                icon: 'info',
                                confirmButtonText: 'Aceptar'
                            });
                        },
                        locale: 'es',
                        defaultView:'agendaWeek'
                    });
                },
                error: function (error) {
                    console.log('Error al obtener los eventos: ' + error);
                }
            });
        });
    </script>
</asp:Content>
