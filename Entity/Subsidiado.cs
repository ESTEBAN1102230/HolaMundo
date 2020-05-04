using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Subsidiado: LiquidacionCuotaModeradora
    {
        
     
        public override void CalcularTarifa()
        {
            Tarifa = 0.05;
            
        }

        public override void CalcularTope()
        {
            int Aplica = 0;
            if(CuotaModeradora>= 200000)
            {
                CuotaModeradora = 200000;
                Aplica = 1;
            }

            if (Aplica==0)
            {
                TopeMaximo = "No plica";
            }
            else
            {
                TopeMaximo = "Aplica";
            }

        }
    }
}
