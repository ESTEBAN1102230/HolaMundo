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
    public partial class VentanaFiltrar : Form
    {

        ClienteService ClienteService = new ClienteService();
        public VentanaFiltrar()
        {
            InitializeComponent();
            Iniciar();

        }

        private void FiltrarCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (FiltrarCmb.Text == "Contributivo")
            {
                Contributivo();
            }
            if (FiltrarCmb.Text == "Subsidiado")
            {
                Subsidiado();
            }
            if (FiltrarCmb.Text == "Valor cuotas")
            {
                ValorCuotas();
            }
            if (FiltrarCmb.Text == "Fecha")
            {
                Fecha();
            }
            if(FiltrarCmb.Text == "Nombre")
            {
                Nombre();
            }

        }


        public void LimpiarCampos()
        {
            DiaCmb.Text = ""; MesCmb.Text = ""; AñoCmb.Text = "";
        }


        public void Contributivo()
        {
            ConsultaDgv.DataSource = null;
            ContributivoLb.Visible = true; ContributivoText.Visible = true;
            TodosLb.Visible = false; TodosText.Visible = false;
            SubsidiadoLb.Visible = false; SubsidiadoText.Visible = false;
            DiaCmb.Visible = false; DiaLb.Visible = false; MesCmb.Visible = false; Meslb.Visible = false;
            AñoCmb.Visible = false; AñoLb.Visible = false; ConsultaBt.Visible = false;
            BuscarLb.Visible = false; BuscarText.Visible = false;
            ConsultaDgv.DataSource = ClienteService.BuscarRegimenContributivo();
            ContributivoText.Text = ClienteService.TotalizarRegimenContributivo().ToString();
        }

        public void Subsidiado()
        {
            ConsultaDgv.DataSource = null;
            SubsidiadoLb.Visible = true; SubsidiadoText.Visible = true;
            TodosLb.Visible = false; TodosText.Visible = false;
            ContributivoLb.Visible = false; ContributivoText.Visible = false;
            DiaCmb.Visible = false; DiaLb.Visible = false; MesCmb.Visible = false; Meslb.Visible = false;
            AñoCmb.Visible = false; AñoLb.Visible = false; ConsultaBt.Visible = false;
            BuscarLb.Visible = false;  BuscarText.Visible = false;
            ConsultaDgv.DataSource = ClienteService.BuscarRegimenSubsidado();
            SubsidiadoText.Text = ClienteService.TotalizarRegimenSubsidiado().ToString();

        }

        public void ValorCuotas()
        {
            ConsultaDgv.DataSource = null;
            string Contributivo = "Contributivo";
            string Subsidiado = "Subsidiado";
            TodosLb.Visible = true; TodosText.Visible = true;
            ContributivoLb.Visible = true; ContributivoText.Visible = true;
            SubsidiadoLb.Visible = true; SubsidiadoText.Visible = true;
            DiaCmb.Visible = false; DiaLb.Visible = false; MesCmb.Visible = false; Meslb.Visible = false;
            AñoCmb.Visible = false; AñoLb.Visible = false; ConsultaBt.Visible = false;
            BuscarLb.Visible = false; BuscarText.Visible = false;
            ConsultaDgv.DataSource = ClienteService.Consultar();
            TodosText.Text = ClienteService.SumarSalario().ToString();
            ContributivoText.Text = ClienteService.SumarRegimen(Contributivo).ToString();
            SubsidiadoText.Text = ClienteService.SumarRegimen(Subsidiado).ToString();

        }

        public void Fecha()
        {
            ContributivoLb.Visible = false; ContributivoText.Visible = false;
            TodosLb.Visible = false; TodosText.Visible = false;
            SubsidiadoLb.Visible = false; SubsidiadoText.Visible = false;
            DiaCmb.Visible = true; DiaLb.Visible = true; MesCmb.Visible = true; Meslb.Visible = true;
            AñoCmb.Visible = true; AñoLb.Visible = true; ConsultaBt.Visible = true;
            BuscarLb.Visible = false; BuscarText.Visible = false;
            ConsultaDgv.DataSource = null;
            string fecha = $"{DiaCmb.Text}/{MesCmb.Text}/{AñoCmb.Text}";
            ConsultaDgv.DataSource = ClienteService.FiltrarFecha(fecha);
        }

        private void ConsultaBt_Click(object sender, EventArgs e)
        {
            ConsultaDgv.DataSource = null;
            string fecha = $"{DiaCmb.Text}/{MesCmb.Text}/{AñoCmb.Text}";
            ConsultaDgv.DataSource = ClienteService.FiltrarFecha(fecha);
        }


        public void Nombre()
        {
            ConsultaDgv.DataSource = null;
            BuscarLb.Visible = true; BuscarText.Visible = true;
            ContributivoLb.Visible = false; ContributivoText.Visible = false;
            TodosLb.Visible = false; TodosText.Visible = false;
            SubsidiadoLb.Visible = false; SubsidiadoText.Visible = false;
            DiaCmb.Visible = false; DiaLb.Visible = false; MesCmb.Visible = false; Meslb.Visible = false;
            AñoCmb.Visible = false; AñoLb.Visible = false; ConsultaBt.Visible = false;

        }

        private void BuscarText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetra(e);
            ConsultaDgv.DataSource = null;
            string palabra = BuscarText.Text;
            ConsultaDgv.DataSource = ClienteService.FiltrarNombre(palabra);
        }


        public void Iniciar()
        {
            BuscarLb.Visible = false; BuscarText.Visible = false;
            ContributivoLb.Visible = false; ContributivoText.Visible = false;
            TodosLb.Visible = false; TodosText.Visible = false;
            SubsidiadoLb.Visible = false; SubsidiadoText.Visible = false;
            DiaCmb.Visible = false; DiaLb.Visible = false; MesCmb.Visible = false; Meslb.Visible = false;
            AñoCmb.Visible = false; AñoLb.Visible = false; ConsultaBt.Visible = false;

        }

        private void BuscarText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
