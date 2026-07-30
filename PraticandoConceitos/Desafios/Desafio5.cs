namespace PraticandoConceitos.Desafios;

internal class Desafio5
{
    public static void Execute()
    {
        while(true)
        {
            string placa = Utilidades.Pergunta("Digite a placa de um veículo seguindo o padrão de 2018");
            Console.WriteLine();

            if (Utilidades.VerificaTextoVazio(placa))
            {
                Console.WriteLine("Você deve digitar a placa");
                Console.WriteLine();
                continue;
            }

            if (placa.Trim().Length != 7)
            {
                Console.WriteLine("A placa deve conter um total de 7 caracteres");
                Console.WriteLine();
                continue;
            }

            if (!placa.Substring(0, 3).All(char.IsLetter))
            {
                Console.WriteLine("A placa é inválida");
                Console.WriteLine();
                continue;
            }

            if (!placa.Substring(3).All(char.IsNumber))
            {
                Console.WriteLine("A placa é inválida");
                Console.WriteLine();
                continue;
            }

            Console.WriteLine("A placa é válida!");
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
