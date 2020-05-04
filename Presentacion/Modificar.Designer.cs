namespace Presentacion
{
    partial class Modificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar));
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroLiquidacionText = new System.Windows.Forms.TextBox();
            this.BuscarBt = new System.Windows.Forms.Button();
            this.ValorservicioLb = new System.Windows.Forms.Label();
            this.ModificarBt = new System.Windows.Forms.Button();
            this.ModificarText = new System.Windows.Forms.TextBox();
            this.ConsultaDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero liquidacion";
            // 
            // NumeroLiquidacionText
            // 
            this.NumeroLiquidacionText.Location = new System.Drawing.Point(155, 104);
            this.NumeroLiquidacionText.Name = "NumeroLiquidacionText";
            this.NumeroLiquidacionText.Size = new System.Drawing.Size(146, 20);
            this.NumeroLiquidacionText.TabIndex = 1;
            this.NumeroLiquidacionText.TextChanged += new System.EventHandler(this.NumeroLiquidacionText_TextChanged);
            this.NumeroLiquidacionText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeroLiquidacionText_KeyPress);
            // 
            // BuscarBt
            // 
            this.BuscarBt.Location = new System.Drawing.Point(327, 102);
            this.BuscarBt.Name = "BuscarBt";
            this.BuscarBt.Size = new System.Drawing.Size(107, 23);
            this.BuscarBt.TabIndex = 2;
            this.BuscarBt.Text = "Buscar";
            this.BuscarBt.UseVisualStyleBackColor = true;
            this.BuscarBt.Click += new System.EventHandler(this.BuscarBt_Click);
            // 
            // ValorservicioLb
            // 
            this.ValorservicioLb.AutoSize = true;
            this.ValorservicioLb.Location = new System.Drawing.Point(46, 158);
            this.ValorservicioLb.Name = "ValorservicioLb";
            this.ValorservicioLb.Size = new System.Drawing.Size(70, 13);
            this.ValorservicioLb.TabIndex = 3;
            this.ValorservicioLb.Text = "Valor servicio";
            // 
            // ModificarBt
            // 
            this.ModificarBt.Location = new System.Drawing.Point(327, 153);
            this.ModificarBt.Name = "ModificarBt";
            this.ModificarBt.Size = new System.Drawing.Size(107, 23);
            this.ModificarBt.TabIndex = 4;
            this.ModificarBt.Text = "Modificar";
            this.ModificarBt.UseVisualStyleBackColor = true;
            this.ModificarBt.Click += new System.EventHandler(this.ModificarBt_Click);
            // 
            // ModificarText
            // 
            this.ModificarText.Location = new System.Drawing.Point(155, 153);
            this.ModificarText.Name = "ModificarText";
            this.ModificarText.Size = new System.Drawing.Size(146, 20);
            this.ModificarText.TabIndex = 5;
            this.ModificarText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModificarText_KeyPress);
            // 
            // ConsultaDgv
            // 
            this.ConsultaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDgv.Location = new System.Drawing.Point(16, 199);
            this.ConsultaDgv.Name = "ConsultaDgv";
            this.ConsultaDgv.Size = new System.Drawing.Size(1139, 150);
            this.ConsultaDgv.TabIndex = 6;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 450);
            this.Controls.Add(this.ConsultaDgv);
            this.Controls.Add(this.ModificarText);
            this.Controls.Add(this.ModificarBt);
            this.Controls.Add(this.ValorservicioLb);
            this.Controls.Add(this.BuscarBt);
            this.Controls.Add(this.NumeroLiquidacionText);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Modificar";
            this.Text = "Modificar";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeroLiquidacionText;
        private System.Windows.Forms.Button BuscarBt;
        private System.Windows.Forms.Label ValorservicioLb;
        private System.Windows.Forms.Button ModificarBt;
        private System.Windows.Forms.TextBox ModificarText;
        private System.Windows.Forms.DataGridView ConsultaDgv;
    }
}