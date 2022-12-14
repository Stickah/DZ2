Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
if (99<a & a<1000)
    Console.WriteLine(a/10%10);
else
Console.WriteLine("Ведите именно трехзначное число");