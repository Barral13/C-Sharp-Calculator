namespace Calculator
{
   public class Operation
   {
      public static void Sum()
      {
         Console.WriteLine("Infome o primeiro número:");
         float firstNumber = short.Parse(Console.ReadLine()!);

         Console.WriteLine("Informe o segundo número:");
         float secoundNumber = short.Parse(Console.ReadLine()!);

         float result = firstNumber + secoundNumber;
         Console.WriteLine($"O resultado da soma é: {result}");

         Console.ReadKey();
         Menu.ShowMenu();
      }

      public static void Subtraction()
      {
         Console.WriteLine("Infome o primeiro número:");
         float firstNumber = short.Parse(Console.ReadLine()!);

         Console.WriteLine("Informe o segundo número:");
         float secoundNumber = short.Parse(Console.ReadLine()!);

         float result = firstNumber - secoundNumber;
         Console.WriteLine($"O resultado da subtração é: {result}");

         Console.ReadKey();
         Menu.ShowMenu();
      }

      public static void Multiplication()
      {
         Console.WriteLine("Infome o primeiro número:");
         float firstNumber = short.Parse(Console.ReadLine()!);

         Console.WriteLine("Informe o segundo número:");
         float secoundNumber = short.Parse(Console.ReadLine()!);

         float result = firstNumber * secoundNumber;
         Console.WriteLine($"O resultado da multiplicação é: {result}");

         Console.ReadKey();
         Menu.ShowMenu();
      }

      public static void Division()
      {
         Console.WriteLine("Informe o primeiro número:");
         float firstNumber = float.Parse(Console.ReadLine()!);

         Console.WriteLine("Informe o segundo número:");
         float secondNumber = float.Parse(Console.ReadLine()!);

         if (secondNumber == 0)
         {
            Console.WriteLine("Não é possível dividir por zero, tente novamente.");
            Division();
         }
         else
         {
            float result = firstNumber / secondNumber;
            Console.WriteLine($"O resultado da divisão é: {result}");
         }

         Console.ReadKey();
         Menu.ShowMenu();
      }

      public static void Modulo()
      {
         Console.WriteLine("Informe o primeiro número:");
         int firstNumber = int.Parse(Console.ReadLine()!);

         Console.WriteLine("Informe o segundo número:");
         int secondNumber = int.Parse(Console.ReadLine()!);

         if (secondNumber == 0)
         {
            Console.WriteLine("Não é possível dividir por zero, tente novamente.");
            Division();
         }
         else
         {
            float result = firstNumber % secondNumber;
            Console.WriteLine($"O resultado da divisão é: {result}");
         }

         Console.ReadKey();
         Menu.ShowMenu();

      }

   }
}