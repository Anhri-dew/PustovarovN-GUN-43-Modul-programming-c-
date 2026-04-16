class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Наша программа может использовать следующие математические операции (+ - * / %) введите 2 числа и знак математической операции ");

        //var a = Int32.Parse(Console.ReadLine());
        //var b = Int32.Parse(Console.ReadLine());
        //var result = 0;
        //Console.WriteLine("result {0} + {1} = {2}", a, b, result = a + b);
        //Console.WriteLine("result {0} - {1} = {2}", a, b, a - b);
        //Console.WriteLine("result {0} * {1} = {2}", a, b, a * b);
        //Console.WriteLine("result {0} / {1} = {2}", a, b, a / b);
        //Console.WriteLine("result {0} % {1} = {2}", a, b, a % b);
        //Console.WriteLine(result);


        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("введено не число");
            return;
        }
        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("введено не число");
            return;
        }


        //if (Int32.TryParse(Console.ReadLine(), out var a))
        //{
        //    Console.WriteLine($"введенное число {a}");
        //}
        //else
        //{
        //    Console.WriteLine("введено не число");
        //    return; // если тут убрать ретерн продолжится выполнение программы
        //}

        //if (Int32.TryParse(Console.ReadLine(), out var b))
        //{
        //    Console.WriteLine($"введенное число {b}");
        //}
        //else
        //{
        //    Console.WriteLine("введено не число");
        //    return;
        //}


        var s = Console.ReadLine();
        //var boolVar = true;
        if (s.Length == 0 || s.Length > 1 /*&& !boolVar непонял зачем нам нужен этот братиш*/)
        {
            Console.WriteLine("Введен не коректный знак математической операции");
            return;
        }

        switch (s[0])
        {
            case '+':
                Console.WriteLine("result {0} + {1} = {2}", a, b, a + b);
                break;

            case '-':
                Console.WriteLine("result {0} - {1} = {2}", a, b, a - b);
                break;

            case '*':
                Console.WriteLine("result {0} * {1} = {2}", a, b, a * b);
                break;

            case '/':
                Console.WriteLine("result {0} / {1} = {2}", a, b, a / b);
                break;

            case '%':
                Console.WriteLine("result {0} % {1} = {2}", a, b, a % b);
                break;

            default:
                Console.WriteLine("К сожалению введенный знак либо не является математическим, либо наша программа еще не умеет его обрабатывать, следите за обновлениями :)");
                break;
        }
    }
}
