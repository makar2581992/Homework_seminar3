// палиндром
int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int Str = Prompt("Введите число: ");

string someStr = Str.ToString();
string rev = new string(someStr.Reverse().ToArray());

int reStr = int.Parse(rev);
if (Str == reStr)
{
    System.Console.WriteLine($"Число {Str} является палиндромом");
}

else
{
    System.Console.WriteLine($"Число {Str} не является палиндромом");
}
