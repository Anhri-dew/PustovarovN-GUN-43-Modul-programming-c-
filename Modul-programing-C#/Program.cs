class Programm
{
    static void Main(string[] args)
    {

        
        if (Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine($"введенное число в 2-чной форме {Convert.ToString(a, 2)}");
            Console.WriteLine($"введенное число в 10-чной форме {a}");
            Console.WriteLine($"введенное число в 16-ричной форме {Convert.ToString(a, 16)}");
        }
        else
        {
            Console.WriteLine("введено не число");
            return; // если тут убрать ретерн продолжится выполнение программы
        }

        if (Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine($"введенное число в 2-чной форме {Convert.ToString(b,2)}");
            Console.WriteLine($"введенное число в 10-чной форме {b}");
            Console.WriteLine($"введенное число в 16-ричной форме {Convert.ToString(b, 16)}");
        }
        else
        {
            Console.WriteLine("введено не число");
            return;
        }

        Console.WriteLine();


        Console.WriteLine("Введите побитовый оператор & | или ^");
        var s = Console.ReadLine();

        if (s.Length == 0 || s.Length > 1 || (s[0] != '&' && s[0] != '|' && s[0] != '^')) 
        {
            Console.WriteLine("Введен не коректный знак побитовой операции");
            return;
        }

        switch (s[0])
        {
            case '&':
                Console.WriteLine("результат вычисленгия в 2-чной форме {0} & {1} = {2}", Convert.ToString(a,2), Convert.ToString(b,2), Convert.ToString(a & b ,2));
                Console.WriteLine("результат вычисленгия в 10-чной форме {0} & {1} = {2}", a, b, a & b);
                Console.WriteLine("результат вычисленгия в 16-чной форме {0} & {1} = {2}", Convert.ToString(a, 16), Convert.ToString(b, 16), Convert.ToString(a & b, 16));
                break;

            case '|':
                Console.WriteLine("результат вычисленгия в 2-чной форме {0} | {1} = {2}", Convert.ToString(a, 2), Convert.ToString(b, 2), Convert.ToString(a | b, 2));
                Console.WriteLine("результат вычисленгия в 10-чной форме {0} | {1} = {2}", a, b, a | b);
                Console.WriteLine("результат вычисленгия в 16-чной форме {0} | {1} = {2}", Convert.ToString(a, 16), Convert.ToString(b, 16), Convert.ToString(a | b, 16));
                break;

            case '^':
                Console.WriteLine("результат вычисленгия в 2-чной форме {0} ^ {1} = {2}", Convert.ToString(a, 2), Convert.ToString(b, 2), Convert.ToString(a ^ b, 2));
                Console.WriteLine("результат вычисленгия в 10-чной форме {0} ^ {1} = {2}", a, b, a ^ b);
                Console.WriteLine("результат вычисленгия в 16-чной форме {0} ^ {1} = {2}", Convert.ToString(a, 16), Convert.ToString(b, 16), Convert.ToString(a ^ b, 16));
                break;
        }
    }
}
