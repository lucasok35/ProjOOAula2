using Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Dados
{
    public class MotorDB
    {

        private Conexao conexao;
        public List<Motor> ListarMotor()
        {
            using (conexao = new Conexao())
            {
                var sql = "SELECT Descricao FROM TB_MOTOR";
                var retorno = conexao.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Motor> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listMotor = new List<Motor>();

            while (retorno.Read())
            {
                var item = new Motor()
                {
                    
                    Descricao = retorno["Descricao"].ToString(),
                    
                };

                listMotor.Add(item);
            }
            return listMotor;
        }
    }
}
