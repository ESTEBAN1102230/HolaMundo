using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void liquidacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        private void RegistrarBt_Click(object sender, EventArgs e)
        {
            VentanaRegistrar ventanaRegistrar = new VentanaRegistrar();
            ventanaRegistrar.Show();
        }

        private void ConsultaBt_Click(object sender, EventArgs e)
        {
            VentanaConsultar ventanaConsultar = new VentanaConsultar();
            ventanaConsultar.Show();
        }

        private void ModificarBt_Click(object sender, EventArgs e)
        {
            Modificar modificar = new Modificar();
            modificar.Show();
        }

        private void EliminarBt_Click(object sender, EventArgs e)
        {
            VentanaEliminar ventanaEliminar = new VentanaEliminar();
            ventanaEliminar.Show();
        }

        

        private void ConsultarBt_Click(object sender, EventArgs e)
        {
            ConsultaTotalDgv consultaTotal = new ConsultaTotalDgv();
            consultaTotal.Show();
        }
    }
}
