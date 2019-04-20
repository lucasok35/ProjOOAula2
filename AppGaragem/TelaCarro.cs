using Entidade;
using Dados;
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
    public partial class TelaCarro : Form
    {
        private static List<Carro> lstCarro = new List<Carro>();

        public TelaCarro()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro()
            {
                Id = int.Parse(txtId.Text),
                Nome = txtNome.Text,
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                //AnoModelo = int.Parse(txtAnoModelo.Text),
                //Cor = txtCor.Text,
                //AnoFab = int.Parse(txtAnoFab.Text),
                motor = new Entidade.Motor{ Id = Convert.ToInt32(cboMotor.SelectedValue) }

            };

            //salvar
            lstCarro.Add(carro);
            saveCarro(carro);


            LimparCampos();
        }

        public void saveCarro(Carro carro)
        {
            if (new CarroDB().Insert(carro))
            {
                MessageBox.Show("Registro inserido com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao inserir registro!");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lstCarro.Clear();
            LimparCampos();
            MessageBox.Show("Registros Excluídos com Sucesso!", "Informação!");
        }



        private void BtnListar_Click(object sender, EventArgs e)
        {
            string msg = "";

            foreach(var item in lstCarro)
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
            txtMarca.Clear();
            txtModelo.Clear();

            //inserir foco no campo id
            txtId.Focus();

        }

        private void CboMotor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TelaCarro_Load(object sender, EventArgs e)
        {
            cboMotor.DataSource = new MotorDB().ListarMotor();
            cboMotor.DisplayMember = "Descricao";
            cboMotor.ValueMember = "Id";
        }
    }
}
