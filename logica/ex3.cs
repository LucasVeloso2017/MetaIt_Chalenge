/*
Um bracket é considerado qualquer um dos seguintes caracteres: (, ), {, }, [ ou ].

Dois brackets são considerados um par combinado se o bracket de abertura
(isto é, (, [ou {) ocorre à esquerda de um bracket de fechamento (ou seja,),] ou} 
do mesmo tipo exato. Existem três tipos de pares de brackets : [], {} e ().

Um par de brackets correspondente não é balanceado se o de abertura e o de fechamento
não corresponderem entre si. Por exemplo, {[(])} não é balanceado porque o conteúdo entre 
{e} não é balanceado. O primeiro bracket inclui o de abertura, (, e o segundo inclui um 
bracket de fechamento desbalanceado,].

Dado sequencias de caracteres, determine se cada sequência de brackets é balanceada. 
Se uma string estiver balanceada, retorne SIM. Caso contrário, retorne NAO.

Exemplo:
{[()]} SIM
{[(])} NAO
{{[[(())]]}} SIM


*/
using System.Collections.Generic;
using static System.Console;
using System.Linq;

namespace Numerotres
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = new List<int>();
      int D_Compra = 0;
      int D_Venda = 0;
      int compra = 0;
      int venda = 0;

      WriteLine("Digite o tamanho do Vetor: ");
      var size = int.Parse(ReadLine());

      WriteLine("Digite os valores do Vetor: ");
      for (int i = 0; i < size; i++)
      {
        input.Add(int.Parse(ReadLine()));
      }

      for (int i = 0; i < input.Count; i++)
      {
        if (input[i] == input.Min())
        {
          D_Compra = i + 1;
          compra = input[i];
          i = D_Compra;
        }
        else if (i + 1 < size)
        {
          if (input[i] > input[i + 1])
          {
            if (compra > 0)
            {
              venda = input[i];
              D_Venda = i + 1;
            }
          }
        }

      }
      if (venda - compra > 0)
        Write($"{venda - compra}");
      else
        Write($"0");
    }
  }
}
