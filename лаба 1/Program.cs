using System;
using System.Text;

namespace лаба_1
{
    class Program
    {
        static int[][] FillingArray(int [][] arr)
        {
            for(int i =0;i < arr.Length; i++)
                for(int j = 0; j < arr[i].Length; j++)
                    arr[i][j] = int.Parse(Console.ReadLine());
            return arr;
        }
        static void Main(string[] args)
        {


            //1)ТИПЫ
            //a)
            //Логический типы:
            //Для чего используется: для проверки условий в if-конструкциях, циклах и т.д.

            bool isValid = true;
            Console.WriteLine(isValid);


            //Целые числа со знаком:
            //Этот тип данных содержит целочисленные значения: как положительные, так и отрицательные. Один бит памяти,
            //выделенной на такое значение, отводится на знак: +или -.

            sbyte check = 123;
            Console.WriteLine(check);
            //Размер: 8 бит.
            //Допустимые значения: от - 128 до 127.
            //Значение по умолчанию: 0.

            short value = 3333;
            Console.WriteLine(value);
            //Размер: 16 бит.
            //Допустимые значения: от - 32768 до 32767.
            //Значение по умолчанию: 0.

            int value2 = 50000;
            Console.WriteLine(value2);
            //Размер: 32 бита.
            //Допустимые значения: от - 2^31 до 2^31 - 1.
            //Значение по умолчанию: 0.

            long value3 = 3000000L;
            Console.WriteLine(value3);
            //Размер: 64 бита.
            //Допустимые значения: от - 2^63 до 2^63 - 1.
            //Значение по умолчанию: 0L(L в конце означает, что это значение типа long).


            //Целые числа без знака:
            //Эти типы данных содержат только значения равные или больше нуля, то есть неотрицательные значения.
            //Если вы уверены, что код не будет пытаться присваивать переменной отрицательное значение, можете смело использовать эти типы данных.'

            byte value4 = 6;
            Console.WriteLine(value4);
            //Размер: 8 бит.
            //Допустимые значения: от 0 до 255.
            //Значение по умолчанию: 0.

            ushort value5 = 1000;
            Console.WriteLine(value5);
            //Размер: 16 бит.
            //Диапазон допустимых значений: от 0 до 65535.
            //Значение по умолчанию: 0.

            uint value6 = 10000;
            Console.WriteLine(value6);
            //Размер: 32 бита.
            //Допустимые значения: от 0 до 2^32 - 1.
            //Значение по умолчанию: 0.

            ulong value7 = 1000000L;
            Console.WriteLine(value7);
            //Размер: 64 бита.
            //Допустимые значения: от 0 до 2^64 - 1.
            //Значение по умолчанию: 0.


            //Числа с плавающей точкой:
            //Эти типы данных содержат числа с плавающей точкой, то есть числа с десятичными дробями — например, 12.36, -92.17 и т.д.

            float value8 = 23.2f;
            Console.WriteLine(value8);
            //Точность: одинарная(зн - 1 бит,порядок - 8 бит,мантисса 23 - бита).
            //Размер: 32 бита.
            //Допустимые значения: от - 3.4 * 10^38 до 3.4 * 10^38.
            //Значение по умолчанию: 0.0F(F на конце обозначает, что это значения типа float).

            double value9 = 2345.2;
            Console.WriteLine(value9);
            //Точность: двойная(зн - 1 бит,порядок 11 - бит,мантисса 52 - бита)
            //Размер: 64 бита.
            //Допустимые значения: от ±5.0 * 10 - 324 до ±1.7 * 10308.
            //Значение по умолчанию: 0.0D(D на конце обозначает, что это значение типа double).


            //Символьный тип(char):

            char a = 'a';
            Console.WriteLine(a);
            //Размер: 16 бит.
            //Допустимые значения: от U+0000('\u0000') до U+FFFF('\uffff') — символы Unicode.
            //Значение по умолчанию: '\0'.


            //Тип Decimal
            //Тип decimal имеет большую точность и меньший диапазон допустимых значений по сравнению с типами с плавающей точкой (double и float),
            //поэтому этот тип данных подходит для денежных расчетов.

            decimal value10 = 9.34234324M;
            Console.WriteLine(value10);
            //Размер: 128 бит.
            //Допустимые значения: от ±1.0 * 10^- 28 до ±7.9228 * 10^28.
            //Значение по умолчанию: 0.0M(M на конце обозначает, что значение представляет тип decimal).


            //b)
            sbyte value11 = 6;
            short value12 = value11;
            int value13 = value11;
            long value14 = value11;
            float value15 = value11;
            decimal value16 = value11;

            sbyte n1 = 2;
            byte n2 = (byte)n1;
            ushort n3 = (ushort)n1;
            uint n4 = (uint)n1;
            ulong n5 = (ulong)n1;
            int n6 = (int)56.8;
            string abc = "16";
            int n7 = System.Convert.ToInt32(abc);//Пользовательское приведение

            //c)
            //Когда любой значимый тип присваивается к ссылочному типу данных, значение перемещается из области стека в кучу.Эта операция называется упаковкой.
            //Когда любой ссылочный тип присваивается к значимому типу данных, значение перемещается из области кучи в стек.Это называется распаковкой.

            int n8 = 100;
            object obj = n8;
            int n9 = (int)obj;
            //ToString

            //d)
            var n10 = 50403;//Неявная типизация - компилятор сам определяет подходящий тип


            //e)

            int? n11 = null;
            Console.WriteLine(n11);

            //f)
            var str = "maxim daniletscki";
            //str = 12;



            //2)СТРОКИ
            //a)
            var arr = new int[2] { 1, 2 };
            var arr1 = new int[2] { 1, 2 };
            string c = "abc hfds dof";
            string d = "abc";//Сначало сравнит указывают ли ссылки на один и тот же объект и если нет,то будет сравнивать две ссылки типа string

            Console.WriteLine(c == d);
            Console.WriteLine(arr == arr1);


            //b)
            string e = "!";
            Console.WriteLine(c + d + e);
            string f = string.Copy(e);
            Console.WriteLine(f);
            string g = c.Substring(1, c.Length - 1);
            Console.WriteLine(g);
            var h = c.Split(' ');
            foreach (var elem in h) Console.WriteLine(elem);
            string i = "abbbbc";
            i = i.Insert(3, " ");
            Console.WriteLine(i);
            string str1 = "oooocccc";
            str1 = str1.Remove(4);
            Console.WriteLine(str1);
            Console.WriteLine($"{str1} maximka: {i}");//один из видов форматирования строк
            Console.WriteLine("maxim {0} g {1}", str1, i);

            //c)
            string str2 = "";
            string str3 = null;
            Console.WriteLine(string.IsNullOrEmpty(str2));
            Console.WriteLine(string.IsNullOrEmpty(str3));
            //Console.WriteLine(str3.Length);
            Console.WriteLine(str3 + str3);
            str3 = i;
            Console.WriteLine(str2.Length);


            //d)
            var strBuilder = new StringBuilder();
            strBuilder.Append("aye");
            strBuilder.Append("123");
            strBuilder.Insert(0, "hahah");
            strBuilder.Remove(3, 5);


            //3)МАССИВЫ
            //a)
            var matrix = new int[5, 5]
            {
                {1,2,3,4,5},
                {6,7,8,9,1},
                {5,3,1,1,0},
                {5,4,3,1,0},
                {1,4,4,0,5}
            };
            
            var len1 = matrix.GetLength(0);
            var len2 = matrix.GetLength(1);
            Console.WriteLine();
            for (int j =0;j < len1; j++)
            {
                for(int k =0;k < len2; k++)
                    Console.Write(matrix[j,k] + " ");
                Console.WriteLine();
            }


            //b)
            var strArray = new string[5] { "vital9", "chel", "pro", "deadinside", "onlypain" };
            strArray[2] = "AAHAHHAHAHAH";


            //c)
            //int[] ARRAY = new int[3] { 2, 3, 4 };
            var intArr = new int[3][];
            intArr[0] = new int[2];
            intArr[1] = new int[3];
            intArr[2] = new int[4];
            //var fullArr = FillingArray(intArr);
            for (int j2 = 0; j2 < intArr.Length; j2++)
            {
                for (int k2 = 0; k2 < intArr[j2].Length; k2++)
                    Console.Write(intArr[j2][k2] + " ");
                Console.WriteLine();
            }
            var STR = new string[2] { "A", "B" };


            //4)Кортежи- предоставляют удобный способ для работы с набором значений(с C# 7.0)
            //a)
            (int, string, char, string, ulong) tuple1 = (1, "abc", 'a', "HAHHA", 1000);
            //b)
            Console.Write(tuple1.Item1);
            Console.Write(tuple1.Item2);
            Console.Write(tuple1.Item3);
            Console.Write(tuple1.Item4);
            Console.Write(tuple1.Item5);

            Console.WriteLine(tuple1.Item1);
            Console.WriteLine(tuple1.Item3);
            Console.WriteLine(tuple1.Item5);

            //c)
            int kortej1 = tuple1.Item1;
            string kortej2 = tuple1.Item2;
            char kortej3 = tuple1.Item3;
            string kortej4 = tuple1.Item4;
            ulong kortej5 = tuple1.Item5;

            (var number, var number1) = ("123", 123);
            Console.WriteLine(number);
            Console.WriteLine(number1);

            var (number2, number3) = ("214", 1000);
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            var (_, _, _, word1, long1) = tuple1;
            Console.WriteLine(word1);
            Console.WriteLine(long1);

            var tuple = (one:1, two:"qwe");

            var oneone = (int)tuple.one;
            Console.WriteLine(oneone);

            //d)
            var kor = (A: 5, B: "s");
            var kor1 = (B: 5, A: "s");
            Console.WriteLine(kor == kor1);
            Console.WriteLine(kor != kor1);
            //Они сравнимы если выполняются несколько условий:
            //1)Кол-во элементов в кортеже должно быть одинаково
            //2)Все элементы кортежей у которых позиция одинакова должны быть одинакового типа.



            //5)Локальные функции - представляют функции,определенные внутри других методов.
            //Локальная функция,как правило,содержит действия,которые применяется только в рамках ее метода.
            var arr2 = new int[4] { 1, 2, 3, 4 };
            var STR2= "jenek";
            (int max,int min,int sum,char firstLetter) LocalMethod(int [] arr,string word)
            {
                var min = int.MaxValue;
                var max = int.MinValue;
                var sum = 0;
                foreach(var e in arr)
                {
                    if (e < min) min = e;
                    if (e > max) max = e;
                    sum += e;
                }
                return (max, min,sum,word[0]);
            }
            var (max, min, sum, letter) = LocalMethod(arr2, STR2);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            Console.WriteLine(letter);


            //6)Сhecked/Unchecked - ключевые слова которые позволяют обрабатывать арифметическое переполнение


            void LocalChecked()
            {
                checked//генерирует исключение если у нас переполнение
                {
                    int a = int.MaxValue;
                    Console.WriteLine(a + 1);
                }
            }
            void LocalUnChecked()
            {
                unchecked//не появляется исключение и усекается значение чтобы оно не вышло за диапазон допустимых значений
                    //усекание - отбрасывание всех старших битов(В случае сложения выполняется переход от максимального значения к минимальному)


                {
                    int a = int.MaxValue;
                    Console.WriteLine(a + 1);
                   
                }
            }

            LocalChecked();
            LocalUnChecked();
        }





        
    }
}
