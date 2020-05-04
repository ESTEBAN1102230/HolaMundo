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
    public partial class VentanaConsultar : Form
    {

        ClienteService ClienteService = new ClienteService();
        private DataTable DataTable;
        public VentanaConsultar()
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

        private void BuscarBtn_Click(object sender, EventArgs e)
        {

           
            Consultar();


        }


        public void Consultar()
        {
            int Control = 0;
           
            foreach (LiquidacionCuotaModeradora liquidacion in ClienteService.Consultar())
            {
                if(liquidacion.NumeroLiquidacion == ConsultaLiquidacionTxt.Text)
                {
                    
                    IngresarDatos(liquidacion);
                    Control = 1;
                }
            }

            if(Control==0)
            {
                MessageBox.Show("No se encontro registro con el numero de liquidacion", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

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

        private void ConsultaDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultaLiquidacionTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarNumero(e);
        }
    }
}
