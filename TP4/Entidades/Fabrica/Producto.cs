using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region Atributos

        private int id;
        private string marca;
        private string CPU;
        private string GPU;
        private int cantidadRAM;
        private int cantidadAlmacenamiento;
        private bool gigaOTera;

        private static readonly string ruta;
        private static readonly string rutaGuardadoLectura;

        #endregion

        #region Constructores

        static Producto()
        {
            ruta = Directory.GetCurrentDirectory();
            ruta = Directory.GetParent(ruta).FullName;
            ruta = Directory.GetParent(ruta).FullName;
            ruta = Directory.GetParent(ruta).FullName;

            rutaGuardadoLectura = ruta + @"\----- Archivos Guardados -----\";
            CrearPaths();
        }


        /// <summary>
        /// Constructor sin parametros. Requerido por el serializer de ArchivoXml.cs
        /// </summary>
        public Producto()
        {
        }

        /// <summary>
        /// Unico constructor que rebibe todos los datos para el producto, inicializandolos a todos
        /// Si la cantidad de almacenamiento supera los 1000GB lo transformara a TB para mejorar su lectura
        /// </summary>
        /// <param name="id"></param>
        /// <param name="marca"></param>
        /// <param name="CPU"></param>
        /// <param name="GPU"></param>
        /// <param name="cantidadRAM"></param>
        /// <param name="cantidadAlmacenamiento"></param>
        public Producto(int id, string marca, string CPU, string GPU, int cantidadRAM, int cantidadAlmacenamiento)
        {
            this.id = id;
            this.marca = marca;
            this.CPU = CPU;
            this.GPU = GPU;
            this.cantidadRAM = cantidadRAM;

            if(cantidadAlmacenamiento >= 1000)
            {
                this.cantidadAlmacenamiento = cantidadAlmacenamiento / 1000;
                gigaOTera = true;
            }
            else
            {
                this.cantidadAlmacenamiento = cantidadAlmacenamiento;
                gigaOTera = false;
            }
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad de solo lectura que retornara el ID
        /// </summary>
        public int ID
        {
            get
            {
                return this.id;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para la marca del producto
        /// </summary>
        public string Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                this.marca = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para el CPU del producto
        /// </summary>
        public string Cpu
        {
            get
            {
                return this.CPU;
            }
            set
            {
                this.CPU = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para la GPU del producto
        /// </summary>
        public string Gpu
        {
            get
            {
                return this.GPU;
            }
            set
            {
                this.GPU = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para la cantidad de RAM del producto
        /// </summary>
        public int CantidadRAM
        {
            get
            {
                return this.cantidadRAM;
            }
            set
            {
                this.cantidadRAM = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para la cantidad de almacenamiento del producto
        /// </summary>
        public int CantidadAlmacenamiento
        {
            get
            {
                return this.cantidadAlmacenamiento;
            }
            set
            {
                this.cantidadAlmacenamiento = value;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Override del ToString para mostrar todos los datos del Producto
        /// Teniendo en cuenta los GB o TB
        /// </summary>
        /// <returns> Retornara un string con todos los datos del producto </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ID: {this.id}");
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Procesador: {this.CPU}");
            sb.AppendLine($"Tarjeta Grafica: {this.GPU}");
            sb.AppendLine($"Cantidad de RAM: {this.cantidadRAM}GB");
            
            if(gigaOTera)
            {
                sb.AppendLine($"Cantidad de Almacenamiento: {this.cantidadAlmacenamiento}TB");
            }
            else
            {
                sb.AppendLine($"Cantidad de Almacenamiento: {this.cantidadAlmacenamiento}GB");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Este metodo guardara los datos que devuelva mostrar fabricacion en un archivo de texto
        /// </summary>
        /// <returns> Retornara true si pudo guardar o false si no pudo </returns>
        public static bool Guardar()
        {
            Texto archivoTexto = new Texto();

            return archivoTexto.Guardar(Producto.rutaGuardadoLectura + "Lista de productos.txt", Fabrica.MostrarFabricacion());
        }

        /// <summary>
        /// Este metodo leera los datos del archivo de texto guardado
        /// </summary>
        /// <returns> Retornara un string con los datos obtenidos del archivo de texto </returns>
        public static string Leer()
        {
            if(File.Exists(Producto.rutaGuardadoLectura + "Lista de productos.txt"))
            {
                Texto archivoTexto = new Texto();
                string datosArchivo;

                archivoTexto.Leer(Producto.rutaGuardadoLectura + "Lista de productos.txt", out datosArchivo);

                return datosArchivo;
            }

            return "No existe el archivo. Primero apriete Guardar Archivo";
        }


        /// <summary>
        /// Metodo que crea la ruta si no existen
        /// </summary>
        private static void CrearPaths()
        {
            if (!Directory.Exists(rutaGuardadoLectura))
            {
                Directory.CreateDirectory(rutaGuardadoLectura);
            }
        }

        #endregion

        #region Sobrecarga de operadores

        /// <summary>
        /// Sobrecarga del operador == 
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <param name="producto"></param>
        /// <returns> Retornara true si es igual o falso si no lo es </returns>
        public static bool operator ==(List<Producto> listaProductos, Producto producto)
        {
            foreach (Producto item in listaProductos)
            {
                if (item.marca == producto.marca &&
                    item.CPU == producto.CPU &&
                    item.GPU == producto.GPU &&
                    item.cantidadRAM == producto.cantidadRAM &&
                    item.cantidadAlmacenamiento == producto.cantidadAlmacenamiento &&
                    item.GetType() == producto.GetType())
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <param name="producto"></param>
        /// <returns> Retornara el valor negado de la sobrecarga == </returns>
        public static bool operator !=(List<Producto> listaProductos, Producto producto)
        {
            return !(listaProductos == producto);
        }

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <param name="producto"></param>
        /// <returns> Retorna la lista de los productos </returns>
        public static List<Producto> operator +(List<Producto> listaProductos, Producto producto)
        {
            try
            {
                if (listaProductos != producto)
                {
                    listaProductos.Add(producto);
                }
                else
                {
                    throw new ProductoRepetidoExcepcion();
                }
            }
            catch(ProductoRepetidoExcepcion e)
            {
                Console.WriteLine(e.Message);
            }

            return listaProductos;
        }

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="producto1"></param>
        /// <param name="producto2"></param>
        /// <returns> Retornara true si es igual o falso si no lo es </returns>
        public static bool operator ==(Producto producto1, Producto producto2)
        {
            if (producto1.GetType() == producto2.GetType())
                {
                    return true;
                }

            return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="producto1"></param>
        /// <param name="producto2"></param>
        /// <returns> Retornara el valor negado de la sobrecarga == </returns>
        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }

        #endregion

    }
}
