using JardinInfantil.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JardinInfantil.vista
{
    public partial class Frm_Registro : Form
    {
        List<ListaJardin> listaEstudiantes;
        String dato;

        public Frm_Registro()
        {
            InitializeComponent();
            listaEstudiantes = new List<ListaJardin>();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bnt_cerrarRegistro_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Frm_Login frm_Login = new Frm_Login();
                frm_Login.Show();

            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {

                ListaJardin estudiante = new ListaJardin();
                estudiante.NumeroRegistroCivil = txt_numRegistro.Text;
                estudiante.NombreCompleto = txt_nombre.Text;
                estudiante.CondicionEspecial = box_condicion.Text;
                estudiante.Estrato = box_estrato.Text;
                estudiante.FechaNacimiento = dt_fecha.Value.ToString("dd/MM/yyyy");
                if (rd_si.Checked)
                {
                    estudiante.Terapia = "Si";
                }
                else if (rd_no.Checked)
                {
                    estudiante.Terapia = "No";
                }

                listaEstudiantes.Add(estudiante);

                CargarDatos();
                limpiarDatos();
            }

        }

        private bool validarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_numRegistro.Text) || string.IsNullOrWhiteSpace(txt_nombre.Text) || box_condicion.Text == "Seleccione" || box_estrato.Text == "Seleccione")
            {
                MessageBox.Show("¡Los campos no pueden estar vacíos!");
                return false;
            }

            return true;
        }

        private void CargarDatos()
        {
            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = listaEstudiantes;
        }

        private void limpiarDatos()
        {
            txt_numRegistro.Clear();
            txt_nombre.Clear();
            box_condicion.Text = "Seleccione";
            box_estrato.Text = "Seleccione";
            dt_fecha.CustomFormat = "";
            dt_fecha.Format = DateTimePickerFormat.Custom;
            rd_si.Checked = false;
            rd_no.Checked = false;
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            if (txt_consulta.Text != "")
            {
                consultar();
                txt_consulta.Clear();
            }
            else
            {
                MessageBox.Show("¡El campo no puede estar vacio!");
            }
        }

        private void consultar()
        {
            for (int i = 0; i < dgvEstudiantes.Rows.Count; i++)
            {
                dato = Convert.ToString(dgvEstudiantes.Rows[i].Cells[0].Value);
                if (dato == txt_consulta.Text.Trim())
                {
                    txt_numRegistro.Text = Convert.ToString(dgvEstudiantes.Rows[i].Cells[0].Value);
                    txt_nombre.Text = Convert.ToString(dgvEstudiantes.Rows[i].Cells[1].Value);
                    box_condicion.Text = Convert.ToString(dgvEstudiantes.Rows[i].Cells[2].Value);
                    box_estrato.Text = Convert.ToString(dgvEstudiantes.Rows[i].Cells[3].Value);
                    dt_fecha.Text = Convert.ToString(dgvEstudiantes.Rows[i].Cells[4].Value);
                    if (dgvEstudiantes.Rows[i].Cells[5].Value == "Si")
                    {
                        rd_si.Checked = true;
                    }
                    else
                    {
                        rd_si.Checked = false;
                    }
                    break;
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (txt_consulta.Text != "")
            {
                eliminarEstudiante();
                txt_consulta.Clear();
            }
            else
            {
                MessageBox.Show("¡El campo no puede estar vacio!");
            }
        }

        private void eliminarEstudiante()
        {
            bool estudianteEncontrado = false;

            for (int i = 0; i < dgvEstudiantes.Rows.Count; i++)
            {
                dato = Convert.ToString(dgvEstudiantes.Rows[i].Cells[0].Value);
                if (dato == txt_consulta.Text)
                {
                    estudianteEncontrado = true;


                    DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar a este estudiante?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        listaEstudiantes.RemoveAt(i);
                        MessageBox.Show("Estudiante eliminado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Eliminación cancelada");
                    }
                    break;
                }
            }

            if (!estudianteEncontrado)
            {
                MessageBox.Show("El Estudiante No Existe");
            }

            CargarDatos();
        }

        private void txt_numRegistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_numRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("¡Solo se aceptan numero!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
