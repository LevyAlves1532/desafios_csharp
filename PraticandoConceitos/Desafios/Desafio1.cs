namespace PraticandoConceitos.Desafios;

internal class Desafio1
{
    public static void Execute()
    {
        while (true)
        {
            Console.WriteLine("Qual é o seu nome?");

            string? nome = Console.ReadLine();

            Console.WriteLine();

            if (nome != null && nome.Trim() != "")
            {
                Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
                break;
            }
            else
            {
                Console.WriteLine("Você não informou o seu nome!");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
