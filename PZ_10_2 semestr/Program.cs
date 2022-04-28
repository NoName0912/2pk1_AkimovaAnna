using System;
using System.Linq;

//Группа студента вводится числом 
//Не смогла реализовать сортировку по среднему баллу, реализована сортировка по имени
//Не смогла реализовать поиск студентов, у которых оценки только 4 или 5, но ещё попытаюсь что-то придумать

namespace PZ_10_2_semestr
{
    class Program
    {
        struct Student
        {
            public string Name;
            public int GroupNomber;
            int[] progress;

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
                string[] marks = Console.ReadLine().Split(',');

                int[] progress = new int[5];
                for (int a = 0; a < 5; a++)
                    progress[a] = int.Parse(marks[a].ToString());

                students[i] = new Student(name, nomber, progress);
            }

            var stud = from i in students orderby i.Name select i; //Сортировка!

            Console.WriteLine("\n\nУпорядоченный по имени массив студентов: ");

            foreach (Student student in stud)
                Console.WriteLine("\n" + student.ToString());

            Console.ReadKey();
        }
    }


}