// Программа принимает на вход цифру, обозначающую день недели
// и проверяет, является ли этот день выходным.

Console.WriteLine(" Введите  число от 1 до 7:");
string num = Console.ReadLine();
int Num = Convert.ToInt32( num );

if((Num ==6) || (Num ==7))
{
    Console.WriteLine($" {Num}, выходной день");
}
else
{
    Console.WriteLine($" {Num}, не выходной день");
}