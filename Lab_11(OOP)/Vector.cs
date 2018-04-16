using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_OOP_
{
    partial class Vecktor
    {
        public static List<Vecktor> list_1 = new List<Vecktor>();
        private string error { get; set; }
        private int ID { get; set; }
        public bool flag = false;
        private const int f = 0;
        private static int count;
        public static int countNull = 0;
        public int sum { get;set ;}
        public bool flag_1 { get; set; }
        public static bool flagForNeg = false;
        static int countNeg = 0;
        public int sumAbs { get; set; }
        public bool flagLengthCount = false; 
        public int Len()
        {
            return this.arr.Length;
        }
        public Vecktor(int size)
        {
            count++;
            arr = new int[size];

        }

        public string Error
        {
            get
            {
                return error;
            }
        }
        public int id
        {
            get
            {
                return ID;
            }
        }
        public Vecktor()
        {
            count++;
        }

    }
    public partial class Vecktor
    {
        public int[] arr;
        public override int GetHashCode()
        {
            int hash = 269;
            ID.GetHashCode();
            hash = (hash * 47) + this.arr.Length.GetHashCode();
            return hash;
        }
        public virtual Boolean Equals(Vecktor obj)
        {
            bool a = false;
            if (obj.arr == null) return false;
            if (this.GetType() != obj.GetType()) return false;
            if (obj.arr.Length == this.arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == obj.arr[i])
                    {
                        if (i == arr.Length - 1)
                            a = true;
                    }
                    else { a = false; break; }
                }
            }
            else { a = false; }
            return a;
        }

        public static void InfoAboutObj(Vecktor obj)
        {
            Console.WriteLine("Этот объект определён как " + obj.ToString());
        }
        public void addValue(Vecktor obj)
        {
            Console.WriteLine("Введите желаемое значения вектора");
            for (int i = 0; i < this.arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < this.arr.Length) return arr[i];
                else { error = "выход за границы массива"; return 0; }
            }
            set
            {
                if (i >= 0 && i < this.arr.Length && value >= 0 && value <= 100) arr[i] = value;
                else error = "неверное значение";
            }
        }
        public void SetConst(ref int f)
        {
            Console.WriteLine("Значение статической переменной = " + f);
        }
        public void GetInfoAboutCount()
        {
            Console.WriteLine("Класс содержит " + count + " объектов");
        }
        public void GetID()
        {
            ID = this.arr.Length * count;
            Console.WriteLine("Значение вычесленного ID = " + ID);
        }

        public void ProizvedVector(int k)
        {
            Console.WriteLine("произведение значений вектора и целого числа " + k);
            for (int i = 0; i < this.arr.Length; i++)
            {
                arr[i] = arr[i] * k;
                Console.WriteLine(arr[i]);
            }
        }


        static void Method(out int i)
        {
            i = 44;
        }
        //addition to Task 3
        public bool nullVecktor()
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (this.arr[i] == 0)
                    flag_1 = true;
                if (i == this.arr.Length - 1)
                    {
                      if (flag_1)
                        {
                            flag_1 = true;
                            countNull++;
                        }
                    }
            }
            return flag_1;
        }
        public bool trueLength(Vecktor obj)
        {
            bool flag_1 = false;
            if (obj.arr.Length == 3 || obj.arr.Length == 5 || obj.arr.Length == 7)
                flag = true;
            return flag_1;
        }
        public int SumVector()
        {
            Console.WriteLine("сумма значений вектора = ");
            for (int i = 0; i < this.arr.Length; i++)
            {
                this.sum += this.arr[i];
            }
            Console.WriteLine(this.sum);
            return this.sum;
        }
        public bool negativeValue()
        {
            if (countNeg > 0)
            {
                flag = false;
                return false;
            }
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (this.arr[i] < 0)
                {
                    flag = true;
                    countNeg++;
                }
            }
            return true;
        }
        public int ModeSum()
        {
            Console.WriteLine("сумма модулей значений вектора = ");
            for (int i = 0; i < this.arr.Length; i++)
            {
                this.sumAbs += Math.Abs(this.arr[i]);
            }
            Console.WriteLine(this.sumAbs);
            return this.sumAbs;
        }
        public void lenCount()
        {
            if(this.arr.Length == 3 || this.arr.Length ==5 || this.arr.Length == 7)
            {
                flagLengthCount = true;
            }
        }
        public static void Print(IEnumerable<Vecktor> obj)
        {
            foreach(Vecktor i in obj)
            {
                for(int j=0;j<i.arr.Length;j++)
                {
                    Console.WriteLine(i.arr[j]);
                }
             }
        }
        public void MethodForLinq()
        {
            this.addValue(this);
            this.nullVecktor();
            this.lenCount();
            this.negativeValue();
        }
    }
}
