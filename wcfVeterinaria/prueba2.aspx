<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prueba2.aspx.cs" Inherits="wcfVeterinaria.prueba2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <style>
        body {
            margin: 40px 10px;
            padding: 0;
            font-family: 'UltimaAlt';
            font-size: 14px;
        }

        #calendar {
            max-width: 1100px;
            margin: 0 auto;
        }
    </style>

    <link href="https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.10.2/fullcalendar.min.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.29.1/moment.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.10.2/fullcalendar.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.10.2/locale/es.js"></script> 
   
    <form id="form1" runat="server">
        <div id="calendar-container">
        <div id="calendar"></div>
    </div>
    </form>
    

    <script>
        function convertirFechaHora(fechaHora) {
            var timestamp = fechaHora.match(/\d+/)[0];
            var fecha = new Date(parseInt(timestamp));
            return fecha;
        }

        $(document).ready(function () {
            $.ajax({
                url: 'http://localhost:55676/serviceAgenda.svc/ListadoAgenda',
                type: 'GET',
                dataType: 'json',             
                    success: function (response) {
                        var events = [];

                        if (Array.isArray(response)) {
                            events = response.map(function (evento) {
                                return {
                                    title: evento.title,
                                    start: convertirFechaHora(evento.start),
                                    end: convertirFechaHora(evento.end),
                                    color: evento.color
                                };
                            });
                        }$('#calendar').fullCalendar({
                        header: {
                            left: 'prev,next,today',
                            center: 'title',
                            right: 'month,agendaWeek,agendaDay'
                        },                     
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


    
</body>
</html>
