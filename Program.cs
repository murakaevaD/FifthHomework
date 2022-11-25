using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Na_15._10.Program;

namespace Na_15._10
{
        internal class Student
    {
        public string surname { get; set; }
        public string name { get; set; }
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
        enum windows
        {
            первое = 0,
            второе = 1,
            третье = 2
        }
        public class Visitor
        {
            public Visitor() { }
            public Visitor(int Id, string Name, int NumOfproblem, string Problem, int IQ, int Scandal)
            {
                this.Id = Id;
                this.Name = Name;
                this.NumOfProblem = NumOfProblem;
                this.Problem = Problem;
                this.IQ = IQ;
                this.Scandal = Scandal;
            }
            public string Name { get; set; }
            public int Id { get; set; }
            public int NumOfProblem { get; set; }
            public string Problem { get; set; }
            public int IQ { get; set; }
            public int Scandal { get; set; }
        }
        public static void Zina()
        {
            Console.WriteLine("История в жэке. Начался отопительный сезон, в городе начали " +
                "включать отопление и у жителей возникают проблемы.Для решения этих проблем они идут в жэк.В жэке есть 3 окна:" +
                "первое окно помогает людям решить проблемы с отоплением(подключение и тд)," +
                "второе окно решает проблемы с оплатой отопления, в третье окно идут все остальные." +
                "Необходимо создать структуру жителя.У жителя есть имя, номер паспорта(для однозначной идентификации), " +
                "проблема, темперамент.Проблема характеризуется номером и описанием." +
                "Темперамент характеризуется степенью скандальности от 0 до 10(10 - скандалист, 0 - паинька)," +
                " умом(1 - умный, 0 - тупой). В каждое окно жители встают по очереди." +
                "Перед входом в жэк стоит Зина, которая уточняет у жителей, какая у них проблема и по " +
                "ключевым словам определяет их в нужное окно. Если житель скандалист(от 5 и выше), " +
                "то он не будет обращать внимание на очередь и обгонит людей, которые впереди него" +
                "(на сколько человек обгонять житель спрашивает у пользователя)." +
                "Если человек тупой, то он встаёт не в то окно, даже несмотря на указание Зины(случайным образом)." +
                "К Зине все выстраиваются в стек.");
            string path = @"C:\Users\дания\source\repos\Na_15.10\zina.txt";
            List<Visitor> listOfVisitors = new List<Visitor>();
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    Visitor person = new Visitor();
                    string text = reader.ReadLine().ToLower();
                    string[] guests = new string[6];
                    guests = text.Split( );
                    person.Name = guests[0];
                    person.Id = int.Parse(guests[1]);
                    person.NumOfProblem = int.Parse(guests[2]);
                    person.Problem = guests[3];
                    person.IQ = int.Parse(guests[4]);
                    person.Scandal = int.Parse(guests[5]);

                    listOfVisitors.Add(person);
                }

                listOfVisitors.Reverse();
                for (int i = 0; i < listOfVisitors.Count(); i++)
                {

                    Visitor person = listOfVisitors[i];
                    Console.WriteLine("Имя: " + person.Name + "\nПаспорт: " + person.Id + "\nНомер проблемы: " + person.NumOfProblem +
                        "\nПроблема: " + person.Problem);

                    if (person.Problem.Contains("podklychenie"))
                    {
                        Console.WriteLine("Зина направила в первое окно");
                        switch (person.IQ)
                        {
                            case 1:
                                Array values = Enum.GetValues(typeof(windows));
                                Random random = new Random();
                                windows randomBar = (windows)values.GetValue(random.Next(values.Length));
                                Console.WriteLine("{0} окно", randomBar);
                                if (person.Scandal > 5)
                                {
                                    Console.WriteLine("Сколько человек обогнать?");
                                    int num3 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Обогнали {0} людей", num3);
                                    Console.WriteLine("(чтобы продолжить - enter)");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("(чтобы продолжить - enter)");
                                    Console.ReadLine();
                                }
                                continue;

                            case 0:
                                Console.WriteLine("Первое окно");
                                if (person.Scandal > 5)
                                {
                                    Console.WriteLine("Сколько человек обогнать?");
                                    int num3 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Обогнали {0} людей", num3);
                                    string wait = Console.ReadLine();
                                    Console.WriteLine("чтобы продолжить - enter)");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("(чтобы продолжить - enter)");
                                    Console.ReadLine();
                                }
                                continue;
                        }
                    }
                    else if (person.Problem.Contains("oplata"))
                    {
                        Console.WriteLine("Зина направила во второе окно");
                        switch (person.IQ)
                        {
                            case 1:
                                Array values = Enum.GetValues(typeof(windows));
                                Random random = new Random();
                                windows randomBar = (windows)values.GetValue(random.Next(values.Length));
                                Console.WriteLine("{0} окно", randomBar);
                                if (person.Scandal > 5)
                                {
                                    Console.WriteLine("Сколько человек обогнать?");
                                    int num3 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Обонали {0} людей", num3);
                                    Console.WriteLine("(чтобы продолжить - enter)");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("(чтобы продолжить - enter)");
                                    Console.ReadLine();
                                }
                                continue;
                            case 0:
                                Console.WriteLine("Первое окно");
                                if (person.Scandal > 5)
                                {
                                    Console.WriteLine("Сколько людей хотите обогнать?");
                                    int num3 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Обогнали {0} людей", num3);
                                    Console.WriteLine("(чтобы продолжить - enter)");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("(чтобы продолжить - enter)");
                                    Console.ReadLine();
                                }
                                continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Зина направила в третье окно");
                        switch (person.IQ)
                        {
                            case 1:
                                Array values = Enum.GetValues(typeof(windows));
                                Random random = new Random();
                                windows randomBar = (windows)values.GetValue(random.Next(values.Length));
                                Console.WriteLine("{0} окно", randomBar);
                                if (person.Scandal > 5)
                                {
                                    Console.WriteLine("Сколько человек обогнать?");
                                    int num3 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Обогнали {0} людей", num3);
                                    Console.WriteLine("(чтобы продолжить - enter)");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("(чтобы продолжить - enter)");
                                    Console.ReadLine();
                                }
                                continue;
                            case 0:
                                Console.WriteLine("Первое окно");
                                if (person.Scandal > 5)
                                {
                                    Console.WriteLine("Сколько человек обогнать?");
                                    int num3 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Обогнали {0} людей", num3);
                                    Console.WriteLine("(чтобы продолжить - enter)");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("(чтобы продолжить - enter)");
                                    Console.ReadLine();
                                }
                                continue;
                        }
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            Zina();

            //Number_1();

            //Number_2 Number_2 = new Number_2();
            //Number_2.nyt();

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
            //Graph graph = new Graph(11);
            //graph.AddEdge(1, 2, false);
            //graph.AddEdge(2, 3, false);
            //graph.AddEdge(3, 4, false);
            //graph.AddEdge(1, 5, false);
            //graph.AddEdge(5, 6, false);
            //graph.AddEdge(6, 7, false);
            //graph.AddEdge(5, 8, false);
            //graph.AddEdge(1, 9, false);
            //graph.AddEdge(9, 10, false);
            //graph.DFS();
        }
    }
}
