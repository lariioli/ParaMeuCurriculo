using System;

public class Program
{
 public double CalcularJurosCompostos(double capital, double taxa, double tempoMeses) //Define um método público que retorna um valor double e recebe três parâmetros: capital, taxa e tempoMeses.

    {
        return capital * Math.Pow(1 + (taxa / 100) / 12, tempoMeses); //Calcula a potência de um número
    }
     public void Executar() //Ele executa as interações com o usuário, coletando entradas e exibindo os resultados no console
    {
        Console.Write("Digite o capital (valor inicial): "); //Exibe uma mensagem no console pedindo ao usuário para inserir o valor do capital inicial.
        double capital = double.Parse(Console.ReadLine()); //Converte a string digitada em um número do tipo double
        Console.Write("Digite a taxa de juros anual (em %): "); //Exibe uma mensagem pedindo a taxa de juros anual, em porcentagem.
        double taxa = double.Parse(Console.ReadLine());  //Converte a string digitada em um número do tipo double