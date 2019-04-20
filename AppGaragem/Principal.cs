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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void CarroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaCarro cadastroCarro = new TelaCarro();
            cadastroCarro.MdiParent = this;
            cadastroCarro.Show();
        }

        private void ClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaCliente cadastroCliente = new TelaCliente();
            cadastroCliente.MdiParent = this;
            cadastroCliente.Show();
        }

        private void FuncionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaFuncionario cadastroFuncionario = new TelaFuncionario();
            cadastroFuncionario.MdiParent = this;
            cadastroFuncionario.Show();
        }

        private void GaragemToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaGaragem cadastroGaragem = new TelaGaragem();
            cadastroGaragem.MdiParent = this;
            cadastroGaragem.Show();
        }

        private void MotorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaMotor cadastroMotor = new TelaMotor();
            cadastroMotor.MdiParent = this;
            cadastroMotor.Show();
        }

        private void AtendimentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaAtendimento cadastroAtendimento = new TelaAtendimento();
            cadastroAtendimento.MdiParent = this;
            cadastroAtendimento.Show();
        }

        private void ExitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaCliente consultaCliente = new ConsultaCliente();
            consultaCliente.MdiParent = this;
            consultaCliente.Show();
        }
    }
}
