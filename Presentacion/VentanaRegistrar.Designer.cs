namespace Presentacion
{
    partial class VentanaRegistrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaRegistrar));
            this.label1 = new System.Windows.Forms.Label();
            this.IdentificacionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.NumeroLiquidacionTxt = new System.Windows.Forms.TextBox();
            this.SalarioTxt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TipoAfiliacionCmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ValorServicioTxt = new System.Windows.Forms.TextBox();
            this.FechaLb = new System.Windows.Forms.Label();
            this.DiaCmb = new System.Windows.Forms.ComboBox();
            this.MesCmb = new System.Windows.Forms.ComboBox();
            this.AñoCmb = new System.Windows.Forms.ComboBox();
            this.EpIdentificacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EpIdentificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IdentificacionTxt
            // 
            this.IdentificacionTxt.Location = new System.Drawing.Point(118, 61);
            this.IdentificacionTxt.Name = "IdentificacionTxt";
            this.IdentificacionTxt.Size = new System.Drawing.Size(123, 20);
            this.IdentificacionTxt.TabIndex = 1;
            this.IdentificacionTxt.TextChanged += new System.EventHandler(this.IdentificacionTxt_TextChanged);
            this.IdentificacionTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdentificacionTxt_KeyPress);
            this.IdentificacionTxt.Validating += new System.ComponentModel.CancelEventHandler(this.IdentificacionTxt_Validating);
            this.IdentificacionTxt.Validated += new System.EventHandler(this.IdentificacionTxt_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero liquidacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salario";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(118, 97);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(123, 20);
            this.NombreTxt.TabIndex = 5;
            this.NombreTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreTxt_KeyPress);
            // 
            // NumeroLiquidacionTxt
            // 
            this.NumeroLiquidacionTxt.Location = new System.Drawing.Point(118, 133);
            this.NumeroLiquidacionTxt.Name = "NumeroLiquidacionTxt";
            this.NumeroLiquidacionTxt.Size = new System.Drawing.Size(123, 20);
            this.NumeroLiquidacionTxt.TabIndex = 6;
            this.NumeroLiquidacionTxt.TextChanged += new System.EventHandler(this.NumeroLiquidacionTxt_TextChanged);
            this.NumeroLiquidacionTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeroLiquidacionTxt_KeyPress);
            // 
            // SalarioTxt
            // 
            this.SalarioTxt.Location = new System.Drawing.Point(118, 169);
            this.SalarioTxt.Name = "SalarioTxt";
            this.SalarioTxt.Size = new System.Drawing.Size(123, 20);
            this.SalarioTxt.TabIndex = 7;
            this.SalarioTxt.TextChanged += new System.EventHandler(this.SalarioTxt_TextChanged);
            this.SalarioTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalarioTxt_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TipoAfiliacionCmb
            // 
            this.TipoAfiliacionCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoAfiliacionCmb.FormattingEnabled = true;
            this.TipoAfiliacionCmb.Items.AddRange(new object[] {
            "",
            "Contributivo",
            "Subsidiado"});
            this.TipoAfiliacionCmb.Location = new System.Drawing.Point(118, 241);
            this.TipoAfiliacionCmb.Name = "TipoAfiliacionCmb";
            this.TipoAfiliacionCmb.Size = new System.Drawing.Size(121, 21);
            this.TipoAfiliacionCmb.TabIndex = 9;
            this.TipoAfiliacionCmb.SelectedIndexChanged += new System.EventHandler(this.TipoAfiliacionCmb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo afiliacion";
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(118, 327);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(113, 25);
            this.GuardarBtn.TabIndex = 11;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor servicio";
            // 
            // ValorServicioTxt
            // 
            this.ValorServicioTxt.Location = new System.Drawing.Point(118, 205);
            this.ValorServicioTxt.Name = "ValorServicioTxt";
            this.ValorServicioTxt.Size = new System.Drawing.Size(123, 20);
            this.ValorServicioTxt.TabIndex = 13;
            this.ValorServicioTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorServicioTxt_KeyPress);
            // 
            // FechaLb
            // 
            this.FechaLb.AutoSize = true;
            this.FechaLb.Location = new System.Drawing.Point(60, 285);
            this.FechaLb.Name = "FechaLb";
            this.FechaLb.Size = new System.Drawing.Size(37, 13);
            this.FechaLb.TabIndex = 14;
            this.FechaLb.Text = "Fecha";
            // 
            // DiaCmb
            // 
            this.DiaCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiaCmb.FormattingEnabled = true;
            this.DiaCmb.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DiaCmb.Location = new System.Drawing.Point(118, 276);
            this.DiaCmb.Name = "DiaCmb";
            this.DiaCmb.Size = new System.Drawing.Size(35, 21);
            this.DiaCmb.TabIndex = 15;
            this.DiaCmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MesCmb
            // 
            this.MesCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MesCmb.FormattingEnabled = true;
            this.MesCmb.Items.AddRange(new object[] {
            "",
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.MesCmb.Location = new System.Drawing.Point(160, 276);
            this.MesCmb.Name = "MesCmb";
            this.MesCmb.Size = new System.Drawing.Size(61, 21);
            this.MesCmb.TabIndex = 16;
            // 
            // AñoCmb
            // 
            this.AñoCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AñoCmb.FormattingEnabled = true;
            this.AñoCmb.Items.AddRange(new object[] {
            "",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.AñoCmb.Location = new System.Drawing.Point(227, 276);
            this.AñoCmb.Name = "AñoCmb";
            this.AñoCmb.Size = new System.Drawing.Size(56, 21);
            this.AñoCmb.TabIndex = 17;
            // 
            // EpIdentificacion
            // 
            this.EpIdentificacion.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AñoCmb);
            this.Controls.Add(this.MesCmb);
            this.Controls.Add(this.DiaCmb);
            this.Controls.Add(this.FechaLb);
            this.Controls.Add(this.ValorServicioTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TipoAfiliacionCmb);
            this.Controls.Add(this.SalarioTxt);
            this.Controls.Add(this.NumeroLiquidacionTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdentificacionTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaRegistrar";
            this.Text = "Registrar";
            ((System.ComponentModel.ISupportInitialize)(this.EpIdentificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdentificacionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox NumeroLiquidacionTxt;
        private System.Windows.Forms.TextBox SalarioTxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox TipoAfiliacionCmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ValorServicioTxt;
        private System.Windows.Forms.Label FechaLb;
        private System.Windows.Forms.ComboBox DiaCmb;
        private System.Windows.Forms.ComboBox MesCmb;
        private System.Windows.Forms.ComboBox AñoCmb;
        private System.Windows.Forms.ErrorProvider EpIdentificacion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}