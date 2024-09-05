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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
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
            txtIDFornecedor.Clear();
                txtRazaoSocial.Clear();
                txtNomeFantasia.Clear();
                txtCnpj.Clear();
                txtContatoFornecedor.Clear();
                txtTelefoneFornecedor.Clear();
                txtEmailFornecedor.Clear();
        }
    }
}
