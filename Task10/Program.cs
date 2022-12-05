// Программа принимает на вход  трехзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine(" Введите трехзначное число :");
string num = Console.ReadLine();
int Num = Convert.ToInt32( num );
Console.WriteLine($" Вы ввели число {Num}");
int Num1 = Num/100;
int Num2 = (Num - Num1*100)/10;
Console.WriteLine($"вторая цифра- {Num2}");