using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Aluno
    {
        private string nome;
        private int idade;
        private string matricula;
        private double p1, p2;

        public double CalcularMedia()
        {
            return (this.p1 + this.p2) / 2;
        }

       
        // Nome
        public void DefinirNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }

        // Idade
        public void DefinirIdade(int idade)
        {
            this.idade = idade;
        }

        public int GetIdade()
        {
            return this.idade;
        }

        // Matricula
        public void DefinirMatricula(string matricula)
        {
            this.matricula = matricula;
        }

        public string GetMatricula()
        {
            return this.matricula;
        }

        // P1
        public void DefinirP1(double p1)
        {
            this.p1 = p1;
        }

        public double GetP1()
        {
            return this.p1;
        }

        // P2
        public void DefinirP2(double p2)
        {
            this.p2 = p2;
        }

        public double GetP2()
        {
            return this.p2;
        }
    }
}
