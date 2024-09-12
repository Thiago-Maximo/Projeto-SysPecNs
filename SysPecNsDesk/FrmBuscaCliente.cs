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
    public partial class FrmBuscaCliente : Form
    {
        public FrmBuscaCliente()
        {
            InitializeComponent();
        }
        private void CarregaGridBuscaCliente(string? nome = "")
        {
            var lista = Cliente.ObterPorLista(nome);
            dgvBuscaClientes.Rows.Clear();
            int cont = 0;
            foreach (var cliente in lista)
            {
                dgvBuscaClientes.Rows.Add();
                dgvBuscaClientes.Rows[cont].Cells[0].Value = cliente.Id;
                dgvBuscaClientes.Rows[cont].Cells[1].Value = cliente.Nome;
                dgvBuscaClientes.Rows[cont].Cells[2].Value = cliente.Cpf;
                dgvBuscaClientes.Rows[cont].Cells[3].Value = cliente.Telefone;
                dgvBuscaClientes.Rows[cont].Cells[4].Value = cliente.Email;
                dgvBuscaClientes.Rows[cont].Cells[5].Value = cliente.DataNasc;
                dgvBuscaClientes.Rows[cont].Cells[6].Value = cliente.DataCad;
                dgvBuscaClientes.Rows[cont].Cells[7].Value = cliente.Ativo;
                cont++;
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

        private void FrmBuscaCliente_Load(object sender, EventArgs e)
        {
            CarregaGridBuscaCliente();
        }
    }
}
