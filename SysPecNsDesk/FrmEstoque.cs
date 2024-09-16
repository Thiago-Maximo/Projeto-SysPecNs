using SysPecNSLib;
using System;
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

        // Evento do botão de consulta
        private void btnConsultaProduto_Click(object sender, EventArgs e)
        {
            // Instancia o formulário de busca
            FrmBuscaProduto frmBuscaProduto = new FrmBuscaProduto();

            // Mostra o formulário de busca como modal
            if (frmBuscaProduto.ShowDialog() == DialogResult.OK)
            {
                // Recebe os dados retornados pela seleção
                string[] dadosProduto = frmBuscaProduto.ObterDadosLinhaSelecionada();

                // Preenche os TextBoxs com as informações retornadas
                if (dadosProduto != null)
                {
                    txtProduto_IdEstoque.Text = dadosProduto[0]; // ID do Produto
                    txtNomeProdutoEstoque.Text = dadosProduto[1]; // Descrição do Produto
                }
            }
        }

        private void btnAdicionarEstoque_Click(object sender, EventArgs e)
        {
            if (txtQuantidadeEstoque.Text == string.Empty && txtProduto_IdEstoque.Text == string.Empty)
            {
                MessageBox.Show("Os Campos Estão Vazios, Por Favor Inserir os Dados");
            }
            else
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
                    CarregaGrid();
                }
                else
                {
                    MessageBox.Show($"Falha Ao Inserir Estoque do Produto com o ID {estoque.Produto_Id}!!");
                    CarregaGrid();
                }
            }
            
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            txtProduto_IdEstoque.Focus();
            CarregaGrid();
        }

        private void CarregaGrid(string? id = "")
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