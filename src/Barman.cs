using System;

namespace c{

    class Barman{
        private string name;
        private int age;
        private int work_experience;


        public void setValues(){
            Console.WriteLine("Enter name, age and work experience of the Barman: ");
            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            work_experience = Convert.ToInt32(Console.ReadLine());
        }

        public void printValues(){
            System.Console.WriteLine(" name: " + name);
            Console.WriteLine(" Work experience: " + work_experience);
        }
    }
}