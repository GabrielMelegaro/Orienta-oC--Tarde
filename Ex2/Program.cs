using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] QuantidadedeAlunos = 
            bool repetir = false;
            do{
                System.Console.WriteLine("Welcome to SENAIzinho, choose one of the options below:");
                System.Console.WriteLine("1 - Register students");
                System.Console.WriteLine("2 - Register classroom");
                System.Console.WriteLine("3 - Alocate students");
                System.Console.WriteLine("4 - Remove students");
                System.Console.WriteLine("5 - Verifying classroom");
                System.Console.WriteLine("6 - Verifying students");
                System.Console.WriteLine("0 - Leave");

                int opção = int.Parse(Console.ReadLine());

                switch(opção){
                    case 1:
                    Alunos aluno1 = new Alunos();
                    System.Console.Write("Enter your full name:");
                    aluno1.nome = Console.ReadLine();            
                    
                    System.Console.Write("Enter your date of birth:");
                    aluno1.dataNascimento = DateTime.Parse(Console.ReadLine());
                    break;
                }
            }while (repetir = false);{

            }    
        }
    }
}
