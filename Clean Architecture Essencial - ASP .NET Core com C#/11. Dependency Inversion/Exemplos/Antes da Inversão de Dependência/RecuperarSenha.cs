namespace Exemplos.Antes;

// M�dulo de alto n�vel
public class RecuperarSenha
{
    // Depende de um m�dulo de baixo n�vel que � uma implementa��o (MySqlConnection) -> Alto acoplamento
    private MySqlConnection _conexaoBanco;

    public void RecuperarSenha()
    {
        _conexaoBanco = new MySqlConnection();
    }
}