using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class PesquisarVenda : Form
    {
        VendaDAO vendaDao = new VendaDAO();
        Venda venda = new Venda();
        internal Venda Venda { get => venda; set => venda = value; }
        int pagamento;
        public PesquisarVenda()
        {
            InitializeComponent();
        }

        private void txtNovoCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtNovaCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            if (vendaDao.pesquisarVenda(Idvda.Text) == true)
            {

                CodVenda.Text = vendaDao.Venda.Id_vda.ToString();

                NovoCli.Text = vendaDao.Venda.Nome_cli1.ToString();
                ValorVenda.Text = vendaDao.Venda.Valor_vda.ToString();
                NovaData.Text = vendaDao.Venda.Data_vda.ToString();
                IdFunc.Text = vendaDao.Venda.Id_func.ToString();
                DescVenda.Text = vendaDao.Venda.Desct_vda.ToString();

                if (vendaDao.Venda.Id_pagto == 1)
                {
                    Cartao.Checked = true;
                }
                if (vendaDao.Venda.Id_pagto == 2)
                {
                    Dinheiro.Checked = true;
                }


            }
            else
            {
                MessageBox.Show("Venda não cadastrada!!!");
                limparVenda();

            }
        }
        private void limparVenda()
        {
            NovoCli.Clear();
            Cartao.Checked = false;
            Dinheiro.Checked = false;
            CodVenda.Clear();
            NovaData.Clear();
            IdFunc.Clear();
            DescVenda.Clear();
            ValorVenda.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult excl;

            excl = MessageBox.Show(
                "Deseja realmente excluir estas informações?",
                "Excluir Venda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (excl == DialogResult.Yes)
            {
                vendaDao.excluir(CodVenda.Text);
                MessageBox.Show("Venda excluída com sucesso!!");
            }
            else
            {
                MessageBox.Show("Cancelado!!");
            }

            limparVenda();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            venda.Id_vda = vendaDao.Venda.Id_vda;

            if (NovoCli.Text == string.Empty ||
                CodVenda.Text == string.Empty ||
                grPagamento == null ||
                IdFunc.Text == string.Empty ||
                NovaData.MaskFull == false ||
                DescVenda.Text == string.Empty ||
                ValorVenda.Text == string.Empty)
            {
                MessageBox.Show("Favor preencher os campos",
                    "ALERTA!!!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);


            }
            else
            {

                try
                {

                    venda.Nome_cli1 = NovoCli.Text;
                    venda.Id_func = Convert.ToInt32(IdFunc.Text);
                    venda.Valor_vda = Convert.ToDouble(ValorVenda.Text.Replace(',', '.'));
                    venda.Desct_vda = Convert.ToInt32(DescVenda.Text);
                    venda.Data_vda = Convert.ToDateTime(NovaData.Text);
                    venda.Id_vda = Convert.ToInt32(CodVenda.Text);
                    venda.Id_pagto = pagamento;





                    vendaDao.alterar(venda);

                    MessageBox.Show("Venda alterada com sucesso!!!");




                    limparVenda();
                }
                catch
                {
                    MessageBox.Show("Verifique as informações!!!");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cartao_CheckedChanged(object sender, EventArgs e)
        {
            pagamento = 1;
        }

        private void Dinheiro_CheckedChanged(object sender, EventArgs e)
        {
            pagamento = 2;
        }

        private void Idvda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

