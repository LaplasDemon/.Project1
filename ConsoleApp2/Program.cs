using System;

namespace ConsoleApp2
{
   public  class Program
    {
       public  static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Ввести довжину ребра a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Square(a);
            Plo(a);
        }
      public static int Square(int a)
        {
            int V =a*a*a;



            return V;
        }
        public static int Plo(int a)
        {
            int S = a * a;
            return S;
        }
    }
}
