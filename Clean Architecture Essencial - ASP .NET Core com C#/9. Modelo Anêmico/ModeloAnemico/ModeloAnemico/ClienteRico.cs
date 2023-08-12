namespace ModeloAnemico;

public class ClienteRico
{
    // Os setters são tornados private para que o estado da classe não possa ser alterado externamente
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Endereco { get; private set; }

    // Um construtor parametrizado deve ser definido para que a classe não possa ser criado com dados faltantes, o que pode
    // torna-la inválida
    public ClienteRico(int id, string nome, string endereco)
    {
        // A realização da validação no momento da construção da classe garante que ela não seja criada com dados inválidos,
        // garantindo assim que seja um modelo válido
        Validar(id, nome, endereco);
        Id = id;
        Nome = nome;
        Endereco = endereco;
    }

    // A definição de um método público é a única maneira do mundo externo atualizar esse objeto, o que faz com que isso seja
    // devidamente encapsulado para que o objeto fique responsável por sua própria atualização, realizando rotinas e/ou validações
    // necessária antes, durante e/ou após atualizar seus próprios valores
    public void Update(int id, string nome, string endereco)
    {
        // A realização da validação no momento em que o objeto é atualizado segue a mesma importância de manter a sua validade
        Validar(id, nome, endereco);
    }

    // Definindo uma rotina de validação dentro da própria classe faz com que seja delegado para ela a responsabilidade de
    // verificar os seus próprios dados e, mais importante, a lógica que envolve isso. Dessa forma, essa lógica fica encapsulada
    // para o mundo exterior e centralizada em um único local, prevenindo que esse código seja repetido
    private void Validar(int id, string nome, string endereco)
    {
        if (id < 0) throw new InvalidOperationException("O Id deve ser maior que 0");

        if (string.IsNullOrWhiteSpace(nome)) throw new InvalidOperationException("O nome é obrigatório");

        if (nome.Length < 3) throw new ArgumentException("O nome deve ter no mínimo 3 caracteres");

        if (nome.Length > 100) throw new ArgumentException("O nome excedeu 100 caracteres");

        if (string.IsNullOrWhiteSpace(endereco)) throw new InvalidOperationException("O endereço é obrigatório");
    }
}
