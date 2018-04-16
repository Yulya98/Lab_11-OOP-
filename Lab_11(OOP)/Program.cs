using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_OOP_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            #region
            Month m = new Month();
            Month m_1 = new Month();
            Console.WriteLine("Введите длину строки = ");
            int i = Convert.ToInt32(Console.ReadLine());
            IEnumerable<string> sequence1 = from n in m.month
                                            where n.Length == i
                                            select n;
            IEnumerable<string> sequence2 = from n in m.month
                                            orderby n
                                            select n;
            IEnumerable<string> sequence3 = from n in m.mouthSummerAndWinter
                                            select n;
            int countOfMon = m.month.Count(p => p.Contains('u') && m.month.Length > 4);
            Console.WriteLine("Название месяцев с указанной длинной: ");
            Month.Print(sequence1);
            Console.WriteLine("Летние месяца: ");
            Console.WriteLine("Месяца в алфавитном порядке: ");
            Month.Print(sequence2);
            Console.WriteLine("Месяца содеражащие букву u и неменьше по длине 4: {0}", countOfMon);
            #endregion
            //Task 2 and Task 3
            #region
            List<Vecktor> list_1 = new List<Vecktor>();
            Vecktor vecktor_1 = new Vecktor(3);
            vecktor_1.MethodForLinq();
            Vecktor vecktor_2 = new Vecktor(4);
            vecktor_2.addValue(vecktor_2);
            vecktor_2.MethodForLinq();
            Vecktor vecktor_3 = new Vecktor(5);
            vecktor_3.MethodForLinq();
            Vecktor vecktor_4 = new Vecktor(7);
            vecktor_4.MethodForLinq();
            list_1.Add(vecktor_1);
            list_1.Add(vecktor_2);
            list_1.Add(vecktor_3);
            list_1.Add(vecktor_4);
            //нулевые элементы массива экземпляра класса Vecktor
            Console.WriteLine("Первый экземпляр класса Vecktor, имеющий отрицательный вектор");
            IEnumerable<Vecktor> selectFirstNeg = from n in list_1
                                   where n.flag == true
                                   select n;
            Vecktor.Print(selectFirstNeg);
            IEnumerable<int> selectVector = from n in list_1
                                            where n.flag_1 == true
                                            select Vecktor.countNull;
            int newMax;
            if (selectVector.Count() > 0)
                newMax = selectVector.Max();
            //наибольший модуль, наименьший модуль
            IEnumerable<Vecktor> selectVectorModSumVecktor = from n in list_1
                                                             select n;
            int min = selectVectorModSumVecktor.Min(p => p.ModeSum());
            Console.WriteLine("Наименьший модуль суммы массива экземляра Vector = " + min);
            int max = selectVectorModSumVecktor.Max(p => p.SumVector());
            Console.WriteLine("Максимальный вектор суммы массива экземляра Vector = " + max);
            Console.WriteLine("Отсортированные по полю Length объекты класса Vecktor: ");
            IEnumerable<Vecktor> ord = list_1.OrderBy(s => s.arr.Length);
            Vecktor.Print(ord);
            Console.WriteLine("Экземпляры класса Vector, имеющие длину массива == 3 || 5 ||7 ");
            IEnumerable<Vecktor> selectVectorForLen = from n in list_1
                                                           where n.flagLengthCount == true 
                                                           select n;
            Vecktor.Print(selectVectorForLen);
            #endregion
        }
    }
}
