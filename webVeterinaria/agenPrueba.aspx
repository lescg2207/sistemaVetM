<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="agenPrueba.aspx.cs" Inherits="webVeterinaria.agenPrueba" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.10.2/fullcalendar.min.css" />
  <style>
    .fc-today {
      background-color: #f0f0f0;
    }
  </style>

  <div id="calendar"></div>
 
  <div id="eventoForm" style="display: none;">
    <h2>Nuevo Evento</h2>
    <input type="text" id="txtTitulo" placeholder="Título" /><br />
    <input type="text" id="txtFechaInicio" placeholder="Fecha de inicio" /><br />
    <input type="text" id="txtFechaFin" placeholder="Fecha de fin" /><br />
    <button id="btnGuardar">Guardar</button>
  </div>
 
  <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.29.1/moment.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.10.2/fullcalendar.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.10.2/locale/es.js"></script>
  <script>
      $(document).ready(function () {
          var calendar = $('#calendar');

          calendar.fullCalendar({
              header: {
                  left: 'prev,next today',
                  center: 'title',
                  right: 'month,agendaWeek,agendaDay'
              },
              defaultView: 'month',
              locale: 'es',
              editable: true,
              events: function (start, end, timezone, callback) {
                  $.ajax({
                      url: 'http://localhost:55676/serviceAgenda.svc/ListadoAgenda',
                      type: 'GET',
                      dataType: 'json',
                      success: function (response) {
                          var eventos = [];

                          for (var i = 0; i < data.d.length; i++) {
                              eventos.push({
                                  id: data.d[i].IdEvento,
                                  title: data.d[i].Titulo,
                                  start: data.d[i].FechaInicio,
                                  end: data.d[i].FechaFin
                              });
                          }
                          callback(eventos);
                      },
                      error: function () {
                          alert('Error al obtener los eventos.');
                      }
                  });
              },
              // Resto de la configuración y eventos de FullCalendar...
          });
      });
  </script>

</asp:Content>
