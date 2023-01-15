
Console.WriteLine("Please enter your name");   //stores username
string username = Console.ReadLine().Trim();

RestartApplication:

Console.WriteLine("please enter a number from 1 to 100");


string usernumber = Console.ReadLine();

int user = int.Parse(usernumber);           // stores user input and converts to integer

if (user >= 1 && user <= 100)
{
    Console.WriteLine($"thanks {username} \n");
}

else
{
    Console.WriteLine("Please enter a valid number");
    goto RestartApplication;
}


    if (user % 2 == 0)
    {
        Console.WriteLine($"{username} Your number is even ");
    }
    else 
    {
        Console.WriteLine($"{username} Your number is odd ");
    }


        if (user >= 26 && user <=60)
        {
        Console.WriteLine("and between 26 & 60 inclusive");
         }
        else if (user > 60)
        {
        Console.WriteLine("and greater than 60");
        }
        else if (user < 60)
        {
        Console.WriteLine($"{user} and less than 60");
        }
        else if (user <= 2 && user <=24)
        {
        Console.WriteLine("and between 2 & 24 inclusive");
        }




Console.WriteLine("Would you like to start over? please type y to begin again or any other key to leave");
string answer = Console.ReadLine();
if (answer == "y")
{
    goto RestartApplication;        //not sure if this is the best way to restart but it works
}
else
{
    Console.WriteLine("Goodbye");
}