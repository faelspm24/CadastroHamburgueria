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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if((txtLogin.Text == "Rafael") && (txtSair.Text == "1997")){

                new frmMenu().Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Você errou sua senha.");
            }

            
        }
    }
}
