﻿using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {           
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

           while (opcaoUsuario.ToUpper() != "X")
           {
               switch(opcaoUsuario)
               {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("Informe a nota do aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota dever ser decimal.");
                        }
                        alunos[indiceAluno] = aluno;
                        indiceAluno ++;
                        break;
                    case "2":
                        foreach(Aluno a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}.");
                            }                            
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        int nrAlunos = 0;
                        for (int i=0; i < alunos.Length;i++)
                        {
                              if(!string.IsNullOrEmpty(alunos[i].Nome))
                              {
                              notaTotal = notaTotal + alunos[i].Nota;
                              nrAlunos++;
                             }
                        }
                        
                        decimal mediaGeral = notaTotal / nrAlunos;
                        ConceitoEnum conceitoGeral;

                        if(mediaGeral < 2)
                        {
                            conceitoGeral = ConceitoEnum.E;
                        }
                        else if(mediaGeral < 4)
                        {
                            conceitoGeral = ConceitoEnum.D;
                        }
                        else if (mediaGeral < 6)
                        {
                            conceitoGeral = ConceitoEnum.C;
                        }
                        else if(mediaGeral < 8)
                        {
                            conceitoGeral = ConceitoEnum.B;
                        }
                        else
                        {
                            conceitoGeral = ConceitoEnum.A;
                        }

                        Console.WriteLine($"MÉdia Geral: {mediaGeral} - Conceito: {conceitoGeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();                    
               }

               opcaoUsuario = ObterOpcaoUsuario();
           }

        }

        private static string ObterOpcaoUsuario()
        {
                Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("1 - Inserir novo aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Calcular média geral");
                Console.WriteLine("X - Sair");
                Console.WriteLine();

                string opcaoUsuario =  Console.ReadLine();

                Console.WriteLine();

                return opcaoUsuario;
        }
    }
}
