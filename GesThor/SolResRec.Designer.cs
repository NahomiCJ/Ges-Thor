namespace GesThor
{
    partial class SolResRec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolResRec));
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEst = new System.Windows.Forms.Label();
            this.lblFech = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblMat = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.lblTab = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.dgvInv = new System.Windows.Forms.DataGridView();
            this.lblHor = new System.Windows.Forms.Label();
            this.numHoras = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.cbMinutos = new System.Windows.Forms.ComboBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Disponible",
            "En Mantenimiento",
            "Dañado"});
            this.cbEstado.Location = new System.Drawing.Point(71, 178);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(200, 25);
            this.cbEstado.TabIndex = 24;
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.BackColor = System.Drawing.Color.Transparent;
            this.lblEst.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEst.Location = new System.Drawing.Point(68, 162);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(45, 16);
            this.lblEst.TabIndex = 23;
            this.lblEst.Text = "Estado:";
            // 
            // lblFech
            // 
            this.lblFech.AutoSize = true;
            this.lblFech.BackColor = System.Drawing.Color.Transparent;
            this.lblFech.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFech.Location = new System.Drawing.Point(69, 301);
            this.lblFech.Name = "lblFech";
            this.lblFech.Size = new System.Drawing.Size(41, 16);
            this.lblFech.TabIndex = 22;
            this.lblFech.Text = "Fecha:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(68, 113);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(53, 16);
            this.lblNom.TabIndex = 20;
            this.lblNom.Text = "Nombre:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(68, 65);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 19;
            this.lblId.Text = "ID:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(71, 129);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 18;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(71, 81);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 23);
            this.txtId.TabIndex = 17;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(368, 32);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(69, 27);
            this.lbl1.TabIndex = 16;
            this.lbl1.Text = "label1";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(71, 317);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.BackColor = System.Drawing.Color.Transparent;
            this.lblMat.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMat.Location = new System.Drawing.Point(67, 209);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(60, 16);
            this.lblMat.TabIndex = 29;
            this.lblMat.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(71, 225);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(200, 23);
            this.txtMatricula.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(21, 452);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 36);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Volver al menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSol
            // 
            this.btnSol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(133)))), ((int)(((byte)(166)))));
            this.btnSol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(133)))), ((int)(((byte)(166)))));
            this.btnSol.FlatAppearance.BorderSize = 0;
            this.btnSol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(133)))), ((int)(((byte)(166)))));
            this.btnSol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(133)))), ((int)(((byte)(166)))));
            this.btnSol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSol.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSol.Location = new System.Drawing.Point(177, 432);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(484, 25);
            this.btnSol.TabIndex = 6;
            this.btnSol.Text = "Default";
            this.btnSol.UseVisualStyleBackColor = false;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // lblTab
            // 
            this.lblTab.AutoSize = true;
            this.lblTab.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTab.Location = new System.Drawing.Point(298, 78);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(107, 16);
            this.lblTab.TabIndex = 33;
            this.lblTab.Text = "Tabla de Inventario";
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(685, -18);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(138, 147);
            this.pb1.TabIndex = 34;
            this.pb1.TabStop = false;
            // 
            // dgvInv
            // 
            this.dgvInv.BackgroundColor = System.Drawing.Color.White;
            this.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInv.Location = new System.Drawing.Point(301, 97);
            this.dgvInv.MultiSelect = false;
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.Size = new System.Drawing.Size(470, 274);
            this.dgvInv.TabIndex = 35;
            this.dgvInv.SelectionChanged += new System.EventHandler(this.dgvInv_SelectionChanged);
            // 
            // lblHor
            // 
            this.lblHor.AutoSize = true;
            this.lblHor.BackColor = System.Drawing.Color.Transparent;
            this.lblHor.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHor.Location = new System.Drawing.Point(68, 256);
            this.lblHor.Name = "lblHor";
            this.lblHor.Size = new System.Drawing.Size(105, 16);
            this.lblHor.TabIndex = 37;
            this.lblHor.Text = "Cantidad de horas:";
            // 
            // numHoras
            // 
            this.numHoras.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHoras.Location = new System.Drawing.Point(71, 272);
            this.numHoras.Name = "numHoras";
            this.numHoras.Size = new System.Drawing.Size(199, 23);
            this.numHoras.TabIndex = 2;
            this.numHoras.Tag = "";
            this.numHoras.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkRed;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(68, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 46;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkRed;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(68, 132);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 23);
            this.textBox2.TabIndex = 47;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkRed;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(68, 183);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 23);
            this.textBox3.TabIndex = 48;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DarkRed;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(68, 320);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 23);
            this.textBox4.TabIndex = 49;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.DarkRed;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(68, 228);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 23);
            this.textBox5.TabIndex = 50;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.DarkRed;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(68, 275);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 23);
            this.textBox6.TabIndex = 51;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(69, 352);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(36, 16);
            this.lblHora.TabIndex = 52;
            this.lblHora.Text = "Hora:";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.DarkRed;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(68, 371);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(85, 23);
            this.textBox7.TabIndex = 54;
            // 
            // cbHora
            // 
            this.cbHora.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Items.AddRange(new object[] {
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cbHora.Location = new System.Drawing.Point(71, 366);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(85, 25);
            this.cbHora.TabIndex = 4;
            this.cbHora.SelectedIndexChanged += new System.EventHandler(this.cbHora_SelectedIndexChanged);
            // 
            // cbMinutos
            // 
            this.cbMinutos.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMinutos.FormattingEnabled = true;
            this.cbMinutos.Items.AddRange(new object[] {
            "00",
            "50"});
            this.cbMinutos.Location = new System.Drawing.Point(187, 366);
            this.cbMinutos.Name = "cbMinutos";
            this.cbMinutos.Size = new System.Drawing.Size(85, 25);
            this.cbMinutos.TabIndex = 5;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(185, 352);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(49, 16);
            this.lblMin.TabIndex = 56;
            this.lblMin.Text = "Minuto:";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.DarkRed;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(184, 371);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(85, 23);
            this.textBox8.TabIndex = 57;
            // 
            // SolResRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(835, 500);
            this.Controls.Add(this.cbMinutos);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.lblHor);
            this.Controls.Add(this.numHoras);
            this.Controls.Add(this.dgvInv);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lblTab);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.lblMat);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblEst);
            this.Controls.Add(this.lblFech);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Name = "SolResRec";
            this.Text = "SolResRec";
            this.Load += new System.EventHandler(this.SolResRec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.Label lblFech;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.DataGridView dgvInv;
        private System.Windows.Forms.Label lblHor;
        private System.Windows.Forms.NumericUpDown numHoras;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.ComboBox cbMinutos;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox textBox8;
    }
}