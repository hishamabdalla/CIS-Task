using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Application
{
     class College:CRUD
     {
        static List<Student> students = new List<Student>();

        public override void AddStudent()
        {
            Console.WriteLine("~~~~Add Student~~~~");
            Console.WriteLine("-----------------------");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            int id = ReadInt("Enter ID: ");


            Console.Write("Enter Faculty: ");
            string faculty = Console.ReadLine();

            int age = ReadInt("Enter Age: ");

            Console.Write("Enter Your Technology: ");
            string tech = Console.ReadLine();

            Student student = new(id, name, faculty, age, tech);

            students.Add(student);
            Console.Clear();

            Console.WriteLine("=============================");
            Console.WriteLine("[ Student added successfully.]");
            Console.WriteLine("=============================\n");

        }
        public override void ViewStudents()
        {
            Console.WriteLine("~~~~View Students~~~~");
            Console.WriteLine("-----------------------");


            if (students.Count == 0)
            {
                Console.WriteLine("No students available.\n");
                return;
            }

            var SortedList = students.OrderBy(x => x.Id).ToList();
            Console.Clear();
            foreach (var student in SortedList)
            {
                Console.WriteLine($"Name: {student.Name.ToUpper()}");
                Console.WriteLine($"ID: {student.Id}");
                Console.WriteLine($"Faculty: {student.Faculty.ToUpper()}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine($"Technology: {student.Technology.ToUpper()}");
                Console.WriteLine("-------------------");
            }
        }
        public override void UpdateStudent()
        {
            Console.WriteLine("~~~~Update Student~~~~");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Enter Student Name:");
            string Name = Console.ReadLine();

            Console.WriteLine();
            var found = students.Find(x => x.Name.ToLower() == Name.ToLower());
            if (found == null)
            {
                Console.WriteLine("Student not found.\n");
                return;
            }
            bool x = false;
            while (!x)
            {
                Console.WriteLine("1. Update Name");
                Console.WriteLine("2. Update ID");
                Console.WriteLine("3. Update Faculty");
                Console.WriteLine("4. Update Age");
                Console.WriteLine("5. Update Technology");
                Console.WriteLine("6. Exit\n");

                Console.Write("Select an Option: ");
                string option = Console.ReadLine();
                Console.WriteLine("-----------------------");


                switch (option)
                {
                    case "1":
                        Console.Write("Enter New Name: ");
                        string name = Console.ReadLine();
                        found.Name = name;
                        break;

                    case "2":
                        Console.Write("Enter New ID: ");
                        int id = int.Parse(Console.ReadLine());
                        found.Id = id;
                        break;

                    case "3":
                        Console.Write("Enter New Faculty: ");
                        string faculty = Console.ReadLine();
                        found.Faculty = faculty;
                        break;

                    case "4":
                        Console.Write("Enter New Age: ");
                        int age = int.Parse(Console.ReadLine());
                        found.Age = age;
                        break;

                    case "5":
                        Console.Write("Enter New Technology: ");
                        string tech = Console.ReadLine();
                        found.Technology = tech;
                        break;
                    case "6":
                        x = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.\n");
                        break;


                }

            }
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("[ Student updated successfully.]");
            Console.WriteLine("=============================\n");





        }

        public override void DeleteStudent()
        {
            Console.WriteLine("~~~~Delete Student~~~~");
            Console.WriteLine("-------------------");
            Console.WriteLine("Enter Student Name:");
            string Name = Console.ReadLine();

            var found = students.Find(x => x.Name == Name);
            if (found == null)
            {
                Console.WriteLine("Student Not Found\n");
                return;
            }

            students.Remove(found);
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("[ Student deleted successfully.]");
            Console.WriteLine("=============================\n");


        }

    }
}
