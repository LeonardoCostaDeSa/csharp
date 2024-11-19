using System;
using System.Threading;

class Program
{
    /// <summary>
    /// Método principal que inicia a execução da calculadora.
    /// </summary>
    static void Main(string[] args)
    {
        Calculadora();
    }

    /// <summary>
    /// Método que contém toda a lógica da calculadora.
    /// </summary>
    static void Calculadora()
    {
        double num1 = 0, num2 = 0, resultado = 0;
        string? operacao = string.Empty;
        var historicoResultados = new List<double>();

        /// <summary>
        /// Coleta os números e a operação a ser realizada pelo usuário.
        /// </summary>
        void coletarNumerosEOperacao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            string? input1 = Console.ReadLine();
            if (input1 != null)
            {
                num1 = Convert.ToDouble(input1);
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
                return;
            }

            Console.WriteLine("Digite o segundo número: ");
            string? input2 = Console.ReadLine();
            if (input2 != null)
            {
                num2 = Convert.ToDouble(input2);
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
                return;
            }

            Console.WriteLine("Digite a operação (+, -, *, /): ");
            operacao = Console.ReadLine();
        }

        /// <summary>
        /// Realiza o cálculo com base nos números e operação fornecidos.
        /// </summary>
        /// <returns>O resultado do cálculo.</returns>
        double calcular()
        {
            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    return 0; // Retorna um valor padrão em caso de operação inválida
            }
            historicoResultados.Add(resultado);
            return resultado;
        }

        /// <summary>
        /// Exibe o resultado do cálculo ao usuário.
        /// </summary>
        void exibirResultado()
        {
            Console.WriteLine($"O resultado da operação é: {resultado}");
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Pergunta ao usuário se deseja sair ou continuar usando a calculadora.
        /// </summary>
        void desejaSair()
        {
            Console.WriteLine("Deseja sair? (S/N)");
            string? sair = Console.ReadLine();
            if (sair?.ToUpper() == "S")
            {
                Console.WriteLine("Saindo...");
                Thread.Sleep(2000); // Pausa a execução por 2 segundos
                Environment.Exit(0);
            }
            else
            {
                recomecar();
            }
        }

        /// <summary>
        /// Exibe os últimos resultados calculados.
        /// </summary>
        void verUltimosResultados()
        {
            Console.WriteLine("Os últimos resultados calculados foram:\n");
            foreach (double resultados in historicoResultados)
            {
                Console.WriteLine(resultados);
            }
        }

        /// <summary>
        /// Pergunta ao usuário se deseja ver os últimos resultados.
        /// </summary>
        void desejaVerUltimosResultados()
        {
            Console.WriteLine("Deseja ver os últimos resultados? (S/N)");
            string? verResultados = Console.ReadLine();
            if (verResultados?.ToUpper() == "S")
            {
                verUltimosResultados();
                desejaSair();
            }
        }

        /// <summary>
        /// Reinicia o processo da calculadora, permitindo novas operações.
        /// </summary>
        void recomecar()
        {
            desejaVerUltimosResultados();
            coletarNumerosEOperacao();
            resultado = calcular();
            exibirResultado();
            desejaSair();
        }

        // Início da execução da calculadora
        coletarNumerosEOperacao();
        if (operacao != null)
        {
            resultado = calcular();
            exibirResultado();
            desejaSair();
        }
    }
}
