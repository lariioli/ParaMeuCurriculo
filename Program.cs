﻿using System;

public class Program
{
 public double CalcularJurosCompostos(double capital, double taxa, double tempoMeses) //Define um método público que retorna um valor double e recebe três parâmetros: capital, taxa e tempoMeses.

    {
        return capital * Math.Pow(1 + (taxa / 100) / 12, tempoMeses); //Calcula a potência de um número
    }
     public void Executar() //Ele executa as interações com o usuário, coletando entradas e exibindo os resultados no console
    {
        Console.Write("Digite o capital (valor inicial): "); //Exibe uma mensagem no console pedindo ao usuário para inserir o valor do capital inicial.