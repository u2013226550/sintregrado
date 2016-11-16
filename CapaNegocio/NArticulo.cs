using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NArticulo
    {
        //Método insertar que llama al método insertar de la clase darticulo
        //de la capadatos
        public static string Insertar(string codigo,string nombre,string descripcion,byte[] imagen,int idcategoria,int idpresentacion)
        {
            DArticulo Obj = new DArticulo();
            Obj.Codigo = codigo;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Imagen = imagen;
            Obj.Idcategoria = idcategoria;
            Obj.Idpresentacion = idpresentacion;

            return Obj.Insertar(Obj);
        }
        //Método editar que llama al metodo  editar de la  clase darticulo
        //de la capadatos
        public static string Editar(int idarticulo,string codigo, string nombre, string descripcion, byte[] imagen, int idcategoria, int idpresentacion)
        {
            DArticulo Obj = new DArticulo();
            Obj.Idarticulo = idarticulo;
            Obj.Codigo = codigo;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Imagen = imagen;
            Obj.Idcategoria = idcategoria;
            Obj.Idpresentacion = idpresentacion;
            return Obj.Editar(Obj);
        }
        //Método eliminar que llama al metodo  eliminar de la  clase darticulo
        //de la capadatos
        public static string Eliminar(int idarticulo)
        {
            DArticulo Obj = new DArticulo();
            Obj.Idarticulo = idarticulo;
            return Obj.Eliminar(Obj);
        }
        //Método mostrar que llama al metodo  mostrar de la  clase darticulo
        //de la capadatos
        public static DataTable Mostrar()
        {
            return new DArticulo().Mostrar();
        }
        //Método buscarnombre que llama al metodo  buscarnombre de la  clase darticulo
        //de la capadatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            DArticulo Obj = new DArticulo();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
        //Método mostrar que llama al metodo  mostrar de la  clase darticulo
        //de la capadatos
        public static DataTable Stock_Articulos()
        {
            return new DArticulo().Stock_Articulos();
        }
    }
}
