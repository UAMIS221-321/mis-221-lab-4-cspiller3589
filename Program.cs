int badInputcounter = 0;

bool showMenu = true;       //the main menu, everything that is not the correct menu numbers returns a error screen with new options.
    Console.Clear();
    Console.WriteLine("Welcome to Crimson Crust\n");

    while(showMenu){
    Console.WriteLine("Choose an option:\n1. Plain Pizza\n2. Cheese Pizza\n3. Pepperoni Pizza\n4. Exit");
    string menuChoice = Console.ReadLine();
    
    if(menuChoice == "1"){
        badInputcounter = 0;
        PlainPizza();
    }  
    else if(menuChoice == "2"){
        badInputcounter = 0;
        CheesePizza();
    }
    else if (menuChoice == "3"){
        badInputcounter = 0;
        PepperoniPizza();
    }
    else if(menuChoice == "4"){
        Console.Clear();
        Console.WriteLine("Goodbye.");
        showMenu = false;
    }
    else{
        Console.Clear();
        Console.WriteLine("Bad Input, Please Try Again (" + badInputcounter + ")\r\n");
        badInputcounter++;
    }
}

static void PlainPizza(){
        Console.Clear();
        Random rand = new Random();// The basic structure of this was helped in part because of my research on StackExchange. The majority of the process I already knew, however the general form and efficency I cannot take full credit for.
        int rows = rand.Next(8, 13); // Random rows between 8 and 12
        for (int i = rows; i > 0; i--)
        {
            Console.WriteLine(new string('*', i) + " ");
        }
        Console.WriteLine("\n Enter any key to continue.");
        Console.ReadLine();
        Console.Clear();
    }

static void CheesePizza(){// Modified version of Plain Pizza.
        Console.Clear();
        Random rand = new Random();
        int rows = rand.Next(8, 13);
        for (int i = rows; i > 0; i--)
        {
            if (i == rows || i == 1)  // Crust rows
            {
                Console.WriteLine(new string('*', i) + " ");
            }
            else  // Cheese
            {
                Console.WriteLine("*" + new string('#', i - 2) + "* ");
            }
        }
        Console.WriteLine("\n Enter any key to continue.");
        Console.ReadLine();
        Console.Clear();
    }

static void PepperoniPizza(){// Even more modified version of Cheese Pizza. Adds a random section for Pepperoni
        Console.Clear();
        Random rand = new Random();
        int rows = rand.Next(8, 13);
        for (int i = rows; i > 0; i--)
        {
            if (i == rows || i == 1)  // Crust rows
            {
                Console.WriteLine(new string('*', i) + " ");
            }
            else  // Cheese and pepperoni inside
            {
                char[] row = new char[i];
                row[0] = '*';
                row[i - 1] = '*';

                for (int j = 1; j < i - 1; j++)  // Filling the row with cheese
                {
                    row[j] = '#';
                }

                // Randomly add pepperonis
                int numPepperonis = rand.Next(1, i / 2);
                for (int j = 0; j < numPepperonis; j++)
                {
                    int pepperoniPosition = rand.Next(1, i - 1);
                    row[pepperoniPosition] = 'o';
                }

                Console.WriteLine(new string(row) + " ");
            }
        }
        Console.WriteLine("\n Enter any key to continue.");
        Console.ReadLine();
        Console.Clear();
    }