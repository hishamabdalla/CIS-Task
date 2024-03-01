namespace CRUD_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Student and Instructor information system!");
            Console.WriteLine("Please select your role:");
           bool ch=false;
            while (!ch)
            {
                Console.WriteLine("Please select your role:");
                Console.WriteLine("1. Student");
                Console.WriteLine("2. Instructor");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string roleChoice = Console.ReadLine();
                Console.WriteLine("=================");

                switch (roleChoice)
                {
                    case "1":
                        CRUD("Student");
                        break;
                    case "2":
                        CRUD("Instructor");
                        break;
                    case "3":
                        ch = true;
                        break;

                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.\n");
                        break;
                }

            }
            

            void CRUD(string person)
            {
                bool x = false;
                while (!x)
                {
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. View");
                    Console.WriteLine("3. Update");
                    Console.WriteLine("4. Delete");
                    Console.WriteLine("5. Exit\n");


                    Console.Write("Select an Option: ");
                    string option = Console.ReadLine();
                    Console.WriteLine("-----------------------");
                    CRUD crud;
                    if (person =="Student")
                    {
                        crud = new CreateStudent();
                    }
                    else
                    {
                        crud = new CreateInstructor();
                    }

                    switch (option)
                    {
                        case "1":
                        case "add":
                            crud.Add();
                            break;

                        case "2":
                        case "view":
                            crud.View();
                            break;

                        case "3":
                        case "update":
                            crud.Update();
                            break;

                        case "4":
                        case "delete":
                            crud.Delete();
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
}

