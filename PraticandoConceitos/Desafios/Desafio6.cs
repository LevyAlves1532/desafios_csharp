namespace PraticandoConceitos.Desafios;

internal class Desafio6
{
    public static void Execute()
    {
        while (true)
        {
            Console.WriteLine("Como você deseja exibir a data atual:");
            Console.WriteLine();

            Console.WriteLine("[1] Formato Completo");
            Console.WriteLine("[2] Apenas a data");
            Console.WriteLine("[3] Apenas a hora");
            Console.WriteLine("[4] Data com mês extenso");
            Console.WriteLine();

            string decisao = Utilidades.Pergunta("Qual formato você deseja?");

            DateTime dataAtual = DateTime.Now;

            string resultado = decisao switch
            {
                "1" => dataAtual.ToString("F"),
                "2" => dataAtual.ToString("d"),
                "3" => dataAtual.ToString("HH") + " horas",
                "4" => dataAtual.ToString("D"),
                _ => "Decisão inválida"
            };

            Console.WriteLine(resultado);
            Console.WriteLine();

            bool decisao2 = Utilidades.PerguntaSimNao2("Você deseja continuar digitando?");
            Console.WriteLine();

            if (!decisao2)
            {
                Console.WriteLine("Obrigado, até mais tarde");
                Console.WriteLine();
                break;
            }
    }
    }
}
