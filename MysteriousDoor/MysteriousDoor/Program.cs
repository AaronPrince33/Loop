string secretCode = "1992";
string attempt = "";

while (attempt != secretCode)
{
    Console.Write("Enter the secret code: ");
    attempt = Console.ReadLine();
    if (attempt != secretCode)
    {
        Console.WriteLine("Wrong code, Try again!");
    }
}

Console.WriteLine("Door Unlocked. Congratulations!!");