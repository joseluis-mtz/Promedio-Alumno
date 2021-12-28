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
    }
}
