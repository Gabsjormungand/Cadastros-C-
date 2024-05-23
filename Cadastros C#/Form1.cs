using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastros_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            txtBoxID.Clear();
            txtBoxProduto.Clear();
            txtBoxQuali.Clear();
            txtBoxPreco.Clear();
            txtBoxID.Focus();
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtBoxID.Text == "")
            {
                MessageBox.Show("ID Não pode ser vazio, por favor preencha o id");
                txtBoxID.Focus();
                return;
            }

            if (txtBoxProduto.Text == "")
            {
                MessageBox.Show("Produto Não pode ser vazio, por favor preencha o Produto");
                txtBoxProduto.Focus();
                return;
            }

            if (txtBoxQuali.Text == "")
            {
                MessageBox.Show("Qualidade Não pode ser vazio, por favor preencha o Qualidade");
                txtBoxQuali.Focus();
                return;
            }

            if (txtBoxPreco.Text == "")
            {
                MessageBox.Show("PREço Não pode ser vazio, por favor preencha o Preço"):
                txtBoxPreco.Focus();
                return;
            }
        }
    }
}
