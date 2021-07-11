using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public static class ArchivosXml
    {
        #region Atributos

        private static readonly string ruta;
        private static readonly string rutaEscritura;
        private static readonly string rutaZipeo;

        #endregion

        #region Constructores

        /// <summary>
        /// Costructor que inicializa las rutas de lectura y zipeo
        /// Y crea las rutas si no existen
        /// </summary>
        static ArchivosXml()
        {
            ruta = Directory.GetCurrentDirectory();
            ruta = Directory.GetParent(ruta).FullName;
            ruta = Directory.GetParent(ruta).FullName;
            ruta = Directory.GetParent(ruta).FullName;

            rutaEscritura = ruta + @"\Archivos\NuevasComputadoras\";
            rutaZipeo = ruta + @"\Archivos\BackupComputadoras\";

            CrearPaths();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que crea un XML por producto, notebook o pc de escritorio
        /// </summary>
        /// <param name="nuevoProducto"></param>
        /// <param name="PCoNotebook"></param>
        /// <returns></returns>
        public static bool NuevosProductos(Producto nuevoProducto, bool PCoNotebook)
        {
            string rutaCompleta = string.Empty;

            if (!(nuevoProducto is null))
            {
                if(PCoNotebook)
                {
                    rutaCompleta = string.Concat(rutaEscritura, "PCEscritorioID-" + nuevoProducto.ID + ".xml");
                }
                else
                {
                    rutaCompleta = string.Concat(rutaEscritura, "NotebookID-" + nuevoProducto.ID + ".xml");
                }

                try
                {
                    using (XmlTextWriter xmlWriter = new XmlTextWriter(rutaCompleta, Encoding.UTF8))
                    {
                        XmlSerializer serializer = new XmlSerializer(nuevoProducto.GetType());
                        serializer.Serialize(xmlWriter, nuevoProducto);
                    }

                    return true;
                }
                catch (Exception e)
                {
                    throw new ArchivosExcepcion(e.Message);
                }
            }
            return false;
        }

        /// <summary>
        /// Este metodo lo que hace es generar un .zip por cada producto que encuentre
        /// en la carpeta NuevasComputadoras. Pasandolos a la carpeta de Backup
        /// </summary>
        public static void GenerarBackup()
        {
            string[] paths;
            DirectoryInfo directorioElegido = new DirectoryInfo(rutaEscritura);

            foreach (FileInfo archivoItem in directorioElegido.GetFiles())
            {
                try
                {
                    using (FileStream archivoFileSteam = archivoItem.OpenRead())
                    {
                        if (archivoItem.Extension == ".xml")
                        {
                            using(FileStream ArchivoSteamComprimido = File.Create(archivoItem.FullName + ".zip"))
                            {
                                using (GZipStream objAComprimir = new GZipStream(ArchivoSteamComprimido, CompressionMode.Compress))
                                {
                                    archivoFileSteam.CopyTo(objAComprimir);
                                }

                                paths = ArchivoSteamComprimido.Name.Split('\\');
                                File.Move(ArchivoSteamComprimido.Name, string.Concat(rutaZipeo, paths[paths.Length - 1].ToString()));
                            }
                        }

                    }
                }
                catch (Exception e)
                {
                }
            }
        }

        /// <summary>
        /// Eliminar zip elimina los archivos comprimidos de la carpeta NuevasComputadoras
        /// Despues de ser pasados a su propia carpeta
        /// </summary>
        public static void EliminarZip()
        {
            DirectoryInfo directorioElegido = new DirectoryInfo(rutaEscritura);
            FileInfo[] files = directorioElegido.GetFiles();

            foreach (FileInfo archivoItem in files)
            {
                if (archivoItem.Name.Contains(".zip"))
                {
                    File.Delete(archivoItem.FullName);
                }
            }
        }

        /// <summary>
        /// Este metodo eliminara el producto de la carpeta de los xml
        /// Dejando el backup .zip creado para dejar una constancia de su fabricacion
        /// </summary>
        /// <param name="id"></param>
        /// <param name="PCoNotebook"></param>
        public static void EliminarProductoArchivo(int id, string PCoNotebook)
        {
            DirectoryInfo directorioElegido = new DirectoryInfo(rutaEscritura);
            FileInfo[] files = directorioElegido.GetFiles();

            foreach (FileInfo archivoItem in files)
            {
                if (archivoItem.Name.Contains(PCoNotebook) && archivoItem.Name.Contains(id.ToString()))
                {
                    File.Delete(archivoItem.FullName);
                }
            }
        }

        /// <summary>
        /// Metodo que crea las rutas si no existen
        /// </summary>
        private static void CrearPaths()
        {
            if (!Directory.Exists(rutaEscritura))
            {
                Directory.CreateDirectory(rutaEscritura);
            }

            if (!Directory.Exists(rutaZipeo))
            {
                Directory.CreateDirectory(rutaZipeo);
            }
        }

        #endregion

    }
}
