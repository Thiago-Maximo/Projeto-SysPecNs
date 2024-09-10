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

        }

        private void txtCodBar_Leave(object sender, EventArgs e)
        {
            if (txtCodBar.Text.Length > 0)
            {
                produto = Produto.ObterPorId(txtCodBar.Text);
                txtDescricao.Text = produto.descricao;
                txtValorUnit.Text = produto.ValorUnit.ToString();
                txtValorUnit.ReadOnly = true;
                txtQuant.Focus();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemPedido item = new(
                int.Parse(txtIdPedido.Text),
                produto,
                produto.ValorUnit,
                double.Parse(txtQuant.Text),
                double.Parse(txtDescontoItem.Text)
                );
            produto = new();
            txtDescontoItem.Text = "0";
            txtDescricao.Clear();
            txtValorUnit.Text = "0";
            txtQuant.Text = "1";
            txtCodBar.Clear();
            txtCodBar.Focus();

            PreencherGridItens();
        }

        private void PreencherGridItens()
        {
            var itens = ItemPedido.ObterListaPorPedido(int.Parse(txtIdPedido.Text));
            dgvItensPedido.Rows.Clear();
            int cont = 0;
            foreach (var item in itens)
            {
                dgvItensPedido.Rows[cont].Cells[0].Value = item.Id;
                dgvItensPedido.Rows[cont].Cells[1].Value = item.Produto.CodBar;
                dgvItensPedido.Rows[cont].Cells[2].Value = item.Produto.descricao;
                dgvItensPedido.Rows[cont].Cells[3].Value = item.ValorUnit;
                dgvItensPedido.Rows[cont].Cells[4].Value = item.Quantidade;
                dgvItensPedido.Rows[cont].Cells[5].Value = item.Desconto;
                dgvItensPedido.Rows[cont].Cells[6].Value = item.ValorUnit * item.Quantidade - item.Desconto;
                cont++;
            }
        }
    }
}
