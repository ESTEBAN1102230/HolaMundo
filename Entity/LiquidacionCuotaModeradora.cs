using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class LiquidacionCuotaModeradora
    {

        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string NumeroLiquidacion { get; set; }
        public string Tipo { get; set; }
        public double Servicio { get; set; }
        public double Salario { get; set; }
        public double CuotaReal { get; set; }
        public double CuotaModeradora { get; set; }
        public string MostrarTarifa { get; set; }
        public double Tarifa { get; set; }
        public string TopeMaximo { get; set; }
        public string Fecha { get; set; }
        public string Mes { get; set; }
        public string Año { get; set; }
       



        public void CalcularCuota()
        {
            CalcularTarifa();
            CuotaModeradora =  Servicio * Tarifa;
            CuotaReal = CuotaModeradora;
            MostrarTarifa = @""+Tarifa*100;
            CalcularTope();

        }
        public abstract void CalcularTarifa();
        public abstract void CalcularTope();




    }
}
