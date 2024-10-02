using System.IO;
using System;
public class Program
{
    // Método para calcular juros compostos
    public double CalcularJurosCompostos(double capital, double taxa, double tempoMeses)
    {
        return capital * Math.Pow(1 + (taxa / 100) / 12, tempoMeses); // Fórmula dos juros compostos
    }

    // Método para executar a interação com o usuário
    public void Executar()
    {
        // Alterar a cor do texto para ciano
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("===== Calculadora de Juros Compostos =====\n");
        
        // Alterar a cor do texto para amarelo
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Digite o capital (valor inicial): ");
        double capital = double.Parse(Console.ReadLine());

        Console.Write("Digite a taxa de juros anual (em %): ");
        double taxa = double.Parse(Console.ReadLine());

        Console.Write("Digite o tempo (em meses): ");
        double tempoMeses = double.Parse(Console.ReadLine());

        // Alterar a cor do texto para verde
        Console.ForegroundColor = ConsoleColor.Green;
        double montante = CalcularJurosCompostos(capital, taxa, tempoMeses);
        double juros = montante - capital;

        Console.WriteLine($"\nO montante total após {tempoMeses} meses é: R$ {montante:F2}");
        Console.WriteLine($"Os juros compostos são: R$ {juros:F2}");

        // Salvar o resultado em um arquivo txt
        SalvarResultadoEmTxt(capital, taxa, tempoMeses, montante, juros);

        // Restaurar a cor original após a execução
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