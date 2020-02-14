using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomialApp
{
    public class Polynomial
    {
        //Массив коэффициентов
        int[] Coefficient { get; set; }
        //Степень многочлена
        public int Degree { get; set; }
        //В конструктор передаем коэффициенты, исходя из их количества устанавливаем степень многочлена
        public Polynomial(params int[] coefficient)
        {
            Coefficient = coefficient;
            Degree = Coefficient.Length - 1;
        }
        //Перегрузка полином + полином
        public static Polynomial operator +(Polynomial polyA, Polynomial polyB)
        {
            int[] M1 = new int[polyA.Degree + 1];
            Polynomial polyC = new Polynomial(M1);
            for (int i = 0; i < polyA.Degree + 1; i++)
            {
                polyC.Coefficient[i] = polyA.Coefficient[i] + polyB.Coefficient[i];
            }

            return polyC;
        }
        //Перегрузка полином - полином
        public static Polynomial operator -(Polynomial polyA, Polynomial polyB)
        {
            int[] M1 = new int[polyA.Degree + 1];
            Polynomial polyC = new Polynomial(M1);
            for (int i = 0; i < polyA.Degree + 1; i++)
            {
                polyC.Coefficient[i] = polyA.Coefficient[i] - polyB.Coefficient[i];
            }

            return polyC;
        }
        //Перегрузка полином * число
        public static Polynomial operator *(Polynomial polyA, int num)
        {
            int[] M1 = new int[polyA.Degree + 1];
            Polynomial polyC = new Polynomial(M1);
            for (int i = 0; i < polyA.Degree + 1; i++)
            {
                polyC.Coefficient[i] = polyA.Coefficient[i] * num;
            }

            return polyC;
        }
        //Перегрузка число * полином
        public static Polynomial operator *(int num, Polynomial polyA)
        {
            int[] M1 = new int[polyA.Degree + 1];
            Polynomial polyC = new Polynomial(M1);
            for (int i = 0; i < polyA.Degree + 1; i++)
            {
                polyC.Coefficient[i] = polyA.Coefficient[i] * num;
            }

            return polyC;
        }
        //Форматирование полинома в строку
        public string Show()
        {
            string polyStr = "";
            //Знак + или - в зависимости от знака числа
            char ch;
            for (int i = 0; i <= Degree; i++)
            {
                ch = '+';
                if (Coefficient[i] < 0 && i != 0)
                {
                    Coefficient[i] = Math.Abs(Coefficient[i]);
                    ch = '-';
                }

                if (i == 0 && Coefficient[i] != 0)
                {
                    polyStr += $" {ch} {Coefficient[i]}";
                }
                else if (Coefficient[i] == 1)
                {
                    polyStr += $" {ch} X^{i}";
                }
                else if (i == 1)
                {
                    polyStr += $" {ch} {Coefficient[i]}X";
                }
                else if (Coefficient[i] == 0)
                {

                    polyStr += $" ";
                }
                else
                {
                    polyStr += $" {ch} {Coefficient[i]}X^{i}";
                }
            }
            return polyStr.Remove(0, 3);
        }
    }
}

