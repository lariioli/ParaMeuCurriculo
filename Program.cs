using System;

public class Program
{
 public double CalcularJurosCompostos(double capital, double taxa, double tempoMeses) //Define um método público que retorna um valor double e recebe três parâmetros: capital, taxa e tempoMeses.

    {
        return capital * Math.Pow(1 + (taxa / 100) / 12, tempoMeses); //Calcula a potência de um número