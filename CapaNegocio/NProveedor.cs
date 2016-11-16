using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NProveedor
    {
        //Método insertar que llama al método insertar de la clase dproveedor
        //de la capadatos
        public static string Insertar(string razon_social,string sector_comercial,string tipo_documento,string num_documento,string direccion,string telefono,string email,string url)
        {
            DProveedor Obj = new DProveedor();
            Obj.Razon_Social = razon_social;
            Obj.Sector_Comercial = sector_comercial;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Url = url;

            return Obj.Insertar(Obj);
        }
        //Método editar que llama al metodo  editar de la  clase dproveedor
        //de la capadatos
        public static string Editar(int idproveedor, string razon_social, string sector_comercial, string tipo_documento, string num_documento, string direccion, string telefono, string email, string url)
        {
            DProveedor Obj = new DProveedor();
            Obj.Idproveedor = idproveedor;
            Obj.Razon_Social = razon_social;
            Obj.Sector_Comercial = sector_comercial;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Url = url;

            return Obj.Editar(Obj);
        }
        //Método eliminar que llama al metodo  eliminar de la  clase dproveedor
        //de la capadatos
        public static string Eliminar(int idproveedor)
        {
            DProveedor Obj = new DProveedor();
            Obj.Idproveedor = idproveedor;
            return Obj.Eliminar(Obj);
        }
        //Método mostrar que llama al metodo  mostrar de la  clase dproveedor
        //de la capadatos
        public static DataTable Mostrar()
        {
            return new DProveedor().Mostrar();
        }
        //Método buscarrason_social que llama al metodo  buscarrason_social de la  clase dproveedor
        //de la capadatos
        public static DataTable BuscarRazon_Social(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarRazon_Social(Obj);
        }
        //Método buscarnum_documento que llama al metodo  buscarnum_documento de la  clase dproveedor
        //de la capadatos
        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }

    }
}
