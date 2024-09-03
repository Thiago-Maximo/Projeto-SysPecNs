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
    }
}
