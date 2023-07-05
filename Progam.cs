using System;

public class Calculator {

  public static int numOption1;
  public static int numOption2; 

  enum Panel
  {
    Sum = 1,
    Subtract,
    Multiply,
    Division
  }

  public static void Main (String[] args) 
  {
    Console.WriteLine("\n1 - Sum \n 2 - Subtract \n 3 - Multiply \n 4 - Division "); 
    int index = int.Parse(Console.ReadLine());

    Panel selectOption = (Panel)index;

    switch(selectOption)
    {
      case Panel.Sum:
        Sum();
      break;
      case Panel.Subtract:
        Sub();
      break;
      case Panel.Multiply:
        Mult();
      break;
      case Panel.Division:
        Div();
      break;
    default:
      Console.WriteLine("This option not exists");
      break;
    }
  }

  public static void Sum ()
  {
    Console.WriteLine("Write a number: ");
    int numOption1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Write a new number: ");
    int numOption2 = int.Parse(Console.ReadLine());

    int result = numOption1 + numOption2;
    Console.WriteLine(result);
  }

  public static void Sub ()
  {
    Console.WriteLine("Write a number: ");
    int numOption1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Write a new number: ");
    int numOption2 = int.Parse(Console.ReadLine());
    
    int result = numOption1 - numOption2;
    Console.WriteLine(result);
  }

  public static void Mult ()
  {
    Console.WriteLine("Write a number: ");
    int numOption1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Write a new number: ");
    int numOption2 = int.Parse(Console.ReadLine());
    
    int result = numOption1 * numOption2;
    Console.WriteLine(result);
  }
  public static void Div ()
  {
    Console.WriteLine("Write a number: ");
    int numOption1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Write a new number: ");
    int numOption2 = int.Parse(Console.ReadLine());
    
    int result = numOption1 / numOption2;
    Console.WriteLine(result);
  }

}