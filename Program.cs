using System;

namespace revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            aluno[] alunos = new aluno[5];
            int ialunos = 0;
            string userOption = getUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");
                        aluno aluno = new aluno();
                        aluno.nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno: ");
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.nota = nota;
                        }
                        else{
                            throw new ArgumentException("valor da nota deve ser decimal");
                        }     
                        alunos[ialunos] = aluno;
                        ialunos++;        

                        break;
                    case "2":
                        foreach(var a in alunos){
                          if (a.nome != null){  
                            Console.WriteLine($"Aluno: {a.nome} - Nota: {a.nota} ");
                          }
                        }

                        break;
                    case "3":

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                }

                userOption = getUserOption();
            }
        }

        private static string getUserOption()
        {
            Console.WriteLine("Informe o que tu quer: ");
            Console.WriteLine("1- Inserir aluno: ");
            Console.WriteLine("2- Listar Alunos:  ");
            Console.WriteLine("3- Calcular media da turma: ");
            Console.WriteLine("X- Sair ");
            Console.WriteLine();

            string userOption = Console.ReadLine();

            Console.WriteLine();
            return userOption;
        }
    }
}
