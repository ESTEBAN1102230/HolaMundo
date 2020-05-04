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
    public partial class VentanaRegistrar : Form
    {

        ClienteService ClienteService;
        LiquidacionCuotaModeradora liquidacion;
        public VentanaRegistrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (ValidarNumeroLiquidacion()==0)
                {

                    Registrar();
                }
                else
                {
                    MessageBox.Show("Numero de liquidacion ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            

        }


        public void Registrar()
        {

            string Dia, Mes, Año;
            ClienteService = new ClienteService();
            ValidarRegimen();
            liquidacion.Identificacion = IdentificacionTxt.Text;
            liquidacion.Nombre = NombreTxt.Text;
            liquidacion.NumeroLiquidacion = NumeroLiquidacionTxt.Text;
            liquidacion.Salario = Double.Parse(SalarioTxt.Text);
            liquidacion.Servicio = Double.Parse(ValorServicioTxt.Text);
            liquidacion.Tipo = TipoAfiliacionCmb.Text;
            Dia = DiaCmb.Text; Mes = MesCmb.Text; Año = AñoCmb.Text;
            liquidacion.Fecha = $"{Dia}/{Mes}/{Año}";
            liquidacion.CalcularCuota();
            MessageBox.Show(ClienteService.Guardar(liquidacion), "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarCampos();
            
        }


        public void limpiarCampos()
        {
            IdentificacionTxt.Text = "";
            NombreTxt.Text = "";
            NumeroLiquidacionTxt.Text = "";
            SalarioTxt.Text = "";
            ValorServicioTxt.Text = "";
            TipoAfiliacionCmb.Text = "";
            DiaCmb.Text = ""; MesCmb.Text = ""; AñoCmb.Text = "";
        }


        public void ValidarRegimen()
        {
            if(TipoAfiliacionCmb.Text == "Contributivo")
            {
                liquidacion = new Contributivo();
            }
            else
            {
                liquidacion = new Subsidiado();
            }
        }


        public int ValidarNumeroLiquidacion()
        {
            ClienteService = new ClienteService();
            int validar = 0;
            foreach (LiquidacionCuotaModeradora  liquidacion in ClienteService.Consultar())
            {
                if(NumeroLiquidacionTxt.Text == liquidacion.NumeroLiquidacion)
                {
                    validar = 1;
                }
            }

            return validar;

        }

        private bool ValidarCampos()
        {
            int validar = 0;

            if(IdentificacionTxt.Text == "")
            {
                validar = 1;
                EpIdentificacion.SetError(IdentificacionTxt, "Ingrese numero liquidacion");
                IdentificacionTxt.Focus();
            }
            else
            {
                EpIdentificacion.Clear();
            }

            if (NombreTxt.Text == "")
            {
                validar = 1;
                EpIdentificacion.SetError(NombreTxt, "Ingresar nombre");
                NombreTxt.Focus();
            }
            else
            {
                EpIdentificacion.Clear();
            }
            if (NumeroLiquidacionTxt.Text == "")
            {
                validar = 1;
                EpIdentificacion.SetError( NumeroLiquidacionTxt, "Ingresar numero liquidacion");
                NumeroLiquidacionTxt.Focus();
            }
            else
            {
                EpIdentificacion.Clear();
            }
            if (SalarioTxt.Text == "")
            {
                validar = 1;
                EpIdentificacion.SetError(SalarioTxt, "Ingresar identificacion");
                SalarioTxt.Focus();
            }
            else
            {
                EpIdentificacion.Clear();
            }
            if (ValorServicioTxt.Text == "")
            {
                validar = 1;
                EpIdentificacion.SetError(ValorServicioTxt, "Ingresar valor servicio");
                ValorServicioTxt.Focus();
            }
            else
            {
                EpIdentificacion.Clear();
            }
            if (TipoAfiliacionCmb.Text == "")
            {
                validar = 1;
                EpIdentificacion.SetError(TipoAfiliacionCmb, "Ingresar tipo afiliacion");
                TipoAfiliacionCmb.Focus();
            }
            else
            {
                EpIdentificacion.Clear();
            }
            if ((DiaCmb.Text == "")||(MesCmb.Text =="")||(AñoCmb.Text == ""))
            {
                validar = 1;
                EpIdentificacion.SetError(AñoCmb, "Error de fecha");
                DiaCmb.Focus();
                MesCmb.Focus();
                AñoCmb.Focus();
            }
            else
            {
                EpIdentificacion.Clear();
            }
            

            if (validar == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        private void IdentificacionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalarioTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TipoAfiliacionCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IdentificacionTxt_Validated(object sender, EventArgs e)
        {

        }

        private void IdentificacionTxt_Validating(object sender, CancelEventArgs e)
        {

        }

        private void IdentificacionTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarNumero(e);
        }

        private void NombreTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetra(e);
        }

        private void NumeroLiquidacionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumeroLiquidacionTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarNumero(e);
        }

        private void SalarioTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarNumero(e);
        }

        private void ValorServicioTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarNumero(e);
        }
    }
}
