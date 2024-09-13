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
    public partial class FrmEstoque : Form
    {
        Estoque estoque;
        Produto produto;
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void btnAdicionarEstoque_Click(object sender, EventArgs e)
        {
            Estoque estoque = new(
            int.Parse(txtProduto_IdEstoque.Text),
            double.Parse(txtQuantidadeEstoque.Text)
            );
            estoque.Inserir();
            if (estoque.Produto_Id > 0)
            {
                MessageBox.Show($"Estoque do Produto com o ID {estoque.Produto_Id} Inserido com Sucesso!!");
                txtProduto_IdEstoque.Clear();
                txtQuantidadeEstoque.Clear();
                txtNomeProdutoEstoque.Clear();
                txtConsultaEstoque.Clear();
            }
            else
            {
                MessageBox.Show($"Falha Ao Inserir Estoque do Produto com o ID {estoque.Produto_Id}!!");
            }
        }
        private void txtProduto_IdEstoque_Leave(object sender, EventArgs e)
        {
            /*if (txtProduto_IdEstoque.TextLength > 0)
            {
                estoque = Estoque.ObterPorID(Convert.ToInt32(txtProduto_IdEstoque.Text));
                txtNomeProdutoEstoque.Text = produto.Descricao;
            }*/
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            txtProduto_IdEstoque.Focus();
            CarregaGrid();
        }
        private void CarregaGrid(string? id = "")
        {
            /*var lista = Estoque.ObterProdutoPorLista(id);
            dgvEstoque.Rows.Clear();
            int cont = 0;
            foreach (var item in lista)
            {
                dgvEstoque.Rows.Add();
                dgvEstoque.Rows[cont].Cells[0].Value = item.Produto_Id;
                dgvEstoque.Rows[cont].Cells[1].Value = produto.Descricao;
                dgvEstoque.Rows[cont].Cells[2].Value = item.Quantidade;
                dgvEstoque.Rows[cont].Cells[3].Value = item.Data_Ultimo_Movimento;
                cont++;
            }*/
        }
        private void txtConsultaEstoque_TextChanged(object sender, EventArgs e)
        {
            /*if (txtConsultaEstoque.Text.Length > 0 )
            {
                CarregaGrid(txtConsultaEstoque.Text);
            }
            else
            {
                CarregaGrid();
            }*/
        }
    }
}
