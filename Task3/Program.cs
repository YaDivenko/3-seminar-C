System.Console.Write("Введите число: ");
int n = Convert.ToInt32 (Console.ReadLine ());

System.Console.WriteLine("Таблица кубов чисел");

for (int i = 1; i <= n; i++)
{
    System.Console.WriteLine($"{i} => {Math.Pow(i, 3)}");
}

