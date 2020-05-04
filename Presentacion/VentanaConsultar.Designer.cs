namespace Presentacion
{
    partial class VentanaConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaConsultar));
            this.IntroducirNumLiquidacionLb = new System.Windows.Forms.Label();
            this.ConsultaLiquidacionTxt = new System.Windows.Forms.TextBox();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.ConsultaDgv = new System.Windows.Forms.DataGridView();
            this.liquidacionCuotaModeradoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subsidiadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteServiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionCuotaModeradoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subsidiadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteServiceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // IntroducirNumLiquidacionLb
            // 
            this.IntroducirNumLiquidacionLb.AutoSize = true;
            this.IntroducirNumLiquidacionLb.Location = new System.Drawing.Point(51, 61);
            this.IntroducirNumLiquidacionLb.Name = "IntroducirNumLiquidacionLb";
            this.IntroducirNumLiquidacionLb.Size = new System.Drawing.Size(97, 13);
            this.IntroducirNumLiquidacionLb.TabIndex = 1;
            this.IntroducirNumLiquidacionLb.Text = "Numero liquidacion";
            // 
            // ConsultaLiquidacionTxt
            // 
            this.ConsultaLiquidacionTxt.Location = new System.Drawing.Point(164, 58);
            this.ConsultaLiquidacionTxt.Name = "ConsultaLiquidacionTxt";
            this.ConsultaLiquidacionTxt.Size = new System.Drawing.Size(120, 20);
            this.ConsultaLiquidacionTxt.TabIndex = 2;
            this.ConsultaLiquidacionTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConsultaLiquidacionTxt_KeyPress);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(307, 58);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(111, 23);
            this.BuscarBtn.TabIndex = 3;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // ConsultaDgv
            // 
            this.ConsultaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDgv.Location = new System.Drawing.Point(31, 144);
            this.ConsultaDgv.Name = "ConsultaDgv";
            this.ConsultaDgv.Size = new System.Drawing.Size(1160, 150);
            this.ConsultaDgv.TabIndex = 4;
            // 
            // liquidacionCuotaModeradoraBindingSource
            // 
            this.liquidacionCuotaModeradoraBindingSource.DataSource = typeof(Entity.LiquidacionCuotaModeradora);
            // 
            // subsidiadoBindingSource
            // 
            this.subsidiadoBindingSource.DataSource = typeof(Entity.Subsidiado);
            // 
            // clienteServiceBindingSource
            // 
            this.clienteServiceBindingSource.DataSource = typeof(BLL.ClienteService);
            // 
            // clienteServiceBindingSource1
            // 
            this.clienteServiceBindingSource1.DataSource = typeof(BLL.ClienteService);
            // 
            // VentanaConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 450);
            this.Controls.Add(this.ConsultaDgv);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.ConsultaLiquidacionTxt);
            this.Controls.Add(this.IntroducirNumLiquidacionLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaConsultar";
            this.Text = "Consultar";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionCuotaModeradoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subsidiadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteServiceBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource subsidiadoBindingSource;
        private System.Windows.Forms.Label IntroducirNumLiquidacionLb;
        private System.Windows.Forms.TextBox ConsultaLiquidacionTxt;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.BindingSource clienteServiceBindingSource;
        private System.Windows.Forms.BindingSource clienteServiceBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicaTopeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource liquidacionCuotaModeradoraBindingSource;
        private System.Windows.Forms.DataGridView ConsultaDgv;
    }
}