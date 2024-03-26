# Calculadora Simples em C-Sharp

Este é um pequeno projeto de uma calculadora simples desenvolvida em C#. Ela oferece operações básicas como soma, subtração, multiplicação, divisão e cálculo do resto da divisão (módulo). O programa foi estruturado em três arquivos principais:

## Arquivos do Projeto

### 1. `Operations.cs`

Este arquivo contém a definição da classe `Operation`, que implementa métodos estáticos para realizar as operações matemáticas básicas. Cada método corresponde a uma operação específica, como soma, subtração, multiplicação, divisão e cálculo do módulo (resto da divisão).

### 2. `Menu.cs`

A classe `Menu` é responsável por exibir o menu de opções da calculadora e direcionar o usuário para a operação escolhida. Ela contém métodos para mostrar o menu, processar a escolha do usuário e sair do programa.

### 3. `Program.cs`

Este é o arquivo de inicialização do programa. Ele contém o método `Main`, que é o ponto de entrada da aplicação. No método `Main`, é chamado o método `ShowMenu()` da classe `Menu` para exibir o menu inicial da calculadora.

## Funcionamento do Programa

1. O programa inicia exibindo um menu com as opções disponíveis: soma, subtração, multiplicação, divisão, cálculo do resto da divisão e fechar o sistema.

2. O usuário escolhe uma opção digitando o número correspondente.

3. Com base na escolha do usuário, a calculadora realiza a operação selecionada.

4. Após a execução da operação, o menu é exibido novamente para que o usuário possa escolher outra operação ou fechar o sistema.

5. Se o usuário escolher fechar o sistema, uma mensagem de agradecimento é exibida e o programa é encerrado.

## Como Utilizar

1. Baixe ou clone o repositório em sua máquina local.

2. Abra o projeto em um ambiente de desenvolvimento compatível com C# (por exemplo, Visual Studio).

3. Compile e execute o projeto.

4. Siga as instruções exibidas no console para realizar as operações desejadas.

## Author

- Dhanglerson Barral

## Observações

- Este é um projeto simples desenvolvido para fins educacionais e de aprendizado em C#.
- As operações são realizadas com números de ponto flutuante (`float`), exceto o cálculo do resto da divisão, que utiliza números inteiros (`int`).
- O programa não inclui tratamento avançado de erros ou validações robustas de entrada do usuário, sendo projetado apenas para fins de demonstração.

Sinta-se à vontade para contribuir com melhorias ou adaptar o código conforme necessário!
