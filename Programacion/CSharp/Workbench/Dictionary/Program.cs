///////////////////////////////////////////////////////////////////////// ABOUT
/**
 * Esto es lo primero y más básico que habría que responder:
 * Esta estructura de datos, ¿para qué sirve, para qué se usa?
 * USOS:
 * -) se utiliza en la búsqueda rápida de datos: tabla de símbolos del compilador
 * -) indexar la base de datos
 * -) cachés
 * -) representación única de datos
 * */

using System;
using System.Collections.Generic;

namespace _Dictionary {
  class Program {
    static void Main(string[] args) {

      // Create a new dictionary of strings, with string keys.
      //
      Dictionary<string, string> Programa = new Dictionary<string, string>();

      // Add some elements to the dictionary. There are no
      // duplicate keys, but some of the values are duplicates.
      Programa.Add("txt", "notepad.exe");
      Programa.Add("bmp", "paint.exe");
      Programa.Add("dib", "paint.exe");
      Programa.Add("rtf", "wordpad.exe");

      // The Add method throws an exception if the new key is
      // already in the dictionary.
      try {
        Programa.Add("txt", "winword.exe");
      }
      catch (ArgumentException) {
        Console.WriteLine("Un elemento con Clave (Key) = \"txt\" ya existe.\n");
      }

      // The Item property is another name for the indexer, so you
      // can omit its name when accessing elements.
      Console.WriteLine("Clave = \"rtf\", Valor = {0}.", Programa["rtf"]);

      // The indexer can be used to change the value associated
      // with a key.
      Programa["rtf"] = "winword.exe";
      Console.WriteLine("Clave = \"rtf\", Valor = {0}.", Programa["rtf"]);

      // If a key does not exist, setting the indexer for that key
      // adds a new key/value pair.
      Programa["doc"] = "winword.exe";

      // The indexer throws an exception if the requested key is
      // not in the dictionary.
      try {
        Console.WriteLine("Clave = \"tif\", Valor = {0}.", Programa["tif"]);
      }
      catch (KeyNotFoundException) {
        Console.WriteLine("\nClave = \"tif\" no encontrada.");
      }

      // When a program often has to try keys that turn out not to
      // be in the dictionary, TryGetValue can be a more efficient
      // way to retrieve values.
      string value = "";
      if (Programa.TryGetValue("tif", out value)) {
        Console.WriteLine("Clave = \"tif\", Valor = {0}.", value);
      }
      else {
        Console.WriteLine("Clave = \"tif\" no encontrada.");
      }

      // ContainsKey can be used to test keys before inserting
      // them.
      if (!Programa.ContainsKey("ht")) {
        Programa.Add("ht", "hypertrm.exe");
        Console.WriteLine("\nValor añadido para Clave = \"ht\": {0}", Programa["ht"]);
      }

      // When you use foreach to enumerate dictionary elements,
      // the elements are retrieved as KeyValuePair objects.
      Console.WriteLine();
      foreach (KeyValuePair<string, string> kvp in Programa) {
        Console.WriteLine("Clave = {0}, Valor = {1}", kvp.Key, kvp.Value);
      }

      // To get the values alone, use the Values property.
      Dictionary<string, string>.ValueCollection valueColl = Programa.Values;

      // The elements of the ValueCollection are strongly typed
      // with the type that was specified for dictionary values.
      Console.WriteLine();
      foreach (string s in valueColl) {
        Console.WriteLine("Valor = {0}", s);
      }

      // To get the keys alone, use the Keys property.
      Dictionary<string, string>.KeyCollection keyColl =
          Programa.Keys;

      // The elements of the KeyCollection are strongly typed
      // with the type that was specified for dictionary keys.
      Console.WriteLine();
      foreach (string s in keyColl) {
        Console.WriteLine("Clave = {0}", s);
      }

      // Use the Remove method to remove a key/value pair.
      Console.WriteLine("\nBorrar(\"doc\")");
      Programa.Remove("doc");

      if (!Programa.ContainsKey("doc")) {
        Console.WriteLine("Clave \"doc\" no encontrada.");
      }

      Console.ReadKey();

    }
  }
}
