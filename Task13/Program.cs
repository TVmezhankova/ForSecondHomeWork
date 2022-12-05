// Программа выводит третью цифру заданного числа и 
// сообщает, что третьей цифры нет.

Console.WriteLine(" Введите любое число :");
string num = Console.ReadLine();
int Num = Convert.ToInt32( num );
int Temp = 0;
if (Num<1000)
{
    Console.WriteLine($"Цифра меньше индекса");
}
else
    int Temp=Num;
while (Temp>1000)
{
    Temp=Temp/10;
}
int result=Temp%10;
Console.WriteLine($"Третья цифра числа {Num} - {result}");