using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowned_Gym
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
        public string Endereco { get; set; }

        public string Senha { get; set; }

        public Aluno(string nome, string cPF, string email, string telefone, int idade, string sexo, float altura, float peso, string endereco, string senha)
        {
            Nome = nome;
            CPF = cPF;
            Email = email;
            Telefone = telefone;
            Idade = idade;
            Sexo = sexo;
            Altura = altura;
            Peso = peso;
            Endereco = endereco;
            Senha = senha;
        }
    }
}
