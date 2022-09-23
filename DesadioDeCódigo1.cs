using System;



class DIO {
static void Main(string[] args){
    string numero = Console.ReadLine();
    int produto = 1, soma = 0;
    for (int i = 0; i < numero.Length; i++)
    {
      string digito = numero[i].ToString();
      produto *= Convert.ToInt32(digito);
      soma += Convert.ToInt32(digito);
    }
    Console.WriteLine(produto - soma);
    }
  }