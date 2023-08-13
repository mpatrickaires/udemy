# Padr�o Repository

## O que � o padr�o Repository?

O padr�o Repository realiza a **media��o** entre o **dom�nio** e as **camadas de mapeamento de dados**, agindo como uma **cole��o de objetos de dom�nio em mem�ria**. Isso permite **desacoplar** o modelo de dom�nio do c�digo de acesso a dados.

Esse padr�o permite, portanto, que o c�digo de neg�cio seja completamente **separado** do c�digo de persist�ncia, pois o Repository **encapsula a l�gica de acesso a dados** necess�rio para persistir os objetos do dom�nio.

## Implementa��o e tipos de reposit�rio

Podemos iniciar definindo uma **interface** que atuar� como a nossa **fachada de acesso a dados** e a seguir definir a **implementa��o na classe concreta**.

Podemos implementar os seguintes tipos de reposit�rio:

- **Reposit�rio Gen�rico**
- **Reposit�rio Espec�fico**

E podemos realizar uma implementa��o s�ncrona ou ass�ncrona (`Task`, `async/await`).

A implementa��o se � feita da seguinte maneira:

1. Criar uma interface ou classe abstrata e definir o contrato com os m�todos do reposit�rio.

2. Criar a classe concreta que implementa a interface.

### Reposit�rio Gen�rico

Interface gen�rica definida na camada **Domain** ou **Application**.

```csharp
public interface IRepository<T>
{
	void Add();
	void Remove();
	IEnumerable<T> Get();
	T GetId(int id);
}
```

Implementa��o da interface definida na camada **Infrastructure**.

```csharp
public class Repository<T> : IRepository<T>
{
	// Implementa��o
}
```

Utiliza��o do reposit�rio gen�rico atrav�s de inje��o de depend�ncia.

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

### Reposit�rio Espec�fico

Interface de um reposit�rio espec�fico definida na camada **Domain** ou **Application**.

```csharp
public interface ICustomerRepository
{
	void Add();
	void Remove();
	IEnumerable<Customer> Get();
	Customer GetId(int id);
}
```

Implementa��o da interface definida na camada **Infrastructure**.

```csharp
public class CustomerRepository : ICustomerRepository
{
	// Implementa��o
}
```

Utiliza��o do reposit�rio espec�fico atrav�s de inje��o de depend�ncia.

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

### Devo usar o reposit�rio gen�rico ou espec�fico?

Com um reposit�rio gen�rico, h� economia de c�digo pois ele pode ser utilizado por qualquer entidade da camada de neg�cios. Entretanto, cada entidade pode possuir particularidades distintas que acabem inviabilizando a reutiliza��o de um mesmo contrato de reposit�rio.

Portanto, essa decis�o depende do contexto e das especificidades do modelo de dom�nio e das particularidade de suas entidades.

## Benef�cios

- Encapsula e centraliza a l�gica das consultas em um reposit�rio, assim evitando consultas esparramadas pelo c�digo e facilitando a manuten��o.
- Desacopla a sua aplica��o dos frameworks de persist�ncia (ex.: EF Core).
- Simplifica os testes unit�rios pela facilita��o na cria��o de reposit�rios fakes.
