using SysPecNSLib;
using System;
using System.Windows.Forms;

namespace SysPecNsDesk
{
    public partial class FrmBuscaProduto : Form
    {
        public FrmBuscaProduto()
        {
            InitializeComponent();
        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Produto.ObterPorlista();
            dgvProdutos.Rows.Clear();
            int cont = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[cont].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[cont].Cells[1].Value = produto.CodBar;
                dgvProdutos.Rows[cont].Cells[2].Value = produto.ValorUnit;
                dgvProdutos.Rows[cont].Cells[3].Value = produto.UnidadeVenda;
                dgvProdutos.Rows[cont].Cells[4].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[cont].Cells[5].Value = produto.estoqueMinimo;
                dgvProdutos.Rows[cont].Cells[6].Value = produto.ClasseDesconto;
                dgvProdutos.Rows[cont].Cells[7].Value = produto.DataCad;
                dgvProdutos.Rows[cont].Cells[8].Value = produto.Descricao;
                cont++;
            }
        }

        private void FrmBuscaProduto_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            CarregaGridQuantidade();
        }

        // Método para pegar os dados da linha selecionada
        public string[] ObterDadosLinhaSelecionada()
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dgvProdutos.SelectedRows[0];
                string[] dados = new string[2];
                dados[0] = linhaSelecionada.Cells[0].Value?.ToString(); // ID do Produto
                dados[1] = linhaSelecionada.Cells[8].Value?.ToString(); // Descrição do Produto

                return dados;
            }
            else
            {
                return null;
            }
        }

        // Evento do duplo clique na célula do DataGridView


        private void dgvProdutos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Define o DialogResult como OK quando o usuário faz duplo clique
            this.DialogResult = DialogResult.OK;

            // Fecha o formulário para retornar o controle para o FrmEstoque
            this.Close();
        }

        private void CarregaGridQuantidade(string? id = "")
        {
            var lista = Estoque.ObterPorLista();
            dgvEstoque.Rows.Clear();
            int cont = 0;
            foreach (var item in lista)
            {
                dgvEstoque.Rows.Add();
                dgvEstoque.Rows[cont].Cells[0].Value = item.Produto_Id;
                dgvEstoque.Rows[cont].Cells[1].Value = item.Quantidade;
                dgvEstoque.Rows[cont].Cells[2].Value = item.Data_Ultimo_Movimento;
                cont++;
            }
        }
    }
}