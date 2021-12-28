using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PromedioAlumno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtProm.Enabled = false;
            txtCalAl.Enabled = false;
            txtCalBa.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCalAl.Clear();
            txtCalBa.Clear();
            txtProm.Clear();
            txtNumAlumnos.Clear();
            txtNumAlumnos.Focus();
        }

        private void btnCalcu_Click(object sender, EventArgs e)
        {
            int noAlumnos = 0;
            double cSuma = 0, cProm;
            if (txtNumAlumnos.Text.Length > 0)
            {
                noAlumnos = int.Parse(txtNumAlumnos.Text);
                double[] calif = new double[noAlumnos];

                for (int i = 0; i < noAlumnos; i++)
                {
                    try
                    {
                        calif[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Escribe la calificación: " + (i + 1), "Promedio de Calificaciones", "", 500, 280));
                    }
                    catch (Exception varEx)
                    {
                        MessageBox.Show("Hubo un error. Debes agregar la calificación del alumno.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cSuma += calif[i];
                }
                cProm = cSuma / noAlumnos;
                txtProm.Text = cProm.ToString("N2");
                Array.Sort(calif);
                txtCalBa.Text = calif[0].ToString();
                Array.Reverse(calif);
                txtCalAl.Text = calif[0].ToString();
            }
            else
            {
                MessageBox.Show("Ingresa la cantidad de alumnos para hacer el calculo.", "Promedios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumAlumnos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Libreria_validacion.Validar.SoloNumeros(e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
