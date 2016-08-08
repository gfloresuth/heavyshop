using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NCategoria
    {
        //Método que llama al método Insertar de la Capa de Datos
        //de la clase dCategoria
        public static string Insertar(string Nombre, string Descripcion)
        {
            dCategoria Cat = new dCategoria();
            Cat.Nombre = Nombre;
            Cat.Descripcion = Descripcion;
            return Cat.Insertar(Cat);
        }
        //Método que llama al método Actualizar de la Capa de Datos
        //de la clase dCategoia
        public static string Editar(int Idcategoria, string Nombre, string Descripcion)
        {
            dCategoria Cat = new dCategoria();
            Cat.Idcategoria = Idcategoria;
            Cat.Nombre = Nombre;
            Cat.Descripcion = Descripcion;
            return Cat.Editar(Cat);
        }

        //Método que se encarga de llamar al método Eliminar
        //de la clase dCategoria
        public static string Eliminar(int Idcategoria)
        {
            dCategoria Cat = new dCategoria();
            Cat.Idcategoria = Idcategoria;
            return Cat.Eliminar(Cat);
        }

        //Método que se encarga de llamar al método ObtenerProducto
        //de la clase Producto
        public static DataTable Mostrar()
        {
            return new dCategoria().Mostrar();
        }

        public static DataTable BuscarNombre(string TextoBuscar)
        {
            dCategoria Cat = new dCategoria();
            Cat.TextoBuscar = TextoBuscar;
            return Cat.BuscarNombre(Cat);
        }
    }
}