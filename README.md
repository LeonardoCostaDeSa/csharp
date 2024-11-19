Calculadora Console em C#
Descrição
Este é um programa simples de calculadora desenvolvido em C#, que permite ao usuário realizar operações aritméticas básicas entre dois números. A calculadora suporta as operações de adição, subtração, multiplicação e divisão. Além disso, mantém um histórico dos resultados anteriores, permitindo que o usuário visualize os últimos cálculos realizados.

Funcionalidades
Operações Suportadas: Adição (+), Subtração (-), Multiplicação (*), Divisão (/).
Histórico de Resultados: Armazena os resultados de cálculos anteriores.
Interação com o Usuário:
Permite ao usuário realizar múltiplos cálculos sem reiniciar o programa.
Oferece a opção de visualizar o histórico de resultados.
Opção de sair do programa a qualquer momento.
Requisitos
SDK do .NET: Versão 6.0 ou superior.
Ambiente de Desenvolvimento: Qualquer IDE compatível com C# (Visual Studio, Visual Studio Code, Rider, etc.) ou simplesmente um editor de texto e o terminal.
Como Executar o Programa
Clone ou Baixe o Repositório:

git clone https://github.com/seu-usuario/nome-do-repositorio.git
Navegue até o Diretório do Projeto:

cd nome-do-repositorio
Compile o Projeto:

dotnet build
Execute o Programa:

dotnet run
Instruções de Uso
Iniciando o Programa:

Ao executar o programa, você será solicitado a inserir o primeiro número.

Inserindo Números:

Digite o primeiro número e pressione Enter.
Em seguida, digite o segundo número e pressione Enter.
Selecionando a Operação:

Escolha a operação desejada digitando um dos seguintes símbolos:
+ para adição
- para subtração
* para multiplicação
/ para divisão
Pressione Enter após digitar o símbolo.
Visualizando o Resultado:

O programa exibirá o resultado da operação.
Aguarde alguns segundos para prosseguir.
Opções Após o Cálculo:

Deseja sair? (S/N): Digite S para sair ou N para continuar.
Se optar por continuar, você será perguntado:
Deseja ver os últimos resultados? (S/N): Digite S para visualizar o histórico ou N para prosseguir sem visualizar.
O programa então reiniciará o processo, permitindo novos cálculos.
Exemplo de Uso
Digite o primeiro número:
10
Digite o segundo número:
5
Digite a operação (+, -, *, /):
*
O resultado da operação é: 50
Deseja sair? (S/N)
N
Deseja ver os últimos resultados? (S/N)
S
Os últimos resultados calculados foram:

50
Observações
Tratamento de Erros: O programa realiza verificações básicas para entradas inválidas, como entradas nulas ou operações não suportadas.
Divisão por Zero: Ao tentar dividir por zero, o programa lançará uma exceção. Recomenda-se implementar um tratamento para este caso em futuras versões.
Extensibilidade: O código está estruturado de forma modular, facilitando a adição de novas funcionalidades ou operações.
Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou pull requests com melhorias, correções de bugs ou novas funcionalidades.

Licença
Este projeto é licenciado sob os termos da licença MIT.