# Separation of Concerns - SoC

Não se deve misturar conceitos e/ou responsabilidades diferentes dentro do design ou do código de um projeto de software.

A violação deste princípio causa código duplicado com mais de uma responsabilidade, violando também os princípios SOLID da **Responsabilidade Única** e o princípio **DRY - Don't Repeat Yourself**.

Exemplos de aplicação do conceito:
- Separar a **interface do usuário (front-end)** da **lógica de negócios (back-end)**.
- Separar o código de **acesso a dados** do código da **apresentação dos dados**.
- Separar o projeto em diferentes **módulos/camadas** com **responsabilidade distintas**.
- Criar **componentes/classes/funções** que realizam apenas uma **única tarefa** com eficiência.

## Aplicação

A aplicação da separação dos conceitos/responsabilidade envolve **dois processos**:

1 - Reduzir o **acomplamento**.

2 - Aumentar a **coesão**.

***

### Acomplamento

Acoplamento é o nível de **dependência/conhecimento** que pode existir **entre os componentes** do sistema.
Quanto **maior o acoplamento** entre os componentes do sistema **maior será a dependência** entre eles, e **mais difícil** será **manter**, **reusar** e **estender** o sistema.

### Coesão

Coesão é o nível de **integridade interna** dos componentes do sistema.
Quanto **maior a coesão** entre os componentes **mais definidas são suas responsabilidades** sendo **mais difícil desmembrar** o componente em outros componentes.

***

Portanto, quanto **menor o acoplamento e mais alta a coesão** de um componente ou módulo do sistema, **mais fácil** será de **manter**, **reusar** e **estender**.
