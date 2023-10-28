namespace JardinInfantil.vista
{
    partial class Frm_Login
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txt_clave = new System.Windows.Forms.TextBox();
            btn_login = new System.Windows.Forms.Button();
            btn_salir = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label1.Location = new System.Drawing.Point(107, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(225, 45);
            label1.TabIndex = 0;
            label1.Text = "Jardin Infantil";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(49, 130);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 37);
            label2.TabIndex = 1;
            label2.Text = "Log in";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_clave
            // 
            txt_clave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_clave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_clave.Location = new System.Drawing.Point(49, 184);
            txt_clave.Multiline = true;
            txt_clave.Name = "txt_clave";
            txt_clave.PasswordChar = '*';
            txt_clave.PlaceholderText = "CONTRASEÑA";
            txt_clave.Size = new System.Drawing.Size(311, 32);
            txt_clave.TabIndex = 2;
            // 
            // btn_login
            // 
            btn_login.BackColor = System.Drawing.Color.DodgerBlue;
            btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_login.ForeColor = System.Drawing.SystemColors.Control;
            btn_login.Location = new System.Drawing.Point(49, 222);
            btn_login.Name = "btn_login";
            btn_login.Size = new System.Drawing.Size(311, 37);
            btn_login.TabIndex = 3;
            btn_login.Text = "Iniciar Sesion";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = System.Drawing.Color.DodgerBlue;
            btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_salir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_salir.ForeColor = System.Drawing.SystemColors.Control;
            btn_salir.Location = new System.Drawing.Point(49, 265);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new System.Drawing.Size(311, 37);
            btn_salir.TabIndex = 4;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(138, 68);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(134, 15);
            label3.TabIndex = 5;
            label3.Text = "Diego Fernando Torrado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(148, 83);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(109, 15);
            label4.TabIndex = 6;
            label4.Text = "Estructura de Datos";
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(403, 342);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_salir);
            Controls.Add(btn_login);
            Controls.Add(txt_clave);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Frm_Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}