using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleAstudillo3B_TI.Clases
{
    public class Gasolina
    {
        private string tipoGasolina;

        public string TipoGasolina
        {
            get { return tipoGasolina; }
            set { tipoGasolina = value; }
        }

        private int galones;

        public int Galones
        {
            get { return galones; }
            set { galones = value; }
        }

        private double precioVenta;

        public double PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }

        public double SubTotal
        {
            get { return PrecioVenta * Galones; }
        }

        public double IVA
        {
            get { return SubTotal * 0.12; }
        }

         public double TotalPagar
        {
            get { return SubTotal + IVA; }
        }

        public Gasolina(string tipoGasolina, int galones, double precioVenta)
        {
            TipoGasolina = tipoGasolina;
            Galones = galones;
            PrecioVenta = precioVenta;
        }
    }
}
