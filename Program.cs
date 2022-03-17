using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno Igor, Vitor, Giovanni, Elder;

            Igor = new Aluno();
            Igor.DefinirNome("Igor");
            Igor.DefinirIdade(20);
            Igor.DefinirMatricula("00001");
            Igor.DefinirP1(9.8);
            Igor.DefinirP2(1.4);


            Console.WriteLine("Nome:"  + Igor.GetNome() + "\n" + 
                              "Idade:" + Igor.GetIdade() + "\n" + 
                              "Matricula:" + Igor.GetMatricula() + "\n" + 
                              "N1:" + Igor.GetP1() + "\n" +
                              "N2:" + Igor.GetP2() + "\n" + 
                              "Média:" + Igor.CalcularMedia()+ "\n");


            Vitor = new Aluno();
            Giovanni = new Aluno();
            Elder = new Aluno();
        }
    }
}
