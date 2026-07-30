namespace PraticandoConceitos;

internal class Utilidades
{
    public static string? Pergunta(string pergunta)
    {
        Console.WriteLine(pergunta);
        return Console.ReadLine();
    }

    public static string? PerguntaSimNao(string pergunta)
    {
        Console.WriteLine(pergunta);
        Console.Write("Digite [S]im ou [N]ão: ");
        return Console.ReadLine();
    }

    public static bool PerguntaSimNao2(string pergunta)
    {
        Console.WriteLine(pergunta);
        Console.Write("Digite [S]im ou [N]ão: ");
        string? decisao = Console.ReadLine();
        return !VerificaTextoVazio(decisao) && decisao.Trim() == "s";
    }

    public static bool VerificaTextoVazio(string? texto) => texto == null || (texto != null && texto.Trim() == "");
}
