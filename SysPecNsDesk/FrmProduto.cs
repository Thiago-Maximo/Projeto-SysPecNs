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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }
        private void FrmProduto_Load(object sender, EventArgs e)
        {
            // carregando o combox de niveis
            var categoria = Categoria.ObterLista();
            cmbCategoria.DataSource = categoria;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";
            CarregaGrid();
        }
        private void CarregaGrid(string nome = "")
        {
            //preechendo o data grid com os usuarios cadastrados
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
                dgvProdutos.Rows[cont].Cells[8].Value = produto.descricao;
                cont++;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new(
                txtCodBarras.Text,
                txtDescricao.Text,
                double.Parse(txtValorUnit.Text),
                txtUnidadeVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (int)nmrEstoque.Value,
                double.Parse(txtDesconto.Text)
                );
            produto.Inserir();
            if (produto.Id > 0)
            {
                MessageBox.Show($"O Produto {produto.descricao}, com o ID {produto.Id}");
                FrmProduto_Load(sender, e);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                txtCodBarras.Clear();
                txtValorUnit.Clear();
                txtUnidadeVenda.Clear();
                txtDesconto.Clear();
                txtDescricao.Clear();
                nmrEstoque.Value = 0;
                btnConsultar.Text = "&Obter Por ID";
                txtID.Focus();
                txtID.ReadOnly = false;
            }
            else if (txtID.Text.Length > 0)
            {
                Produto produto = Produto.ObterPorId(int.Parse(txtID.Text));
                txtCodBarras.Text = produto.CodBar;
                txtValorUnit.Text = Convert.ToString(produto.ValorUnit);
                txtDescricao.Text = produto.descricao;
                txtDesconto.Text = produto.ClasseDesconto.ToString();
                txtUnidadeVenda.Text = produto.UnidadeVenda;
                //nmrEstoque.Value = produto.estoqueMinimo;
                cmbCategoria.SelectedIndex = cmbCategoria.FindString(produto.Categoria.Nome);
                btnEditar.Enabled = true;
            }
        }
        private void LimpaControles() 
        {
            txtID.Clear();
            txtCodBarras.Clear();
            txtValorUnit.Clear();
            txtUnidadeVenda.Clear();
            txtDesconto.Clear();
            txtDescricao.Clear();
            nmrEstoque.Value = 0;
            txtCodBarras.Focus();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new(int.Parse(txtID.Text),
                txtCodBarras.Text,
                txtDescricao.Text,
                double.Parse(txtValorUnit.Text),
                txtUnidadeVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (double)nmrEstoque.Value,
                double.Parse(txtDesconto.Text)
                );
            produto.Atualizar();
            MessageBox.Show($"Produto {produto.Id} - {produto.descricao} foi Atualizado com Sucesso!!!");
            btnEditar.Enabled = false;
            txtID.ReadOnly = true;
            btnConsultar.Text = "&Consultar";
            LimpaControles();
            FrmProduto_Load(sender, e);
        }
    }
}
