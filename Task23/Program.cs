Console.WriteLine("Введите натуральное число");
string? input = Console.ReadLine();
if (int.TryParse(input, out int num))
{
    int number = Convert.ToInt32 (input);
    if (number <= 0)
    {
        Console.WriteLine ("Нужно ввести НАТУРАЛЬНОЕ число!");
    }
    for (int i = 1; i <= number; i++)
        Console.WriteLine (i*i*i);
}
else 
    Console.WriteLine("Вы ввели не совсем число");
