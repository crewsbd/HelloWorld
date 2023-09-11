//A simple hello world program with an scrolling animation
class HelloWorld
{
    static void Main(string[] args)
    {
        //Initialize states
        bool continue_loop = true;
        int currentX = 2;
        int minX = 1;
        int maxX = 30;
        int speed = 1;

        //Clear the screen and hide the cursor
        Console.Clear();
        Console.CursorVisible = false;

        //Animation loop
        do
        {
            //Position the cursor, clear the screen and write the text
            Console.SetCursorPosition(0, 0);
            Console.Clear();
            Console.SetCursorPosition(currentX, 10);
            if (Console.KeyAvailable) //Stop on any key press
            {
                continue_loop = false;
            }

            Console.Write("Hello World!"); //The main event!

            if (currentX >= maxX) //If extent reached, reverse direction
            {
                speed = -speed;
                currentX = maxX;
            }
            else if (currentX <= minX)
            {
                speed = -speed;
                currentX = minX;
            }
            currentX += speed; //Move the text

            Thread.Sleep(66); //Delay so we can see the animation

        } while (continue_loop);
        //Clean
        Console.Clear();
        Console.CursorVisible = true;
    }
}