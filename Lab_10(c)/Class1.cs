using System;

 public class Word
    {
        public void Create()
        {
            Console.WriteLine("Программа установлена");
        }
        public void Delete()
        {
            Console.WriteLine("Программа удалена");
        }
        int h;
        int m;
        int sec;
        public Word(int f, int v, int d)
        {
            h = f;
            m = v;
            sec = d;
        }
        public void WordMethod()
        {
            Console.WriteLine("Время создания дока" + h + "." + m + "." + sec);
        }
    }
