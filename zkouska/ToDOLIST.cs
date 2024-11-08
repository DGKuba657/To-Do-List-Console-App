namespace Test;

public class ToDOLIST
{
    
    enum UserChoice {
        AddTask = 1,
        DeleteTask,
        Exit
    }
    public static void List() {
         List<string> toDoList = new List<string>();
        while (true) {
            if (toDoList.Count > 0) {
                Console.WriteLine("To-Do list:");
                for (int i = 0; i < toDoList.Count; i++) {
                    Console.WriteLine("- " + toDoList[i]);
                }
                Console.WriteLine("");
            }
            else {
                Console.WriteLine("You currently have no tasks in your To-do list.");
                Console.WriteLine("");
            }
            
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Delete Task");
            Console.WriteLine("3. Exit");
            int choice = int.Parse(Console.ReadLine());

            if (choice == (int)UserChoice.AddTask) {
                Console.Write("Enter task: ");
                string task = Console.ReadLine();
                toDoList.Add(task);
                Jachym.Klir();
                Console.WriteLine("Task added");
            }
            else if (choice == (int)UserChoice.Exit) {
                break;
            }
            else if (choice == (int)UserChoice.DeleteTask) {
                if (toDoList.Count > 0) {
                    Console.Write("Enter the number of task you want to delete: \n");
                    
                    for (int i = 0; i < toDoList.Count; i++) {
                        Console.WriteLine("(" + (i + 1) + ") " + toDoList[i]); 
                    }
                    int taskNum = int.Parse(Console.ReadLine());
                    taskNum--;
                    if (taskNum >= 0 && taskNum < toDoList.Count) {
                        toDoList.RemoveAt(taskNum);
                        Jachym.Klir();
                        Console.WriteLine("Task deleted");
                        Console.WriteLine("");
                    }
                    else {
                        Jachym.Klir();
                        Console.WriteLine("Invalid task number");
                        Console.WriteLine("");
                    }
                }
            }

        }
    }
}