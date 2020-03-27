using System;


namespace ExfixacaoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados: ");
            int quantidadeQuartos = int.Parse(Console.ReadLine());

            Hospede[] hospede = new Hospede[9];

            for (int i=0; i < quantidadeQuartos; i++)
            {
                int j = i + 1;
                Console.WriteLine("Hospede " + j +":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                hospede[quarto] = new Hospede { Email = email, Nome = nome };

                Console.WriteLine(); 

            }


            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < hospede.Length; i++)
            {
                if (hospede[i] != null)
                {
                    Console.WriteLine(i + ": " + hospede[i].ToString());
                    Console.WriteLine();
                }

            }

        }
    }
}
