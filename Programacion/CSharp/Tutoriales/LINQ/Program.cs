using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ {
  class Program {
    static void Main(string[] args) {

      // Para los ejemplos, vamos a suponer una clase como esta: (VER CLASE)
      // Partamos de la base de que tenemos una colección de alumnos como esta:
      var alumnos = new List<Alumno> {
        new Alumno { Nombre = "Pedro",  Nota = 4 },
        new Alumno { Nombre = "Jorge",  Nota = 8 },
        new Alumno { Nombre = "Andres", Nota = 3 }
      };

      // SELECT: Nos va a permitir hacer una selección sobre la colección de
      // datos, ya sea seleccionándolos todos, solo una parte o transformándolos.
      var nombresAlumnos = alumnos.Select(x => x.Nombre).ToList();

      // WHERE: Nos permite seleccionar una colección a partir de otra con los
      // objetos que cumplan las condiciones especificadas.
      var alumnosAprobados = alumnos.Where(x => x.Nota >= 5).ToList();

      // FIRST/LAST: Esta extensión nos va a permitir obtener respectivamente
      // el primer y el último objeto de la colección. Esto es especialmente
      // útil si la colección está ordenada.
      var primero = alumnos.First();
      var ultimo = alumnos.Last();

      // ORDERBY: Gracias a este método, vamos a poder ordenar la colección en
      // base a un criterio de ordenación que le indicamos mediante una
      // expresión lambda. Análogamente, también existe OrderByDescending, el
      // cual va a ordenar la colección de manera inversa según el criterio.
      var ordenadoMenorAMayor = alumnos.OrderBy(x => x.Nota).ToList();
      var ordenadoMayorAMenos = alumnos.OrderByDescending(x => x.Nota).ToList();

      // SUM: Como hemos visto más arriba, nos va a permitir sumar la colección.
      var sumaNotas = alumnos.Sum(x => x.Nota);

      // MAX/MIN: Gracias a esta extensión, vamos a poder obtener los valores
      // máximo y mínimo de la colección.
      var notaMaxima = alumnos.Max(x => x.Nota);
      var notaMinima = alumnos.Min(x => x.Nota);

      // AVERAGE: Este método nos va a devolver la media aritmética de los
      // valores (numéricos) de los elementos que le indiquemos de la colección.
      var media = alumnos.Average(x => x.Nota);

      // ALL/ANY: Con este último operador, vamos a poder comprobar si todos o
      // alguno de los valores de la colección cumplen el criterio que le indiquemos.
      var todosAprobados = alumnos.All(x => x.Nota >= 5);
      var algunAprobado = alumnos.Any(x => x.Nota >= 5);

      // SINTAXIS INTEGRADA.---------------------------------------------------
      var resultado = from alumno in alumnos
                      where alumno.Nota >= 5
                      orderby alumno.Nota
                      select alumno;

      /////////////////////////////////////////////////////////////////////////
      Console.ReadKey(true);
    }
  }
}
