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
        private SqlConnection conexion;
        private SqlCommand comando;
        private List<Producto> listaProductos;

        public ProductoDAO()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConnection);
            this.comando = new SqlCommand();

            this.comando.Connection = this.conexion;

            this.listaProductos = new List<Producto>();
        }

        public List<Producto> ListaProductos
        {
            get 
            { 
                return this.listaProductos; 
            }
        }

        public List<Producto> EnlistadorProductos()
        {
            bool notebooks = false;
            bool pcsEscrotorio = true;

            foreach (Producto productoSinEnlistar in GetProductos(notebooks))
            {
                if(listaProductos != productoSinEnlistar)
                {
                    listaProductos.Add(productoSinEnlistar);
                }
            }

            foreach (Producto productoSinEnlistar in GetProductos(pcsEscrotorio))
            {
                if (listaProductos != productoSinEnlistar)
                {
                    listaProductos.Add(productoSinEnlistar);
                }
            }

            return listaProductos;
        }

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
    }
}
