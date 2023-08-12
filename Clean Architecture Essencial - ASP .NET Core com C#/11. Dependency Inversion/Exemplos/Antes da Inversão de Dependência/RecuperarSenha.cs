namespace Exemplos.Antes;

// Módulo de alto nível
public class RecuperarSenha
{
    // Depende de um módulo de baixo nível que é uma implementação (MySqlConnection) -> Alto acoplamento
    private MySqlConnection _conexaoBanco;

    public void RecuperarSenha()
    {
        _conexaoBanco = new MySqlConnection();
    }
}