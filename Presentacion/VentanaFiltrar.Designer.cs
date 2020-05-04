namespace Presentacion
{
    partial class VentanaFiltrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaFiltrar));
            this.ConsultaDgv = new System.Windows.Forms.DataGridView();
            this.FiltrarCmb = new System.Windows.Forms.ComboBox();
            this.FiltrarLb = new System.Windows.Forms.Label();
            this.TodosLb = new System.Windows.Forms.Label();
            this.TodosText = new System.Windows.Forms.TextBox();
            this.ContributivoLb = new System.Windows.Forms.Label();
            this.SubsidiadoLb = new System.Windows.Forms.Label();
            this.ContributivoText = new System.Windows.Forms.TextBox();
            this.SubsidiadoText = new System.Windows.Forms.TextBox();
            this.AñoCmb = new System.Windows.Forms.ComboBox();
            this.MesCmb = new System.Windows.Forms.ComboBox();
            this.DiaCmb = new System.Windows.Forms.ComboBox();
            this.AñoLb = new System.Windows.Forms.Label();
            this.Meslb = new System.Windows.Forms.Label();
            this.DiaLb = new System.Windows.Forms.Label();
            this.ConsultaBt = new System.Windows.Forms.Button();
            this.BuscarLb = new System.Windows.Forms.Label();
            this.BuscarText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaDgv
            // 
            this.ConsultaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDgv.Location = new System.Drawing.Point(12, 155);
            this.ConsultaDgv.Name = "ConsultaDgv";
            this.ConsultaDgv.Size = new System.Drawing.Size(1100, 150);
            this.ConsultaDgv.TabIndex = 6;
            // 
            // FiltrarCmb
            // 
            this.FiltrarCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrarCmb.FormattingEnabled = true;
            this.FiltrarCmb.Items.AddRange(new object[] {
            "Contributivo",
            "Subsidiado",
            "Valor cuotas",
            "Fecha",
            "Nombre"});
            this.FiltrarCmb.Location = new System.Drawing.Point(123, 38);
            this.FiltrarCmb.Name = "FiltrarCmb";
            this.FiltrarCmb.Size = new System.Drawing.Size(121, 21);
            this.FiltrarCmb.TabIndex = 7;
            this.FiltrarCmb.SelectedIndexChanged += new System.EventHandler(this.FiltrarCmb_SelectedIndexChanged);
            // 
            // FiltrarLb
            // 
            this.FiltrarLb.AutoSize = true;
            this.FiltrarLb.Location = new System.Drawing.Point(73, 41);
            this.FiltrarLb.Name = "FiltrarLb";
            this.FiltrarLb.Size = new System.Drawing.Size(32, 13);
            this.FiltrarLb.TabIndex = 8;
            this.FiltrarLb.Text = "Filtrar";
            // 
            // TodosLb
            // 
            this.TodosLb.AutoSize = true;
            this.TodosLb.Location = new System.Drawing.Point(33, 89);
            this.TodosLb.Name = "TodosLb";
            this.TodosLb.Size = new System.Drawing.Size(37, 13);
            this.TodosLb.TabIndex = 9;
            this.TodosLb.Text = "Todos";
            // 
            // TodosText
            // 
            this.TodosText.Location = new System.Drawing.Point(76, 89);
            this.TodosText.Name = "TodosText";
            this.TodosText.ReadOnly = true;
            this.TodosText.Size = new System.Drawing.Size(59, 20);
            this.TodosText.TabIndex = 10;
            // 
            // ContributivoLb
            // 
            this.ContributivoLb.AutoSize = true;
            this.ContributivoLb.Location = new System.Drawing.Point(142, 89);
            this.ContributivoLb.Name = "ContributivoLb";
            this.ContributivoLb.Size = new System.Drawing.Size(63, 13);
            this.ContributivoLb.TabIndex = 11;
            this.ContributivoLb.Text = "Contributivo";
            // 
            // SubsidiadoLb
            // 
            this.SubsidiadoLb.AutoSize = true;
            this.SubsidiadoLb.Location = new System.Drawing.Point(292, 89);
            this.SubsidiadoLb.Name = "SubsidiadoLb";
            this.SubsidiadoLb.Size = new System.Drawing.Size(59, 13);
            this.SubsidiadoLb.TabIndex = 12;
            this.SubsidiadoLb.Text = "Subsidiado";
            // 
            // ContributivoText
            // 
            this.ContributivoText.Location = new System.Drawing.Point(211, 87);
            this.ContributivoText.Name = "ContributivoText";
            this.ContributivoText.ReadOnly = true;
            this.ContributivoText.Size = new System.Drawing.Size(75, 20);
            this.ContributivoText.TabIndex = 13;
            // 
            // SubsidiadoText
            // 
            this.SubsidiadoText.Location = new System.Drawing.Point(357, 87);
            this.SubsidiadoText.Name = "SubsidiadoText";
            this.SubsidiadoText.ReadOnly = true;
            this.SubsidiadoText.Size = new System.Drawing.Size(72, 20);
            this.SubsidiadoText.TabIndex = 14;
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
            this.AñoCmb.Location = new System.Drawing.Point(777, 103);
            this.AñoCmb.Name = "AñoCmb";
            this.AñoCmb.Size = new System.Drawing.Size(56, 21);
            this.AñoCmb.TabIndex = 32;
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
            this.MesCmb.Location = new System.Drawing.Point(664, 103);
            this.MesCmb.Name = "MesCmb";
            this.MesCmb.Size = new System.Drawing.Size(61, 21);
            this.MesCmb.TabIndex = 31;
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
            this.DiaCmb.Location = new System.Drawing.Point(587, 103);
            this.DiaCmb.Name = "DiaCmb";
            this.DiaCmb.Size = new System.Drawing.Size(35, 21);
            this.DiaCmb.TabIndex = 30;
            // 
            // AñoLb
            // 
            this.AñoLb.AutoSize = true;
            this.AñoLb.Location = new System.Drawing.Point(745, 106);
            this.AñoLb.Name = "AñoLb";
            this.AñoLb.Size = new System.Drawing.Size(26, 13);
            this.AñoLb.TabIndex = 29;
            this.AñoLb.Text = "Año";
            // 
            // Meslb
            // 
            this.Meslb.AutoSize = true;
            this.Meslb.Location = new System.Drawing.Point(631, 106);
            this.Meslb.Name = "Meslb";
            this.Meslb.Size = new System.Drawing.Size(27, 13);
            this.Meslb.TabIndex = 28;
            this.Meslb.Text = "Mes";
            // 
            // DiaLb
            // 
            this.DiaLb.AutoSize = true;
            this.DiaLb.Location = new System.Drawing.Point(547, 106);
            this.DiaLb.Name = "DiaLb";
            this.DiaLb.Size = new System.Drawing.Size(23, 13);
            this.DiaLb.TabIndex = 27;
            this.DiaLb.Text = "Dia";
            // 
            // ConsultaBt
            // 
            this.ConsultaBt.Location = new System.Drawing.Point(748, 322);
            this.ConsultaBt.Name = "ConsultaBt";
            this.ConsultaBt.Size = new System.Drawing.Size(75, 23);
            this.ConsultaBt.TabIndex = 33;
            this.ConsultaBt.Text = "Consultar";
            this.ConsultaBt.UseVisualStyleBackColor = true;
            this.ConsultaBt.Click += new System.EventHandler(this.ConsultaBt_Click);
            // 
            // BuscarLb
            // 
            this.BuscarLb.AutoSize = true;
            this.BuscarLb.Location = new System.Drawing.Point(316, 41);
            this.BuscarLb.Name = "BuscarLb";
            this.BuscarLb.Size = new System.Drawing.Size(40, 13);
            this.BuscarLb.TabIndex = 34;
            this.BuscarLb.Text = "Buscar";
            // 
            // BuscarText
            // 
            this.BuscarText.Location = new System.Drawing.Point(372, 41);
            this.BuscarText.Name = "BuscarText";
            this.BuscarText.Size = new System.Drawing.Size(123, 20);
            this.BuscarText.TabIndex = 35;
            this.BuscarText.TextChanged += new System.EventHandler(this.BuscarText_TextChanged);
            this.BuscarText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscarText_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(587, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaFiltrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BuscarText);
            this.Controls.Add(this.BuscarLb);
            this.Controls.Add(this.ConsultaBt);
            this.Controls.Add(this.AñoCmb);
            this.Controls.Add(this.MesCmb);
            this.Controls.Add(this.DiaCmb);
            this.Controls.Add(this.AñoLb);
            this.Controls.Add(this.Meslb);
            this.Controls.Add(this.DiaLb);
            this.Controls.Add(this.SubsidiadoText);
            this.Controls.Add(this.ContributivoText);
            this.Controls.Add(this.SubsidiadoLb);
            this.Controls.Add(this.ContributivoLb);
            this.Controls.Add(this.TodosText);
            this.Controls.Add(this.TodosLb);
            this.Controls.Add(this.FiltrarLb);
            this.Controls.Add(this.FiltrarCmb);
            this.Controls.Add(this.ConsultaDgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaFiltrar";
            this.Text = "Filtrar";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultaDgv;
        private System.Windows.Forms.ComboBox FiltrarCmb;
        private System.Windows.Forms.Label FiltrarLb;
        private System.Windows.Forms.Label TodosLb;
        private System.Windows.Forms.TextBox TodosText;
        private System.Windows.Forms.Label ContributivoLb;
        private System.Windows.Forms.Label SubsidiadoLb;
        private System.Windows.Forms.TextBox ContributivoText;
        private System.Windows.Forms.TextBox SubsidiadoText;
        private System.Windows.Forms.ComboBox AñoCmb;
        private System.Windows.Forms.ComboBox MesCmb;
        private System.Windows.Forms.ComboBox DiaCmb;
        private System.Windows.Forms.Label AñoLb;
        private System.Windows.Forms.Label Meslb;
        private System.Windows.Forms.Label DiaLb;
        private System.Windows.Forms.Button ConsultaBt;
        private System.Windows.Forms.Label BuscarLb;
        private System.Windows.Forms.TextBox BuscarText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}