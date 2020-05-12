using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //biblioteca de classes manipular conexao mysql
// instalar conector mysql a partir do site.
namespace ConsoleAppClass
{ //introdução a Orientação a Objetos. 
  // o que é um objeto? é uma instância da classe 
  // o que é classe?  - coleção de objetos do mesmo tipo
  //4 pilares da OO? Abstração, Encapsulamento, Herança, Polimorfismo
  // get set
  // Nome = Precisa ter a primeira letra maiúscula
  // Atributos = características do objeto // propriedades
  // Métodos = Comportamentos da classe
        
    public class Aluno // da nossa escola de música
    {
        //atributo
        private int id;
        private string nome;
        private string cpf;
        private string sexo;
        private string email;
        private string telefone;


        //métodos construtores
        public Aluno()
        {
 
        }

        public Aluno(int id, string nome, string cpf, string sexo, string email, string telefone)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.sexo = sexo;
            this.email = email;
            this.telefone = telefone;
        }

        public Aluno(string nome, string cpf, string sexo, string email, string telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.sexo = sexo;
            this.email = email;
            this.telefone = telefone;
        }



        // criar as propriedades (método e acesso)
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }

  

        // métodos...
        public List<Aluno> ListarAlunos() 
        {
            List<Aluno> listAluno = new List<Aluno>();
            MySqlCommand comando = Banco.Abrir();
            comando.CommandText = "select * from tb_aluno";
            MySqlDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())// lê o proximo registro da consulta...
            {
                listAluno.Add(new Aluno(
                 leitor.GetInt32(0),
                 leitor.GetString(1),
                 leitor.GetString(2),
                 leitor.GetString(3),
                 leitor.GetString(4),
                 leitor.GetString(5)
                 ));
            }
            return listAluno;
        }
        public void Inserir()
        {
            MySqlCommand comando = Banco.Abrir();
            try
            {
                comando.CommandText = "insert tb_aluno values (0,'"+Nome
                    +"','"+Cpf+"','"+Sexo+"','"+Email+"','"+Telefone+"')";
                comando.ExecuteNonQuery();//executa o comando no banco na tabela
                comando.CommandText = "select @@identity"; //o último id inserido
                Id = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch (Exception)
            {
                Id = 0;
            }

        }
    }
}
