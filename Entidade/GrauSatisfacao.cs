using System.Collections.Generic;

namespace Entidade
{
    public class GrauSatisfacao { 

        #region Atributos

        public static List<GrauSatisfacao> lstGrauSatisfacao = new List<GrauSatisfacao>();

        #endregion Atributos

        #region Propriedades

        public int Id { get; set; }
        public string Descricao { get; set; }
        
        #endregion Propriedades

        #region Métodos

        public void addGrausatisfacao()
        {
            lstGrauSatisfacao.Add(this);
        }

        public List<GrauSatisfacao> getAll()
        {
            return lstGrauSatisfacao;
        }

        public override string ToString()
        {
            return "Id: " + this.Id
                + "\nDescrição: " + this.Descricao;
        }

        #endregion Métodos
    }
}