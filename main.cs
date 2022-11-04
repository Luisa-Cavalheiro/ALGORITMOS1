using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("<<<<Created by Luísa Cavalheiro>>>>");
    string opt= "S";
    double gas, alc, vant;
    while (opt.Equals ("S") || opt.Equals("s")){
      Console.Write($"Digite o valor da gasolina: ");
      gas = double.Parse(Console.ReadLine());
      Console.Write("Digite o valor do alcool: ");
      alc = double.Parse(Console.ReadLine());
      vant = alc / gas;

      if (vant>0.7){
        Console.WriteLine(">>>Você deve abastecer com gasolina.");
        
      } else if (vant == 0.7){
        Console.WriteLine(">>>Não há vantagem em nenhum combustível. Faça sua escolha.");
        
      }else {
        Console.WriteLine(">>>nVocê deve abastecer com álcool.");
      }
      Console.Write("=>Deseja fazer outro cálculo? (S/N) ");
      opt = Console.ReadLine();
    }
    Console.WriteLine("-----Fim do Programa - By Luisa Cavalheiro-----");
  }
}