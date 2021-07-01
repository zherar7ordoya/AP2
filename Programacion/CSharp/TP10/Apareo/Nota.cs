using System;

namespace Apareo
{
    class Nota
    {
        public Nota(string linea)
        {
            var datos = linea.Split(',');
            Legajo = int.Parse(datos[0]);
            ValorNota = int.Parse(datos[1]);
        }
        public Nota(int legajo, int valorNota)
        {
            Legajo = legajo;
            ValorNota = valorNota;
        }
        public string ObtenerRegistro()
        {
            return String.Format("{0}, {1}", Legajo, ValorNota);
        }
        public int Legajo { get; set; }
        public int ValorNota { get; set; }
    }
}
