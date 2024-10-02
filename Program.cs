using System IO;
using System;

public class Program
{
 public double CalcularJurosCompostos(double capital, double taxa, double tempoMeses) //Define um método público que retorna um valor double e recebe três parâmetros: capital, taxa e tempoMeses.

    {
        return capital * Math.Pow(1 + (taxa / 100) / 12, tempoMeses); //Calcula a potência de um número
    }
     public void Executar() //Ele executa as interações com o usuário, coletando entradas e exibindo os resultados no console
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("===== Calculadora de Juros Compostos =====\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Digite o capital (valor inicial): "); //Exibe uma mensagem no console pedindo ao usuário para inserir o valor do capital inicial.
        double capital = double.Parse(Console.ReadLine()); //Converte a string digitada em um número do tipo double

        Console.Write("Digite a taxa de juros anual (em %): "); //Exibe uma mensagem pedindo a taxa de juros anual, em porcentagem.
        double taxa = double.Parse(Console.ReadLine());  //Converte a string digitada em um número do tipo double

        Console.Write("Digite o tempo (em meses): "); //Exibe uma mensagem pedindo o tempo de investimento em meses.
        double tempoMeses = double.Parse(Console.ReadLine());  //Lê e converte o tempo em meses para double.
        Console.ForegroundColor = ConsoleColor.Green;

        double montante = CalcularJurosCompostos(capital, taxa, tempoMeses); //Calcula com os valores fornecidos para o montante final

        double juros = montante - capital; //Subtrai o capital inicial do montante total para obter o valor dos juros compostos ganhos

        Console.WriteLine($"\nO montante total após {tempoMeses} meses é: R$ {montante:F2}"); //Exibe o montante total e os juros compostos com duas casas decimais
        Console.WriteLine($"Os juros compostos são: R$ {juros:F2}"); //Exibe o tempo em meses e o valor calculado do montante e dos juros

        SalvarResultadoEmTxt(capital, taxa, tempoMeses, montante, juros);
        Console.ResetColor();
     }

    // Método para salvar o resultado em um arquivo de texto
    public void SalvarResultadoEmTxt(double capital, double taxa, double tempoMeses, double montante, double juros)
    {
        string caminho = "resultado_juros_compostos.txt";
        using (StreamWriter writer = new StreamWriter(caminho, true)) // O parâmetro "true" indica que o arquivo será anexado.
        {
            writer.WriteLine("Cálculo de Juros Compostos:");
            writer.WriteLine($"Capital Inicial: R$ {capital:F2}");
            writer.WriteLine($"Taxa de Juros Anual: {taxa:F2}%");
            writer.WriteLine($"Tempo (em meses): {tempoMeses}");
            writer.WriteLine($"Montante Final: R$ {montante:F2}");
            writer.WriteLine($"Juros Compostos: R$ {juros:F2}");
            writer.WriteLine("======================================");
        }

        // Alterar a cor do texto para azul
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nResultado salvo em 'resultado_juros_compostos.txt'.");
        Console.ResetColor(); // Restaurar cor original após exibição
    }

    public static void Main()
    {
        Program programa = new Program();
        
        // Alterar a cor do fundo para preto e a cor do texto para branco no início do programa
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        
        Console.Clear(); // Apaga o conteúdo anterior com as novas cores
        programa.Executar();
    }
}
