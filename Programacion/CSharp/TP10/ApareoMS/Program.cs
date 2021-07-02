using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

/**
 * El único ejemplo que encontré en la documentación de C#
 * que se parece al concepto del "apareo" de la cátedra.
 */

class ApareoMicrosoft
{
    static void Main()
    {
        #region VARIABLES
        /**
         * Combina contenido de archivos no iguales que contienen información
         * relacionada. El archivo "alumnos.csv" contiene el nombre del
         * estudiante además de un ID. El archivo "notas.csv" contiene el ID
         * más un conjunto de 4 notas.
         * La siguiente búsqueda combina las notas con el estudiante usando
         * el ID como clave de coincidencia.
         */
        string[] alumnos = File.ReadAllLines(@"../../../alumnos.csv");
        string[] notas = File.ReadAllLines(@"../../../notas.csv");
        /**
         * CÓMO SE COMBINAN LOS ARCHIVOS:
         * 
         * Alumno:  Apellido[0],  Nombre[1],  ID[2]
         *          Omelchenko,   Svetlana,   11
         * Nota:    AlumnoID[0],  Examen1[1]  Examen2[2],  Examen3[3],  Examen4[4]
         *          111,          97,         92,          81,          60  
         */
        #endregion

        #region APAREO
        /**
         * He aquí el horno de la combinación de la mano del LINQ de C#.
         * Si alguna vez trabajaron con SQL, las explicaciones sobran.
         * Son vivos estos ñatos de Microsoft, ¿no?
         * Ellos aclaran que, en este ejemplo, usan varias cláusulas FROM
         * en vez de JOIN a fin de guardar los resultados de ID.Split.
         */
        IEnumerable<string> resultado =
            from alumno in alumnos
            let registroAlumno = alumno.Split(',')
            from id in notas
            let registroNotas = id.Split(',')
            where Convert.ToInt32(registroAlumno[2]) == Convert.ToInt32(registroNotas[0])
            select  registroAlumno[0] + "\t" + 
                    registroNotas[1]  + "\t" + 
                    registroNotas[2]  + "\t" + 
                    registroNotas[3]  + "\t" + 
                    registroNotas[4];
        #endregion

        Imprimir(resultado, "COMBINAR DOS ARCHIVOS DE VALORES SEPARADOS POR COMA (CSV):" + Environment.NewLine);
        Console.WriteLine("Eso es todo, ¿te gustó?");
    }
    #region FUNCIONES
    static void Imprimir(IEnumerable<string> resultado, string mensaje)
    {
        Console.WriteLine(mensaje);
        foreach (string item in resultado) { Console.WriteLine("\t" + item); }
        Console.WriteLine(Environment.NewLine + "{0} registros." + Environment.NewLine, resultado.Count());
    }
    #endregion
}