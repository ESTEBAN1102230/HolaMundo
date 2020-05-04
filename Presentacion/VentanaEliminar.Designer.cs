namespace Presentacion
{
    partial class VentanaEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaEliminar));
            this.NumeroLiquidacionBt = new System.Windows.Forms.Label();
            this.NumeroLiquidacionText = new System.Windows.Forms.TextBox();
            this.EliminarBt = new System.Windows.Forms.Button();
            this.ConsultaLiquidacion = new System.Windows.Forms.Button();
            this.ConsultaTotal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NumeroLiquidacionBt
            // 
            this.NumeroLiquidacionBt.AutoSize = true;
            this.NumeroLiquidacionBt.Location = new System.Drawing.Point(71, 112);
            this.NumeroLiquidacionBt.Name = "NumeroLiquidacionBt";
            this.NumeroLiquidacionBt.Size = new System.Drawing.Size(101, 13);
            this.NumeroLiquidacionBt.TabIndex = 0;
            this.NumeroLiquidacionBt.Text = "Numero Liquidacion";
            // 
            // NumeroLiquidacionText
            // 
            this.NumeroLiquidacionText.Location = new System.Drawing.Point(193, 105);
            this.NumeroLiquidacionText.Name = "NumeroLiquidacionText";
            this.NumeroLiquidacionText.Size = new System.Drawing.Size(145, 20);
            this.NumeroLiquidacionText.TabIndex = 1;
            // 
            // EliminarBt
            // 
            this.EliminarBt.Location = new System.Drawing.Point(374, 102);
            this.EliminarBt.Name = "EliminarBt";
            this.EliminarBt.Size = new System.Drawing.Size(101, 23);
            this.EliminarBt.TabIndex = 2;
            this.EliminarBt.Text = "Eliminar";
            this.EliminarBt.UseVisualStyleBackColor = true;
            this.EliminarBt.Click += new System.EventHandler(this.EliminarBt_Click);
            // 
            // ConsultaLiquidacion
            // 
            this.ConsultaLiquidacion.Location = new System.Drawing.Point(74, 189);
            this.ConsultaLiquidacion.Name = "ConsultaLiquidacion";
            this.ConsultaLiquidacion.Size = new System.Drawing.Size(115, 23);
            this.ConsultaLiquidacion.TabIndex = 3;
            this.ConsultaLiquidacion.Text = "Consulta liquidacion";
            this.ConsultaLiquidacion.UseVisualStyleBackColor = true;
            this.ConsultaLiquidacion.Click += new System.EventHandler(this.ConsultaLiquidacion_Click);
            // 
            // ConsultaTotal
            // 
            this.ConsultaTotal.Location = new System.Drawing.Point(212, 189);
            this.ConsultaTotal.Name = "ConsultaTotal";
            this.ConsultaTotal.Size = new System.Drawing.Size(115, 23);
            this.ConsultaTotal.TabIndex = 4;
            this.ConsultaTotal.Text = "Consulta total";
            this.ConsultaTotal.UseVisualStyleBackColor = true;
            this.ConsultaTotal.Click += new System.EventHandler(this.ConsultaTotal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(534, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ConsultaTotal);
            this.Controls.Add(this.ConsultaLiquidacion);
            this.Controls.Add(this.EliminarBt);
            this.Controls.Add(this.NumeroLiquidacionText);
            this.Controls.Add(this.NumeroLiquidacionBt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaEliminar";
            this.Text = "Eliminar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumeroLiquidacionBt;
        private System.Windows.Forms.TextBox NumeroLiquidacionText;
        private System.Windows.Forms.Button EliminarBt;
        private System.Windows.Forms.Button ConsultaLiquidacion;
        private System.Windows.Forms.Button ConsultaTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}