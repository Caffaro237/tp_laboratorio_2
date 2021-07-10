using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class ProductoDAO
    {
        #region Atributos

        private SqlConnection conexion;
        private SqlCommand comando;
        private List<Producto> listaProductos;
        bool notebook;
        bool pcEscritorio;

        #endregion

        #region Constructores

        /// <summary>
        /// Unico constructor que inicializa todos los atributos de esta clase
        /// </summary>
        public ProductoDAO()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConnection);
            this.comando = new SqlCommand();

            this.comando.Connection = this.conexion;

            this.listaProductos = new List<Producto>();

            this.pcEscritorio = true;
            this.notebook = false;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad de solo lectura de la lista de productos
        /// </summary>
        public List<Producto> ListaProductos
        {
            get 
            { 
                return this.listaProductos; 
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Este metodo llamara a GetProductos para traer desde la base de datos
        /// A todos los productos, viendo cual esta y cual no cargado en la lista
        /// </summary>
        /// <returns> Retorna la lista con lo productos cargados sin repetir </returns>
        public List<Producto> EnlistadorProductos()
        {
            foreach (Producto productoSinEnlistar in GetProductos(notebook))
            {
                if(listaProductos != productoSinEnlistar)
                {
                    ArchivosXml.NuevosProductos(productoSinEnlistar, notebook);
                    listaProductos.Add(productoSinEnlistar);
                }
            }

            foreach (Producto productoSinEnlistar in GetProductos(pcEscritorio))
            {
                if (listaProductos != productoSinEnlistar)
                {
                    ArchivosXml.NuevosProductos(productoSinEnlistar, pcEscritorio);
                    listaProductos.Add(productoSinEnlistar);
                }
            }

            return listaProductos;
        }

        /// <summary>
        /// En GetProductos se conectara a la base de datos para
        /// traer todos los productos que existan, siendo pc de escritorio o notebook
        /// </summary>
        /// <param name="PCoNotebook"></param>
        /// <returns> Retorna la lista con lo productos que existan en la base de datos </returns>
        public List<Producto> GetProductos(bool PCoNotebook)
        {
            List<Producto> lista = new List<Producto>();

            if(PCoNotebook)
            {
                comando.CommandText = "SELECT id, Marca, CPU, GPU, RAM, Almacenamiento FROM PCEscritorio";
            }
            else
            {
                comando.CommandText = "SELECT id, Marca, CPU, GPU, RAM, Almacenamiento, Pulgadas, Hertz FROM Notebook";
            }

            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                this.comando.Parameters.Clear();

                SqlDataReader oDr = this.comando.ExecuteReader();

                while (oDr.Read())
                {
                    int id;
                    int RAM;
                    int almacenamiento;
                    double pulgadas;
                    int hertz;

                    int.TryParse(oDr["ID"].ToString(), out id);
                    string marca = oDr["Marca"].ToString();
                    string CPU = oDr["CPU"].ToString();
                    string GPU = oDr["GPU"].ToString();
                    int.TryParse(oDr["RAM"].ToString(), out RAM);
                    int.TryParse(oDr["Almacenamiento"].ToString(), out almacenamiento);

                    if(!PCoNotebook)
                    {
                        double.TryParse(oDr["Pulgadas"].ToString(), out pulgadas);
                        int.TryParse(oDr["Hertz"].ToString(), out hertz);

                        Fabrica.Producto = new Notebook(id, marca, CPU, GPU, RAM, almacenamiento, pulgadas, hertz);
                        lista.Add(new Notebook(id, marca, CPU, GPU, RAM, almacenamiento, pulgadas, hertz));
                    }
                    else
                    {
                        Fabrica.Producto = new PCEscritorio(id, marca, CPU, GPU, RAM, almacenamiento);
                        lista.Add(new PCEscritorio(id, marca, CPU, GPU, RAM, almacenamiento));
                    }

                }

                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexion.Close();
            }
        }

        /// <summary>
        /// Este INSERT sera el encargado de agregar una nueva Notebook
        /// a la base de datos, siempre y cuando no este repetido
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="CPU"></param>
        /// <param name="GPU"></param>
        /// <param name="RAM"></param>
        /// <param name="almacenamiento"></param>
        /// <param name="pulgadas"></param>
        /// <param name="hertz"></param>
        public void InsertNotebook(string marca, string CPU, string GPU, int RAM, int almacenamiento, double pulgadas, int hertz)
        {
            comando.CommandText = "INSERT INTO Notebook (Marca, CPU, GPU, RAM, Almacenamiento, Pulgadas, Hertz) VALUES (@marca, @cpu, @gpu, @ram, @almacenamiento, @pulgadas, @hertz)";
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@cpu", CPU);
            comando.Parameters.AddWithValue("@gpu", GPU);
            comando.Parameters.AddWithValue("@ram", RAM);
            comando.Parameters.AddWithValue("@almacenamiento", almacenamiento);
            comando.Parameters.AddWithValue("@pulgadas", pulgadas);
            comando.Parameters.AddWithValue("@hertz", hertz);

            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                if (!(ProductoRepetido(marca, CPU, GPU, RAM, almacenamiento)))
                {
                    comando.ExecuteNonQuery();
                }
                else
                {
                    throw new ProductoRepetidoExcepcion();
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexion.Close();
            }

        }

        /// <summary>
        /// Este INSERT sera el encargado de agregar una nueva PC de Escritorio
        /// a la base de datos, siempre y cuando no este repetido
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="CPU"></param>
        /// <param name="GPU"></param>
        /// <param name="RAM"></param>
        /// <param name="almacenamiento"></param>
        public void InsertPCEscritorio(string marca, string CPU, string GPU, int RAM, int almacenamiento)
        {
            comando.CommandText = "INSERT INTO PCEscritorio (Marca, CPU, GPU, RAM, Almacenamiento) VALUES (@marca, @cpu, @gpu, @ram, @almacenamiento)";
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@cpu", CPU);
            comando.Parameters.AddWithValue("@gpu", GPU);
            comando.Parameters.AddWithValue("@ram", RAM);
            comando.Parameters.AddWithValue("@almacenamiento", almacenamiento);

            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                if(!(ProductoRepetido(marca, CPU, GPU, RAM, almacenamiento)))
                {
                    comando.ExecuteNonQuery();
                }
                else
                {
                    throw new ProductoRepetidoExcepcion();
                }
            }
            catch (ProductoRepetidoExcepcion e)
            {
                throw e;
            }
            finally
            {
                this.conexion.Close();
            }
        }

        /// <summary>
        /// Este metodo se encargara de preguntar si el producto existe o no
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="CPU"></param>
        /// <param name="GPU"></param>
        /// <param name="RAM"></param>
        /// <param name="almacenamiento"></param>
        /// <returns> Retornara un true si el producto ya existe, sino retornara false </returns>
        public bool ProductoRepetido(string marca, string CPU, string GPU, int RAM, int almacenamiento)
        {
            bool retorno = false;

            if(almacenamiento >= 1000)
            {
                almacenamiento = almacenamiento / 1000;
            }

            foreach (Producto p in listaProductos)
            {
                if (p.Marca != marca || p.Cpu != CPU || p.Gpu != GPU || p.CantidadRAM != RAM || p.CantidadAlmacenamiento != almacenamiento)
                {
                    retorno = false;
                }
                else
                {
                    retorno = true;
                    break;
                }
            }
            
            return retorno;
        }

        /// <summary>
        /// BorrarProducto es el encargado de eliminar algun producto de 
        /// la base de datos usando el DELETE
        /// </summary>
        /// <param name="id"></param>
        /// <param name="PCoNotebook"></param>
        /// <returns> Retornara true si lo pudo borrar y false si no lo borro o no existe en la lista </returns>
        public bool BorrarProducto(int id, bool PCoNotebook)
        {
            bool retorno = false;

            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                foreach (Producto producto in listaProductos)
                {
                    if(producto.ID == id)
                    {
                        if (PCoNotebook)
                        {
                            comando.CommandText = "DELETE FROM PCEscritorio WHERE id = @id";
                            comando.Parameters.AddWithValue("@id", id);
                        }
                        else
                        {
                            comando.CommandText = "DELETE FROM Notebook WHERE id = @id";
                            comando.Parameters.AddWithValue("@id", id);
                        }

                        comando.ExecuteNonQuery();
                        Fabrica.listaProductos.Clear();
                        listaProductos.Clear();

                        retorno = true;
                        break;
                    }
                    else
                    {
                        retorno = false;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.comando.Parameters.Clear();
                this.conexion.Close();
            }

            return retorno;
        }

        #endregion

    }
}
