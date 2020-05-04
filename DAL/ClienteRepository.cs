using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entity;

namespace DAL
{
    public class ClienteRepository
    {
        private string ruta = @"Clientes.txt";
        private IList<LiquidacionCuotaModeradora> liquidacions;
        LiquidacionCuotaModeradora liquidacion;



        public ClienteRepository()
        {
            liquidacions = new List<LiquidacionCuotaModeradora>();
        }


        public void Guardar(LiquidacionCuotaModeradora liquidacion)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{liquidacion.NumeroLiquidacion};{liquidacion.Identificacion};{liquidacion.Nombre};" +
                $"{liquidacion.Tipo};{liquidacion.Salario};{liquidacion.Servicio};{liquidacion.CuotaModeradora};{liquidacion.CuotaReal};" +
                $"{liquidacion.MostrarTarifa};{liquidacion.TopeMaximo};{liquidacion.Fecha}"); 
            escritor.Close();
            file.Close();
        }

      public IList<LiquidacionCuotaModeradora> Consultar()
        {

            liquidacions.Clear();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(file);
            string line = string.Empty;
            

            while ((line = reader.ReadLine()) != null)
            {
               
                string[] MatrizClientes = line.Split(';');
                ValidarRegimen(MatrizClientes[3]);
                liquidacion.NumeroLiquidacion = MatrizClientes[0];
                liquidacion.Identificacion = MatrizClientes[1];
                liquidacion.Nombre = MatrizClientes[2];
                liquidacion.Tipo = MatrizClientes[3];
                liquidacion.Salario = Convert.ToDouble(MatrizClientes[4]);
                liquidacion.Servicio = Convert.ToDouble(MatrizClientes[5]);
                liquidacion.CuotaModeradora = Convert.ToDouble(MatrizClientes[6]);
                liquidacion.CuotaReal = Convert.ToDouble(MatrizClientes[7]);
                liquidacion.MostrarTarifa = MatrizClientes[8];
                liquidacion.TopeMaximo = MatrizClientes[9];
                liquidacion.Fecha = MatrizClientes[10];
                liquidacions.Add(liquidacion);
            }
            file.Close();  reader.Close();
            return liquidacions;
            
        }

        public void ValidarRegimen(string TipoAfiliacion)
        {
            if(TipoAfiliacion == "Contributivo")
            {
                liquidacion = new Contributivo();
            }
            else
            {
                liquidacion = new Subsidiado();
            }
        }

        public void Eliminar(IList<LiquidacionCuotaModeradora> liquidacions)
        {

            liquidacions.Clear();
            FileStream file = new FileStream(ruta,FileMode.Create);
            StreamWriter escritor = new StreamWriter(file);
            foreach (LiquidacionCuotaModeradora liquidacion in liquidacions)
            {
                escritor.WriteLine($"{liquidacion.NumeroLiquidacion};{liquidacion.Identificacion};{liquidacion.Nombre};" +
                $"{liquidacion.Tipo};{liquidacion.Salario};{liquidacion.Servicio};{liquidacion.CuotaModeradora};{liquidacion.CuotaReal};" +
                $"{liquidacion.MostrarTarifa};{liquidacion.TopeMaximo};{liquidacion.Fecha}");
            }
            escritor.Close();
            file.Close();
            
        }

        public void Actualizar(LiquidacionCuotaModeradora liquidacion)
        {
            liquidacions.Clear();
            liquidacions = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in liquidacions)
            {
                if(item.NumeroLiquidacion != liquidacion.NumeroLiquidacion)
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(liquidacion);
                }
            }
        }

        public IList<LiquidacionCuotaModeradora> BuscarRegimenContributivo()
        {
            liquidacions.Clear();
            liquidacions = Consultar();
            return liquidacions.Where(l => l.Tipo == "Contributivo").ToList();
        }

        public IList<LiquidacionCuotaModeradora> BuscarRegimenSubsidado()
        {
            liquidacions.Clear();
            liquidacions = Consultar();
            return liquidacions.Where(l => l.Tipo == "Subsidiado").ToList();
        }

        public int TotalizarRegimenContributivo()
        {

            return liquidacions.Count(l => l.Tipo == "Contributivo");

        }

        public int TotalizarRegimenSubsidiado()
        {
            return liquidacions.Count(l => l.Tipo == "Subsidiado");
        }





        public IList<LiquidacionCuotaModeradora> ListaRegimen()
        {
            liquidacions.Clear();
            return liquidacions.Where(l => (l.Tipo == "Contributivo") || (l.Tipo == "Subsidiado")).ToList();
        }

        public int TotalizarRegimen()
        {
            liquidacions.Clear();
            return liquidacions.Count(l => (l.Tipo == "Contributivo")||(l.Tipo=="Subsidiado"));
        }


        public double SumarSalario()
        {
            return liquidacions.Sum(l => l.CuotaModeradora);
        }

        public double SumarRegimen(string tipo)
        {

            if (tipo == "Contributivo")
            {
                return liquidacions.Where(l=>l.Tipo=="Contributivo").Sum(l=>l.CuotaModeradora);
            }else if (tipo == "Subsidiado")
            {
                return liquidacions.Where(l=>l.Tipo=="Subsidiado").Sum(l => l.CuotaModeradora);
            }
            return 0;

           
        }

        public IList<LiquidacionCuotaModeradora> FiltrarFecha(string fecha)
        {
            liquidacions.Clear();
            liquidacions = Consultar();
           return liquidacions.Where(l=>l.Fecha == fecha).ToList();
        }
       
        public IList<LiquidacionCuotaModeradora> FiltrarNombre(string nombre)
        {
            liquidacions.Clear();
            liquidacions = Consultar();
            return liquidacions.Where (l => l.Nombre.Contains(nombre)).ToList();
        }

    }
}
