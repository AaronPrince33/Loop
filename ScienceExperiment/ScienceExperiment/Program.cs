int temp;

do
{
    Console.Write("Enter your temperature: ");
    temp = int.Parse(Console.ReadLine());

    if (temp < -50 || temp > 150)
    {
        Console.WriteLine("Invalid input. Temperature must be between -50 until 150 Celcius");
    }
}
while (temp < -50 || temp > 150);

Console.WriteLine($"Temperature recorded: {temp}°C");

if (temp > 100)
{
    Console.WriteLine($"Category: Extremely Hot:");
}
else if (temp >= 31)
{
    Console.WriteLine($"Category: Hot");
}
else if (temp >= 0)
{
    Console.WriteLine($"Category: Normal");
}
else
{
    Console.WriteLine($"Category: Freezing");
}
