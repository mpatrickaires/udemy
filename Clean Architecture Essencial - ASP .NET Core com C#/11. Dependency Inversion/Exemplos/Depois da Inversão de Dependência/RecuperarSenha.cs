namespace Exemplos.Depois;

public class RecuperarSenha
{
    private IDatabaseConnection _conexaoBanco;

    // Injetando a dependÍncia no construtor da classe
    public void RecuperarSenha(IDatabaseConnection conexaoBanco)
    {
        _conexaoBanco = conexaoBanco;
    }
}