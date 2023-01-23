System.Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32 (Console.ReadLine ());
string i = n.ToString();

if (i[0]==i[4] & i[1]==i[3])
{
System.Console.WriteLine("Число является палиндромом");
}

else
{
    System.Console.WriteLine("Число не является палиндромом");
};



