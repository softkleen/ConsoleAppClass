using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass
{
    class Program
    {
        static void Main(string[] args)
        {   // lista de alunos - com a classe List<Aluno>
            List<Aluno> lista = new List<Aluno>();

           
            Console.WriteLine("Digite o nome de aluno:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o cpf de aluno:");
            string cpf = Console.ReadLine();
            Console.WriteLine("Digite o sexo de aluno:");
            string sexo = Console.ReadLine();
            Console.WriteLine("Digite o email de aluno:");
            string email = Console.ReadLine();
            Console.WriteLine("Digite a telefone de aluno:");
            string telefone = Console.ReadLine();
             Aluno a = new Aluno(nome,cpf,sexo,email,telefone);
            a.Inserir();// verificar se foi gravado...
            Console.WriteLine("----------Gravando...---------");
            if (a.Id > 0)
            {
                Console.WriteLine("Aluno gravado com sucesso, com o ID: {0}", a.Id);
            }
            else
            {
                Console.WriteLine("Falha ao grvar o aluno...");
            }
            lista = a.ListarAlunos();
            foreach (var aluno in lista)
            {
                Console.WriteLine("Aluno ->id: {2} nome: {0}, email: {1}, Telefone: {3}",
                    aluno.Nome, aluno.Email, aluno.Id,aluno.Telefone);
            }



            Console.ReadKey();
        }
    }
}
