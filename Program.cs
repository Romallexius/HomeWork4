//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int numA = 0;
int numB = 0;
int sum = 0;

while(true)
{
    Console.WriteLine("Введите целое число А:");

    if(int.TryParse(Console.ReadLine(), out int number))
    {
        numA = number; break;
    }
    else Console.WriteLine("Некорректно указано число!\n");
}
while(true)
{
    Console.WriteLine("Введите целое НАТУРАЛЬНОЕ число В:");

    if(int.TryParse(Console.ReadLine(), out int number))
    {
        if(number < 0) 
        {
            Console.WriteLine("Вами введено НЕ натуральное число (отрицательное)!");
            continue;
        }
        else numB = number; break;
    }
    else Console.WriteLine("Некорректно указано число!\n");
}

Console.WriteLine("число " + numA + " в степени " + numB + " = " + Calculate(numA, numB));

int Calculate(int a, int b)
{
    if (a == 0 && b == 0)
    {
        sum = 1;
    }
    else
    {
        sum = a;
        for(int i = 1; i < b; i++)
        {
            sum = sum * a;
        }
    }
    return sum;
}

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число ");

        int number = Convert.ToInt32(Console.ReadLine()!);

        int sum(int number)

        {
            int count = Convert.ToString(number).Length;
            int a = 0;
            int result = 0;

            for (int i = 0; i < count; i++)
            {
                a = number - number % 10;
                result = result + (number - a);
                number = number / 10;
            }
            return result;
        }

        int sumNumber = sum(number);
        Console.WriteLine("Сумма цифр в числе: " + sumNumber);
    }
}

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("программа, создающая массив из N введённых в консоль чисел\nВам необходимо ввести N целых чисел");

int count = 1;
List<int> array = new List<int>();

while(true) {
    Console.WriteLine("Введите " + count + "-е число:");
        string str = Console.ReadLine();
        if(str == "стоп") {
            break;
        }
        if(int.TryParse(str, out int number)) {
            array.Add(number);
            count++;
            continue;
        }
        else {
            Console.WriteLine("Некорректно указано число!\n");
            continue;
        }
    }

Console.WriteLine("Вы создали массив: "); Print(array);

void Print(List<int> array)
{
    for(int index = 0; index < count - 1; index++) {
        if(index == 0) Console.Write("[" + array[index] + ", ");
        else if (index == count - 2) Console.Write(array[index] + "]!");
        else Console.Write(array[index] + ", ");
    }
}
