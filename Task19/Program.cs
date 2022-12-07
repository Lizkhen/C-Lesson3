Console.WriteLine ("Введите пятизначное число");
string? input = Console.ReadLine();
if (int.TryParse(input, out int num))
{   
    int number = Convert.ToInt32(input);
    if (number > 0)
    {
        if (number > 99999 && number < 10000)
            Console.WriteLine ("Ошибка!");
            string str = number.ToString();
            int[] Array = new int[str.Length];
            int strLen = str.Length;
            for ( int i=0; i< str.Length; i++)
            { 
                Array[i] = Convert.ToInt32(str[i].ToString()); 
            }

            if (number < 99999 && number > 10000 && number > 0)
            {
                if (Array[0] != Array[4] || Array[1]!=Array[3])
    
                {
                Console.WriteLine ("Нет, это не палиндром");
                }
                else
                    Console.WriteLine ("Да, это палиндром!");
            }    
            else
                Console.WriteLine ("Введено некорректное число");
    }        
    else 
        Console.WriteLine ("Палиндром не может быть орицательным"); 
}
else
    Console.Write ("В строке не только цифры");

