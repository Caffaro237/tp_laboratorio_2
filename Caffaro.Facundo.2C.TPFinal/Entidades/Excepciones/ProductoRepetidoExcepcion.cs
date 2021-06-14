using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoRepetidoExcepcion : Exception
    {
        /// <summary>
        /// Constructor por defecto y llama al constructor que recibe un mensaje
        /// </summary>
        public ProductoRepetidoExcepcion()
            : this("Producto repetido")
        {

        }

        /// <summary>
        /// Constructor que recibe un string como parametro y llama a la base
        /// </summary>
        /// <param name="message"></param>
        public ProductoRepetidoExcepcion(string message)
            : base(message)
        {
        }
    }
}
