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
        private static readonly string path;
        private static readonly string pathEscritura;
        private static readonly string pathZipeo;

        static ArchivosXml()
        {
            path = Directory.GetCurrentDirectory();
            path = Directory.GetParent(path).FullName;
            path = Directory.GetParent(path).FullName;
            path = Directory.GetParent(path).FullName;

            

            pathEscritura = path + @"\Archivos\NuevasComputadoras\";
            pathZipeo = path + @"\Archivos\BackupComputadoras\";

            CrearPaths();
        }


        public static bool NuevosProductos(Producto nuevoProducto, bool PCoNotebook)
        {
            string pathCompleto = string.Empty;

            if (!(nuevoProducto is null))
            {
                if(PCoNotebook)
                {
                    pathCompleto = string.Concat(pathEscritura, "PCEscritorioID-" + nuevoProducto.ID + ".xml");
                }
                else
                {
                    pathCompleto = string.Concat(pathEscritura, "NotebookID-" + nuevoProducto.ID + ".xml");
                }

                try
                {
                    using (XmlTextWriter xmlWriter = new XmlTextWriter(pathCompleto, Encoding.ASCII))
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

        public static void GenerarBackup()
        {
            string[] paths;
            DirectoryInfo directorioElegido = new DirectoryInfo(pathEscritura);

            foreach (FileInfo archivoItem in directorioElegido.GetFiles())
            {
                try
                {
                    using (FileStream archivoFileSteam = archivoItem.OpenRead())
                    {
                        if (archivoItem.Extension == ".xml")
                        {
                            using (FileStream ArchivoSteamComprimido = File.Create(archivoItem.FullName + ".zip"))
                            {
                                using (GZipStream objAComprimir = new GZipStream(ArchivoSteamComprimido, CompressionMode.Compress))
                                {
                                    archivoFileSteam.CopyTo(objAComprimir);
                                }

                                paths = ArchivoSteamComprimido.Name.Split('\\');
                                File.Move(ArchivoSteamComprimido.Name, string.Concat(pathZipeo, paths[paths.Length - 1].ToString()));
                            }
                        }

                    }
                }
                catch (Exception e)
                {

                }
            }
        }

        public static void EliminarZip()
        {

            DirectoryInfo directorioElegido = new DirectoryInfo(pathEscritura);
            FileInfo[] files = directorioElegido.GetFiles();

            foreach (FileInfo archivoItem in files)
            {
                if (archivoItem.Name.Contains(".zip"))
                {
                    File.Delete(archivoItem.FullName);
                }

            }

        }

        private static void CrearPaths()
        {
            if (!Directory.Exists(pathEscritura))
            {
                Directory.CreateDirectory(pathEscritura);
            }

            if (!Directory.Exists(pathZipeo))
            {
                Directory.CreateDirectory(pathZipeo);
            }
        }
    }
}
