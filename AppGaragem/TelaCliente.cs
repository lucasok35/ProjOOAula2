using Dados;
using Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppGaragem
{
    public partial class TelaCliente : Form
    {

        private static List<Cliente> lstCliente = new List<Cliente>();
        public TelaCliente()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                Id = int.Parse(txtId.Text),
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text
            };

            //salvar
            lstCliente.Add(cliente);
            saveCliente(cliente);


            LimparCampos();

        }

        public void saveCliente(Cliente cliente)
        {
            if (new ClienteDB().Insert(cliente)) {
                MessageBox.Show("Registro Inserido na base de dados!");
            }
            else
            {
                MessageBox.Show("Erro ao inserir registro na base de dados!");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lstCliente.Clear();
            LimparCampos();
            MessageBox.Show("Registros Excluídos com Sucesso!", "Informação!");
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            string msg = "";

            //listar clientes
            foreach (var item in lstCliente)
            {
                msg = msg + item;
            }

            MessageBox.Show(msg, "Dados");
        }
        
        private void LimparCampos()
        {

            //limpar campos
            txtId.Clear();
            txtNome.Clear();
            txtTelefone.Clear();

            //inserir foco no campo id
            txtId.Focus();

        }
    }

 }
