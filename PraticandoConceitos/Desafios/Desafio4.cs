namespace PraticandoConceitos.Desafios;

internal class Desafio4
{
    public static void Execute()
    {
        while (true)
        {
            Console.Write("Digite alguma coisa: ");
            string? texto = Console.ReadLine();

            Console.WriteLine();

            if (Utilidades.VerificaTextoVazio(texto))
            {
                Console.WriteLine("Você deve digitar alguma coisa");
                return;
            }

            int quantidadeCaracteres = texto.Trim().Length;
            Console.WriteLine($"O que você digitou tem {quantidadeCaracteres} caracteres");
            Console.WriteLine();

            bool decisao = Utilidades.PerguntaSimNao2("Você deseja continuar digitando?");

            if (!decisao)
            {
                Console.WriteLine("Obrigado, até mais tarde");
                Console.WriteLine();
                break;
            }
        }
    }
}
