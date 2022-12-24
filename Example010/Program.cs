Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
char[] array = number.ToString().ToCharArray();
Console.WriteLine(array[1]);



