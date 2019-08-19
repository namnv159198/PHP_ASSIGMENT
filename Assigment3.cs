using System;
using System.Collections.Generic;

namespace Assigment2
{
    public class Assigment3
    {
        public static void Main(string[] args)
    {
      
      News n = new News();

      List<News>listnew = new List<News>();
      
      int choice;
      
      do {            
        Console.WriteLine("\n-------------------------Menu-------------------------");
        Console.WriteLine("1. Insert news");
        Console.WriteLine("2. View list news");
        Console.WriteLine("3. Average rate");
        Console.WriteLine("4. Exit");
          
        do {            
          Console.WriteLine("Input choice number menu (1/2/3/4) : ");
          choice = Convert.ToInt32(Console.ReadLine());
          if (choice < 1 || choice > 4) {
            Console.WriteLine("Error ! Please choose again !");
          }
        } while (choice < 1 || choice > 4);          
        
         
        switch (choice){
          
          case 1: inputInfor(listnew); break;
          case 2:
            Console.WriteLine("--------------- List New ---------------");
            foreach (News news in listnew)
            {
              news.display();
            }
              break;
          case 3 :
            AverageRate(listnew,true);
            break;
          case 4 :
           return;
          
        }
            
             } while (choice != 0);
             
      
        
        }
    static void inputInfor(List<News> list)
    {
            
      Console.WriteLine("input ID : ");
      int ID = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("input Title : ");
      string Title = Console.ReadLine();
      Console.WriteLine("input PublishDate : ");
      string PublishDate = Console.ReadLine();
      Console.WriteLine("input Author : ");
      string Author = Console.ReadLine();
      Console.WriteLine("input Content : ");
      string Content = Console.ReadLine();
      News n = new News(ID,Title,PublishDate,Author,Content);
      Console.WriteLine("Input Rate :");
      for (int i = 0; i < 3; i++)
      { 
        Console.WriteLine("Rate  :" +(i+1));
        n[i] = Convert.ToInt32(Console.ReadLine());
      }
      list.Add(n);
    
    }

    static void AverageRate(List<News> list , bool b = false)
    {
      foreach (News n in list)
      {
        if (b)
        {
          n.Calculate();
        }
        n.display();
      }
    }
    }
}