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
    public partial class VentanaEliminar : Form
    {

        ClienteService ClienteService = new ClienteService();
        List<LiquidacionCuotaModeradora> liquidacions = new List<LiquidacionCuotaModeradora>();

        public VentanaEliminar()
        {
            InitializeComponent();
            
        }

        private void EliminarBt_Click(object sender, EventArgs e)
        {

            Eliminar();

        }

        
        public void Eliminar()
        {
            int index = 0;
            int Control = 0;
            IList<LiquidacionCuotaModeradora> liquidacions = new List<LiquidacionCuotaModeradora>();
            liquidacions = ClienteService.Consultar();

            foreach (var liquidacion in liquidacions)
            {

                if(liquidacion.NumeroLiquidacion == NumeroLiquidacionText.Text)
                {
                    index = liquidacions.IndexOf(liquidacion);
                    Control = 1;
                }
            }

            if (Control == 0)
            {
                MessageBox.Show("No se encontro coincidencias", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NumeroLiquidacionText.Text = "";
            }
            else
            {
                liquidacions.RemoveAt(index);
                MessageBox.Show(ClienteService.Eliminar(liquidacions), "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NumeroLiquidacionText.Text = "";
            }
        }

        private void ConsultaLiquidacion_Click(object sender, EventArgs e)
        {
            VentanaConsultar ventanaConsultar = new VentanaConsultar();
            ventanaConsultar.Show();
        }

        private void ConsultaTotal_Click(object sender, EventArgs e)
        {
            ConsultaTotalDgv consultaTotal = new ConsultaTotalDgv();
            consultaTotal.Show();
            
        }


        
            
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }
    }
}
