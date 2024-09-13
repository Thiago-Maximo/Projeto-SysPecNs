using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SysPecNsDesk
{
    public partial class FrmPedido : Form
    {
        Produto produto;
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Program.UsuarioLogado.Id + " - " + Program.UsuarioLogado.Nome;
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(
                Program.UsuarioLogado,
                Cliente.ObterPorId(int.Parse(txtIDCliente.Text)), 0
                );
            pedido.Inserir();
            txtIdPedido.Text = pedido.Id.ToString();
            grpItens.Enabled = true;
            grpIdentificacao.Enabled = false;
            txtCodBar.Focus();
        }

        private void txtCodBar_Leave(object sender, EventArgs e)
        {
            if (txtCodBar.TextLength > 0)
            {
                produto = Produto.ObterPorId(txtCodBar.Text);
                txtDescricao.Text = produto.Descricao;
                txtValorUnit.Text = produto.ValorUnit.ToString();
                if (produto.ClasseDesconto == 0)
                {
                    txtDescontoItem.Enabled = false;
                }
                else
                {
                    txtDescontoItem.Enabled = true;
                    label4.Text = "R$" + (produto.ValorUnit * produto.ClasseDesconto).ToString("#0.00");

                }
                txtValorUnit.ReadOnly = true;
                txtQuantidade.Focus();
            }
            if ()
            {

            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemPedido item = new(
                int.Parse(txtIdPedido.Text),
                produto,
                produto.ValorUnit,
                double.Parse(txtQuantidade.Text),
                double.Parse(txtDescontoItem.Text)
                );
            item.Inserir();
            produto = new();
            txtDescontoItem.Text = "0";
            txtDescricao.Clear();
            txtValorUnit.Text = "0";
            txtQuantidade.Text = "1";
            txtCodBar.Clear();
            PreencherGridItens();
            txtDescontoPedido.Focus();
        }

        private void PreencherGridItens()
        {
            var itens = ItemPedido.ObterListaPorPedido(int.Parse(txtIdPedido.Text));
            dgvItensPedido.Rows.Clear();
            int linha = 0;
            double desconto = 0;
            double total = 0;
            foreach (var item in itens)
            {
                dgvItensPedido.Rows.Add();
                dgvItensPedido.Rows[linha].Cells[0].Value = $"#{linha + 1}";
                dgvItensPedido.Rows[linha].Cells[1].Value = item.Produto.CodBar;
                dgvItensPedido.Rows[linha].Cells[2].Value = item.Produto.Descricao;
                dgvItensPedido.Rows[linha].Cells[3].Value = item.ValorUnit.ToString("#0.00");
                dgvItensPedido.Rows[linha].Cells[4].Value = item.Quantidade.ToString("#0.00");
                dgvItensPedido.Rows[linha].Cells[5].Value = item.Desconto.ToString("#0.00");
                dgvItensPedido.Rows[linha].Cells[6].Value = (item.ValorUnit * item.Quantidade - item.Desconto).ToString("#0.00");
                linha++;
                total += item.ValorUnit * item.Quantidade - item.Desconto;
                desconto += item.Desconto;

            }
            txtTotal.Text = total.ToString("#0.00");
            txtDescontoItens.Text = desconto.ToString("#0.00");
            txtSubTotal.Text = (total + desconto).ToString("#0.00");

            txtTotal.Text = total.ToString("#0.00");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void txtValorFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescontoPedido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Verifica se o campo de desconto do pedido não está vazio
                if (txtDescontoPedido.Text != string.Empty)
                {
                    // Tenta converter os valores dos campos de texto em double
                    double subTotal = double.Parse(txtSubTotal.Text);
                    double descontoPedido = double.Parse(txtDescontoPedido.Text);
                    double descontoItens = double.Parse(txtDescontoItens.Text);

                    // Calcula o total e exibe no campo de texto
                    double total = subTotal - descontoPedido - descontoItens;
                    txtTotal.Text = total.ToString("#0.00");
                }
                else
                {
                    // Se o campo estiver vazio, atribui "0,00" a ele
                    txtDescontoPedido.Text = "0,00";
                }
            }
            catch (FormatException)
            {
                // Exibe uma mensagem de erro se o formato do texto não for um número válido
                MessageBox.Show("Por favor, insira valores numéricos válidos.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Captura outras exceções e exibe uma mensagem de erro genérica
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtValorFinal.Text = txtTotal.Text;
        }

        private void txtDescontoPedido_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescontoPedido.Text))
            {
                txtDescontoPedido.SelectionStart = 0;
                txtDescontoPedido.SelectionLength = txtQuantidade.Text.Length;
            }
        }

        private void btnBuscaIDCliente_Click(object sender, EventArgs e)
        {
            FrmBuscaCliente frmBuscaCliente = new();
            frmBuscaCliente.Show();
        }
    }
}
