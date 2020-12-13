using System;
using System.Collections.Generic;

class MainClass {
  public static void Main () {
    
    List<produto> Lista_produto = new List<produto>();
    string cadastrar = "S";
    int novo = 0;
    while (cadastrar == "S"){
      novo++;
      produto desconhecido = new produto("desconhecido","vazio",0,"nenhuma");
      Console.WriteLine("deseja cadastrar um novo produto ?S/N");
      cadastrar = Console.ReadLine();
      if (cadastrar == "S"){
        Console.WriteLine("diga o nome do produto>>");
        string nome = Console.ReadLine();
        desconhecido.Setnomeproduto(nome);

        Console.WriteLine("diga o local que o produto está guardado >>");
        string local = Console.ReadLine();
        desconhecido.Setlocal(local);

        Console.WriteLine("diga a quantidade do produto>>");
        int quantidade = int.Parse(Console.ReadLine());
        desconhecido.Setqntdproduto(quantidade);

        Console.WriteLine("diga a categoria do produto>>");
        string categoria = Console.ReadLine();
        desconhecido.Setcategoria(categoria);

        Lista_produto.Add(desconhecido);         
      }
    }
    for (int i = 0; i<Lista_produto.Count; i++){
      Console.WriteLine("Indice--NOME--LOCAL--QUANT--CATE");
      for (int j = 0; j<Lista_produto.Count; j++){
        Console.WriteLine($"{j}---{Lista_produto[j].Getnomeproduto()}--{Lista_produto[j].Getlocal()}--{Lista_produto[j].Getqntdproduto()}---{Lista_produto[j].Getcategoria()}");

      }
    }




  
    

  }
}