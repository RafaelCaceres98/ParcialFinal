using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Lacteos
    {
        public int Sede { get; set; }
        public string Cedula { get; set; }
        public string  Nombre { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public decimal Salario { get; set; }
        public decimal Bonificaciones { get; set; }
        public decimal Descuentos { get; set; }
        public decimal TotalPago { get; set; }



        public decimal CalcularPago()
        {
            return (Salario + Bonificaciones - Descuentos);
        }
    }
}
