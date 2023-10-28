namespace JardinInfantil.vista
{
    partial class Frm_Registro
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
            panel1 = new System.Windows.Forms.Panel();
            btn_limpiar = new System.Windows.Forms.Button();
            btn_guardar = new System.Windows.Forms.Button();
            rd_no = new System.Windows.Forms.RadioButton();
            rd_si = new System.Windows.Forms.RadioButton();
            label7 = new System.Windows.Forms.Label();
            dt_fecha = new System.Windows.Forms.DateTimePicker();
            label6 = new System.Windows.Forms.Label();
            box_estrato = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            box_condicion = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            txt_nombre = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txt_numRegistro = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btn_eliminar = new System.Windows.Forms.Button();
            dgvEstudiantes = new System.Windows.Forms.DataGridView();
            bnt_cerrarRegistro = new System.Windows.Forms.Button();
            txt_consulta = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            btn_Consultar = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_limpiar);
            panel1.Controls.Add(btn_guardar);
            panel1.Controls.Add(rd_no);
            panel1.Controls.Add(rd_si);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dt_fecha);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(box_estrato);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(box_condicion);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_nombre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_numRegistro);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(31, 58);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(325, 558);
            panel1.TabIndex = 0;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = System.Drawing.Color.DodgerBlue;
            btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_limpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_limpiar.ForeColor = System.Drawing.Color.White;
            btn_limpiar.Location = new System.Drawing.Point(176, 486);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new System.Drawing.Size(117, 34);
            btn_limpiar.TabIndex = 15;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = System.Drawing.Color.DodgerBlue;
            btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_guardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_guardar.ForeColor = System.Drawing.Color.White;
            btn_guardar.Location = new System.Drawing.Point(31, 486);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new System.Drawing.Size(117, 34);
            btn_guardar.TabIndex = 14;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // rd_no
            // 
            rd_no.AutoSize = true;
            rd_no.Location = new System.Drawing.Point(83, 455);
            rd_no.Name = "rd_no";
            rd_no.Size = new System.Drawing.Size(41, 19);
            rd_no.TabIndex = 13;
            rd_no.TabStop = true;
            rd_no.Text = "No";
            rd_no.UseVisualStyleBackColor = true;
            // 
            // rd_si
            // 
            rd_si.AutoSize = true;
            rd_si.Location = new System.Drawing.Point(33, 455);
            rd_si.Name = "rd_si";
            rd_si.Size = new System.Drawing.Size(34, 19);
            rd_si.TabIndex = 12;
            rd_si.TabStop = true;
            rd_si.Text = "Si";
            rd_si.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(31, 427);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(47, 15);
            label7.TabIndex = 11;
            label7.Text = "Terapia:";
            // 
            // dt_fecha
            // 
            dt_fecha.Location = new System.Drawing.Point(29, 386);
            dt_fecha.Name = "dt_fecha";
            dt_fecha.Size = new System.Drawing.Size(264, 23);
            dt_fecha.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(33, 359);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(125, 15);
            label6.TabIndex = 9;
            label6.Text = "Fecha de Nacimiento: ";
            // 
            // box_estrato
            // 
            box_estrato.FormattingEnabled = true;
            box_estrato.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            box_estrato.Location = new System.Drawing.Point(29, 322);
            box_estrato.Name = "box_estrato";
            box_estrato.Size = new System.Drawing.Size(264, 23);
            box_estrato.TabIndex = 8;
            box_estrato.Text = "Seleccione";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(29, 295);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 15);
            label5.TabIndex = 7;
            label5.Text = "Estrato: ";
            label5.Click += label5_Click;
            // 
            // box_condicion
            // 
            box_condicion.FormattingEnabled = true;
            box_condicion.Items.AddRange(new object[] { "Autismo", "Hiperactividad", "Discapacidad" });
            box_condicion.Location = new System.Drawing.Point(29, 255);
            box_condicion.Name = "box_condicion";
            box_condicion.Size = new System.Drawing.Size(264, 23);
            box_condicion.TabIndex = 6;
            box_condicion.Text = "Seleccione";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(29, 225);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(113, 15);
            label4.TabIndex = 5;
            label4.Text = "Condicion Especial: ";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new System.Drawing.Point(29, 183);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new System.Drawing.Size(264, 23);
            txt_nombre.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(29, 154);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(113, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre Completo: ";
            // 
            // txt_numRegistro
            // 
            txt_numRegistro.Location = new System.Drawing.Point(29, 116);
            txt_numRegistro.Name = "txt_numRegistro";
            txt_numRegistro.Size = new System.Drawing.Size(264, 23);
            txt_numRegistro.TabIndex = 2;
            txt_numRegistro.TextChanged += txt_numRegistro_TextChanged;
            txt_numRegistro.KeyPress += txt_numRegistro_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(29, 89);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(145, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero de Registro Civil: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(2, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(318, 37);
            label1.TabIndex = 0;
            label1.Text = "Registro de Estudiantes";
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = System.Drawing.Color.DodgerBlue;
            btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_eliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_eliminar.ForeColor = System.Drawing.Color.White;
            btn_eliminar.Location = new System.Drawing.Point(456, 11);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new System.Drawing.Size(160, 34);
            btn_eliminar.TabIndex = 16;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstudiantes.BackgroundColor = System.Drawing.Color.White;
            dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new System.Drawing.Point(385, 58);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.RowHeadersVisible = false;
            dgvEstudiantes.RowTemplate.Height = 25;
            dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            dgvEstudiantes.Size = new System.Drawing.Size(772, 475);
            dgvEstudiantes.TabIndex = 1;
            // 
            // bnt_cerrarRegistro
            // 
            bnt_cerrarRegistro.BackColor = System.Drawing.Color.Red;
            bnt_cerrarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bnt_cerrarRegistro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bnt_cerrarRegistro.ForeColor = System.Drawing.Color.White;
            bnt_cerrarRegistro.Location = new System.Drawing.Point(1100, 12);
            bnt_cerrarRegistro.Name = "bnt_cerrarRegistro";
            bnt_cerrarRegistro.Size = new System.Drawing.Size(57, 30);
            bnt_cerrarRegistro.TabIndex = 2;
            bnt_cerrarRegistro.Text = "X";
            bnt_cerrarRegistro.UseVisualStyleBackColor = false;
            bnt_cerrarRegistro.Click += bnt_cerrarRegistro_Click;
            // 
            // txt_consulta
            // 
            txt_consulta.Location = new System.Drawing.Point(21, 19);
            txt_consulta.Name = "txt_consulta";
            txt_consulta.PlaceholderText = "Numero de Registro Civil";
            txt_consulta.Size = new System.Drawing.Size(207, 23);
            txt_consulta.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_eliminar);
            panel2.Controls.Add(btn_Consultar);
            panel2.Controls.Add(txt_consulta);
            panel2.Location = new System.Drawing.Point(385, 556);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(644, 60);
            panel2.TabIndex = 3;
            // 
            // btn_Consultar
            // 
            btn_Consultar.BackColor = System.Drawing.Color.DodgerBlue;
            btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Consultar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Consultar.ForeColor = System.Drawing.Color.White;
            btn_Consultar.Location = new System.Drawing.Point(252, 11);
            btn_Consultar.Name = "btn_Consultar";
            btn_Consultar.Size = new System.Drawing.Size(173, 34);
            btn_Consultar.TabIndex = 17;
            btn_Consultar.Text = "Consultar";
            btn_Consultar.UseVisualStyleBackColor = false;
            btn_Consultar.Click += btn_Consultar_Click;
            // 
            // Frm_Registro
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1185, 643);
            Controls.Add(panel2);
            Controls.Add(bnt_cerrarRegistro);
            Controls.Add(dgvEstudiantes);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Frm_Registro";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Frm_Registro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox box_estrato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox box_condicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_numRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.RadioButton rd_no;
        private System.Windows.Forms.RadioButton rd_si;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Button bnt_cerrarRegistro;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_consulta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Consultar;
    }
}