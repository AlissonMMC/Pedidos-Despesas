using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221051
{
    public partial class Loja : Form
    {
        double total;
        double totaldesp;
        double saldo;

        public Loja()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            double vlr = double.Parse(txtValor.Text);
            

            total = total + vlr;

            lblPedido.Text = total.ToString("C");
            
            listProduto.Items.Add(txtPedido.Text + " / " + txtCliente.Text + " / " + vlr.ToString("C"));

            txtCliente.Text = "";
            txtPedido.Text = "";
            txtValor.Text = "";
        }

        private void btnDespesa_Click(object sender, EventArgs e)
        {
            double vlrDesp = double.Parse(txtVlr_Despesa.Text);

            totaldesp = totaldesp + vlrDesp;
            
            lblDespesa.Text = totaldesp.ToString("C");

            listDespesa.Items.Add(txtDespesa.Text + " / " + vlrDesp.ToString("C"));

            saldo = total - totaldesp;

            lblSaldo.Text = saldo.ToString("C");

            txtVlr_Despesa.Text = "";
            txtDespesa.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            total = 0;
            totaldesp = 0;
            saldo= 0;

            lblPedido.Text = "R$0,00";
            lblDespesa.Text = "R$0,00";
            lblSaldo.Text = "R$0,00";

            listDespesa.Items.Clear();
            listProduto.Items.Clear();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
