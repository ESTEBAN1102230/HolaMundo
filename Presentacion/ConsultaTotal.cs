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
    public partial class ConsultaTotalDgv : Form
    {
        ClienteService ClienteService = new ClienteService();
        IList<LiquidacionCuotaModeradora> liquidacions = new List<LiquidacionCuotaModeradora>();
        private DataTable DataTable;

        public ConsultaTotalDgv()
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

        private void ConsultaTotalBt_Click(object sender, EventArgs e)
        {
            
            MostrarDatos();
            

        }

        public void MostrarDatos()
        {

            liquidacions.Clear();
            liquidacions = ClienteService.Consultar();

        foreach (var liquidacion in liquidacions)
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


        }

        private void ConsultaDgv_Validating(object sender, CancelEventArgs e)
        {

        }

        private void ConsultaFiltradaBt_Click(object sender, EventArgs e)
        {
            VentanaFiltrar ventanaFiltrar = new VentanaFiltrar();
            ventanaFiltrar.Show();
            SetVisibleCore(false);
        }

        private void NumeroLiquidacionBt_Click(object sender, EventArgs e)
        {
            VentanaConsultar ventanaConsultar = new VentanaConsultar();
            ventanaConsultar.Show();
        }

        private void ConsultaDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
