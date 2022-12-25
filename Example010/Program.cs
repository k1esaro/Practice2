Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int n1 = number/100 * 10;
int result = number/10 - n1;
Console.WriteLine(result);



