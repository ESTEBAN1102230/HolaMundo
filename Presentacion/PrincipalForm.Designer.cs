namespace Presentacion
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RegistrarBt = new System.Windows.Forms.Button();
            this.ModificarBt = new System.Windows.Forms.Button();
            this.EliminarBt = new System.Windows.Forms.Button();
            this.ConsultarBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(379, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RegistrarBt
            // 
            this.RegistrarBt.Location = new System.Drawing.Point(70, 66);
            this.RegistrarBt.Name = "RegistrarBt";
            this.RegistrarBt.Size = new System.Drawing.Size(124, 23);
            this.RegistrarBt.TabIndex = 2;
            this.RegistrarBt.Text = "Registrar";
            this.RegistrarBt.UseVisualStyleBackColor = true;
            this.RegistrarBt.Click += new System.EventHandler(this.RegistrarBt_Click);
            // 
            // ModificarBt
            // 
            this.ModificarBt.Location = new System.Drawing.Point(70, 173);
            this.ModificarBt.Name = "ModificarBt";
            this.ModificarBt.Size = new System.Drawing.Size(124, 23);
            this.ModificarBt.TabIndex = 4;
            this.ModificarBt.Text = "Modificar";
            this.ModificarBt.UseVisualStyleBackColor = true;
            this.ModificarBt.Click += new System.EventHandler(this.ModificarBt_Click);
            // 
            // EliminarBt
            // 
            this.EliminarBt.Location = new System.Drawing.Point(70, 222);
            this.EliminarBt.Name = "EliminarBt";
            this.EliminarBt.Size = new System.Drawing.Size(124, 23);
            this.EliminarBt.TabIndex = 5;
            this.EliminarBt.Text = "Eliminar";
            this.EliminarBt.UseVisualStyleBackColor = true;
            this.EliminarBt.Click += new System.EventHandler(this.EliminarBt_Click);
            // 
            // ConsultarBt
            // 
            this.ConsultarBt.Location = new System.Drawing.Point(70, 121);
            this.ConsultarBt.Name = "ConsultarBt";
            this.ConsultarBt.Size = new System.Drawing.Size(124, 23);
            this.ConsultarBt.TabIndex = 6;
            this.ConsultarBt.Text = "Consultar";
            this.ConsultarBt.UseVisualStyleBackColor = true;
            this.ConsultarBt.Click += new System.EventHandler(this.ConsultarBt_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.ConsultarBt);
            this.Controls.Add(this.EliminarBt);
            this.Controls.Add(this.ModificarBt);
            this.Controls.Add(this.RegistrarBt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalForm";
            this.Text = "Liquidacion cuota moderadora";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RegistrarBt;
        private System.Windows.Forms.Button ModificarBt;
        private System.Windows.Forms.Button EliminarBt;
        private System.Windows.Forms.Button ConsultarBt;
    }
}

