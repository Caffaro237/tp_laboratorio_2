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
        /// Constructor por defecto y llama a la base pasandole un mensaje predeterminado
        /// </summary>
        public ProductoRepetidoExcepcion()
            : base("Producto repetido")
        {
        }
    }
}
