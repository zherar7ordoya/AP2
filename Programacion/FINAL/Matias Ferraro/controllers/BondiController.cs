using Integrador.entidades;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;

namespace Integrador.controllers
{
    public class BondiController
    {
        /// <summary>
        /// Path base para los archivos.
        /// </summary>
        public const string pathBase = "../../archivosDatos/";
        public const string pathPasajeros = pathBase + "pasajeros.txt";

        /// <summary>
        /// Numero maximo de masajeros.
        /// </summary>
        private const int MAX_PASAJEROS = 19;

        /// <summary>
        /// Personas que esperan subir.
        /// </summary>
        private ColaBondi Cola { get; set; }

        /// <summary>
        /// Pasajeros que estan arriba del bondi.
        /// </summary>
        private ColaBondi Pasajeros { get; set; }

        public bool EstaLleno
        {
            get
            {
                return this.Pasajeros.Contar() >= MAX_PASAJEROS ? true : false;
            }
        }

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public BondiController()
        {
            //Inicializo las colas
            this.Cola = new ColaBondi();
            this.Pasajeros = new ColaBondi();

            //Al iniciar un nuevo Bondi elimina el archivo de pasajeros. 
            //Esto previene que si se abre y cierra el programa se generen varios backups de un archivo de pasajeros antiguo.
            EliminarArchivoPasajeros();
        }

        /// <summary>
        /// Se utiliza para eliminar el archivo pasajeros.txt
        /// </summary>
        private void EliminarArchivoPasajeros()
        {
            try
            {
                //Verifica si el archivo existe
                if (File.Exists(pathPasajeros))
                {
                    //Elimina el archivo
                    File.Delete(pathPasajeros);
                }
            }
            catch (Exception)
            {
                throw new Exception("Ha ocurrido un error al eliminar el archivo de pasajeros.");
            }
        }

        public void EncolarPasajero(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                Cola.Encolar(nombre);
            }
            else
            {
                throw new Exception("Debe completar el nombre del pasajero.");
            }
        }

        public void SubirPasajero()
        {
            //Verifico si ya tiene la capacidad maxima.
            if (this.Pasajeros.Contar() >= MAX_PASAJEROS)
            {
                throw new Exception("La combi está llena.");
            }

            //saco un pasajero de la lista de espera.
            var pasajeroSubido = this.Cola.Desencolar();

            //valido que no sea null.
            if (pasajeroSubido == null)
            {
                throw new Exception("No hay ningún pasajero esperando a subir.");
            }

            //lo agrego a la lista de pasajeros.
            this.Pasajeros.Encolar(pasajeroSubido);
        }
        
        public void EmprenderViaje()
        {
            GuardarPasajeros();
        }

        public BindingList<string> ListarCola()
        {
            BindingList<string> lista = new BindingList<string>();

            var nodo = Cola.PrimerNodo;

            while (nodo != null)
            {
                lista.Add(nodo.Pasajero);
                nodo = nodo.NodoSiguiente;
            }

            return lista;
        }

        public Bitmap ObtenerImagen()
        {
            //Retorna la imagen a partir de la cantidad de personas en el bondi.
            switch (this.Pasajeros.Contar())
            {
                case 0:
                    return global::Integrador.Properties.Resources.Combi0;
                case 1:
                    return global::Integrador.Properties.Resources.Combi1;
                case 2:
                    return global::Integrador.Properties.Resources.Combi2;
                case 3:
                    return global::Integrador.Properties.Resources.Combi3;
                case 4:
                    return global::Integrador.Properties.Resources.Combi4;
                case 5:
                    return global::Integrador.Properties.Resources.Combi5;
                case 6:
                    return global::Integrador.Properties.Resources.Combi6;
                case 7:
                    return global::Integrador.Properties.Resources.Combi7;
                case 8:
                    return global::Integrador.Properties.Resources.Combi8;
                case 9:
                    return global::Integrador.Properties.Resources.Combi9;
                case 10:
                    return global::Integrador.Properties.Resources.Combi10;
                case 11:
                    return global::Integrador.Properties.Resources.Combi11;
                case 12:
                    return global::Integrador.Properties.Resources.Combi12;
                case 13:
                    return global::Integrador.Properties.Resources.Combi13;
                case 14:
                    return global::Integrador.Properties.Resources.Combi14;
                case 15:
                    return global::Integrador.Properties.Resources.Combi15;
                case 16:
                    return global::Integrador.Properties.Resources.Combi16;
                case 17:
                    return global::Integrador.Properties.Resources.Combi17;
                case 18:
                    return global::Integrador.Properties.Resources.Combi18;
                case 19:
                    return global::Integrador.Properties.Resources.Combi19;
                default:
                    return global::Integrador.Properties.Resources.Combi19;
            }
        }
        
        public void GenerarBackup()
        {
            //Verifica si el archivo existe y en caso de que si procede a crear un backup
            if (File.Exists(pathPasajeros))
            {
                //obtiene la fecha en el formato que se pide
                string date = DateTime.Now.ToString("yyyy_MM_dd");
                //obtiene el path del archivo de backup
                string pathBackup = pathBase + "pasajeros." + date + ".bak";
                
                int indice = 1;

                //Si ya existe un backup de una combi para hoy, entonces agrega un indice al archivo 
                //(para no pisar el backup anterior)
                while(File.Exists(pathBackup))
                {
                    pathBackup = pathBase + "pasajeros." + date + "("+indice+").bak";
                    indice++;
                }
                
                //Abre el archivo de backup en escritura y el de pasajeros.txt en lectura y genera el backup
                using (FileStream fsBackup = new FileStream(pathBackup, FileMode.CreateNew, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(fsBackup))
                    {
                        using (FileStream fs = new FileStream(pathPasajeros, FileMode.Open, FileAccess.Read))
                        {
                            using (StreamReader reader = new StreamReader(fs))
                            {
                                string linea = reader.ReadLine();

                                while (linea != null)
                                {
                                    writer.WriteLine(linea);
                                    linea = reader.ReadLine();
                                }
                            }
                        }
                    }
                }
            }
        }
       
        private void GuardarPasajeros()
        {
            try
            {
                //Guarda los pasajeros en el archivo
                using (FileStream fs = new FileStream(pathPasajeros, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        var nodoPasajero = this.Pasajeros.Desencolar();

                        //Voy pasando los pasajeros de la estructura de pasajeros al archivo.
                        while (nodoPasajero != null)
                        {
                            writer.WriteLine(nodoPasajero.Pasajero);
                            nodoPasajero = this.Pasajeros.Desencolar();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
