using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Misto = 9.00, Egg = 15.00, Salada = 13.50, Bacon = 18.00, Frango = 20.00, Coca = 5.80,
                fantaLaranja = 7.00, fantaUva = 7.90, Soda = 5.00, Caçulinha = 4.50;

            double totalLanche = Misto * double.Parse(cbMisto.Text)
                + Egg * double.Parse(cbEgg.Text) 
                + Salada * double.Parse(cbSalada.Text) 
                + Bacon * double.Parse(cbBacon.Text)
                + Frango * double.Parse(cbFrango.Text)
                + Coca * double.Parse(cbCoca.Text)
                + fantaLaranja * double.Parse(cbfantaLaranja.Text)
                + fantaUva * double.Parse(cbfantaUva.Text)
                + Soda * double.Parse(cbSoda.Text) 
                + Caçulinha * double.Parse(cbCaçulinha.Text);

            txtTotal.Text = totalLanche.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por comprar conosco ");
            Application.Exit();
        }
    }
}
