using System;
using System.Collections.Generic;

namespace dz_3
{
    class Program
    {
        /// <summary>
        /// Акулов Д.С. 3 дз
        /// </summary>
        static void Main(string[] args)
        {
            // Complex x = new Complex(10, 123);
            // Complex y = new Complex(23, 12);

            //Complex_struct t = new Complex_struct(312, 123);
            //Helps.Printm($"{t}");
            //Helps.Pause();

            //Drob x = new Drob(123, 3323);
            //double y = x.Nms;
            //Helps.Print($"{y}");
            //Helps.Pause();
         
            do
            {

                switch (Helps.Msg_int("Выберите задачу 1,2 или 3"))
                {
                    case 1:
                        // калькулятор комплексных чисел
                        switch (Helps.Msg_int("Выберите 1 - стуктуры, 2 - классы"))
                        {
                            case 1:
                                do
                                {
                                    Z_1_a();
                                } while (Helps.Msg_int("1 - еще раз") == 1);
                                break;
                            case 2:
                                do
                                {
                                    Z_1();
                                } while (Helps.Msg_int("1 - еще раз") == 1);
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        // задача с суммой чисел
                        Helps.Print($"\nСумма нечетных положительных чисел: {Z_2(Helps.Msg_int("Введите число (0 - стоп) >"))}");
                        break;
                    case 3:
                        do
                        {
                            Z_3();
                        } while (Helps.Msg_int("1 - еще раз") == 1);
                        break;
                    default:
                        break;
                }
            } while (Helps.Msg_int("Вернуться к задачам? (1 - yes)") == 1);

            Helps.Pause();
        }

        static void Z_1()
        {
            Complex a = new Complex(Helps.Msg_int("Реальная часть 1ого числа"), Helps.Msg_int("Мнимая часть 1ого числа"));
            Helps.Print($"Отлично, первое число {a}");
            Complex b = new Complex(Helps.Msg_int("Реальная часть 2ого числа"), Helps.Msg_int("Мнимая часть 2ого числа"));
            Helps.Print($"Отлично, второе число {b}");
            switch (Helps.Msg_int("1-сложение\n2-вычитание\n3-Умножение\n4-Деление\nВыберите операцию:"))
            {

                case 1: // сумма
                    Helps.Print($"a> {a}\nb> {b}\nСумма: {a + b}");
                    break;
                case 2: //вычитание
                    Helps.Print($"a> {a}\nb> {b}\nРазница: {a - b}");
                    break;
                case 3: // умножение
                    Helps.Print($"a> {a}\nb> {b}\nПроизведение: {a * b}");
                    break;
                case 4: // деление
                    Helps.Print($"a> {a}\nb> {b}\nДеление: {a / b}");
                    break;
                default:
                    Console.WriteLine("Такой операции не существует!");
                    break;
            }
        } // классы комлпексных чисел

        static int Z_2(int x)
        {
            List<int> numbers = new List<int>();
            int result = 0;
            int checker = x;
            while (checker != 0)
            {
                checker = Helps.Msg_int("Введите число (0 - стоп) >");
                if (checker / 2 != 0 && checker > 0)
                {

                    numbers.Add(checker);
                    result = result + checker;
                }
            }
            Helps.Printm("Введенные числа: ");
            foreach (int number in numbers)
            {
                Helps.Printm($"{number}; ");
            }
            return result;
        } // ввод чисел с TryParse

        static void Z_1_a()
        {
            Complex_struct a = new Complex_struct(Helps.Msg_int("Реальная часть 1ого числа"), Helps.Msg_int("Мнимая часть 1ого числа"));
            Helps.Print($"Отлично, первое число {a}");
            Complex_struct b = new Complex_struct(Helps.Msg_int("Реальная часть 2ого числа"), Helps.Msg_int("Мнимая часть 2ого числа"));
            Helps.Print($"Отлично, второе число {b}");
            switch (Helps.Msg_int("1-сложение\n2-вычитание\n3-умножение\nВыберите операцию:"))
            {

                case 1: // сумма
                    Helps.Print($"a> {a}\nb> {b}\nСумма:{a.Plus(b)}");
                    break;
                case 2: //вычитание
                    Helps.Print($"a> {a}\nb> {b}\nРазница: {a.Minus(b)}");
                    break;
                case 3: //умножение
                    Helps.Print($"a> {a}\nb> {b}\nРазница: {a.Multi(b)}");
                    break;
                default:
                    Console.WriteLine("Такой операции не существует!");
                    break;
            }
        } // структуры комлпексных чисел

        static void Z_3()
        {
            Drob a = new Drob(Helps.Msg_int("Числитель 1ого числа"), Helps.Msg_int("Знаменатель 1ого числа"));
            Helps.Print($"Отлично, первое число {a}");
            Drob b = new Drob(Helps.Msg_int("Числитель 2ого числа"), Helps.Msg_int("Знаменатель 2ого числа"));
            Helps.Print($"Отлично, второе число {b}");
            switch (Helps.Msg_int("1-сложение\n2-вычитание\n3-Умножение\n4-Деление\n" +
                "5-доступ к числителю\n6-доступ к знаменателю\n" +
                "7-десятичный вид дробей\n8-сокращение дробей\nВыберите операцию:"))
            {
                case 1: // сумма
                    Helps.Print($"a> {a}\nb> {b}\nСумма: {a + b}");
                    break;
                case 2: //вычитание
                    Helps.Print($"a> {a}\nb> {b}\nРазница: {a - b}");
                    break;
                case 3: // умножение
                    Helps.Print($"a> {a}\nb> {b}\nПроизведение: {a * b}");
                    break;
                case 4: // деление
                    Helps.Print($"a> {a}\nb> {b}\nДеление: {a / b}");
                    break;
                case 5:
                    Helps.Print($"Числитель а> {a.Num}\nЧислитель b> {b.Num}");
                    break;
                case 6:
                    Helps.Print($"Числитель а> {a.Den}\nЧислитель b> {b.Den}");
                    break;
                case 7:
                    Helps.Print($"Десятичная дробь а> {a.Nms}\nДесятичная дробь b> {b.Nms}");
                    break;
                case 8:
                    Helps.Print($"a> {a}\nb> {b}\nСокращение a: {a.Nod}\n Сокращение b: {b.Nod}");
                    break;
                default:
                    Console.WriteLine("Такой операции не существует!");
                    break;
            }
        } //дроби
    }
}
