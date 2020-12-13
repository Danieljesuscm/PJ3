using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainClass {
  public static void Main () {
    
     StreamWriter Arquivo;
     
    
    string caminhoArquivo = "Estoque.txt";
    
    List<produto> Lista_produto = new List<produto>();
    string cadastrar = "S";
    int novo = 0;
   
       while (cadastrar == "S"){
        try{
         novo++;
         produto desconhecido = new produto("desconhecido","vazio",0,"nenhuma");
         Console.WriteLine("\ndeseja cadastrar um novo produto ?S/N");
         cadastrar = Console.ReadLine();
          if (cadastrar == "S"){
           Console.WriteLine("diga o nome do produto>>");
           string nome = Console.ReadLine();
           desconhecido.Setnomeproduto(nome);

           Console.WriteLine("diga o local que o produto está guardado >>");
           string local = Console.ReadLine();
           desconhecido.Setlocal(local);

           Console.WriteLine("diga a quantidade do produto>>");
           
           //Quantidade minima de produtos necessarios 5
           
           int quantidade = int.Parse(Console.ReadLine());
           if (quantidade < 5 ){ 
             throw new Exception("valor minimo esperado para cadastrar produto é 5");

           }

           desconhecido.Setqntdproduto(quantidade);

           Console.WriteLine("diga a categoria do produto>>");
           string categoria = Console.ReadLine();
           desconhecido.Setcategoria(categoria);

           Lista_produto.Add(desconhecido);         
           
          }
          
    }
     catch(System.FormatException){
      Console.WriteLine("\nAlgum valor foi inserido de maneira errada");
      }
      }
    
    
    
     Arquivo = File.AppendText(caminhoArquivo);
     Arquivo.WriteLine("Novo Cadastro de Estoque");
    try{
      
      Console.WriteLine("Indice--NOME--LOCAL--QUANT--CATE");
      for (int j = 0; j<Lista_produto.Count; j++){
        Console.WriteLine($"{j}---{Lista_produto[j].Getnomeproduto()}--{Lista_produto[j].Getlocal()}--{Lista_produto[j].Getqntdproduto()}---{Lista_produto[j].Getcategoria()}");

        Arquivo.WriteLine($"Nome >> {Lista_produto[j].Getnomeproduto()}");
        
        Arquivo.WriteLine($"Local >> {Lista_produto[j].Getlocal()}");

        Arquivo.WriteLine($"Quantidade >> {Lista_produto[j].Getqntdproduto()}"); 
        
        Arquivo.WriteLine($"Categoria >> {Lista_produto[j].Getcategoria()}");
        Arquivo.WriteLine();

      
    }
    }
    catch(IndexOutOfRangeException){
      Console.WriteLine("Não foi possivel pecorrer o estoque");
    }
    
    Arquivo.Close();

  }
}