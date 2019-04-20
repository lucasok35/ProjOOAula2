using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class TesteGrauSatisfacao
    {
        public static void Main (string []args)
        {
            Console.WriteLine("Teste Proj Grau Satisfação");

            GrauSatisfacao gf1 = new GrauSatisfacao()
            {
                Id = 1,
                Descricao = "Ruim"

            };

            GrauSatisfacao gf2 = new GrauSatisfacao()
            {
                Id = 2,
                Descricao = "Bom"

            };

            GrauSatisfacao gf3 = new GrauSatisfacao()
            {
                Id = 3,
                Descricao = "Muito Bom"

            };

            //inserir grau de satisfação
            gf1.addGrausatisfacao();
            gf2.addGrausatisfacao();
            gf3.addGrausatisfacao();

            foreach (var item in gf1.getAll())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
