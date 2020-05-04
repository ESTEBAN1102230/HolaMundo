namespace Presentacion
{
    partial class ConsultaTotalDgv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaTotalDgv));
            this.ConsultaTotalBt = new System.Windows.Forms.Button();
            this.ConsultaDgv = new System.Windows.Forms.DataGridView();
            this.ConsultaFiltradaBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NumeroLiquidacionBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaTotalBt
            // 
            this.ConsultaTotalBt.Location = new System.Drawing.Point(12, 311);
            this.ConsultaTotalBt.Name = "ConsultaTotalBt";
            this.ConsultaTotalBt.Size = new System.Drawing.Size(131, 23);
            this.ConsultaTotalBt.TabIndex = 1;
            this.ConsultaTotalBt.Text = "Consultar";
            this.ConsultaTotalBt.UseVisualStyleBackColor = true;
            this.ConsultaTotalBt.Click += new System.EventHandler(this.ConsultaTotalBt_Click);
            // 
            // ConsultaDgv
            // 
            this.ConsultaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDgv.Location = new System.Drawing.Point(12, 132);
            this.ConsultaDgv.Name = "ConsultaDgv";
            this.ConsultaDgv.Size = new System.Drawing.Size(1106, 150);
            this.ConsultaDgv.TabIndex = 5;
            this.ConsultaDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConsultaDgv_CellContentClick);
            this.ConsultaDgv.Validating += new System.ComponentModel.CancelEventHandler(this.ConsultaDgv_Validating);
            // 
            // ConsultaFiltradaBt
            // 
            this.ConsultaFiltradaBt.Location = new System.Drawing.Point(348, 311);
            this.ConsultaFiltradaBt.Name = "ConsultaFiltradaBt";
            this.ConsultaFiltradaBt.Size = new System.Drawing.Size(131, 23);
            this.ConsultaFiltradaBt.TabIndex = 6;
            this.ConsultaFiltradaBt.Text = "Otras consultas";
            this.ConsultaFiltradaBt.UseVisualStyleBackColor = true;
            this.ConsultaFiltradaBt.Click += new System.EventHandler(this.ConsultaFiltradaBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(618, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // NumeroLiquidacionBt
            // 
            this.NumeroLiquidacionBt.Location = new System.Drawing.Point(176, 311);
            this.NumeroLiquidacionBt.Name = "NumeroLiquidacionBt";
            this.NumeroLiquidacionBt.Size = new System.Drawing.Size(131, 23);
            this.NumeroLiquidacionBt.TabIndex = 8;
            this.NumeroLiquidacionBt.Text = "Numero liquidacion";
            this.NumeroLiquidacionBt.UseVisualStyleBackColor = true;
            this.NumeroLiquidacionBt.Click += new System.EventHandler(this.NumeroLiquidacionBt_Click);
            // 
            // ConsultaTotalDgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.NumeroLiquidacionBt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ConsultaFiltradaBt);
            this.Controls.Add(this.ConsultaDgv);
            this.Controls.Add(this.ConsultaTotalBt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaTotalDgv";
            this.Text = "Consulta Total";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ConsultaTotalBt;
        private System.Windows.Forms.DataGridView ConsultaDgv;
        private System.Windows.Forms.Button ConsultaFiltradaBt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NumeroLiquidacionBt;
    }
}