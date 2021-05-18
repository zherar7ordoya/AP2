/**
 * Si te has preguntado alguna vez para qué sirven los espacios de nombres en 
 * C#, la respuesta es que son, por decirlo de algún modo, contenedores para 
 * elementos como clases, enumeraciones, entre otros.
 * Supongamos que estamos desarrollando una aplicación de un videojuego, y se 
 * nos ocurre crear una clase llamada “Player”, la cual contendrá elementos 
 * como la cantidad de vidas del jugador, etc.
 * Todo va de maravilla, pero nos atascamos un día, y decidimos comprar una 
 * biblioteca adicional que contiene elementos ó clases que nos servirán para 
 * desatascar nuestro problema. Sin embargo, nos enfrentamos a otro problema, y
 * es que dentro de ese ensamblado, existe también una clase llamada Player, la
 * cual contiene ciertas propiedades y métodos que sirven para otras cosas muy 
 * distintas a las que nosotros estamos haciendo.
 * ¿Te fijaste en el problema? Dos clases con el mismo nombre, algo que 
 * definitivamente al compilador no le va a gustar nada...
 * Anteriormente, los desarrolladores colocaban un prefijo antes del nombre de 
 * la clase, por ejemplo “SpaceInvadersGamePlayer”, ó “GraphicsLibrarySprite”, 
 * sin embargo, esto es poco escalable, ya que los nombres pueden volverse 
 * bastante grandes, lo que es improductivo al momento de estar escribiendo 
 * código.
 * La solución de este problema, son precisamente los espacios de nombres. Con 
 * ellos, podemos “agrupar” en un contexto diferente cada una de las clases, 
 * con lo que lograremos que las clases no sean confundidas, y con ello 
 * solucionar el problema.
 */

using System;
using System.Collections.Generic; // Este lo contiene y es default.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///////////////////////////////////////////////////////////////////////// ABOUT
/**
 * Esto es lo primero y más básico que habría que responder:
 * Esta estructura de datos, ¿para qué sirve, para qué se usa?
 * USOS:
 * -) funcionalidad deshacer/rehacer
 * -) inversión de palabras
 * -) en los navegadores: avanzar/retroceder
 * -) algoritmos de retroceso (¿y esto qué es?)
 * -) verificación de soporte (¿y esto qué es?)
 * */

using System.Collections; // Este lo contiene y hay que llamarlo.

namespace _Stack1 {
  class Program {
    static void Main(string[] args) {
      // Creates and initializes a new Stack.
      Stack Pila = new Stack();
      Pila.Push("Primero");
      Pila.Push("Segundo");
      Pila.Push("Tercero");

      // Displays the properties and values of the Stack.
      Console.WriteLine("PILA");
      Console.WriteLine("\tConteo:\t{0}", Pila.Count);
      Console.Write("\tValores:");
      PrintValues(Pila);

      // Cálmate...
      Console.ReadKey();
    }
    public static void PrintValues(IEnumerable pila) {
      foreach (Object objeto in pila) Console.Write("\n\t\t{0}", objeto);
    }
  }
}
