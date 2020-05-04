using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class ClienteService
    {

         ClienteRepository ClienteRepository = new ClienteRepository();

       
        public string Guardar(LiquidacionCuotaModeradora liquidacion)
        {
            ClienteRepository.Guardar(liquidacion);
            return "Se guardo exitosamente";
        }

        public IList<LiquidacionCuotaModeradora> Consultar()
        {
            return ClienteRepository.Consultar();
        }


        public string Actualizar(LiquidacionCuotaModeradora liquidacion)
        {
            ClienteRepository.Actualizar(liquidacion);
            return "Se modifico correctamente";
                
            
        }

        public string Eliminar(IList<LiquidacionCuotaModeradora> liquidacions)
        {

            ClienteRepository.Eliminar(liquidacions);
            return  "Se elimino correctamente";
        }

        public IList<LiquidacionCuotaModeradora> BuscarRegimenContributivo()
        {
           return ClienteRepository.BuscarRegimenContributivo();
        }

        public int TotalizarRegimenContributivo()
        {
            return ClienteRepository.TotalizarRegimenContributivo();
        }

        public IList<LiquidacionCuotaModeradora> BuscarRegimenSubsidado()
        {
            return ClienteRepository.BuscarRegimenSubsidado();
        }

        public int TotalizarRegimenSubsidiado()
        {
            return ClienteRepository.TotalizarRegimenSubsidiado();
        }

        public int TotalizarRegimen()
        {
            return ClienteRepository.TotalizarRegimen();
        }

        public IList<LiquidacionCuotaModeradora> ListaRegimen()
        {
            return ClienteRepository.ListaRegimen();
        }

        public double SumarSalario()
        {
            return ClienteRepository.SumarSalario();
        }

        public double SumarRegimen(string tipo)
        {
            return ClienteRepository.SumarRegimen(tipo);
        }

        public IList<LiquidacionCuotaModeradora> FiltrarFecha(string fecha)
        {
            return ClienteRepository.FiltrarFecha(fecha);
        }

        public IList<LiquidacionCuotaModeradora> FiltrarNombre(string nombre)
        {
            return ClienteRepository.FiltrarNombre(nombre);
        }
        
    }
}
