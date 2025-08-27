using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Trabajo
{
    public partial class frmDatossAleatorios : Form

    {
        private Random random = new Random();
        public frmDatossAleatorios()
        {
            InitializeComponent();
        }
        private void Generar_Click(object sender, EventArgs e)
        {

            Empleado emp = new Empleado
            {
                Numero = random.Next(1, 100),
                Nombre = GenerarNombre(),
                FechaNacimiento = GenerarFechaNacimiento(),
                Sexo = (random.Next(0, 2) == 0) ? "Masculino" : "Femenino",
                Grupo = (char)random.Next('a', 'd'),
                Sueldo = Math.Round(random.NextDouble() * 20000 + 5000, 2),
                SeguroMedico = random.Next(0, 2) == 1
            };


            Numero.Text = emp.Numero.ToString();
            Nombre.Text = emp.Nombre;
            Fecha.Value = emp.FechaNacimiento;

            if (emp.Sexo == "Masculino")
                Masculino.Checked = true;
            else
                Femenino.Checked = true;

            Grupo.SelectedItem = emp.Grupo.ToString();
            Sueldo.Text = emp.Sueldo.ToString("F2");
            Seguro.Checked = emp.SeguroMedico;
        }

        private string GenerarNombre()
        {
            string[] nombres = { "miguel", "felipe", "gael", "ana", "luis", "jose", "juan", "esteban" };
            int indiceAleatorio = random.Next(nombres.Length);
            string nombreElegido = nombres[indiceAleatorio];
            return nombreElegido;
        }

        private DateTime GenerarFechaNacimiento()
        {
            DateTime inicio = new DateTime(1960, 1, 1);
            int diasTotales = (DateTime.Today - inicio).Days;
            int diasAleatorios = random.Next(diasTotales);
            DateTime fechaAleatoria = inicio.AddDays(diasAleatorios);

            return fechaAleatoria;
        }


        private void frmDatossAleatorios_Load(object sender, EventArgs e)
        {
            Grupo.Items.Clear();
            Grupo.Items.Add("a");
            Grupo.Items.Add("b");
            Grupo.Items.Add("c");
            Grupo.Items.Add("d");




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Femenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Grupo_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Sueldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Grupo_SelectedItemChanged_1(object sender, EventArgs e)
        {

        }
    }
}
