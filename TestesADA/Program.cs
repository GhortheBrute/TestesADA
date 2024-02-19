using Anagrama;

namespace MainTestes;

public class Program
{
    static void Main(string[] args)
    {
        var roda = new VerificadorAnagrama();

        if (roda.VerificarAnagrama("Alegria","Alergia"))
        {
            Console.WriteLine("A palavra é um anagrama.");
        }else { Console.WriteLine("A palavr não é um anagrama."); }
    }
}