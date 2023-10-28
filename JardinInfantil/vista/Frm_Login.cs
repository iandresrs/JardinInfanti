using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JardinInfantil.vista
{
    public partial class Frm_Login : Form
    {

        Frm_Registro frm_Registro = new Frm_Registro();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_clave.Text != "")
            {
                if (txt_clave.Text == "123")
                {
                    this.Hide();
                    frm_Registro.Show();
                }
                else
                {
                    MessageBox.Show("Clave incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_clave.Text = "";
                }
            }
            else
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
