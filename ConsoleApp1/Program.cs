Console.WriteLine($"welcome to the gulag");
Console.WriteLine($"what is the challengers name");
Console.WriteLine($"if you win you earn your rights for freedom");

string yous = Console.ReadLine();
string enemys = "enemy";
int youhp = 100;
int enemyhp = 100;
Random generator = new Random();

while (youhp > 0 && enemyhp > 0)
{
    Console.WriteLine("\n press enter for next round");
    Console.WriteLine($"{yous}: {youhp}  {enemys}: {enemyhp}\n");
    int yourhit = generator.Next(15);
    enemyhp -= yourhit;
    enemyhp = Math.Max(0, enemyhp);
    Console.WriteLine($"{yous} shot at {enemys} and hit for {yourhit}");
    int enemyhit = generator.Next(15);
    youhp -= enemyhit;
    youhp = Math.Max(0, youhp);
    Console.WriteLine($"{enemys} fired 3 shots {yous} and hit for {enemyhit}");
    Console.WriteLine("press any button");
    Console.ReadKey();
}

Console.WriteLine("\n fight is over");

if (youhp == 0 && enemyhp == 0)
{

    Console.WriteLine($"both people killed in fight");
}

else if (youhp == 0)
{

    Console.WriteLine($"{enemys} won the fight");
}
else
{

    Console.WriteLine($"{yous} came out on top");
}

Console.WriteLine("press any button");
Console.ReadKey();
