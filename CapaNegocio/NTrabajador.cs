using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NTrabajador
    {
        //Métodos para comunicarnos a la capa datos
        //Método insertar que llama al método insertar de la clase dtrabajador
        //de la capadatos
        public static string Insertar(string nombre, string apellidos, string sexo, DateTime fecha_nacimiento,
            string num_documento, string direccion, string telefono, string email,string acceso,string usuario,string password)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fecha_nacimiento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Password = password;

            return Obj.Insertar(Obj);
        }
        //Método editar que llama al metodo  editar de la  clase dtrabajor
        //de la capadatos
        public static string Editar(int idtrabajador, string nombre, string apellidos, string sexo, DateTime fecha_nacimiento,
            string num_documento, string direccion, string telefono, string email, string acceso,string usuario,
            string password)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Idtrabajador = idtrabajador;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fecha_nacimiento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Password = password;

            return Obj.Editar(Obj);
        }
        //Método eliminar que llama al metodo  eliminar de la  clase dtrabajador
        //de la capadatos
        public static string Eliminar(int idtrabajador)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Idtrabajador = idtrabajador;
            return Obj.Eliminar(Obj);
        }
        //Método mostrar que llama al metodo  mostrar de la  clase dtrabajador
        //de la capadatos
        public static DataTable Mostrar()
        {
            return new DTrabajador().Mostrar();
        }
        //Método buscarapellidos que llama al metodo  buscarrason_social de la  clase dapellidos
        //de la capadatos
        public static DataTable BuscarApellidos(string textobuscar)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarApellidos(Obj);
        }
        //Método buscarnum_documento que llama al metodo  buscarnum_documento de la  clase dtrabajador
        //de la capadatos
        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }
        public static DataTable Login(string usuario, string password)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Usuario = usuario;
            Obj.Password = password;
            return Obj.Login(Obj);
        }
    }
}
