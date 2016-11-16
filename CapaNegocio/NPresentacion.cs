using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NPresentacion
    {
        //Método insertar que llama al método insertar de la clase dpresentacion
        //de la capadatos
        public static string Insertar(string nombre, string descripcion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }
        //Método editar que llama al metodo  editar de la  clase dpresentacion
        //de la capadatos
        public static string Editar(int idpresentacion, string nombre, string descripcion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Idpresentacion = idpresentacion;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }
        //Método eliminar que llama al metodo  eliminar de la  clase dpresentacion
        //de la capadatos
        public static string Eliminar(int idpresentacion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Idpresentacion = idpresentacion;
            return Obj.Eliminar(Obj);
        }
        //Método mostrar que llama al metodo  mostrar de la  clase dpresentacion
        //de la capadatos
        public static DataTable Mostrar()
        {
            return new DPresentacion().Mostrar();
        }
        //Método buscarnombre que llama al metodo  buscarnombre de la  clase dpresentacion
        //de la capadatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
