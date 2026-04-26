using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_programing_C_
{
    internal class Homework_cycle
    {
        static void Main(string[] args)
        {
            OneCase();
            TwoCase();
            ThreeCase();
            FourCase();
        }

        static void OneCase()
        {
            Console.WriteLine("-----------OneCase--------------");
            int[] fibonachi_array = new int[10];
            for (int i = 0; i < fibonachi_array.Length; i++)
            {
                if (i == 0)
                {
                    fibonachi_array[i] = i;
                }
                else if (i == 1)
                {
                    fibonachi_array[i] = i;
                }
                else
                {
                    fibonachi_array[i] = fibonachi_array[i - 2] + fibonachi_array[i - 1];
                }

                Console.WriteLine(fibonachi_array[i]);
            }

        }

        static void TwoCase()
        {
            Console.WriteLine("-----------TwoCase--------------");
            int[] array = new int[20];
            for (int i = 0  ; i < array.Length ; i++)
            {
                array[i] = i +1 ;

                if (array[i] % 2 == 0 )
                {
                    Console.WriteLine(array[i]);  
                }
            }   
        }

        static void ThreeCase()
        {
            Console.WriteLine("-----------ThreeCase--------------");

            int[] array = new int[10];
            for (int i = 1 ;i < array.Length ; i++)
            {
                if (i > 5)
                {
                    break;
                } 

                int a = i;
                Console.WriteLine($"---таблица умножения {a} ---");

                
                    for (int j = 0; j < array.Length; j++)
                    {
                        Console.WriteLine(i * j);
                    }

            }
        }

        static void FourCase()
        {
            Console.WriteLine("-----------FourCase--------------");
            

            
            Console.WriteLine("Установите пароль");
            string password = Console.ReadLine();
            string userInput = "";
            do
            {
                Console.WriteLine("Введите пороль для входа");
                userInput = Console.ReadLine();
                if (password == userInput)
                {
                    Console.WriteLine("пароль введен верно");
                }
                else
                {
                    Console.WriteLine("Попробйте вновь ввести пароль");
                }
            }
            while (password != userInput);
            
        }


    }
}
