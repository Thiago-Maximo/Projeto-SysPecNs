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
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtRazaoSocial.Text.Length > 0)
            {
                btnAdicionar.Enabled = true;
            }
            Fornecedor fornecedor = new(
                txtRazaoSocial.Text,
                txtNomeFantasia.Text,
                txtCnpj.Text,
                txtContatoFornecedor.Text,
                txtTelefoneFornecedor.Text,
                txtEmailFornecedor.Text,
                Fornecedor.ObterPorID(Convert.ToInt32(cmbCategoriaFornecedor.SelectedValue))
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
            }
        }

        private void CadFornecedores_Click(object sender, EventArgs e)
        {

        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            CarregaGrid();

            //carregando o combox de categoria
            var fornecedor = Categoria.ObterLista();
            cmbCategoriaFornecedor.DataSource = fornecedor;
            cmbCategoriaFornecedor.DisplayMember = "Nome";
            cmbCategoriaFornecedor.ValueMember = "Id";
        }
        private void CarregaGrid(string Razao_Social = "")
        {
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
                dgvFornecedor.Rows[cont].Cells[7].Value = fornecedor.Categoria;
                cont++;
            }
        }

        private void txtBuscaFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaFornecedor.Text.Length > 0)
            {
                CarregaGrid(txtBuscaFornecedor.Text);

            }
            else
            {
                CarregaGrid();
            }
        }
    }
}
