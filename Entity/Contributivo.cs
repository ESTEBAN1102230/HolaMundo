using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity
{
    public class Contributivo : LiquidacionCuotaModeradora
    { 

       
        public override void CalcularTarifa()
        {
            if (Salario < 1961314)
            {
               Tarifa = 0.15;
                

            }else if ((Salario>= 1961314) ||(Salario <= 4903285))
            {
               
                Tarifa = 0.2;
                
            }
            else if(Salario> 4903285)
            { 
                
                Tarifa = 0.25;
                
            }
        }

        public override  void CalcularTope()
        {
            int Aplica = 0;
            if ((Salario < 1961314) && (CuotaModeradora>250000))
            {
                CuotaModeradora = 250000;
                Aplica = 1;
            }
            if ((Salario>=1961314)||(Salario<=4903285) && (CuotaModeradora>900000) )
            {
                CuotaModeradora = 900000;
                Aplica = 1;
            }
            if ((Salario> 4903285)&&(CuotaModeradora>1500000))
            {
                CuotaModeradora = 15000000;
                Aplica = 1;
            }

            if (Aplica==0)
            {
                TopeMaximo = "No aplica";
            }
            else 
            {
                TopeMaximo = "Aplica";
            }
        }
    }
    }

