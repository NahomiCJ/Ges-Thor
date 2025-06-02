namespace GesThor
{
    partial class Devolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucion));
            this.dgvInv = new System.Windows.Forms.DataGridView();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.lblTab = new System.Windows.Forms.Label();
            this.lblMat = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEst = new System.Windows.Forms.Label();
            this.lblFech = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInv
            // 
            this.dgvInv.BackgroundColor = System.Drawing.Color.White;
            this.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInv.Location = new System.Drawing.Point(279, 84);
            this.dgvInv.MultiSelect = false;
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.Size = new System.Drawing.Size(470, 243);
            this.dgvInv.TabIndex = 66;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(663, -31);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(138, 147);
            this.pb1.TabIndex = 65;
            this.pb1.TabStop = false;
            // 
            // lblTab
            // 
            this.lblTab.AutoSize = true;
            this.lblTab.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTab.Location = new System.Drawing.Point(276, 65);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(108, 16);
            this.lblTab.TabIndex = 64;
            this.lblTab.Text = "Tabla de Prestamos";
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.BackColor = System.Drawing.Color.Transparent;
            this.lblMat.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMat.Location = new System.Drawing.Point(45, 196);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(60, 16);
            this.lblMat.TabIndex = 63;
            this.lblMat.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(49, 212);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(200, 23);
            this.txtMatricula.TabIndex = 52;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(49, 304);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha.TabIndex = 54;
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Disponible",
            "En Mantenimiento",
            "Dañado"});
            this.cbEstado.Location = new System.Drawing.Point(49, 165);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(200, 25);
            this.cbEstado.TabIndex = 62;
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.BackColor = System.Drawing.Color.Transparent;
            this.lblEst.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEst.Location = new System.Drawing.Point(46, 149);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(45, 16);
            this.lblEst.TabIndex = 61;
            this.lblEst.Text = "Estado:";
            // 
            // lblFech
            // 
            this.lblFech.AutoSize = true;
            this.lblFech.BackColor = System.Drawing.Color.Transparent;
            this.lblFech.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFech.Location = new System.Drawing.Point(47, 288);
            this.lblFech.Name = "lblFech";
            this.lblFech.Size = new System.Drawing.Size(41, 16);
            this.lblFech.TabIndex = 60;
            this.lblFech.Text = "Fecha:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(46, 100);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(53, 16);
            this.lblNom.TabIndex = 59;
            this.lblNom.Text = "Nombre:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(46, 52);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 58;
            this.lblId.Text = "ID:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(49, 116);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 57;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(49, 68);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 23);
            this.txtId.TabIndex = 56;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(346, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(69, 27);
            this.lbl1.TabIndex = 55;
            this.lbl1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkRed;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(46, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 68;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkRed;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(46, 119);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 23);
            this.textBox2.TabIndex = 69;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkRed;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(46, 170);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 23);
            this.textBox3.TabIndex = 70;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DarkRed;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(46, 307);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 23);
            this.textBox4.TabIndex = 71;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.DarkRed;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(46, 215);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 23);
            this.textBox5.TabIndex = 72;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(26, 401);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 36);
            this.btnBack.TabIndex = 75;
            this.btnBack.Text = "Volver al menu";
            this.btnBack.UseVisualStyleBackColor = false;
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
            this.btnSol.Location = new System.Drawing.Point(164, 358);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(484, 25);
            this.btnSol.TabIndex = 74;
            this.btnSol.Text = "Default";
            this.btnSol.UseVisualStyleBackColor = false;
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.dgvInv);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lblTab);
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
            this.Name = "Devolucion";
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.Devolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvInv;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.Label lblFech;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSol;
    }
}