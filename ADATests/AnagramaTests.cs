namespace Anagrama;

/*    Alegria: alergia, regalia, galeria;
    Cantiga: catinga;
    Carro: corar;
    Muro: rumo;
    Pedra: perda, padre;
    Ova: voa, avo;
    Pato: topa, opta;
    Iracema: América;
*/

public class AnagramaTests
{
    [Fact]
    public void VerificadorAnagrama_Comparacao_Positiva()
    {
        // arrange
        var anagrama = new VerificadorAnagrama();

        // act
        bool resultado = anagrama.VerificarAnagrama("alegria", "alergia");

        // assert
        Assert.True(resultado);
    }

    [Fact]
    public void VerificadoraAnagrama_Comparacao_Negativa()
    {
        // arrange
        var anagrama = new VerificadorAnagrama();

        // act
        bool resultado = anagrama.VerificarAnagrama("alegria", "rumo");

        // assert
        Assert.False(resultado);
    }

    [Fact]
    public void VerificarAnagrama_Comparacao_Nulo()
    {
        // arrange
        var anagrama = new VerificadorAnagrama();

        // act
        bool resultado = anagrama.VerificarAnagrama("alegria", null);

        // assert
        Assert.False(resultado);
    }
}