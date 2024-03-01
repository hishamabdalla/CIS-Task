namespace CRUD_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = false;
            while (!x)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Student");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit\n");


                Console.Write("Select an Option: ");
                string option = Console.ReadLine();
                Console.WriteLine("-----------------------");

                switch (option)
                {
                    case "1":
                    case "add":
                        CRUD.AddStudent();
                        break;

                    case "2":
                    case "view":
                        CRUD.ViewStudents();
                        break;

                    case "3":
                    case "update":
                        CRUD.UpdateStudent();
                        break;

                    case "4":
                    case "delete":
                        CRUD.DeleteStudent();
                        break;

                    case "5":
                    case "exit":
                        x = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.\n");
                        break;

                }




            }


        }
    }
}
