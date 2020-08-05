using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPoo
{
    public class Vehiculo
    {
        public Vehiculo()
        {
        }

        public Vehiculo(int iD, string marca, string modelo, string color, string placa, string descripción, bool estado)
        {
            ID = iD;
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Placa = placa;
            Descripción = descripción;
            Estado = estado;
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private string placa;
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        private string descripcion;
        public string Descripción
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public bool Estado { get; set; }
    }
}