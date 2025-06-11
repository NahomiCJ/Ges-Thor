namespace Formulario_de_Login
{
    partial class CentrodeRecuperación
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
            this.txt_NuevaContraseña = new System.Windows.Forms.TextBox();
            this.txt_CodigoVerificador = new System.Windows.Forms.TextBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_NuevaContraseña
            // 
            this.txt_NuevaContraseña.Location = new System.Drawing.Point(250, 106);
            this.txt_NuevaContraseña.Name = "txt_NuevaContraseña";
            this.txt_NuevaContraseña.Size = new System.Drawing.Size(162, 22);
            this.txt_NuevaContraseña.TabIndex = 14;
            this.txt_NuevaContraseña.Text = "Nueva contraseña";
            // 
            // txt_CodigoVerificador
            // 
            this.txt_CodigoVerificador.Location = new System.Drawing.Point(250, 65);
            this.txt_CodigoVerificador.MaxLength = 6;
            this.txt_CodigoVerificador.Name = "txt_CodigoVerificador";
            this.txt_CodigoVerificador.Size = new System.Drawing.Size(163, 22);
            this.txt_CodigoVerificador.TabIndex = 13;
            this.txt_CodigoVerificador.Text = "Codigo de verificacion";
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(229, 228);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(123, 36);
            this.btn_Confirmar.TabIndex = 12;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(250, 142);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(164, 22);
            this.txt_Usuario.TabIndex = 15;
            this.txt_Usuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ingrese el codigo de verificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ingresa la nueva contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Confirma tu usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Acceder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "El codigo no funciono? Intentalo de nuevo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CentrodeRecuperación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 294);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_NuevaContraseña);
            this.Controls.Add(this.txt_CodigoVerificador);
            this.Controls.Add(this.btn_Confirmar);
            this.Name = "CentrodeRecuperación";
            this.Text = "CentrodeRecuperación";
            this.Load += new System.EventHandler(this.CentrodeRecuperación_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NuevaContraseña;
        private System.Windows.Forms.TextBox txt_CodigoVerificador;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}