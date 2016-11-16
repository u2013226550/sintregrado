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
        //Método insertar que llama al método insertar de la clase dcategoria
        //de la capadatos
        public static string Insertar (string nombre, string descripcion)
        {
            DCategoria Obj = new DCategoria();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }
        //Método editar que llama al metodo  editar de la  clase dcategoria
        //de la capadatos
        public static string Editar(int idcategoria, string nombre, string descripcion)
        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = idcategoria;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }
        //Método eliminar que llama al metodo  eliminar de la  clase dcategoria
        //de la capadatos
        public static string Eliminar(int idcategoria)
        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = idcategoria;
            return Obj.Eliminar(Obj);
        }
        //Método mostrar que llama al metodo  mostrar de la  clase dcategoria
        //de la capadatos
        public static DataTable Mostrar()
        {
            return new DCategoria().Mostrar();
        }
        //Método buscarnombre que llama al metodo  buscarnombre de la  clase dcategoria
        //de la capadatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            DCategoria Obj = new DCategoria();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
