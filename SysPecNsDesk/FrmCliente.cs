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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            CarregaGridBuscaClienteEndereco();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new(
                txtNome.Text,
                txtCpf.Text,
                txtTelefone.Text,
                txtEmail.Text,
                dateTimePicker1.Value
                );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                txtId.Text = cliente.Id.ToString();
                MessageBox.Show($"O Usuario {cliente.Nome}, foi gravado " +
                    $"com sucesso, com o ID {cliente.Id}");
                txtId.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
                txtCpf.Clear();
                txtNome.Focus();
                FrmCliente_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Falha ao Grava Usuario!");
            }
        }
        private bool VerificandoControles()
        {
            if (txtNome.Text != string.Empty ||
                txtEmail.Text != string.Empty ||
                txtTelefone.Text != string.Empty ||
                txtCpf.Text != string.Empty
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (VerificandoControles())
            {
                var msg = MessageBox.Show("Deseja continuar o cadastro?",
                    "Confirmação de saída",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                if (msg == DialogResult.No) this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void CadEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarEndereco_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                var msg = MessageBox.Show("Deseja continuar o cadastro?",
                    "Confirmação de saída",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                if (msg == DialogResult.No) this.Close();
            }
            else { this.Close(); }
        }
        private bool VerificaControles()
        {
            if (txtIDEndereco.Text != string.Empty ||
                txtIDCliente.Text != string.Empty ||
                txtLogradouro.Text != string.Empty ||
                txtCidade.Text != string.Empty ||
                txtCep.Text != string.Empty ||
                txtBairro.Text != string.Empty ||
                txtTipoEndereco.Text != string.Empty ||
                txtUf.Text != string.Empty
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnInserirEndereco_Click(object sender, EventArgs e)
        {
            Endereco endereco = new(
                Convert.ToInt32(txtIDCliente.Text),
                txtCep.Text,
                txtLogradouro.Text,
                txtNumeroEndereco.Text,
                txtComplemento.Text,
                txtBairro.Text,
                txtCidade.Text,
                txtUf.Text,
                txtTipoEndereco.Text
                );
            endereco.Inserir();
            if (endereco.Id > 0)
            {
                //txtId.Text = cliente.Id.ToString();
                MessageBox.Show($"O Endereço foi gravado " +
                    $"com sucesso, com o ID {endereco.Id}");
                txtIDCliente.Clear();
                txtCep.Clear();
                txtLogradouro.Clear();
                txtNumeroEndereco.Clear();
                txtComplemento.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtUf.Clear();
                txtTipoEndereco.Clear();
                txtIDCliente.Focus();
                FrmCliente_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao Grava Endereço!");
            }
        }

        private void txtIDEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscaCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaCliente.Text.Length > 0)
            {
                CarregaGrid(txtBuscaCliente.Text);
            }
            else
            {
                CarregaGrid();
            }
        }
        private void CarregaGrid(string? nome = "")
        {
            var lista = Cliente.ObterPorLista(nome);
            dgvClientes.Rows.Clear();
            int cont = 0;
            foreach (var cliente in lista)
            {
                dgvClientes.Rows.Add();
                dgvClientes.Rows[cont].Cells[0].Value = cliente.Id;
                dgvClientes.Rows[cont].Cells[1].Value = cliente.Nome;
                dgvClientes.Rows[cont].Cells[2].Value = cliente.Cpf;
                dgvClientes.Rows[cont].Cells[3].Value = cliente.Telefone;
                dgvClientes.Rows[cont].Cells[4].Value = cliente.Email;
                dgvClientes.Rows[cont].Cells[5].Value = cliente.DataNasc;
                dgvClientes.Rows[cont].Cells[6].Value = cliente.DataCad;
                dgvClientes.Rows[cont].Cells[7].Value = cliente.Ativo;
                cont++;
            }
        }
        private void txtBuscaEndereco_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaEndereco.Text.Length > 0)
            {
                CarregaGridBuscaClienteEndereco(txtBuscaEndereco.Text);
            }
            else
            {
                CarregaGridBuscaClienteEndereco();
            }
        }
        private void CarregaGridBuscaClienteEndereco(string? nome = "")
        {
            var lista = Endereco.ObterPorLista(nome);
            dgvBuscaClientes.Rows.Clear();
            int cont = 0;
            foreach (var endereco in lista)
            {
                dgvBuscaClientes.Rows.Add();
                dgvBuscaClientes.Rows[cont].Cells[0].Value = endereco.ClienteId;
                dgvBuscaClientes.Rows[cont].Cells[1].Value = endereco.Cep;
                dgvBuscaClientes.Rows[cont].Cells[2].Value = endereco.Logradouro;
                dgvBuscaClientes.Rows[cont].Cells[3].Value = endereco.Numero;
                dgvBuscaClientes.Rows[cont].Cells[4].Value = endereco.Complemento;
                dgvBuscaClientes.Rows[cont].Cells[5].Value = endereco.Bairro;
                dgvBuscaClientes.Rows[cont].Cells[6].Value = endereco.Cidade;
                dgvBuscaClientes.Rows[cont].Cells[7].Value = endereco.Uf;
                dgvBuscaClientes.Rows[cont].Cells[7].Value = endereco.TipoEndereco;
                cont++;
            }
        }
    }
}