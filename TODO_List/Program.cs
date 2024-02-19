using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;


        List<string> listToDo = new List<string>();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nHello, it's your list to-do for today:\n");
            Console.ResetColor();

            int i = 1;

            foreach (string s in listToDo)
            {
                Console.WriteLine(i++ + ". " + s);
            }

            Console.WriteLine("Please choose your option:");
            Console.WriteLine("1. Add new task.");
            Console.WriteLine("2. Remove the task.");
            Console.WriteLine("3. EXIT.\n");
                        
            string operationNumber = Console.ReadLine();
            bool operationNumRes = int.TryParse(operationNumber, out int number);

            if (operationNumRes == true)
            {
                
                if (number == 1)
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Add new task:\n");
                    Console.ResetColor();

                    string newTask = Console.ReadLine();
                    listToDo.Add(newTask);

                    continue;
                }

                if (number == 2)
                {
                    int counttasks = listToDo.Count;
                    if (counttasks == 0)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("List of tasks is empty. Please choose another options!\n");
                        Console.ResetColor();
                        //operationNumber = Console.ReadLine();
                        //number = int.Parse(operationNumber);
                        continue;
                    }

                    if (counttasks != 0)
                    {


                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Remove the task:");
                        Console.ResetColor();
                        string newTask = Console.ReadLine();
                        bool removeTask = int.TryParse(newTask, out int result);



                        if (removeTask == true)
                        {
                            //int removeNumber = int.Parse(newTask);
                            int removeNumber2 = /*removeNumber*/ result- 1;
                            listToDo[removeNumber2] = newTask;
                            listToDo.Remove(newTask);

                            int d = 1;
                            foreach (string f in listToDo)
                            {
                                Console.WriteLine(d++ + ". " + f);
                            }

                        }
                        continue;
                    }
                }

                if (number == 3)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Exit complited!");
                    Console.ResetColor();
                    break;
                }

                if (number!=1 && number !=2 && number !=3)
                {
                    Console.WriteLine("Choose correct option");
                }
                               
            }
            else
            {

                Console.WriteLine("Choose correct option");
            }
        }
    }
}





