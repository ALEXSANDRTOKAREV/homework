 int PoverNumder(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }

    return result;
}

  Console.Write("Введите  первое число : ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите второе число : ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int poverNumder =PoverNumder(numberA, numberB);
  Console.WriteLine("Ответ: " + poverNumder);
