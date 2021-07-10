using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Agrega productos de tipo NOTEBOOK

            Fabrica.Producto = new Notebook(1, EnumMarcas.Asus.ToString(), EnumCPU.IntelI7.ToString(), EnumGPU.RTX2080.ToString(), 16, 1000, 17.3, 120);
            Fabrica.Producto = new Notebook(2, EnumMarcas.HP.ToString(), EnumCPU.IntelI5.ToString(), EnumGPU.GTX1080.ToString(), 8, 500, 15.6, 60);
            Fabrica.Producto = new Notebook(3, EnumMarcas.Asus.ToString(), EnumCPU.IntelI7.ToString(), EnumGPU.RTX2080.ToString(), 16, 1000, 17.3, 120);

            //Agrega productos de tipo PC ESCRITORIO

            Fabrica.Producto = new PCEscritorio(1, EnumMarcas.Acer.ToString(), EnumCPU.IntelI9.ToString(), EnumGPU.RTX3080.ToString(), 64, 4000);
            Fabrica.Producto = new PCEscritorio(2, EnumMarcas.Lenovo.ToString(), EnumCPU.IntelI7.ToString(), EnumGPU.RTX2080.ToString(), 32, 2000);
            Fabrica.Producto = new PCEscritorio(3, EnumMarcas.Lenovo.ToString(), EnumCPU.IntelI7.ToString(), EnumGPU.RTX2080.ToString(), 32, 2000);

            //Guardado de datos en un .txt
            try
            {
                Producto.Guardar();
                Console.WriteLine("**** Archivo de la lista de productos guardado ****\n");
            }
            catch (ArchivosExcepcion e)
            {
                Console.WriteLine(e.Message);
            }

            //Lectura del archivo guardado
            Console.WriteLine(Producto.Leer());

            Console.WriteLine("Presione una tecla para salir...");

            Console.ReadKey();

        }
    }
}
