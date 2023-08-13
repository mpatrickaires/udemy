# Padrão Repository

## O que é o padrão Repository?

O padrão Repository realiza a **mediação** entre o **domínio** e as **camadas de mapeamento de dados**, agindo como uma **coleção de objetos de domínio em memória**. Isso permite **desacoplar** o modelo de domínio do código de acesso a dados.

Esse padrão permite, portanto, que o código de negócio seja completamente **separado** do código de persistência, pois o Repository **encapsula a lógica de acesso a dados** necessário para persistir os objetos do domínio.

## Implementação e tipos de repositório

Podemos iniciar definindo uma **interface** que atuará como a nossa **fachada de acesso a dados** e a seguir definir a **implementação na classe concreta**.

Podemos implementar os seguintes tipos de repositório:

- **Repositório Genérico**
- **Repositório Específico**

E podemos realizar uma implementação síncrona ou assíncrona (`Task`, `async/await`).

A implementação se é feita da seguinte maneira:

1. Criar uma interface ou classe abstrata e definir o contrato com os métodos do repositório.

2. Criar a classe concreta que implementa a interface.

### Repositório Genérico

Interface genérica definida na camada **Domain** ou **Application**.

```csharp
public interface IRepository<T>
{
	void Add();
	void Remove();
	IEnumerable<T> Get();
	T GetId(int id);
}
```

Implementação da interface definida na camada **Infrastructure**.

```csharp
public class Repository<T> : IRepository<T>
{
	// Implementação
}
```

Utilização do repositório genérico através de injeção de dependência.

```csharp
public class CustomerController : Controller
{
	private readonly IRepository<Customer> _repository;

	public CustomerController(IRepository<Customer> repository)
	{
		_repository = repository;
	}
}
```

### Repositório Específico

Interface de um repositório específico definida na camada **Domain** ou **Application**.

```csharp
public interface ICustomerRepository
{
	void Add();
	void Remove();
	IEnumerable<Customer> Get();
	Customer GetId(int id);
}
```

Implementação da interface definida na camada **Infrastructure**.

```csharp
public class CustomerRepository : ICustomerRepository
{
	// Implementação
}
```

Utilização do repositório específico através de injeção de dependência.

```csharp
public class CustomerController : Controller
{
	private readonly ICustomerRepository _repository;

	public CustomerController(ICustomerRepository repository)
	{
		_repository = repository;
	}
}
```

### Devo usar o repositório genérico ou específico?

Com um repositório genérico, há economia de código pois ele pode ser utilizado por qualquer entidade da camada de negócios. Entretanto, cada entidade pode possuir particularidades distintas que acabem inviabilizando a reutilização de um mesmo contrato de repositório.

Portanto, essa decisão depende do contexto e das especificidades do modelo de domínio e das particularidade de suas entidades.

## Benefícios

- Encapsula e centraliza a lógica das consultas em um repositório, assim evitando consultas esparramadas pelo código e facilitando a manutenção.
- Desacopla a sua aplicação dos frameworks de persistência (ex.: EF Core).
- Simplifica os testes unitários pela facilitação na criação de repositórios fakes.
