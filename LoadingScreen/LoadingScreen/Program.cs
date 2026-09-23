int totalSteps = 10;

for (int step = 1; step <= 10; step += 1)
{
    Console.WriteLine($"Loading.. Step {step} of {totalSteps}");
    if (step % 3 == 0) 
    {
        Console.WriteLine("Checkpoint reached!");
    } 
}

Console.WriteLine("\nDungeon is ready. Enter now!");