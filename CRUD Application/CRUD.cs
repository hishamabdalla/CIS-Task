using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUD_Application
{
    internal abstract class CRUD
    {
       
        public abstract void AddStudent();
        public abstract void ViewStudents();
        public abstract void UpdateStudent();
        public abstract void DeleteStudent();
       

        protected int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                if(int.TryParse(Console.ReadLine(), out int value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Invalid input,Please Try Again.");
                }
            }
            

        }
    }
}
