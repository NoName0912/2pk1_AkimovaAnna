using System;
using System.Linq;

//Группу вводить числом 

namespace Students
{
    internal class Program
    {
        struct Student
        {
            public string Name;
            public int GroupNomber;
            public int[] progress;

            public Student(string Name, int GroupNomber, int[] marks)
            {
                this.Name = Name;
                this.GroupNomber = GroupNomber;
                progress = marks;
            }

            public override string ToString()
            {
                return string.Format("ФИО: {0} \nНомер группы: {1}", Name, GroupNomber);
            }
        }

        static void Main(string[] args)
        {
            Student[] students = new Student[10];

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("Введите имя и инициалы {0}-ого студента: ", i + 1);
                string name = Console.ReadLine();
                Console.Write("Введите номер группы {0}-ого студента: ", i + 1);
                int nomber = int.Parse(Console.ReadLine());
                Console.Write("Введите, через запятую, 5 оценок {0}-ого студента: ", i + 1);
                string[] marks = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);

                int[] progress = new int[5];
                for (int a = 0; a < 5; a++)
                    progress[a] = int.Parse(marks[a]);

                students[i] = new Student(name, nomber, progress);
            }

            var stud = students.OrderBy(s => s.progress.Average()); 

            Console.WriteLine("\n\nУпорядоченный по возрастанию среднего балла массив студентов: ");

            foreach (Student student in stud)
                Console.WriteLine($"\n{student}");

            var goodStud = students.Where(s => s.progress.Max() > 3);
            if (goodStud.Any())
            {
                Console.WriteLine("\nСтуденты имеющие оценки 4 и 5: ");
                foreach (Student student in goodStud)
                    Console.WriteLine($"\n{student}");
            }
            else
                Console.WriteLine("\nСтудентов имеющих оценки 4 и 5 нет!");

            Console.ReadKey();
        }
    }
}