# Dependency Inversion (DI) ou Inversão da Dependência

A **direção da dependência** em uma aplicação deverá ser na direção da **abstração** e **não nos detalhes de implementação**.

**Módulos de alto nível não devem depender de módulos de baixo nível**. Ambos devem depender de uma **abstração**.

**Abstrações não devem depender de detalhes**. Detalhes devem depender de abstrações.

Módulos de **alto nível** são classes da **camada de negócio** que encapsulam uma lógica complexa.

Módulos de **baixo nível** são classes da **camada de infraestrutura** que implementam operações básicas, como acesso a dados, ao disco, protocolos de rede, etc.

As **abstrações** seriam **interfaces** ou **classes** abstratas que não possuem implementação.

Assim, as **classes da camada de negócio não devem depender das classes da camada de infraestrutura**, mas **ambas devem depender de interfaces ou classes abstratas**.

> Não confundir o princípio da **inversão da dependência** com o padrão de projeto da **injeção da dependência**.

Em uma arquitetura em camadas, um componente de alto nível não deve depender de um componente de baixo nível. Devemos criar uma abstração e fazer os dois componentes depender desta abstração.

## Resumo

### Princípio da Inversão da Dependência (DIP)

É um princípio que **sugere uma solução** para o **problema da dependência** mas **não diz como implementar ou que técnica usar**.

### Injeção da Dependência (DI)

Padrão de projeto usado para **implementar a inversão da dependência**. Permite **injetar a implementação concreta** de um componente de baixo nível em um componente de alto nível.

### Inversão de Controle (IoC)

É uma forma de **aplicar a inversão de dependência** permitindo que **componente de alto nível dependam de uma abstração e não de um componente de baixo nível**.

### Container IoC (Container de Injeção de Dependência)

É um framework que permite fazer a injeção de dependência de forma automática nos componentes.
