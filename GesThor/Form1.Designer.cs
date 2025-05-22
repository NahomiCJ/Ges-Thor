namespace GesThor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btnAg = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(397, 69);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(54, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Inventario";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(83, 412);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Volver al menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(682, 405);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 3;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(682, -9);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(138, 147);
            this.pb1.TabIndex = 4;
            this.pb1.TabStop = false;
            // 
            // btnAg
            // 
            this.btnAg.Location = new System.Drawing.Point(388, 405);
            this.btnAg.Name = "btnAg";
            this.btnAg.Size = new System.Drawing.Size(75, 23);
            this.btnAg.TabIndex = 5;
            this.btnAg.Text = "Agregar";
            this.btnAg.UseVisualStyleBackColor = true;
            this.btnAg.Click += new System.EventHandler(this.btnAg_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.GridColor = System.Drawing.Color.White;
            this.dgvInventario.Location = new System.Drawing.Point(142, 95);
            this.dgvInventario.Name = "dgvInventario";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            this.dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventario.Size = new System.Drawing.Size(546, 268);
            this.dgvInventario.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.btnAg);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button btnAg;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button button1;
    }
}

