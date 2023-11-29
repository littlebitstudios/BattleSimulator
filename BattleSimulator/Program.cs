using System;
Console.WriteLine("LittleBit's Battle Simulator");
Console.Write("Do you have an (e)xisting character list, or do you need a (n)ew one?");
var cmd = Console.ReadLine();
if (cmd.Equals("e", StringComparison.OrdinalIgnoreCase))
{
    var deserializer = new YamlDotNet.Serialization.Deserializer();
    var alivecharacters = new List<Character>();
    var deadcharacters = new List<Character>();
    try
    {
        Console.WriteLine();
        Console.Write("Enter the path to the character list YAML file: ");
        var path = Console.ReadLine();
        var characterdb = File.ReadAllText(path);
        alivecharacters = deserializer.Deserialize<List<Character>>(characterdb);
    }
    catch (DirectoryNotFoundException)
    {
        Console.WriteLine("That's an invalid path (nonexistent directory), try again.");
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("That's an invalid path (nonexistent file), try again.");
    }
    while (alivecharacters.Count > 1)
    {
        Thread.Sleep(700);
        Random rand = new Random();
        var attackingchar = alivecharacters[rand.Next(alivecharacters.Count())];
        var targetchar = alivecharacters[rand.Next(alivecharacters.Count())];
        if (attackingchar.healer)
        {
            if (attackingchar.Equals(targetchar))
            {
                Console.WriteLine();
                var healamount = rand.Next(attackingchar.minHealing, attackingchar.maxHealing);
                attackingchar.health += healamount;
                if(attackingchar.health > attackingchar.maxHealth)
                {
                    attackingchar.health = attackingchar.maxHealth;
                }
                System.Console.WriteLine($"{attackingchar.name} healed themself by {healamount} HP. They now have {attackingchar.health} HP.");
            }
            else
            {
                var damage = rand.Next(attackingchar.minDamage, attackingchar.maxDamage);
                targetchar.health -= damage;
                if (targetchar.health <= 0)
                {
                    Console.WriteLine();
                    System.Console.WriteLine($"{attackingchar.name} eliminated {targetchar.name}!");
                    System.Console.WriteLine($"{attackingchar.name} has {attackingchar.health} HP left.");
                    deadcharacters.Add(targetchar);
                    alivecharacters.Remove(targetchar);
                }
                else
                {
                    Console.WriteLine();
                    System.Console.WriteLine($"{attackingchar.name} damaged {targetchar.name} by {damage} HP.");
                    System.Console.WriteLine($"{attackingchar.name} has {attackingchar.health} HP left. {targetchar.name} has {targetchar.health} HP left.");
                }
            }
        }
        else
        {
            if (attackingchar.Equals(targetchar))
            {

            }
            else
            {
                var damage = rand.Next(attackingchar.minDamage, attackingchar.maxDamage);
                targetchar.health -= damage;
                if (targetchar.health <= 0)
                {
                    Console.WriteLine();
                    System.Console.WriteLine($"{attackingchar.name} eliminated {targetchar.name}!");
                    System.Console.WriteLine($"{attackingchar.name} has {attackingchar.health} HP left.");
                    deadcharacters.Add(targetchar);
                    alivecharacters.Remove(targetchar);
                }
                else
                {
                    Console.WriteLine();
                    System.Console.WriteLine($"{attackingchar.name} damaged {targetchar.name} by {damage} HP.");
                    System.Console.WriteLine($"{attackingchar.name} has {attackingchar.health} HP left. {targetchar.name} has {targetchar.health} HP left.");
                }
            }
        }
    }
    System.Console.WriteLine($"{alivecharacters[0].name} won!");
}
else if (cmd.Equals("n", StringComparison.OrdinalIgnoreCase))
{
    var serializer = new YamlDotNet.Serialization.Serializer();
    Console.WriteLine();
    Console.Write("Enter the file path where for the new character list YAML file: ");
    var path = Console.ReadLine();
    string[] splitpath = path.Split("/");
    var dir = path.Replace(splitpath.Last(), "");
    if (Directory.Exists(dir) == false)
    {
        Directory.CreateDirectory(dir);
    }
    var characters = new List<Character>()
    {
        new("Example1", 0, 0, 0, false, 0, 0),
        new("Example2", 0, 0, 0, false, 0, 0)
    };
    var newchardb = serializer.Serialize(characters);
    File.WriteAllText(path, newchardb);
    Console.WriteLine("Character list YAML file created. The program will exit.");
    Console.WriteLine("Edit the file, adding and removing characters as desired, with the stats you want.");
    Console.WriteLine("To start the battle, rerun the program and say you have an existing character list.");
}
else
{
    Console.WriteLine("Invalid command, exiting...");
}
