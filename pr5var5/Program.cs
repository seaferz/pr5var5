double calcFunc = 1; //расчетная функция
double anltFunc = 3.14 / 2; //аналитическая функция
int n; //счетчик

//цикл
for ( n = 1; n <= 50; n++)
{
    calcFunc *= (4 * Math.Pow(n, 2)) / (4 * Math.Pow(n, 2) - 1);
}
Console.WriteLine(calcFunc); //вывод

//проверка на совпадение
if (Math.Abs(calcFunc - anltFunc) < 1.0)
{
    Console.WriteLine("Расчеты верны");
}
else
{
    Console.WriteLine("Расчеты не верны");
}
