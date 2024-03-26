
namespace Calculator
{
   public class Menu
   {
      public static void ShowMenu()
      {
         Console.Clear();
         Console.WriteLine("Calculadora Dev");
         Console.WriteLine("Informe a operação que deseja Realizar!");
         Console.WriteLine("");
         Console.WriteLine("1 - Soma");
         Console.WriteLine("2 - Subtração");
         Console.WriteLine("3 - Multiplicação");
         Console.WriteLine("4 - Divisão");
         Console.WriteLine("5 - Modulo/Resto da divisão");
         Console.WriteLine("0 - Fechar o sistema");

         short option = short.Parse(Console.ReadLine()!);
         switch (option)
         {
            case 1: Operation.Sum(); break;
            case 2: Operation.Subtraction(); break;
            case 3: Operation.Multiplication(); break;
            case 4: Operation.Division(); break;
            case 5: Operation.Modulo(); break;
            case 0: ExitOperation(); break;
            default: ShowMenu(); break;
         }
      }

      public static void ExitOperation()
      {
         Console.Clear();
         Console.WriteLine("Obrigado por utilizar nosso sistema, até breve!");
         Thread.Sleep(2000);
         Environment.Exit(0);
      }
   }
}