namespace PraticandoConceitos.Desafios;

internal class Desafio3
{
    public static void Execute()
    {
        string? decisao = Utilidades.PerguntaSimNao("Você deseja informar o valor de X e Y?");
        Console.WriteLine();

        while (true)
        {
            double x, y;

            if (Utilidades.VerificaTextoVazio(decisao))
            {
                Console.WriteLine("Você deve digitar");
                Console.WriteLine();
                decisao = Utilidades.PerguntaSimNao("Você deseja informar o valor de X e Y?");
                Console.WriteLine();
                continue;
            }

            if (decisao.ToLower() == "s")
            {
                string? numeroX = Utilidades.Pergunta("1. Informe o valor de X:");
                Console.WriteLine();

                string? numeroY = Utilidades.Pergunta("2. Informe o valor de Y:");
                Console.WriteLine();

                if (Utilidades.VerificaTextoVazio(numeroX))
                {
                    Console.WriteLine("O número X deve ser preenchido");
                    Console.WriteLine();
                    continue;
                }

                if (!double.TryParse(numeroX, result: out x))
                {
                    Console.WriteLine("O número X é inválido");
                    Console.WriteLine();
                    continue;
                }

                if (Utilidades.VerificaTextoVazio(numeroY))
                {
                    Console.WriteLine("O número Y deve ser preenchido");
                    Console.WriteLine();
                    continue;
                }

                if (!double.TryParse(numeroY, result: out y))
                {
                    Console.WriteLine("O número Y é inválido");
                    Console.WriteLine();
                    continue;
                }

                if (y == 0)
                {
                    Console.WriteLine("O número Y não deve ser 0");
                    Console.WriteLine();
                    continue;
                }
            }
            else if (decisao.ToLower() == "n")
            {
                Random random = new Random();
                x = random.Next(1, 100);
                y = random.Next(1, 100);
            }
            else
            {
                Console.WriteLine("Decisão inválida");
                Console.WriteLine();
                decisao = Utilidades.PerguntaSimNao("Você deseja informar o valor de X e Y?");
                Console.WriteLine();
                continue;
            }

            Console.WriteLine($"O valor de X é {x}");
            Console.WriteLine($"O valor de Y é {y}");
            Console.WriteLine();

            double resultadoSoma = x + y;
            Console.WriteLine($"A soma de {x} + {y} = {resultadoSoma}");
            Console.WriteLine();

            double resultadoSubtracao = x - y;
            Console.WriteLine($"A subtração de {x} - {y} = {resultadoSubtracao}");
            Console.WriteLine();

            double resultadoMutiplicacao = x * y;
            Console.WriteLine($"A multiplicação de {x} * {y} = {resultadoMutiplicacao}");
            Console.WriteLine();

            double resultadoDivisao = x / y;
            Console.WriteLine($"A divisão de {x} / {y} = {resultadoDivisao}");
            Console.WriteLine();

            double resultadoMedia = resultadoSoma / 2;
            Console.WriteLine($"A média de {resultadoSoma} ({x} + {y}) é {resultadoMedia}");
            Console.WriteLine();

            break;
        }
    }
}
