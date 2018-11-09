using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter file_text = File.CreateText("resultados.txt");

            int idade_total = 0, idade, num_alunos;

            Console.Write("Quantos alunos tem a turma: ");
            num_alunos = int.Parse(Console.ReadLine());

            int[] lista_de_idades;
            lista_de_idades = new int[num_alunos];

            for (int x = 0; x < num_alunos; x++)
            {
                Console.Write("\t\t - Insira a idade do {0}º aluno: ", x+1);
                idade = int.Parse(Console.ReadLine());

                lista_de_idades[x] = idade;

                idade_total += idade;
            }
            
            //calculo das idades
            Console.WriteLine("\nIdade mais alta: {0}", lista_de_idades.Max());
            file_text.WriteLine("Idade mais alta: {0}", lista_de_idades.Max());

            Console.WriteLine("Idade mais baixa: {0}", lista_de_idades.Min());
            file_text.WriteLine("Idade mais baixa: {0}", lista_de_idades.Min());

            Console.WriteLine("Média das idades: {0}", idade_total / num_alunos);
            file_text.WriteLine("Média das idades: {0}", idade_total / num_alunos);

            file_text.Close();
            Console.ReadKey();
        }
    }
}