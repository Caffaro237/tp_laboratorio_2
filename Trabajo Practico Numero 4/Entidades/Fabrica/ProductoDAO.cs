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

        public ProductoDAO()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConnection);
            this.comando = new SqlCommand();

            this.comando.Connection = this.conexion;
        }

        public List<Producto> GetNotebooks()
        {
            List<Producto> lista = new List<Producto>();

            comando.CommandText = "SELECT Marca, CPU, GPU, RAM, Almacenamiento, Pulgadas, Hertz FROM Notebook";

            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    int RAM;
                    int almacenamiento;
                    double pulgadas;
                    int hertz;

                    string marca = oDr["Marca"].ToString();
                    string CPU = oDr["CPU"].ToString();
                    string GPU = oDr["GPU"].ToString();
                    int.TryParse(oDr["RAM"].ToString(), out RAM);
                    int.TryParse(oDr["Almacenamiento"].ToString(), out almacenamiento);
                    double.TryParse(oDr["Pulgadas"].ToString(), out pulgadas);
                    int.TryParse(oDr["Hertz"].ToString(), out hertz);

                    Fabrica.Producto = new Notebook(marca, CPU, GPU, RAM, almacenamiento, pulgadas, hertz);
                    lista.Add(new Notebook(marca, CPU, GPU, RAM, almacenamiento, pulgadas, hertz));

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

        public List<Producto> GetPCEscritorio()
        {
            List<Producto> lista = new List<Producto>();

            comando.CommandText = "SELECT Marca, CPU, GPU, RAM, Almacenamiento FROM PCEscritorio";

            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    int RAM;
                    int almacenamiento;

                    string marca = oDr["Marca"].ToString();
                    string CPU = oDr["CPU"].ToString();
                    string GPU = oDr["GPU"].ToString();
                    int.TryParse(oDr["RAM"].ToString(), out RAM);
                    int.TryParse(oDr["Almacenamiento"].ToString(), out almacenamiento);

                    Fabrica.Producto = new PCEscritorio(marca, CPU, GPU, RAM, almacenamiento);
                    lista.Add(new PCEscritorio(marca, CPU, GPU, RAM, almacenamiento));
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

                comando.ExecuteNonQuery();
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

                foreach (Producto p in this.GetPCEscritorio())
                {
                    if (p.Marca != marca || p.Cpu != CPU || p.Gpu != GPU || p.CantidadRAM != RAM || p.CantidadAlmacenamiento != almacenamiento)
                    {
                        comando.ExecuteNonQuery();
                    }
                    else
                    {
                        throw new ProductoRepetidoExcepcion();
                    }
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


    }
}
