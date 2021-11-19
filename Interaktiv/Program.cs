using System;

Console.WriteLine("Whats your name");
string name = Console.ReadLine();


Console.WriteLine($"Hello {name}");


// isAlive = true;

// Console.WriteLine(t == "H");

Console.WriteLine("How many Chaos Emerlds are there in Sonic The Hedgehog?");
string answer = Console.ReadLine();

if (answer == "6")
{
    Console.WriteLine("CORRECT?"); 
}
else if (answer == "7")
{
    Console.WriteLine("TRY AGAIN");
}
else if (answer == "5")
{
    Console.WriteLine("WOW YOU SUCK");
}
else
{
    Console.WriteLine("NOOB");  
}

Console.WriteLine("When did Sonic first realse?");
answer = Console.ReadLine();

if (answer == "1991")
{
Console.WriteLine("Amazing you know your stuff");
}

else if (answer == "1985")
{
    Console.WriteLine("This isn't Mario we're talking about");
}
else 
{
    Console.WriteLine("Your no real Sonic fan do your resaerch");
}

Console.WriteLine("Who is Sonic's arch enemy?");
answer = Console.ReadLine(); 

if (answer == "Eggman")
{
    Console.WriteLine("That's right but what's his real name?"); 
    answer=Console.ReadLine ();
    if (answer == "Robotnik") 
    {
        Console.WriteLine("Right again Amazing");
    }
}

else if (answer == "Bowser")
{
Console.WriteLine("NOOOOOO are you stupid?");
}

else
{
    Console.WriteLine("Too bad"); 
}

Console.WriteLine($"Thanks for playing {name} Would you like to try again?"); 
answer = Console.ReadLine ();
if (answer == "Yes")
{
    Console.WriteLine("Press any button to restart");
}

else if (answer =="No")
{
    Console.WriteLine("Are you sure?");
    answer = Console.ReadLine ();
    if ( answer == "Yes")
    {
        Console.WriteLine("Have a nice day");
    }
}

else 
{
    Console.WriteLine("That's not the answer I was Looking for"); 
}



Console.ReadLine();