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
            cmbbxName.Items.Add("Santiago Jagua Carvajal");
            cmbbxName.Items.Add("Jose Daniel Cabrera Calderon");
            cmbbxName.Items.Add("Valentina Peñuela Navas");
            cmbbxName.Items.Add("Daniel Felipe Millan Martinez");
            cmbbxName.Items.Add("Felix Andres Asela Garcia");
            cmbbxName.Items.Add("Daniela Lucia Arenas Gomez");
            cmbbxName.Items.Add("Karen Nicol Dayanna Lizarazo Ortiz");
            cmbbxName.Items.Add("Carlos Stevenz Rua Garcia");
            cmbbxName.Items.Add("Diego Felipe Lara Angarita");
            cmbbxName.Items.Add("Santiago Jagua Carvajal");
            cmbbxName.Items.Add("Juan Sebastian Perez Millares");
            cmbbxName.Items.Add("Juan David Macias Calderon");
            cmbbxName.Items.Add("Harold Enrique Niño Aristizabal");
            cmbbxName.Items.Add("Juan Sebastian Pasichana Moncada");
            cmbbxName.Items.Add("Andres Essneider Quintero Valderrama");
            cmbbxName.Items.Add("Juan Pablo Adames Solarte");
            cmbbxName.Items.Add("Diego Alejandro Pinzon Gonzalez");
            cmbbxName.Items.Add("Jesus Enrique Bonilla España");
            cmbbxName.Items.Add("Yarith Fernanda Espitia Ortiz");
            cmbbxName.Items.Add("Nicolas Elias Bossio Rincon");
            cmbbxName.Items.Add("Andres Santiago Lopez Lopez");
            cmbbxName.Items.Add("Edinson Felipe Lazaro Gonzales");
            cmbbxName.Items.Add("Juan David Acuña Merchan");
            cmbbxName.Items.Add("Juan Sebastian Tarazona Quintero");
            cmbbxName.Items.Add("Jorge Andres Pinilla Gonzalez");
            cmbbxName.Items.Add("Edwin Nicolas Tarazona Morales");
            cmbbxName.Items.Add("David Alejandro Pinzon Gonzalez");
            cmbbxName.Text = "Selecciona tu nombre";
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


            if (rdbttnFemenino.Checked);
            {
                rtxtResults.Text = Convert.ToString(cmbbxName.SelectedItem) + " - "
                + Convert.ToString(rdbttnFemenino.Text) + " - "
                + Convert.ToString(dttmpckrFechaNacimiento.Value) + " - "          
                + Convert.ToString(txtbxNRC.Text);
            }

            if (rdbttnMasculino.Checked)
            {
                rtxtResults.Text = Convert.ToString(cmbbxName.SelectedItem) + " - "
                + Convert.ToString(rdbttnMasculino.Text) + " - "
                + Convert.ToString(dttmpckrFechaNacimiento.Value) + " - "
                + Convert.ToString(txtbxNRC.Text);
             }

            cmbbxName.Text = "Selecciona tu nombre";
            rdbttnFemenino.Checked = false;
            rdbttnMasculino.Checked = false;
            dttmpckrFechaNacimiento.Value = DateTime.Today;
            txtbxNRC.Clear();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form Formulario = new Form2();
            Formulario.Show();
        }
    }
}




