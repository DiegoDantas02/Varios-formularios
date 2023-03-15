using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Varios_formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (textBoxInserir.Text == " ")
            {
                MessageBox.Show("Por Favor insira um nome no campo!!!", "Aviso!", MessageBoxButtons.OK);
                btnInserir.Focus();
                return;

            }

            textBoxMultitexto.Text += btnInserir.Text + " ,";
            textBoxInserir.Clear();
            textBoxInserir.Focus();
        }
    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
