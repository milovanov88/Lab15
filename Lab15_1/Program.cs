using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 15");
            Console.WriteLine("Введите начальное значение: ");
            Input(out int x);
            Console.WriteLine("Арифметическая прогрессия: ");
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(x);
            for (int i = 0; i < 5; i++)
            {
                arithProgression.getNext();

            }
            Console.WriteLine();
            arithProgression.reset();

            Console.WriteLine("Гелметрическая прогрессия: ");
            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart(x);
            for (int i = 0; i < 5; i++)
            {
                geomProgression.getNext();

            }
            Console.WriteLine();
            geomProgression.reset();

            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadLine();
        }
        static void Input(out int num)
        {
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 1) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода данных. Введите число заново");
                Input(out num);
            }
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();

    }
    class ArithProgression : ISeries
    {
        int Start;
        int value;
        public ArithProgression()
        {
            Start = 0;
            value = 0;
        }
        public void setStart(int x)
        {
            Start = x;
            value = x;
        }
        public int getNext()
        {
            value += Start;
            Console.Write($"{value} ");
            return (value);
        }
        public void reset()
        {
            value = Start;
            Console.WriteLine($"Сброс до начального значения {value} ");
        }


    }
    class GeomProgression : ISeries
    {
        int Start;
        int value;
        public GeomProgression()
        {
            Start = 0;
            value = 0;
        }
        public void setStart(int x)
        {
            Start = x;
            value = x;
        }
        public int getNext()
        {
            value = value * Start;
            Console.Write($"{value} ");
            return (value);
        }
        public void reset()
        {
            value = Start;
            Console.WriteLine($"Сброс до начального значения {value} ");


        }
    }
}