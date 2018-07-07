using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapstoneTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            //menu list
            Task task1 = new Task("List Tasks", 1);
            Task task2 = new Task("Add Task", 2);
            Task task3 = new Task("Delete Task", 3);
            Task task4 = new Task("Mark Task complete", 4);
            List<Task> menu = new List<Task>();
            menu.Add(task1);
            menu.Add(task2);
            menu.Add(task3);
            menu.Add(task4);

            //task list
            Task taskA = new Task("Laundry", 1);
            Task taskB = new Task("Dishes", 2);
            Task taskC = new Task("Garbage", 3);
            Task taskD = new Task("mow lawn", 4);
            List<Task> chores = new List<Task>();
            chores.Add(taskA);
            chores.Add(taskB);
            chores.Add(taskC);
            chores.Add(taskD);

            Console.WriteLine("Welcome to task list");

            foreach (Task a in menu)
            {
                Console.WriteLine(a.TaskNumber + " " + a.TaskName);
            }
            Console.WriteLine("Choose an item from the menu by entering item number");
            string answer = Console.ReadLine();

            if (answer == "1")
            {
                foreach (Task b in chores)
                {
                    Console.WriteLine("\t" + b.TaskNumber + " " + b.TaskName + " is completed " + b.taskcomplete);
                }
            }
            else if (answer == "2")
            {
                Console.WriteLine("Enter new task");
                chores.Add(new Task(Console.ReadLine(), Convert.ToInt32(Console.ReadLine())));
            }
            else if (answer == "3")
            {
                Console.WriteLine("Enter Task Number");
                int answer3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Are you sure you would like to delete task {answer3} (Y/N)?");
                int answer4 = Convert.ToInt32(Console.ReadLine());
                int Y = 0;
                if (answer4 == Y)
                {
                    chores.RemoveAt(answer3 -1);
                }
                else
                {
                    return;
                }
            }
            else if (answer == "4")
            {
                Console.WriteLine("Which task would you like to mark complete?");
                int answer5 = Convert.ToInt32(Console.ReadLine());
                chores[answer5 - 1].taskcomplete = true;

            }



        }
    }
}
