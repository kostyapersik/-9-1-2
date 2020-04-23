using System;

namespace Лабароторная_9
{

    class Money
    {
        //Объявление переменных
        public int rubles;
        public int kopeks;

        //Установка свойств для Рублей
        public int Rub
        {
            get { return rubles; }
            set
            {
                if (value < 0)
                { rubles = 0; }
                else rubles = value;
            }
        }

        //Установка свойств для Копеек
        public int Kop
        {
            get { return kopeks; }
            set
            {
                if (value < 0)
                { kopeks = 0; }
                else
                {
                    if (value > 99)
                    {
                        rubles = value / 100;
                        kopeks = value % 100;
                    }
                    else kopeks = value;
                };
            }
        }

        public Money()
        {
            Rub = 0;
            Kop = 0;
        }

        public Money(int r, int k)
        {
            Rub = r;
            Kop = k;
        }


        //Вычитание
        public static Money operator - (Money m1, Money m2)
        {
            Money temp = new Money();
            temp.Rub = m1.Rub - m2.Rub;
            temp.Kop = m1.Kop - m2.Kop;
            return temp;
        }


        //Сложение
        public static Money operator +(Money m1, Money m2)
        {
            Money temp = new Money();
            temp.Rub = m1.Rub + m2.Rub;
            temp.Kop = m1.Kop + m2.Kop;
            return temp;
        }

        //Перегрузка унарной операции ++ для Копеек
        public static Money operator ++(Money m)
        {
            m.Kop++;
            return m;
        }
        //Перегрузка унарной операции -- для Копеек
        public static Money operator --(Money m)
        {
            m.Kop--;
            return m;
        }

        //Перегрузка бинарной операции + для Копеек
        public static Money operator +(int kop, Money m)
        {
            Money temp = new Money();
            temp.Rub = m.Rub;
            temp.Kop = m.Kop + kop;
            return temp;
        }
        public static Money operator +(Money m, int kop)
        {
            Money temp = new Money();
            temp.Rub = m.Rub;
            temp.Kop = m.Kop + kop;
            return temp;
        }

        //Перегрузка бинарной операции - для Копеек
        public static Money operator -(int kop, Money m)
        {
            Money temp = new Money();
            temp.Rub = m.Rub;
            temp.Kop = m.Kop - kop;
            return temp;
        }
        public static Money operator -(Money m, int kop)
        {
            Money temp = new Money();
            temp.Rub = m.Rub;
            temp.Kop = m.Kop - kop;
            return temp;
        }

        //Вывод значения
        public void Show()
        {
            Console.WriteLine($"{Rub} руб. {Kop} коп. ");
        }

    }
    class Program
    {


        static void Main(string[] args)
        {
            Money First = new Money(5, 20);
            First.Show();
            Money Second = new Money(5, 0);
            Second.Show();
            Money Third = First - Second;
            Third.Show();
            Third = First + Second;
            Third.Show();
            Money temp = new Money(5, 0);
            temp.Show();
            temp++;
            temp.Show();
            --temp;
            temp.Show();
        }
    }
}
