using System;

namespace c{

    class Waiter{
        private string name;
        private int age;
        private int work_experience;
        private int grade;
        private string orders;
        private int count;


        public void setValues(){
            Console.WriteLine("Enter the data of the waiter: ");
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the work experience: ");
            work_experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the grade: ");
            grade = Convert.ToInt32(Console.ReadLine());
        }

        public void printValues(){
            System.Console.WriteLine(" name: " + name);
            System.Console.WriteLine(" Work experience: " + work_experience);
        }

        // Method to take the orders from the clients
        public void takeOrders(){
            orders = Console.ReadLine();
            count++;
        }

    }
}