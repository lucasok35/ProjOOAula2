using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Utils;
using System.Data.SqlClient;

namespace Dados
{
    public class ClienteDB
    {

        private StringBuilder sb;
        private Conexao conexao;
        public bool Insert(Cliente cliente)
        {
            try
            {
                sb = new StringBuilder();

                sb.Append("INSERT INTO TB_CLIENTE (nome, telefone) VALUES ");
                sb.Append(string.Format("('{0}', '{1}')", cliente.Nome, cliente.Telefone));

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

        public List<Cliente> ListarCliente()
        {
            using (conexao = new Conexao())
            {
                var sql = "SELECT codigo, nome, telefone FROM TB_CLIENTE";
                var retorno = conexao.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Cliente> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listCliente = new List<Cliente>();

            while (retorno.Read())
            {
                var item = new Cliente()
                {
                    Id = Convert.ToInt32(retorno["codigo"]),
                    Nome = retorno["nome"].ToString(),
                    Telefone = retorno["telefone"].ToString(),
                };

                listCliente.Add(item);
            }
            return listCliente;
        }

    }
}
