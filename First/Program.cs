using System;
using System.Text;
using System.Globalization;
using System.IO;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sonad = new string[7] { "aaa", "bbb", "ccc", "ddd", "eee", "fff", "zzz" };
            foreach (string sona in sonad)
            {
                Console.WriteLine(sona);
            }
            for (int i = 0; i < sonad.Length; i++)
            {
                Console.WriteLine(sonad[i]);
            }
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Valjuta Escape");
                key = Console.ReadKey();
            } while (key.Key!=ConsoleKey.Escape);
            /*
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello world!");
            Random rnd = new Random();
            Console.Write("Yes-random, ei-ise sisestan number: ");
            string soov = Console.ReadLine();
            int numb = 0;
            if (soov=="jah")
            {
                numb = rnd.Next(1, 8);
                Console.WriteLine($"Day number: {numb}");
            }
            else
            {
                try
                {
                    Console.Write("Enter the day: ");
                    numb = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Day number: {numb}");
                }
                catch (SystemException)
                {
                }
            }
            string nimetus = "";
            switch (numb)
            {
                case 1: nimetus = "Monday"; break;
                case 2: nimetus = "Tuesday"; break;
                case 3: nimetus = "Wednesday"; break;
                case 4: nimetus = "Thursday"; break;
                case 5: nimetus = "Friday"; break;
                case 6: nimetus = "Saturday"; break;
                case 7: nimetus = "Sunday"; break;
                default:
                    nimetus = "Error!";
                    break;
            }
            Console.WriteLine(nimetus);

            StreamWriter file = new StreamWriter(@"..\..\..\andmed.txt", false);
            file.WriteLine($"Number was {numb}, day {nimetus}.");
            file.Close();
            StreamReader filest = new StreamReader(@"..\..\..\andmed.txt");
            string a = filest.ReadToEnd();
            Console.WriteLine("This is the fail: \n" + a);*/
            //-----------------------------------------------------
            /*
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Введите значение 'a', 'z', 'v', 'b'.");
                Console.Write("'a': ");
                try
                {
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("'z': ");
                    double z = Convert.ToDouble(Console.ReadLine());
                    Console.Write("'v': ");
                    double v = Convert.ToDouble(Console.ReadLine());
                    Console.Write("'b': ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    double answer = Math.Round((15 * a + z) / (11 * v - 13 * b), 2);
                    Console.WriteLine($"Ответ: {answer}.");
                }
                catch
                {
                    Console.WriteLine("Ошибка при введении значений.");
                }
            }
            */
            //------------------------------------------------------
            /*
            Console.OutputEncoding = Encoding.UTF8;
            string name = "";
            string group = "";
            string variant = "";
            string age = "";
            string who = "";
            string lab = "";
            string labName = "";
            
            try
            {
                Console.Write("Введите имя и фамилию(Очество не обязательно): ");
                name = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Ошибка при введении данных.");
            }
            try
            {
                Console.Write("Введите группу в которой учитесь: ");
                group = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Ошибка при введении данных.");
            }
            try
            {
                Console.Write("Введите номер варианта: ");
                variant = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Ошибка при введении данных.");
            }
            try
            {
                Console.Write("Введите возраст: ");
                age = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Ошибка при введении данных.");
            }
            try
            {
                Console.Write("Введите пол: ");
                who = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Ошибка при введении данных.");
            }
            try
            {
                Console.Write("Введите номер лабороторной работы: ");
                lab = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Ошибка при введении данных.");
            }
            try
            {
                Console.Write("Введите название лабороторной работы: ");
                labName = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Ошибка при введении данных.");
            }

                StreamWriter file = new StreamWriter(@"..\..\..\andmed.txt", false);
                file.WriteLine($"Имя-Фамилия: {name}\nГруппа: {group}\nНомер варианта: {variant}\nВозраст: {age}\nПол: {who}\nНомер лабороторной работы: {lab}\nНазвание лабороторной работы: {labName}");
                file.Close();
            */
            //------------------------------------------------------
            /*
            Console.Write("First number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a >= 0)
            {
                Console.WriteLine("'a' is positive.")
            }
            else
            {
                Console.WriteLine("'a' is negative.");
            }
            if (b >= 0)
            {
                Console.WriteLine("'b' is positive.");
            }
            else
            {
                Console.WriteLine("'b' is negative.");
            }
            */
        }
    }
}
