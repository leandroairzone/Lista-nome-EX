using System;
using System.Collections.Generic;

namespace Lista_ex
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> nomes = new List<string>();
           nomes.Add("Leandro");
           nomes.Add("Cleyton");
           nomes.Add("Yasmim");
           nomes.Add("Tayna");
           nomes.Add("DEUS");

          // bool resposta =  nomes.Contains("DEUS"); // retorna um valor boleano caso o item pesquisado seja encontrado
         // if (resposta == true){
        //    Console.WriteLine("Nome encontrado");
       // }else{
      //    Console.WriteLine("Nome nao encontrado");
     //     }
          //   Console.WriteLine(nomes.Count); //count conta quantos intens temos na lista 

             for (var i = 0; i < nomes.Count; i++)

             {
                  Console.WriteLine(nomes[i]); // lista de nomes 
             }


       }
     }

    // 1º parte foi numeros 
    // 2º parte foi nomes 
 }
