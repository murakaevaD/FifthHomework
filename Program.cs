using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Na_15._10
{
        internal class Student
    {
        public string surname { get; set; } //get выполняются действия по получению значения свойства (возращаем)
        public string name { get; set; } //set устанавливается значение свойства
        public int birthYear { get; set; }
        public string exam { get; set; }
        public int scores { get; set; }
    }
    class Number_2
    {
        private static string Game(int[] firstKlan, int[] secondKlan)
        {
            string fraza1 = "Drinks All Round! Free Beers on Bjorg!";
            string fraza2 = "Ой, Бьорг -пончик! Ни для кого пива!";
            int count1 = 0;
            int count2 = 0;
            foreach (int n in firstKlan)
            {
                if (n == 5)
                {
                    count1 += 1;
                }
            }
            foreach (int n in secondKlan)
            {
                if (n == 5)
                {
                    count2 += 1;
                }
            }
            return count1 == count2 ? fraza1 : fraza2;
        }
        public void nyt()
        {
            Console.WriteLine("Номер 2");
            Console.Write("Введите количество элементов массива: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа для 1 массива:");
            int[] firstKlan = new int[d];
            for (int i = 0; i < firstKlan.Length; i++)
            {
                firstKlan[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите числа для 2 массива:");
            int[] secondKlan = new int[d];
            for (int i = 0; i < secondKlan.Length; i++)
            {
                secondKlan[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(Game(firstKlan, secondKlan));
        }

    }
    internal class Program
    {
        static void Number_1()
        {
            Console.WriteLine("Номер 1 (студенты)");
            Dictionary<int, Student> students = new Dictionary<int, Student>
            {
                [0] = new Student { surname = "Муракаева", name = "Дания", birthYear = 2004, exam = "англ", scores = 100 },
                [1] = new Student { surname = "Хайрнасова", name = "Дарина", birthYear = 2004, exam = "англ", scores = 99 },
                [2] = new Student { surname = "Листопадова", name = "Алина", birthYear = 2004, exam = "инфа", scores = 50 },
                [3] = new Student { surname = "Куликова", name = "Валерия", birthYear = 2003, exam = "физ", scores = 65 },
                [4] = new Student { surname = "Самигулин", name = "Ильназ", birthYear = 2005, exam = "инфа", scores = 94 },
                [5] = new Student { surname = "Мирный", name = "Иван", birthYear = 2005, exam = "инфа", scores = 67 },
                [6] = new Student { surname = "Табличкин", name = "Марсель", birthYear = 2004, exam = "физ", scores = 78 },
                [7] = new Student { surname = "Фахрутдинов", name = "Имиль", birthYear = 2004, exam = "англ", scores = 90 },
                [8] = new Student { surname = "Ильриус", name = "Федя", birthYear = 2004, exam = "инфа", scores = 76 },
                [9] = new Student { surname = "Хабибрахманов", name = "Паша", birthYear = 2003, exam = "физ", scores = 85 }
            };
            Console.WriteLine("Меню: Новый студент / Удалить / Сортировать");
            string a = Console.ReadLine();
            switch (a)
            {
                case "Новый студент":
                    Console.Write("Введите фамилию студента: ");
                    string sur = Console.ReadLine();
                    Console.Write("Введите имя студента: ");
                    string nam = Console.ReadLine();
                    Console.Write("Введите год рождения: ");
                    int god = int.Parse(Console.ReadLine());
                    Console.Write("Введите экзамен");
                    string ex = Console.ReadLine();
                    Console.Write("Введите баллы за экзамен: ");
                    int ball = int.Parse(Console.ReadLine());
                    students.Add(11, new Student { surname = sur, name = nam, birthYear = god, exam = ex, scores = ball });
                    break;

                case "Удалить":
                    Console.Write("Введите фамилию и имя через пробел: ");
                    string[] name = Console.ReadLine().Split(' ');
                    var item = students.First(x => x.Value.surname == name[0]);
                    students.Remove(item.Key);
                    foreach (var b in students)
                    {
                        Console.WriteLine($" Имя: {b.Value.surname} {b.Value.name}, Год рождения: {b.Value.birthYear}, Экзамен: {b.Value.exam}, Баллы: {b.Value.scores} ");
                    }
                    break;

                case "Сортировать":
                    Console.WriteLine("Отсортированный список: \n");
                    var sortStud = students.OrderBy(x => x.Value.scores);
                    foreach (var c in sortStud)
                    {
                        Console.WriteLine($" Имя: {c.Value.surname} {c.Value.name}, Год рождения: {c.Value.birthYear}, Экзамен: {c.Value.exam}, Баллы: {c.Value.scores}  ");
                    }
                    break;
            }
        }
        public class person
        {
            public string name;
            public string pasport;
            public string problem;
            public int scandal;
            public bool Smart;

            public person(string name, string passport, string problem, int scandal, bool Smart)
            {
                this.name = name;
                this.pasport = pasport;
                this.problem = problem;
                this.scandal = scandal;
                this.Smart = Smart;
            }

        }
        public class Window
        {
            Check check = new Check();
            public string problem;
            public List<person> notSortedQueuePersons = new List<person>();
            public Queue<person> queuePersons;
            public void AllPeopele()
            {
                for (int i = 0; i < notSortedQueuePersons.Count; i++)
                {
                    Console.WriteLine(i + ": " + notSortedQueuePersons[i].name);
                }
            }
            public void Peopele()
            {
                Console.WriteLine("Окно " + problem);
                AllPeopele();
                for (int i = 0; i < notSortedQueuePersons.Count; i++)
                {
                    if (notSortedQueuePersons[i].scandal >= 5)
                    {
                        int userChoose;
                        bool flag = false;
                        Console.WriteLine(notSortedQueuePersons[i].name + " очень наглая. Скольких он обгонит?");
                        check.UserInutWithCheckInteger(out userChoose);
                        if (i - userChoose > 0)
                        {
                            person rotate = notSortedQueuePersons[i - userChoose];
                            notSortedQueuePersons[i - userChoose] = notSortedQueuePersons[i];
                            notSortedQueuePersons[i] = rotate;
                        }
                    }
                }
                queuePersons = new Queue<person>(notSortedQueuePersons);
            }
            public void BlPers()
            {
                while (queuePersons.Count > 0)
                {
                    person person = queuePersons.Dequeue();
                    Console.WriteLine("Обработка жителя:");
                    Console.WriteLine(person.pasport + ": " + person.name);
                }
            }
        }
        public class Zinochka
        {
            Window[] allWindows;
            public Stack<person> stackPers = new Stack<person>();
            public void InsertAllStack()
            {
                stackPers.Push(new person("Эля", "1", "Подключение", 10, true));
                stackPers.Push(new person("Марина", "2", "Другое", 2, false));
                stackPers.Push(new person("Юля", "8", "Оплата", 3, true));
                stackPers.Push(new person("Мира", "4", "Оплата", 7, false));
                stackPers.Push(new person("Алсу", "4", "Другое", 1, false));
                stackPers.Push(new person("Илюза", "3", "Подключение", 9, true));
                stackPers.Push(new person("Феруза", "1", "Оплата", 5, true));
                stackPers.Push(new person("Эда", "5", "Другое", 5, true));
                stackPers.Push(new person("Пырыл", "9", "Подключение", 6, true));
                stackPers.Push(new person("Язгуль", "3", "Оплата", 0, false));

            }
            public Zinochka(Window[] allWindows)
            {
                this.allWindows = allWindows;
                InsertAllStack();
            }
            public void Cold()
            {
                while (stackPers.Count > 0)
                {
                    person person = stackPers.Pop();
                    if (person.Smart)
                    {
                        for (int i = 0; i < allWindows.Length; i++)
                        {
                            if (person.problem == allWindows[i].problem)
                            {
                                allWindows[i].notSortedQueuePersons.Add(person);
                            }
                        }
                    }
                    else
                    {
                        Random random = new Random();
                        int villageChoose = random.Next(0, allWindows.Length);
                        allWindows[villageChoose].notSortedQueuePersons.Add(person);
                    }

                }
            }
        }
        public class Check
        {
            public bool UserInutWithCheckInteger(out int userNumber)
            {
                Console.WriteLine("Введите число:");
                while (!int.TryParse(Console.ReadLine(), out userNumber))
                {
                    Console.WriteLine("Ошибка, введите число");
                }
                return true;
            }
        }
        class Number_3
        {
            string[] problems = { "Подключение", "Оплата", "Другое" };
            Window[] allWindows = new Window[3];
            public void fac()
            {
                Console.WriteLine("Задание 3");
                for (int i = 0; i < 3; i++)
                {
                    allWindows[i] = new Window();
                    allWindows[i].problem = problems[i];
                }
                Zinochka zina = new Zinochka(allWindows);
                zina.Cold();
                for (int i = 0; i < allWindows.Length; i++)
                {
                    allWindows[i].Peopele();
                    allWindows[i].BlPers();
                }
            }
        }
        public class Graph //обход графа в глубину
        {
            LinkedList<int>[] linkedListArray;

            public Graph(int v)
            {
                linkedListArray = new LinkedList<int>[v];
            }
            public void AddEdge(int u, int v, bool blnBiDir = true)
            {
                if (linkedListArray[u] == null)
                {
                    linkedListArray[u] = new LinkedList<int>();
                    linkedListArray[u].AddFirst(v);
                }
                else
                {
                    var last = linkedListArray[u].Last;
                    linkedListArray[u].AddAfter(last, v);
                }

                if (blnBiDir)
                {
                    if (linkedListArray[v] == null)
                    {
                        linkedListArray[v] = new LinkedList<int>();
                        linkedListArray[v].AddFirst(u);
                    }
                    else
                    {
                        var last = linkedListArray[v].Last;
                        linkedListArray[v].AddAfter(last, u);
                    }
                }
            }

            internal void DFSHelper(int src, bool[] visited)
            {
                visited[src] = true;
                Console.Write(src + "->");
                if (linkedListArray[src] != null)
                {
                    foreach (var item in linkedListArray[src])
                    {
                        if (!visited[item] == true)
                        {
                            DFSHelper(item, visited);
                        }
                    }
                }
            }
            internal void DFS()
            {
                Console.WriteLine("номер 4 (обход графа в глубину)");
                bool[] visited = new bool[linkedListArray.Length + 1];
                DFSHelper(1, visited);

            }
        }
        static void Main(string[] args)
        {
            //Number_1();

            //Number_2 Number_2 = new Number_2();
            //Number_2.nyt();

            //Number_3 number_3 = new Number_3();
            //number_3.fac();

            /*
             *               1
             *             / | \
             *            2  5  9
             *           /  / \   \
             *          3  6   8   10
             *         /  / 
             *        4  7
             *
             */
            Graph graph = new Graph(11);
            graph.AddEdge(1, 2, false);
            graph.AddEdge(2, 3, false);
            graph.AddEdge(3, 4, false);
            graph.AddEdge(1, 5, false);
            graph.AddEdge(5, 6, false);
            graph.AddEdge(6, 7, false);
            graph.AddEdge(5, 8, false);
            graph.AddEdge(1, 9, false);
            graph.AddEdge(9, 10, false);
            graph.DFS();
        }
    }
}
