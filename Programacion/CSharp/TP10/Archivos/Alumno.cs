namespace Archivos
{
    class Alumno
    {
        public Alumno(long dni) { this.DNI = dni; }
        public Alumno(string linea)
        {
            string[] datos = linea.Split(',');
            this.DNI = long.Parse(datos[0]);
            this.Apellido = datos[1];
            this.Nombre = datos[2];
        }
        public long DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string GenerarRegistro() { return $"{DNI},{Apellido},{Nombre}"; }
    }
}
