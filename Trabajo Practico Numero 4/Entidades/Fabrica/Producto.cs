using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region Atributos

        private string marca;
        private string CPU;
        private string GPU;
        private int cantidadRAM;
        private int cantidadAlmacenamiento;
        private bool gigaOTera;

        #endregion

        #region Constructores

        /// <summary>
        /// Unico constructor que rebibe todos los datos para el producto, inicializandolos a todos
        /// Si la cantidad de almacenamiento supera los 1000GB lo transformara a TB para mejorar su lectura
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="CPU"></param>
        /// <param name="GPU"></param>
        /// <param name="cantidadRAM"></param>
        /// <param name="cantidadAlmacenamiento"></param>
        public Producto(string marca, string CPU, string GPU, int cantidadRAM, int cantidadAlmacenamiento)
        {
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
        /// </summary>
        /// <returns> Retornara un string con todos los datos del producto </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

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

            return archivoTexto.Guardar("Lista de productos.txt", Fabrica.MostrarFabricacion());
        }

        /// <summary>
        /// Este metodo leera los datos del archivo de texto guardado
        /// </summary>
        /// <returns> Retornara un string con los datos obtenidos del archivo de texto </returns>
        public static string Leer()
        {
            Texto archivoTexto = new Texto();
            string datosArchivo;

            archivoTexto.Leer("Lista de productos.txt", out datosArchivo);

            return datosArchivo;
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
