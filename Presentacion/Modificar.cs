using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Presentacion
{
    public partial class Modificar : Form
    {

        ClienteService ClienteService = new ClienteService();
        string NuevoNumeroLiquidacion;
        DataTable DataTable;
        public Modificar()
        {
            InitializeComponent();
            DataTable = new DataTable();
            DataTable.Columns.Add("Numero liquidacion").ReadOnly = true;
            DataTable.Columns.Add("Identificacion").ReadOnly = true;
            DataTable.Columns.Add("Nombre").ReadOnly = true;
            DataTable.Columns.Add("Tipo").ReadOnly = true;
            DataTable.Columns.Add("Salario").ReadOnly = true;
            DataTable.Columns.Add("Servicio").ReadOnly = true;
            DataTable.Columns.Add("Cuota moderadora").ReadOnly = true;
            DataTable.Columns.Add("Cuota real").ReadOnly = true;
            DataTable.Columns.Add("Mostrar tarifa").ReadOnly = true;
            DataTable.Columns.Add("Tope maximo").ReadOnly = true;
            DataTable.Columns.Add("Fecha").ReadOnly = true;
            ConsultaDgv.DataSource = DataTable;
        }

        private void BuscarBt_Click(object sender, EventArgs e)
        {
            
            Buscar();
            NumeroLiquidacionText.Text = "";

        }

        public void Buscar()
        {

            foreach (LiquidacionCuotaModeradora liquidacion in ClienteService.Consultar())
            {
                if(liquidacion.NumeroLiquidacion == NumeroLiquidacionText.Text)
                {
                    
                    IngresarDatos(liquidacion);
                    NuevoNumeroLiquidacion = liquidacion.NumeroLiquidacion;

                }
            }
        }

        public void modificar()
        {
            IList<LiquidacionCuotaModeradora> liquidacions= new List<LiquidacionCuotaModeradora>();
            liquidacions = ClienteService.Consultar();

            foreach  ( LiquidacionCuotaModeradora liquidacion in liquidacions.ToList())
            {

                if(liquidacion.NumeroLiquidacion == NuevoNumeroLiquidacion)
                {
                    DataTable.Clear();
                    liquidacion.Servicio = Convert.ToDouble(ModificarText.Text);
                    liquidacion.CalcularCuota();
                    ClienteService.Actualizar(liquidacion);
                    IngresarDatos(liquidacion);
                }
               
            }


        }


        public void IngresarDatos(LiquidacionCuotaModeradora liquidacion)
        {
            DataRow dataRow = DataTable.NewRow();
            dataRow["Numero liquidacion"] = liquidacion.NumeroLiquidacion;
            dataRow["Identificacion"] = liquidacion.Identificacion;
            dataRow["Nombre"] = liquidacion.Nombre;
            dataRow["Tipo"] = liquidacion.Tipo;
            dataRow["Salario"] = liquidacion.Salario;
            dataRow["Servicio"] = liquidacion.Servicio;
            dataRow["Cuota moderadora"] = liquidacion.CuotaModeradora;
            dataRow["Cuota real"] = liquidacion.CuotaReal;
            dataRow["Mostrar tarifa"] = liquidacion.MostrarTarifa;
            dataRow["Tope maximo"] = liquidacion.TopeMaximo;
            dataRow["Fecha"] = liquidacion.Fecha;

            DataTable.Rows.Add(dataRow);
        }

        private void ModificarBt_Click(object sender, EventArgs e)
        {

            if (ModificarText.Text == "")
            {
                ModificarText.Focus();
                
            }
            else
            {
                modificar();
                ModificarText.Text = "";
                MessageBox.Show("Se modifico correctamente", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void NumeroLiquidacionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumeroLiquidacionText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarNumero(e);
        }

        private void ModificarText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarNumero(e);
        }
    }

   
}
