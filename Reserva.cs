using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPoo
{
    public class Reserva
    {
        public Reserva()
        {
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string fecha;
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private string hora;

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        private int Id_cliente;

        public int Id_Cliente
        {
            get { return Id_cliente; }
            set { Id_cliente = value; }
        }
        public int IdCarro { get; set; }

    }
}
