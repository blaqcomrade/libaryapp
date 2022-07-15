Console.WriteLine("                                  WELCOME TO THE LIBARY\n");
            int choose;
Console.Write("                                WHAT WILL YOU LIKE TO DO\n\n");

Console.Write("                 Enter [1] to borrow a Book [2] to return a Book or [3] to exit the library\n");


try
{
    choose = Convert.ToInt32(Console.ReadLine());

    switch (choose)
    {
         case 1:
            borrow();
            break;

         case 2:

             returnbook();
             break;

         case 3:
             Environment.Exit(0);
             break;

             default:
             Console.Write("invalid entry.");
             break;
    }
}
catch
{
          Console.WriteLine("string not allowed");
}

static void borrow()
{
    List<object> Books = new List<object>();
    Books.Add("bribe");
    Books.Add("love");
    Books.Add("john");
    Books.Add("tribe");


    Console.WriteLine("List of Available Books\n");
    foreach (var item in Books)
    {

        Console.WriteLine(item);
    }

    string op = Console.ReadLine();

    if (Books.Contains(op))
    {
        Books.Remove(op);
        Console.WriteLine($"\nYou succefully borrowed {op}\n");
    }
    else
    {
        Console.WriteLine("\nbook currently not available");
    }


    while (true)
    {
        if (Books.Count == 0)
        {
            Console.WriteLine("Sorry library empty");
            break;
        }
        else
        {
            Console.WriteLine("What will you like to do\n");
            Console.WriteLine("Enter [1] to borrow [2] to return or [3] to exit library\n");
            string opt3 = Console.ReadLine();
            if (int.Parse(opt3) == 1)
            {
                Console.WriteLine("List of Available Books\n");
                foreach (var item in Books)
                {

                    Console.WriteLine(item);
                }

                string opt = Console.ReadLine();

                if (Books.Contains(opt))
                {
                    Books.Remove(opt);
                    Console.WriteLine($"\nYou succefully borrowed {opt}");
                }
                else
                {
                    Console.WriteLine("\nbook currently not available");
                }
            }
            else if (int.Parse(opt3) == 2)
            {
                returnbook();
            }
            else if (int.Parse(opt3) == 3)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("invalid option");
            }
        }
    }


    
    
}
static void returnbook()
{


    Console.WriteLine("                        how many days have you held the book for?");
    string returnopt = Console.ReadLine();
    int fine = int.Parse(returnopt) - 10;
    

    if (int.Parse(returnopt) <= 10)
    {
        Console.WriteLine("Thank you");
    }
    else if (int.Parse(returnopt) >= 11 && int.Parse(returnopt) <= 30)
    {


        Console.WriteLine($"You are to pay a fine of {fine * 50}");

    }
    else if (int.Parse(returnopt) >= 30)
    {

        Console.WriteLine($"You are to pay a fine of {fine * 100}");
    }
}
borrow();








