Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int digit = 0;
if (a<=99)
Console.WriteLine("третьей цифры нет");
else {
while (a>=1000)
    a = a/10;
digit = a%10;
Console.WriteLine(digit);
};