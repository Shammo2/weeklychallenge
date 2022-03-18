namespace UI;

public class MainMenu {
    

    public void Start() {
        bool exit = false;
        Console.WriteLine("Welcome to Weekly challenge pick a app to run");

        while(!exit)
        {
            Console.WriteLine("[1] stack app");
            Console.WriteLine("[2] linked lists");
            Console.WriteLine("[x] Exit");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    new stack().stackstart();
                break;
                case "2":
                new linked().linkedlists();

                break;
                case "x":
                    exit = true;
                    Console.WriteLine("goodbye!");
                break;

            }
        }
    }
}
