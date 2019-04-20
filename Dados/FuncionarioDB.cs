using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Dados
{
    public class FuncionarioDB
    {
        private StringBuilder sb;
        private Conexao conexao;
        public bool Insert(Funcionario funcionario)
        {
            try
            {
                sb = new StringBuilder();

                sb.Append("INSERT INTO TB_FUNCIONARIO (nome, telefone, salario) VALUES ");
                sb.Append(string.Format("('{0}', '{1}', {2})", funcionario.Nome, funcionario.Telefone, funcionario.Salario));

                using (conexao = new Conexao())
                {
                    conexao.ExecutaComando(sb.ToString());
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }


        }
    }
}
