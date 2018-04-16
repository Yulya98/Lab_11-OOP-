using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_c_
{
    class Word
    {
        public double version { get; set; }
        public const string companyManyfacturer = "Microsoft";
        public Word(double ver)
        {
            this.version = ver;
        }
        public void Create()
        {
           Console.WriteLine("Программа установлена");
        }
        public void Delete()
        {
           Console.WriteLine("Программа удалена");
        }
    }
}
