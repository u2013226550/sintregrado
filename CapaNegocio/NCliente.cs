using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;


namespace CapaNegocio
{
    public class NCliente
    {
        //Métodos para comunicarnos a la capa datos
        //Método insertar que llama al método insertar de la clase dcliente
        //de la capadatos
        public static string Insertar(string nombre,string apellidos,string sexo,DateTime fecha_nacimiento,string tipo_documento,
            string num_documento,string direccion,string telefono,string email)
        {
            DCliente Obj = new DCliente();
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fecha_nacimiento;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            
            return Obj.Insertar(Obj);
        }
        //Método editar que llama al metodo  editar de la  clase dcliente
        //de la capadatos
        public static string Editar(int idcliente, string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string tipo_documento,
            string num_documento, string direccion, string telefono, string email)
        {
            DCliente Obj = new DCliente();
            Obj.Idcliente = idcliente;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fecha_nacimiento;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            
            return Obj.Editar(Obj);
        }
        //Método eliminar que llama al metodo  eliminar de la  clase dcliente
        //de la capadatos
        public static string Eliminar(int idcliente)
        {
            DCliente Obj = new DCliente();
            Obj.Idcliente = idcliente;
            return Obj.Eliminar(Obj);
        }
        //Método mostrar que llama al metodo  mostrar de la  clase dcliente
        //de la capadatos
        public static DataTable Mostrar()
        {
            return new DCliente().Mostrar();
        }
        //Método buscarrason_social que llama al metodo  buscarrason_social de la  clase dcliente
        //de la capadatos
        public static DataTable BuscarApellidos(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarApellidos(Obj);
        }
        //Método buscarnum_documento que llama al metodo  buscarnum_documento de la  clase dcliente
        //de la capadatos
        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }
    }
}
