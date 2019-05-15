using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AleAstudillo3B_TI.Clases;

namespace AleAstudillo3B_TI
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosCliente datocli = new DatosCliente("070457006-8", "Astudillo Tama", "Alexandra Aracely", "Manta");
            Gasolina calculogaso = new Gasolina("Extra", 10, 2.50);

            Console.WriteLine("Información del Cliente");
            Console.WriteLine("     Apellidos: {0} \n     Nombres: {1} \n     Cédula: {2} \n     Dirección: {3}",
                    datocli.Apellidos, datocli.Nombres, datocli.Cedula, datocli.Direccion);
            Console.WriteLine("\n");


            Console.WriteLine("Información Gasolina");
            Console.WriteLine("     Tipo: {0} \n     Galones: {1} \n     Precio: {2}", 
                calculogaso.TipoGasolina, calculogaso.Galones, calculogaso.PrecioVenta);
            Console.WriteLine("\n");


            Console.WriteLine("********** FACTURA ***********");
            Console.WriteLine("     Subtotal: " + calculogaso.SubTotal);
            Console.WriteLine("     Iva 12%: " + calculogaso.IVA);
            Console.WriteLine("     Valor Final: " + calculogaso.TotalPagar);

            Console.ReadKey();
        }
    }
}
