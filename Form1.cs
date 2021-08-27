using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParadigmaEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbName.Items.Add("Santiago Jagua Carvajal");
            cbName.Items.Add("Jose Daniel Cabrera Calderon");
            cbName.Items.Add("Valentina Peñuela Navas");
            cbName.Items.Add("Daniel Felipe Millan Martinez");
            cbName.Items.Add("Felix Andres Asela Garcia");
            cbName.Items.Add("Daniela Lucia Arenas Gomez");
            cbName.Items.Add("Karen Nicol Dayanna Lizarazo Ortiz");
            cbName.Items.Add("Carlos Stevenz Rua Garcia");
            cbName.Items.Add("Diego Felipe Lara Angarita");
            cbName.Items.Add("Juan Sebastian Perez Millares");
            cbName.Items.Add("Juan David Macias Calderon");
            cbName.Items.Add("Harold Enrique Niño Aristizabal");
            cbName.Items.Add("Juan Sebastian Pasichana Moncada");
            cbName.Items.Add("Andres Essneider Quintero Valderrama");
            cbName.Items.Add("Juan Pablo Adames Solarte");
            cbName.Items.Add("Diego Alejandro Pinzon Gonzalez");
            cbName.Items.Add("Jesus Enrique Bonilla España");
            cbName.Items.Add("Yarith Fernanda Espitia Ortiz");
            cbName.Items.Add("Nicolas Elias Bossio Rincon");
            cbName.Items.Add("Andres Santiago Lopez Lopez");
            cbName.Items.Add("Edinson Felipe Lazaro Gonzales");
            cbName.Items.Add("Juan Felipe Meza Morales");
            cbName.Items.Add("Juan David Acuña Merchan");
            cbName.Items.Add("Juan Sebastian Tarazona Quintero");
            cbName.Items.Add("Jorge Andres Pinilla Gonzalez");
            cbName.Items.Add("Edwin Nicolas Tarazona Morales");
            cbName.Items.Add("David Alejandro Pinzon Gonzalez");
            cbName.Text = "Selecciona tu nombre";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string frase = "Nombre: "
            + Convert.ToString(cbName.SelectedItem) + " - " + " Documento: "
            + Convert.ToString(tbDocumento.Text) + " - " + " Fecha de nacimiento: "
            + Convert.ToString(dtpFechaNacimiento.Value) + " - " + "NRC: "
            + Convert.ToString(tbNRC.Text);

            rtxtResults.Text = frase + rtxtResults.Text;

            cbName.Text = "Selecciona tu nombre";
            tbDocumento.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            tbNRC.Clear();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form2 Formulario = new Form2();
            Formulario.Show();

            Form2 f = new Form2();
            f.tbDatos.Text = rtxtResults.Text;
            this.Hide();
            f.ShowDialog();

        }

    }
}






