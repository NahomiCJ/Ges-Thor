namespace Formulario_de_Login
{
    partial class Recuperacion
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_CodigoGoogle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cambiarcodigo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NuevoCodigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_EnviarCodigo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ingrese el usuario";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(144, 42);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(100, 22);
            this.txt_Usuario.TabIndex = 17;
            this.txt_Usuario.TextChanged += new System.EventHandler(this.txt_Usuario_TextChanged);
            // 
            // lbl_CodigoGoogle
            // 
            this.lbl_CodigoGoogle.AutoSize = true;
            this.lbl_CodigoGoogle.Location = new System.Drawing.Point(46, 150);
            this.lbl_CodigoGoogle.Name = "lbl_CodigoGoogle";
            this.lbl_CodigoGoogle.Size = new System.Drawing.Size(89, 16);
            this.lbl_CodigoGoogle.TabIndex = 24;
            this.lbl_CodigoGoogle.Text = "Tu codigo es:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ingresa el nuevo codigo";
            // 
            // btn_Cambiarcodigo
            // 
            this.btn_Cambiarcodigo.Location = new System.Drawing.Point(268, 129);
            this.btn_Cambiarcodigo.Name = "btn_Cambiarcodigo";
            this.btn_Cambiarcodigo.Size = new System.Drawing.Size(82, 31);
            this.btn_Cambiarcodigo.TabIndex = 27;
            this.btn_Cambiarcodigo.Text = "Confirmar";
            this.btn_Cambiarcodigo.UseVisualStyleBackColor = true;
            this.btn_Cambiarcodigo.Click += new System.EventHandler(this.btn_Cambiarcodigo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_NuevoCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Cambiarcodigo);
            this.groupBox1.Location = new System.Drawing.Point(479, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 176);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificación del codigo de tu conexión";
            // 
            // txt_NuevoCodigo
            // 
            this.txt_NuevoCodigo.Location = new System.Drawing.Point(175, 38);
            this.txt_NuevoCodigo.Name = "txt_NuevoCodigo";
            this.txt_NuevoCodigo.Size = new System.Drawing.Size(159, 22);
            this.txt_NuevoCodigo.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_EnviarCodigo);
            this.groupBox2.Controls.Add(this.txt_Usuario);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(21, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 176);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recuperación de tu contraseña de usuario";
            // 
            // txt_EnviarCodigo
            // 
            this.txt_EnviarCodigo.Location = new System.Drawing.Point(230, 129);
            this.txt_EnviarCodigo.Name = "txt_EnviarCodigo";
            this.txt_EnviarCodigo.Size = new System.Drawing.Size(87, 31);
            this.txt_EnviarCodigo.TabIndex = 23;
            this.txt_EnviarCodigo.Text = "Confirmar";
            this.txt_EnviarCodigo.UseVisualStyleBackColor = true;
            this.txt_EnviarCodigo.Click += new System.EventHandler(this.txt_EnviarCodigo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Centro de recuperación";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(862, -4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 41);
            this.button2.TabIndex = 31;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Recuperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 280);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_CodigoGoogle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recuperacion";
            this.Text = "Recuperacion";
            this.Load += new System.EventHandler(this.Recuperacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label lbl_CodigoGoogle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cambiarcodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button txt_EnviarCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NuevoCodigo;
        private System.Windows.Forms.Button button2;
    }
}