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
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Disponible",
            "En Mantenimiento",
            "Dañado"});
            this.cbEstado.Location = new System.Drawing.Point(68, 190);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(200, 21);
            this.cbEstado.TabIndex = 24;
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.Location = new System.Drawing.Point(65, 174);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(43, 13);
            this.lblEst.TabIndex = 23;
            this.lblEst.Text = "Estado:";
            // 
            // lblFech
            // 
            this.lblFech.AutoSize = true;
            this.lblFech.Location = new System.Drawing.Point(66, 222);
            this.lblFech.Name = "lblFech";
            this.lblFech.Size = new System.Drawing.Size(40, 13);
            this.lblFech.TabIndex = 22;
            this.lblFech.Text = "Fecha:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(65, 124);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(47, 13);
            this.lblNom.TabIndex = 20;
            this.lblNom.Text = "Nombre:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(65, 74);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 19;
            this.lblId.Text = "ID:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(68, 140);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(68, 90);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 20);
            this.txtId.TabIndex = 17;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(364, 35);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(69, 27);
            this.lbl1.TabIndex = 16;
            this.lbl1.Text = "label1";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(69, 238);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 27;
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Location = new System.Drawing.Point(64, 275);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(53, 13);
            this.lblMat.TabIndex = 29;
            this.lblMat.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(67, 291);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(200, 20);
            this.txtMatricula.TabIndex = 28;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(27, 408);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 23);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Volver al menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(153, 381);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(484, 23);
            this.btnSol.TabIndex = 31;
            this.btnSol.Text = "Default";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // lblTab
            // 
            this.lblTab.AutoSize = true;
            this.lblTab.Location = new System.Drawing.Point(316, 82);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(99, 13);
            this.lblTab.TabIndex = 33;
            this.lblTab.Text = "Tabla de Inventario";
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(660, -19);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(138, 147);
            this.pb1.TabIndex = 34;
            this.pb1.TabStop = false;
            // 
            // dgvInv
            // 
            this.dgvInv.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInv.Location = new System.Drawing.Point(319, 98);
            this.dgvInv.MultiSelect = false;
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.Size = new System.Drawing.Size(405, 228);
            this.dgvInv.TabIndex = 35;
            this.dgvInv.SelectionChanged += new System.EventHandler(this.dgvInv_SelectionChanged);
            // 
            // lblHor
            // 
            this.lblHor.AutoSize = true;
            this.lblHor.Location = new System.Drawing.Point(65, 322);
            this.lblHor.Name = "lblHor";
            this.lblHor.Size = new System.Drawing.Size(96, 13);
            this.lblHor.TabIndex = 37;
            this.lblHor.Text = "Cantidad de horas:";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(68, 338);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(199, 20);
            this.numCantidad.TabIndex = 36;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SolResRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHor);
            this.Controls.Add(this.numCantidad);
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
            this.Name = "SolResRec";
            this.Text = "SolResRec";
            this.Load += new System.EventHandler(this.SolResRec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numCantidad;
    }
}