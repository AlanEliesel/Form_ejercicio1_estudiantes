using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_ejercicio1_estudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            string nombre, apellido, carrera;

            int matricula, edad;

            nombre = txt_Nombre.Text;
            apellido = txt_Apellidos.Text;
            carrera = txt_Carrera.Text;

            matricula = Convert.ToInt32(txt_Matricula.Text);
            edad = Convert.ToInt32(txt_Edad.Text);
            

           string Datos = $"Matricula :   {matricula}" + " " + $"Nombre    :   {nombre}" + " " + $"Apellido  :   {apellido}" + " " + $"Edad      :   {edad} " + " " + $"Carrera   :   {carrera}";


            lbl_Prueba.Text = Datos;


        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Apellidos.Text = string.Empty;
            txt_Carrera.Text = string.Empty;
            txt_Edad.Text = string.Empty;
            txt_Matricula.Text = string.Empty;
            txt_Nombre.Text = string.Empty;
            lbl_Imprimir.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
