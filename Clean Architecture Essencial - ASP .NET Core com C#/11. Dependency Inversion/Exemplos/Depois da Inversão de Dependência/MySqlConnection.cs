namespace Exemplos.Depois;

// O m�dulo de baixo n�vel (MySqlConnection) agora depende de uma abstra��o: a interface IDatabaseConnection
public class MySqlConnection : IDatabaseConnection
{
    public void Conectar()
    {
    }
}