/*50Пn=1 (4n^2/(4n^2-1)
Аналитическая функция = P/2 */

double calcFunc = 1; //расчетная функция
double anltFunc = 3.14 / 2; //аналитическая функция
int n; //счетчик

//цикл
for (n = 1; n <= 50; n++)
{
    calcFunc *= (4 * Math.Pow(n, 2)) / (4 * Math.Pow(n, 2) - 1);
}

//вывод
Console.WriteLine("Результат функции = " + calcFunc);
Console.WriteLine("Аналитическая фунция = " + anltFunc);
//проверка на совпадение
if (Math.Abs(calcFunc - anltFunc) < 1.0)
{
    Console.WriteLine("Расчеты верны");
}
else
{
    Console.WriteLine("Расчеты не верны");
}
