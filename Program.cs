int a;
int b;
int c = new int();
int znak;

Console.Write("Введите A: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("1 - сложение;");
Console.Write("Введите нужную цифру: ");
znak = Convert.ToInt32(Console.ReadLine());

if (znak == 1)
{
    c = a + b;
}


Console.WriteLine("Ответ: " + c);