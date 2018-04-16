using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//добавила для необобщ коллекции
using System.Collections.ObjectModel;//добавлено для класса-наблюдателя
using System.Collections.Specialized;//добавлено для класса-наблюдателя

namespace Lab_10_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1.1
            ArrayList array = new ArrayList();
            Random rnd = new Random(5);
            for(int i=0;i<4;i++)
                array.Add(rnd.Next());
            foreach (Object prop in array)
            {
                Console.WriteLine(prop);
            }
            //Task 1.2
            string str = "Hello";
            array.Add(str);
            //Task 1.3
            Console.WriteLine("Введите индекс элемента, который желаете удалить");
            int indexForRemove = int.Parse(Console.ReadLine());
            array.RemoveAt(indexForRemove-1) ;
            Console.WriteLine("Stack<T> не содержащий " + indexForRemove +" элемент");
            //Task 1.4
            foreach (Object prop in array)
            {
                Console.WriteLine(prop);
            }
            Console.WriteLine("Количество элементов в Stack<T> = " + array.Count);
            //1.5 Serch;
            Object lastElem = array[array.Count - 1];
            Console.WriteLine("Проверка на наличие в необобщённой коллеции элемента");
            string elemSrech = "Hello";
            foreach(Object prop in array)
            {
                if(prop == elemSrech)
                {
                    Console.WriteLine("Элемент " + elemSrech + " найден в необобщённой коллекции ArrayList");
                }
                else
                {
                    if (prop == lastElem)
                        Console.WriteLine("Данный элемент не найден в необобщённой коллекции");
                    
                }
            } 
            Console.WriteLine("==================================================");
            //Task 2.1
            Stack<char> stack = new Stack<char>();
            stack.Push('A');
            stack.Push('B');
            stack.Push('C');
            foreach(char i in stack)
            {
                Console.WriteLine(i);
            }
            //Task 2.2
            Console.WriteLine("Сколько элементов желаете удалить?");
            int countForRemove = int.Parse(Console.ReadLine());
            for(int i = 0; i < countForRemove; i++)
            {
                stack.Pop();
            }
            Console.WriteLine("Stack<T> не содержащие первые " +countForRemove  +" элементы");
            foreach (char i in stack)
            {
                Console.WriteLine(i);
            }
            //Task 2.3
            stack.Push('D');
            stack.Push('E');
            stack.Push('F');
            Console.WriteLine("new Stack<T>");
            foreach (char i in stack)
            {
                Console.WriteLine(i);
            }
            //Task 2.4
            List<Stack<char>> list = new List<Stack<char>>();
            list.Add(stack);
            Console.WriteLine("Обобщённая коллекция List<T>,использующая данные коллекции Stack<T>");
            //Task 2.5
            foreach(Stack<char> l in list)
            {
                foreach (char s in l)
                    Console.WriteLine(s);
            }
            //Task 2.6 Serch
            char serchLetter = 'E';
            Console.WriteLine("Проверка на наличие в обобщённой коллекции буквы " + serchLetter );
            bool f = false;
            foreach (Stack<char> l in list)
            {
                foreach (char s in l)
                {
                    if (s == serchLetter)
                    {
                        Console.WriteLine("Данная буква есть в коллекции");
                        f = true;
                    }

                }
            }
            if(!f)
            {
                Console.WriteLine("Данная буква в коллекции не найдена");
            }
            Console.WriteLine("==================================================");
            //Task 3
            Word word = new Word(1.0);
            Word word_2 = new Word(2.0);
            Word word_3 = new Word(3.0);
            Stack<Word> stack2 = new Stack<Word>();
            stack2.Push(word);
            stack2.Push(word_2);
            stack2.Push(word_3);
            Console.WriteLine("Необобщённая коллекция, использующая пользовательский класс");
            foreach(Word w in stack2)
            {
                Console.WriteLine("Компания производитель: " + Word.companyManyfacturer + " Версия программного продукта: " + w.version);
            }
            Console.WriteLine("Сколько элементов желаете удалить?");
            int countForWordRemove = int.Parse(Console.ReadLine());
            for (int i = 0; i < countForWordRemove; i++)
            {
                stack2.Pop();
            }
            Console.WriteLine("Stack<Word> не содержащие первые " + countForRemove  + " элемента");
            foreach (Word w in stack2)
            {
                Console.WriteLine("Компания производитель: " + Word.companyManyfacturer + " Версия программного продукта: " + w.version);
            }
            Word word_4 = new Word(1.0);
            stack2.Push(word_4);
            Console.WriteLine("new Stack<Word> :");
            foreach (Word i in stack2)
            {
                Console.WriteLine("Компания производитель: " + Word.companyManyfacturer + " Версия программного продукта: " + i.version);
            }
            List<Stack<Word>> list_2 = new List<Stack<Word>>();
            list_2.Add(stack2);
            Console.WriteLine("Обобщённая коллекция List<Stack<Word>>,использующая данные коллекции Stack<Word>");
            foreach (Stack<Word> m in list_2)
            {
                foreach (Word s in m)
                    Console.WriteLine("Компания производитель: " + Word.companyManyfacturer + " Версия программного продукта: " + s.version);
            }
            Stack<Word> stack_3 = new Stack<Word>();
            stack_3.Push(word_4);
            list_2.Add(stack_3);
            //Serch
                Console.WriteLine("==================================================");
            //Task 4
            ObservableCollection<Word> users = new ObservableCollection<Word>();
            users.CollectionChanged += Users_CollectionChanged;
            users.Add(new Word(5.0));
            users.Add(word);
            users.Remove(word);
        }
        private static void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    Word newUser = e.NewItems[0] as Word;
                    Console.WriteLine("Добавлен новый объект: {0}", newUser);
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    Word oldUser = e.OldItems[0] as Word;
                    Console.WriteLine("Удален объект: {0}", oldUser);
                    break;
            }
        }
    }
}
