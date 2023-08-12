namespace Exemplos.Depois;

// O módulo de baixo nível (MySqlConnection) agora depende de uma abstração: a interface IDatabaseConnection
public class MySqlConnection : IDatabaseConnection
{
    public void Conectar()
    {
    }
}