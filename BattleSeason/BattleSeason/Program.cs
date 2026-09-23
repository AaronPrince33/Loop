string charName;
int number0fBattle, expGained, totalEXP = 0;

Console.Write("Input character's name: ");
charName = Console.ReadLine();

Console.Write("Imput the number of battles: ");
number0fBattle = int.Parse(Console.ReadLine());

Console.Write("Input the EXP gained per battle: ");
expGained = int.Parse(Console.ReadLine());

Console.WriteLine("----------------------------");

for (int i = 1; i <= number0fBattle; i++)
{
    totalEXP += expGained;
    Console.WriteLine($"Battle {i} | EXP Gained: {expGained} | Total EXP: {totalEXP}");
}

Console.WriteLine("\n=== BATTLE COMPLETE ===");
Console.WriteLine($"Character:\t{charName}");
Console.WriteLine($"Battles:\t{number0fBattle}");
Console.WriteLine($"Total EXP:\t{totalEXP}");