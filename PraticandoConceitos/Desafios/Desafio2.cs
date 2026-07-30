namespace PraticandoConceitos.Desafios;

internal class Desafio2
{
    public static void Execute()
    {
        while (true)
        {

            string nome = Utilidades.Pergunta("1. Qual é o seu nome?");

            Console.WriteLine();

            string sobrenome = Utilidades.Pergunta("2. Qual é o seu sobrenome?");

            Console.WriteLine();

            if (Utilidades.VerificaTextoVazio(nome))
            {
                Console.WriteLine("O nome deve ser preenchido!");
                Console.WriteLine();
                continue;
            }

            if (Utilidades.VerificaTextoVazio(sobrenome))
            {
                Console.WriteLine("O sobrenome deve ser preenchido!");
                Console.WriteLine();
                continue;
            }

            Console.WriteLine("Seu nome + sobrenome completo é:");
            Console.WriteLine(nome + " " + sobrenome);
            break;
        }
    }
}
