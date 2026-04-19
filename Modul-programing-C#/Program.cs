//class Programm
//{
//    static void Main(string[] args)
//    {


//        if (Int32.TryParse(Console.ReadLine(), out var a))
//        {
//            Console.WriteLine($"введенное число в 2-чной форме {Convert.ToString(a, 2)}");
//            Console.WriteLine($"введенное число в 10-чной форме {a}");
//            Console.WriteLine($"введенное число в 16-ричной форме {Convert.ToString(a, 16)}");
//        }
//        else
//        {
//            Console.WriteLine("введено не число");
//            return; // если тут убрать ретерн продолжится выполнение программы
//        }

//        if (Int32.TryParse(Console.ReadLine(), out var b))
//        {
//            Console.WriteLine($"введенное число в 2-чной форме {Convert.ToString(b,2)}");
//            Console.WriteLine($"введенное число в 10-чной форме {b}");
//            Console.WriteLine($"введенное число в 16-ричной форме {Convert.ToString(b, 16)}");
//        }
//        else
//        {
//            Console.WriteLine("введено не число");
//            return;
//        }

//        Console.WriteLine();


//        Console.WriteLine("Введите побитовый оператор & | или ^");
//        var s = Console.ReadLine();

//        if (s.Length == 0 || s.Length > 1 || (s[0] != '&' && s[0] != '|' && s[0] != '^')) 
//        {
//            Console.WriteLine("Введен не коректный знак побитовой операции");
//            return;
//        }

//        switch (s[0])
//        {
//            case '&':
//                Console.WriteLine("результат вычисленгия в 2-чной форме {0} & {1} = {2}", Convert.ToString(a,2), Convert.ToString(b,2), Convert.ToString(a & b ,2));
//                Console.WriteLine("результат вычисленгия в 10-чной форме {0} & {1} = {2}", a, b, a & b);
//                Console.WriteLine("результат вычисленгия в 16-чной форме {0} & {1} = {2}", Convert.ToString(a, 16), Convert.ToString(b, 16), Convert.ToString(a & b, 16));
//                break;

//            case '|':
//                Console.WriteLine("результат вычисленгия в 2-чной форме {0} | {1} = {2}", Convert.ToString(a, 2), Convert.ToString(b, 2), Convert.ToString(a | b, 2));
//                Console.WriteLine("результат вычисленгия в 10-чной форме {0} | {1} = {2}", a, b, a | b);
//                Console.WriteLine("результат вычисленгия в 16-чной форме {0} | {1} = {2}", Convert.ToString(a, 16), Convert.ToString(b, 16), Convert.ToString(a | b, 16));
//                break;

//            case '^':
//                Console.WriteLine("результат вычисленгия в 2-чной форме {0} ^ {1} = {2}", Convert.ToString(a, 2), Convert.ToString(b, 2), Convert.ToString(a ^ b, 2));
//                Console.WriteLine("результат вычисленгия в 10-чной форме {0} ^ {1} = {2}", a, b, a ^ b);
//                Console.WriteLine("результат вычисленгия в 16-чной форме {0} ^ {1} = {2}", Convert.ToString(a, 16), Convert.ToString(b, 16), Convert.ToString(a ^ b, 16));
//                break;
//        }
//    }
//}

public static class Programm
{
    static void Main(string[] args)
    {
        //int[] fibonachi = new int[8] { 0, 1, 1, 2, 3, 5, 8, 13 };
        //string[] month = new string[12]
        //{
        //    "January",
        //    "February",
        //    "March",
        //    "April",
        //    "May",
        //    "June",
        //    "July",
        //    "August",
        //    "September",
        //    "October",
        //    "November",
        //    "December"
        //};
        //int[,] dobleArray = new int[3,3]
        //{

        //    {(int)Math.Pow(2,1), (int)Math.Pow(3,1), (int)Math.Pow(4,1) },
        //    {(int)Math.Pow(2,2), (int)Math.Pow(3,2), (int)Math.Pow(4,3) },
        //    {(int)Math.Pow(2,3), (int)Math.Pow(3,3), (int)Math.Pow(4,3) },

        //};

        //double[][] arrayArray = new double[3][]
        //{
        //    new double[5]{1 ,2,3,4,5},
        //    new double[2]{Math.E, Math.PI },
        //    new double[4]{Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) }
        //};



        int[] array = { 1, 2, 3, 4, 5 };
        int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
        Array.Copy(array, array2, 3);
        Console.WriteLine(string.Join(" ", array2));

        string[] sample = { "", "" };

        Array.Resize(ref array, 10);
        Console.WriteLine(string.Join(" ", array));
    }

}
