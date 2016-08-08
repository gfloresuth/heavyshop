using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class dCategoria
    {
        private int VarIdcategoria;
        private string VarNombre;
        private string VarDescripcion;
        public string TextoBuscar;

        //Constructor vacío
        public dCategoria()
        {

        }

        //Constructor con parámetros
        public dCategoria(int Idcategoria, string Nombre, string Descripcion)
        {
            this.VarIdcategoria = Idcategoria;
            this.VarNombre = Nombre;
            this.VarDescripcion = Descripcion;
        }
        //Métodos setter and Getter
        #region Metodos Get y Set
        public int Idcategoria
        {
            get { return VarIdcategoria; }
            set { VarIdcategoria = value; }
        }
        public string Nombre
        {
            get { return VarNombre; }
            set { VarNombre = value; }
        }
        public string Descripcion
        {
            get { return VarDescripcion; }
            set { VarDescripcion = value; }
        }
        #endregion


        //Método utilizado para insertar una Categoría
        public string Insertar(dCategoria Categoria)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //1. Establecer la cadena de conexión
                SqlCon.ConnectionString = Conexion.Cn;
                //2. Abrir la conexión de la BD
                SqlCon.Open();
                //3. Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parámetros al comando
                //Establecemos los valores para el parámetro
                //@idcategoria del Procedimiento Almacenado
                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                //Le declaramos que el parámetro es de salida,
                //porque obtendremos el código generado por la base de datos
                ParIdcategoria.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcategoria);
                //Agregamos el parámetro al comando


                //Establecemos los valores para el parámetro
                //@nombre del Procedimiento Almacenado
                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 100;
                ParNombre.Value = Categoria.Nombre;
                SqlCmd.Parameters.Add(ParNombre);
                //Agregamos el parámetro al comando

                //Establecemos los valores para el parámetro
                //@descripción del Procedimiento Almacenado
                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Categoria.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);
                //Agregamos el parámetro al comando

                //5. Ejecutamos el commando
                Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro de forma correcta";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;

            }
            finally
            {
                //6. Cerramos la conexion con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }


        //Método utilizado para actualizar un Producto
        public string Editar(dCategoria Categoria)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //1. Establecer la cadena de conexión
                SqlCon.ConnectionString = Conexion.Cn;
                //2. Abrir la conexión de la BD
                SqlCon.Open();
                //3. Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spEditar_Categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parámetros al comando
                //Establecemos los valores para el parámetro
                //@idcategoria del Procedimiento Almacenado
                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = Categoria.Idcategoria;
                SqlCmd.Parameters.Add(ParIdcategoria);
                //Agregamos el parámetro al comando

                //Establecemos los valores para el parámetro
                //@nombre del Procedimiento Almacenado
                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 100;
                ParNombre.Value = Categoria.Nombre;
                SqlCmd.Parameters.Add(ParNombre);
                //Agregamos el parámetro al comando

                //Establecemos los valores para el parámetro
                //@descripcion del Procedimiento Almacenado
                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Categoria.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);
                //Agregamos el parámetro al comando

                //5. Ejecutamos el commando
                Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el registro de forma correcta";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;

            }
            finally
            {
                //6. Cerramos la conexión con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        //Método utilizado para eliminar un Producto
        public string Eliminar(dCategoria Categoria)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //1. Establecer la cadena de conexión
                SqlCon.ConnectionString = Conexion.Cn;
                //2. Abrir la conexión de la BD
                SqlCon.Open();
                //3. Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parámetros al comando
                //Establecemos los valores para el parámetro
                //@idcategoria del Procedimiento Almacenado
                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = Categoria.Idcategoria;
                SqlCmd.Parameters.Add(ParIdcategoria);
                //Agregamos el parámetro al comando
                //5. Ejecutamos el commando
                Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                //6. Cerramos la conexión con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }




        //Método utilizado para obtener todas las categorías de la base de datos
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //1. Establecer la cadena de conexion
                SqlCon.ConnectionString = Conexion.Cn;

                //2. Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;//La conexión que va a usar el comando
                SqlCmd.CommandText = "spmostrar_categoria";//El comando a ejecutar
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //Decirle al comando que va a ejecutar una sentencia SQL

                //3. No hay parámetros

                //4. El DataAdapter que va a ejecutar el comando y
                //es el encargado de llena el DataTable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);//Llenamos el DataTable
            }
            catch (Exception ex)
            {
                DtResultado = null;

            }
            return DtResultado;
        }

        public DataTable BuscarNombre(dCategoria Categoria)
        {
            DataTable DtResultado = new DataTable("categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //1. Establecer la cadena de conexion
                SqlCon.ConnectionString = Conexion.Cn;

                //2. Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;//La conexión que va a usar el comando
                SqlCmd.CommandText = "spBuscar_Categoria_Nombre";//El comando a ejecutar
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //Decirle al comando que va a ejecutar una sentencia SQL

                //3.Enviamos el parámetro de Búsqueda
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Categoria.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                //4. El DataAdapter que va a ejecutar el comando y
                //es el encargado de llena el DataTable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);//Llenamos el DataTable
            }
            catch (Exception ex)
            {
                DtResultado = null;

            }
            return DtResultado;
        }


    }

}
