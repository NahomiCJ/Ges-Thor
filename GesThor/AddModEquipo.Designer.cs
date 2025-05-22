namespace GesThor
{
    partial class AddModEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddModEquipo));
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCan = new System.Windows.Forms.Label();
            this.lblEst = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblDis = new System.Windows.Forms.Label();
            this.chbDisponibilidad = new System.Windows.Forms.CheckBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(369, 38);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "label1";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(218, 116);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(465, 116);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(218, 364);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(347, 23);
            this.btnMod.TabIndex = 6;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(24, 406);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Volver al menu";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(215, 86);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "ID:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(462, 86);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(47, 13);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Nombre:";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(218, 231);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(100, 20);
            this.numCantidad.TabIndex = 10;
            // 
            // lblCan
            // 
            this.lblCan.AutoSize = true;
            this.lblCan.Location = new System.Drawing.Point(215, 202);
            this.lblCan.Name = "lblCan";
            this.lblCan.Size = new System.Drawing.Size(52, 13);
            this.lblCan.TabIndex = 11;
            this.lblCan.Text = "Cantidad:";
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.Location = new System.Drawing.Point(462, 202);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(43, 13);
            this.lblEst.TabIndex = 12;
            this.lblEst.Text = "Estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Disponible",
            "En Mantenimiento",
            "Dañado"});
            this.cbEstado.Location = new System.Drawing.Point(465, 230);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(100, 21);
            this.cbEstado.TabIndex = 13;
            // 
            // lblDis
            // 
            this.lblDis.AutoSize = true;
            this.lblDis.Location = new System.Drawing.Point(340, 284);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(75, 13);
            this.lblDis.TabIndex = 14;
            this.lblDis.Text = "Disponibilidad:";
            // 
            // chbDisponibilidad
            // 
            this.chbDisponibilidad.AutoSize = true;
            this.chbDisponibilidad.Location = new System.Drawing.Point(343, 311);
            this.chbDisponibilidad.Name = "chbDisponibilidad";
            this.chbDisponibilidad.Size = new System.Drawing.Size(80, 17);
            this.chbDisponibilidad.TabIndex = 15;
            this.chbDisponibilidad.Text = "checkBox1";
            this.chbDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(650, -11);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(138, 147);
            this.pb1.TabIndex = 16;
            this.pb1.TabStop = false;
            // 
            // AddModEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.chbDisponibilidad);
            this.Controls.Add(this.lblDis);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblEst);
            this.Controls.Add(this.lblCan);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbl1);
            this.Name = "AddModEquipo";
            this.Text = "AddModEquipo";
            this.Load += new System.EventHandler(this.AddModEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblCan;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblDis;
        private System.Windows.Forms.CheckBox chbDisponibilidad;
        private System.Windows.Forms.PictureBox pb1;
    }
}