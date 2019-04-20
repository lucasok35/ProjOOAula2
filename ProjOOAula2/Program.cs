using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario funcionario = new Funcionario()
            {

                Id = 1,
                Nome = "André",
                Salario = 10,
                Telefone = "(16) 1234-5678"


            };

            Console.WriteLine(funcionario);
            Console.ReadKey();

        }
    }
}

