using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNsDesk
{
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
            txtRazaoSocial.Focus();
        }

        //Inserção,Alteração e Consulta de Fornecedores, 

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Inserindo Fornecedores

            Fornecedor fornecedor = new(
                txtRazaoSocial.Text,
                txtNomeFantasia.Text,
                txtCnpj.Text,
                txtContatoFornecedor.Text,
                txtTelefoneFornecedor.Text,
                txtEmailFornecedor.Text
                );
            fornecedor.Inserir();
            if (fornecedor.Id > 0)
            {
                txtIDFornecedor.Text = fornecedor.Id.ToString();
                MessageBox.Show($"O Fornecedor foi gravado com sucesso!!, com o ID {fornecedor.Id}");
                txtRazaoSocial.Clear();
                txtNomeFantasia.Clear();
                txtCnpj.Clear();
                txtContatoFornecedor.Clear();
                txtTelefoneFornecedor.Clear();
                txtEmailFornecedor.Clear();
                txtRazaoSocial.Focus();
                FrmFornecedores_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao Gravar Fornecedor!!");
                FrmFornecedores_Load(sender, e);
            }

        }
        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            //Quando o Formulário estiver sendo carregado ele irá fazer
            CarregaGrid();
        }
        private void CarregaGrid(string Razao_Social = "")
        {
            //dataGrid de exibição no cadastro de fornecedores

            var lista = Fornecedor.ObterPorLista(Razao_Social);
            dgvFornecedor.Rows.Clear();
            int cont = 0;
            foreach (var fornecedor in lista)
            {
                dgvFornecedor.Rows.Add();
                dgvFornecedor.Rows[cont].Cells[0].Value = fornecedor.Id;
                dgvFornecedor.Rows[cont].Cells[1].Value = fornecedor.Razao_Social;
                dgvFornecedor.Rows[cont].Cells[2].Value = fornecedor.Fantasia;
                dgvFornecedor.Rows[cont].Cells[3].Value = fornecedor.Cnpj;
                dgvFornecedor.Rows[cont].Cells[4].Value = fornecedor.Contato;
                dgvFornecedor.Rows[cont].Cells[5].Value = fornecedor.Telefone;
                dgvFornecedor.Rows[cont].Cells[6].Value = fornecedor.Email;
                cont++;
            }
        }

        private void txtBuscaFornecedor_TextChanged(object sender, EventArgs e)
        {
            //buscar por nome o fornecedor, na aba de inserção de fornecedores

            if (txtBuscaFornecedor.Text.Length > 0)
            {
                CarregaGrid(txtBuscaFornecedor.Text);

            }
            else
            {
                CarregaGrid();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Botão de consultar (Pesquisar para poder editar os dados)

            if (btnConsultar.Text == "&Consultar")
            {
                txtRazaoSocial.Clear();
                txtNomeFantasia.Clear();
                txtCnpj.Clear();
                txtContatoFornecedor.Clear();
                txtEmailFornecedor.Clear();
                txtTelefoneFornecedor.Clear();
                btnConsultar.Text = "&Obter Por ID";
                txtIDFornecedor.Focus();
                txtIDFornecedor.ReadOnly = false;
            }
            else if (txtIDFornecedor.Text.Length > 0)
            {
                Fornecedor fornecedor = Fornecedor.ObterPorID(int.Parse(txtIDFornecedor.Text));
                txtRazaoSocial.Text = fornecedor.Razao_Social;
                txtNomeFantasia.Text = fornecedor.Fantasia;
                txtContatoFornecedor.Text = fornecedor.Contato;
                txtTelefoneFornecedor.Text = fornecedor.Telefone;
                txtEmailFornecedor.Text = fornecedor.Email;
                txtCnpj.Text = fornecedor.Cnpj;
                btnEditar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Botão de editar os dados do fornecedor

            Fornecedor fornecedor = new(int.Parse(txtIDFornecedor.Text),
                txtRazaoSocial.Text,
                txtNomeFantasia.Text,
                txtCnpj.Text,
                txtContatoFornecedor.Text,
                txtTelefoneFornecedor.Text,
                txtEmailFornecedor.Text
                );
            fornecedor.Atualizar();
            MessageBox.Show($"O Fornecedor {fornecedor.Razao_Social}, Com o ID {fornecedor.Id} foi alterado com Sucesso!!");
            btnEditar.Enabled = false;
            txtIDFornecedor.ReadOnly = true;
            btnConsultar.Text = "&Consultar";
            LimpaControles();
            FrmFornecedores_Load(sender, e);
        }
        private void LimpaControles()
        {
            //limpando todos os campos do formulario de inserção de fornecedores

            txtIDFornecedor.Clear();
            txtRazaoSocial.Clear();
            txtNomeFantasia.Clear();
            txtCnpj.Clear();
            txtContatoFornecedor.Clear();
            txtTelefoneFornecedor.Clear();
            txtEmailFornecedor.Clear();
        }



        //Exibição da Lista de Fornecedores e com os produtos que eles fornecem 


        private void txtBuscafornecedorLista_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscafornecedorLista.Text.Length > 0)
            {
                CarregaGridBuscaFornecedor(txtBuscafornecedorLista.Text);

            }
            else
            {
                CarregaGridBuscaFornecedor();
            }
        }
        private void CarregaGridBuscaFornecedor(string Razao_Social = "")
        {
            var lista = Fornecedor.ObterPorLista(Razao_Social);
            dgvFornecedor.Rows.Clear();
            int cont = 0;
            foreach (var fornecedor in lista)
            {
                dgvBuscaFornecedor.Rows.Add();
                dgvBuscaFornecedor.Rows[cont].Cells[0].Value = fornecedor.Id;
                dgvBuscaFornecedor.Rows[cont].Cells[1].Value = fornecedor.Razao_Social;
                dgvBuscaFornecedor.Rows[cont].Cells[2].Value = fornecedor.Fantasia;
                dgvBuscaFornecedor.Rows[cont].Cells[3].Value = fornecedor.Cnpj;
                dgvBuscaFornecedor.Rows[cont].Cells[4].Value = fornecedor.Contato;
                dgvBuscaFornecedor.Rows[cont].Cells[5].Value = fornecedor.Telefone;
                dgvBuscaFornecedor.Rows[cont].Cells[6].Value = fornecedor.Email;
                cont++;
            }
        }
        /*private void CarregaGridBuscaProdutoFornecedor(int teste)
        {
            var lista = Produto.ObterPorlista();
            dgvBuscaProdutoFornecedor.Rows.Clear();
            int cont = 0;
            foreach (var fornecedor in lista)
            {
                dgvBuscaProdutoFornecedor.Rows[cont].Cells[0].Value = fornecedor.Id;
                dgvBuscaProdutoFornecedor.Rows[cont].Cells[1].Value = fornecedor.CodBar;
                dgvBuscaProdutoFornecedor.Rows[cont].Cells[2].Value = fornecedor.descricao;
                dgvBuscaProdutoFornecedor.Rows[cont].Cells[3].Value = fornecedor.ValorUnit;
                dgvBuscaProdutoFornecedor.Rows[cont].Cells[4].Value = fornecedor.UnidadeVenda;
                dgvBuscaProdutoFornecedor.Rows[cont].Cells[5].Value = fornecedor.Categoria;
                dgvBuscaProdutoFornecedor.Rows[cont].Cells[6].Value = fornecedor.estoqueMinimo;
                dgvBuscaProdutoFornecedor.Rows[cont].Cells[7].Value = fornecedor.ClasseDesconto;
                dgvBuscaProdutoFornecedor.Rows[cont].Cells[8].Value = fornecedor.DataCad;
            }
            
        }*/
        private void TabCtFornecedores_Selecting(object sender, TabControlCancelEventArgs e)
        {
            CarregaGridBuscaFornecedor();
        }

        /*private void dgvBuscaProdutoFornecedor_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }*/

        /*private void dgvBuscaFornecedor_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            int teste = Convert.ToInt32(dgvBuscaProdutoFornecedor.Rows[dgvBuscaProdutoFornecedor.CurrentRow.Index].Cells[0]);
            //CarregaGridBuscaProdutoFornecedor(teste);
        }*/
    }
}
