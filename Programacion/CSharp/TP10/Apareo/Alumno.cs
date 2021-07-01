﻿using System;

namespace Apareo
{
    class Alumno
    {
        public int Legajo { get; set; }
        public string Apellido { get; set; }

        public Alumno(string linea)
        {
            var datos = linea.Split(',');
            Legajo = int.Parse(datos[0]);
            Apellido = datos[1];
        }

        public Alumno(int legajo, string apellido)
        {
            Legajo = legajo;
            Apellido = apellido;
        }

        public string ObtenerRegistro()
        {
            return String.Format("{0}, {1}", Legajo, Apellido);
        }
    }
}
