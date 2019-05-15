using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleAstudillo3B_TI.Clases
{
    //En la empresa Tercer Nivel Cía. Ltda. existe un requerimiento para realizar una aplicación que permita calcular 
    //el precio a cobrar por ventas de Galones de Gasolina, para la realización de la aplicación tenga en cuenta los 
    //siguientes requisitos funcionales:
        //La aplicación debe solicitar los datos del Cliente, que son Apellidos, Nombres, Número de Cédula de identidad y Dirección.
        //La aplicación debe solicitar los datos de la Gasolina, que son Tipo, Cantidad de Galones y Precio de Venta.
        //Si el tipo de Gasolina es “Extra” entonces el precio de la gasolina será de $1.50 por galón, caso contrario la Gasolina será 
        //“Super” por lo que el precio será de $2.00 por galón.
        //Al cálculo debe aumentar el impuesto al valor agregado I.V.A.del 12%.
        //La salida por pantalla debe mostrar los datos del Cliente, los datos de la Gasolina y el valor final a cancelar 
        //(Subtotal, IVA y Total).

    public class DatosCliente
    {
        private string cedula;

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        
        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private string nombres;

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public DatosCliente(string cedula, string apellidos, string nombres, string direccion)
        {
            Cedula = cedula;
            Apellidos = apellidos;
            Nombres = nombres;
            Direccion = direccion;
        }
    }
}
