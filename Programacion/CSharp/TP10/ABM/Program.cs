using System;
using System.IO;

namespace ABM
{
    class Program
    {
        static StreamReader Lectura;
        static StreamWriter Escritura, temporal;
        static string cadena, respuesta;
        static string noSerie, modelo, fabricante, color;
        static short anio;
        static double precio;
        static bool encontrado;
        static string[] campos = new string[6];

        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey(true);
        }

        private static void Menu()
        {
            byte opcion;
            opcion = 0;

            do
            {
                try
                {
                    Console.WriteLine("Menú de opciones");
                    Console.WriteLine("1. Altas");
                    Console.WriteLine("2. Bajas");
                    Console.WriteLine("3. Consultas");
                    Console.WriteLine("4. Modificaciones");
                    Console.WriteLine("5. Ver todos los registros");
                    Console.WriteLine("6. Salir");

                    Console.Write("Seleccione: ");
                    opcion = Convert.ToByte(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            crearArchivo();
                            Altas();
                            break;
                        case 2:
                            Bajas();
                            break;
                        case 3:
                            Consultas();
                            break;
                        case 4:
                            Modificaciones();
                            break;
                        case 5:
                            ConsultaGeneral();
                            break;
                        case 6:
                            Console.WriteLine("APLICACIÓN FINALIZADA");
                            break;
                        default:
                            Console.WriteLine("Opción incorrecta.");
                            break;
                    }
                }
                catch (FormatException fe) { Console.WriteLine("Error: " + fe.Message); }
                catch (Exception e) { Console.WriteLine("Error: " + e.Message); }
            } while (opcion != 6);
        }

        static void crearArchivo()
        {
            Escritura = File.AppendText("autos.txt");
            Escritura.Close();
        }

        static void Altas()
        {
            encontrado = false;
            try
            {
                Lectura = File.OpenText("autos.txt");
                Console.Write("Nro de serie: ");
                noSerie = Console.ReadLine();
                noSerie = noSerie.ToUpper();
                cadena = Lectura.ReadLine();

                while (cadena != null) // Validación (auto serie repetido)
                {
                    campos = cadena.Split(',');

                    if (campos[0].Trim().Equals(noSerie))
                    {
                        encontrado = true;
                        break;
                    }
                    cadena = Lectura.ReadLine();
                }
                Lectura.Close();
                Escritura = File.AppendText("autos.txt");

                if (encontrado == false)
                {
                    Console.Write("Modelo: ");
                    modelo = Console.ReadLine();
                    modelo = modelo.ToUpper();

                    Console.Write("Año: ");
                    anio = Convert.ToInt16(Console.ReadLine());

                    Console.Write("Fabricante: ");
                    fabricante = Console.ReadLine();
                    fabricante = fabricante.ToUpper();

                    Console.Write("Color: ");
                    color = Console.ReadLine();
                    color = color.ToUpper();

                    Console.Write("Precio: ");
                    precio = Convert.ToDouble(Console.ReadLine());

                    Escritura.WriteLine(
                      noSerie + ", " +
                      modelo + ", " +
                      anio + ", " +
                      fabricante + ", " +
                      color + ", " +
                      precio
                      );
                    Console.WriteLine("Registro agregado correctamente.");
                }
                else { Console.WriteLine("Ya existe nro de serie."); }
                Escritura.Close();
            }
            catch (FileNotFoundException fn) { Console.WriteLine("Error: " + fn.Message); }
            catch (Exception e) { Console.WriteLine("Error: " + e.Message); }
            finally
            {
                Lectura.Close();
                Escritura.Close();
            }
        }

        static void Bajas()
        {
            encontrado = false;

            try
            {
                Lectura = File.OpenText("autos.txt");
                temporal = File.CreateText("tmp.txt");

                Console.WriteLine("Número de serie: ");
                noSerie = Console.ReadLine();
                noSerie = noSerie.ToUpper();
                cadena = Lectura.ReadLine();

                while (cadena != null)
                {
                    campos = cadena.Split(',');

                    if (campos[0].Trim().Equals(noSerie))
                    {

                        encontrado = true;
                        Console.WriteLine("Serie:       " + campos[0]);
                        Console.WriteLine("Modelo:      " + campos[1]);
                        Console.WriteLine("Año:         " + campos[2]);
                        Console.WriteLine("Fabricante:  " + campos[3]);
                        Console.WriteLine("Color:       " + campos[4]);
                        Console.WriteLine("Precio:      " + campos[5]);
                        Console.WriteLine("Eliminar?");
                        respuesta = Console.ReadLine();
                        respuesta = respuesta.ToUpper();

                        if (!respuesta.Equals("SI")) { temporal.WriteLine(cadena); }
                    }
                    else { temporal.WriteLine(cadena); }
                    cadena = Lectura.ReadLine();
                }

                if (encontrado == false) { Console.WriteLine("El nro de serie " + noSerie + "no existe en la BBDD."); }
                else if (respuesta.Equals("SI")) { Console.WriteLine("Auto eliminado."); }
                else { Console.WriteLine("Eliminación cancelada."); }

                Lectura.Close();
                temporal.Close();
                File.Delete("autos.txt");
                File.Move("tmp.txt", "autos.txt");

            }
            catch (FileNotFoundException fn) { Console.WriteLine("Error: " + fn.Message); }
            catch (Exception e) { Console.WriteLine("Error: " + e.Message); }
            finally
            {
                Lectura.Close();
                temporal.Close();
            }
        }

        static void Consultas()
        {
            encontrado = false;

            try
            {
                Lectura = File.OpenText("autos.txt");
                Console.Write("Fabricante: ");
                fabricante = Console.ReadLine();
                fabricante = fabricante.ToUpper();
                cadena = Lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(',');

                    if (campos[3].Trim().Equals(fabricante))
                    {
                        encontrado = true;
                        Console.WriteLine("Serie:       " + campos[0]);
                        Console.WriteLine("Modelo:      " + campos[1]);
                        Console.WriteLine("Año:         " + campos[2]);
                        Console.WriteLine("Fabricante:  " + campos[3]);
                        Console.WriteLine("Color:       " + campos[4]);
                        Console.WriteLine("Precio:      " + campos[5]);
                        Console.WriteLine("-------------------------");
                    }
                    cadena = Lectura.ReadLine();
                }
                if (encontrado == false) { Console.WriteLine("Fabricante no encontrado"); }
                Lectura.Close();
            }
            catch (FileNotFoundException fn) { Console.WriteLine("Error: " + fn.Message); }
            catch (Exception e) { Console.WriteLine("Error: " + e.Message); }
            finally { Lectura.Close(); }
        }

        static void Modificaciones()
        {
            encontrado = false;
            byte opcionM = 0;
            string nuevoModelo, nuevoFabricante, nuevoColor;
            short nuevoAnio;
            double nuevoPrecio;

            try
            {
                Lectura = File.OpenText("autos.txt");
                temporal = File.CreateText("tmp.txt");

                Console.Write("Nro de serie: ");
                noSerie = Console.ReadLine();
                noSerie = noSerie.ToUpper();
                cadena = Lectura.ReadLine();

                while (cadena != null)
                {
                    campos = cadena.Split(',');

                    if (campos[0].Trim().Equals(noSerie))
                    {
                        encontrado = true;
                        Console.WriteLine("Serie:       " + campos[0]);
                        Console.WriteLine("Modelo:      " + campos[1]);
                        Console.WriteLine("Año:         " + campos[2]);
                        Console.WriteLine("Fabricante:  " + campos[3]);
                        Console.WriteLine("Color:       " + campos[4]);
                        Console.WriteLine("Precio:      " + campos[5]);
                        Console.WriteLine("-------------------------");

                        Console.Write("Confirmar (SI/NO):");
                        respuesta = Console.ReadLine();
                        respuesta = respuesta.ToUpper();

                        if (respuesta.Equals("SI"))
                        {
                            Console.WriteLine("Menú de opciones a modificar: ");
                            Console.WriteLine("    1. Modelo");
                            Console.WriteLine("    2. Año");
                            Console.WriteLine("    3. Fabricante");
                            Console.WriteLine("    4. Color");
                            Console.WriteLine("    5. Precio");
                            Console.WriteLine("¿Qué desea modificar");

                            opcionM = Convert.ToByte(Console.ReadLine());

                            switch (opcionM)
                            {
                                case 1:
                                    Console.Write("Modelo: ");
                                    nuevoModelo = Console.ReadLine();
                                    nuevoModelo = nuevoModelo.ToUpper();
                                    temporal.WriteLine(
                                      campos[0] + ',' +
                                      nuevoModelo + ',' +
                                      campos[2] + ',' +
                                      campos[3] + ',' +
                                      campos[4] + ',' +
                                      campos[5] + ',');
                                    Console.WriteLine("Modelo modificado.");
                                    break;
                                case 2:
                                    Console.Write("Año: ");
                                    nuevoAnio = Convert.ToInt16(Console.ReadLine());
                                    temporal.WriteLine(
                                      campos[0] + ',' +
                                      campos[1] + ',' +
                                      nuevoAnio + ',' +
                                      campos[3] + ',' +
                                      campos[4] + ',' +
                                      campos[5] + ',');
                                    Console.WriteLine("Año modificado.");
                                    break;
                                case 3:
                                    Console.Write("Fabricante: ");
                                    nuevoFabricante = Console.ReadLine();
                                    nuevoFabricante = nuevoFabricante.ToUpper();
                                    temporal.WriteLine(
                                      campos[0] + ',' +
                                      campos[1] + ',' +
                                      campos[2] + ',' +
                                      nuevoFabricante + ',' +
                                      campos[4] + ',' +
                                      campos[5] + ',');
                                    Console.WriteLine("Fabricante modificado.");
                                    break;
                                case 4:
                                    Console.Write("Color: ");
                                    nuevoColor = Console.ReadLine();
                                    nuevoColor = nuevoColor.ToUpper();
                                    temporal.WriteLine(
                                      campos[0] + ',' +
                                      campos[1] + ',' +
                                      campos[2] + ',' +
                                      campos[3] + ',' +
                                      nuevoColor + ',' +
                                      campos[5] + ',');
                                    Console.WriteLine("Color modificado.");
                                    break;
                                case 5:
                                    Console.Write("Precio: ");
                                    nuevoPrecio = Convert.ToDouble(Console.ReadLine());
                                    temporal.WriteLine(
                                      campos[0] + ',' +
                                      campos[1] + ',' +
                                      campos[2] + ',' +
                                      campos[3] + ',' +
                                      campos[4] + ',' +
                                      nuevoPrecio + ',');
                                    Console.WriteLine("Precio modificado.");
                                    break;
                                default:
                                    Console.WriteLine("Opción incorrecta");
                                    break;
                            }
                        }
                        else { temporal.WriteLine(cadena); }
                    }
                    else { temporal.WriteLine(cadena); }
                    cadena = Lectura.ReadLine();
                }

                if (encontrado == false) { Console.WriteLine("Registro no encontrado"); }
                Lectura.Close();
                temporal.Close();
                File.Delete("autos.txt");
                File.Move("tmp.txt", "autos.txt");

            }
            catch (FileNotFoundException fn) { Console.WriteLine("Error: " + fn.Message); }
            catch (Exception e) { Console.WriteLine("Error: " + e.Message); }
            finally
            {
                Lectura.Close();
                temporal.Close();
            }
        }

        static void ConsultaGeneral()
        {
            encontrado = false;

            try
            {
                Lectura = File.OpenText("autos.txt");
                cadena = Lectura.ReadLine();

                while (cadena != null)
                {
                    encontrado = true;
                    campos = cadena.Split(',');
                    Console.WriteLine("Serie:       " + campos[0]);
                    Console.WriteLine("Modelo:      " + campos[1]);
                    Console.WriteLine("Año:         " + campos[2]);
                    Console.WriteLine("Fabricante:  " + campos[3]);
                    Console.WriteLine("Color:       " + campos[4]);
                    Console.WriteLine("Precio:      " + campos[5]);
                    Console.WriteLine("-------------------------");
                    cadena = Lectura.ReadLine();
                }
                if (encontrado == false) { Console.WriteLine("Registro no encontrado."); }
                Lectura.Close();
            }
            catch (FileNotFoundException fn) { Console.WriteLine("Error: " + fn.Message); }
            catch (Exception e) { Console.WriteLine("Error: " + e.Message); }
            finally { Lectura.Close(); }
        }

    }
}
