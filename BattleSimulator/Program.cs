using System;
Console.WriteLine("LittleBit's Battle Simulator");
Console.Write("Do you have an (e)xisting character list, or do you need a (n)ew one?");
var cmd = Console.ReadLine();
if (cmd != null && cmd.Equals("e", StringComparison.OrdinalIgnoreCase))
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
        try
        {
            alivecharacters = deserializer.Deserialize<List<Character>>(characterdb);
            Console.WriteLine();
            Console.WriteLine($"The fight starts with {alivecharacters.Count()} players!");
        }
        catch (YamlDotNet.Core.YamlException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Failed to parse the character list YAML file. Please check the file format.");
            Console.WriteLine($"Error details: {ex.Message}");
            Console.ResetColor();
            return;
        }
    }
    catch (DirectoryNotFoundException)
    {
        Console.WriteLine("That's an invalid path (nonexistent directory), try again.");
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("That's an invalid path (nonexistent file), try again.");
    }
    // fighting logic begins here
    Random rand = new Random();
    while (alivecharacters.Count > 1)
    {
        Thread.Sleep(700);
        var attackingchar = alivecharacters[rand.Next(alivecharacters.Count())];
        var targetchar = alivecharacters[rand.Next(alivecharacters.Count())];
        if (attackingchar.healer)
        {
            if (attackingchar.Equals(targetchar))
            {
                // healers that try to attack themselves will heal instead.
                Console.WriteLine();
                var healamount = rand.Next(attackingchar.minHealing, attackingchar.maxHealing + 1);
                attackingchar.health += healamount;
                if (attackingchar.health > attackingchar.maxHealth)
                {
                    attackingchar.health = attackingchar.maxHealth;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{attackingchar.name} healed themself by {healamount} HP. They now have {attackingchar.health} HP.");
                Console.ResetColor();
            }
            else
            {
                var damage = rand.Next(attackingchar.minDamage, attackingchar.maxDamage + 1);
                targetchar.health -= damage;
                if (targetchar.health <= 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{attackingchar.name} eliminated {targetchar.name}!");
                    Console.ResetColor();
                    Console.WriteLine($"{attackingchar.name} has {attackingchar.health} HP left.");
                    deadcharacters.Add(targetchar);
                    alivecharacters.Remove(targetchar);
                    Console.WriteLine($"Remaining players: {string.Join(", ", alivecharacters.Select(c => c.name))}");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"{attackingchar.name} damaged {targetchar.name} by {damage} HP.");
                    Console.WriteLine($"{attackingchar.name} has {attackingchar.health} HP left. {targetchar.name} has {targetchar.health} HP left.");
                }
            }
        }
        else
        {
            if (attackingchar.Equals(targetchar))
            {
                // do nothing, we don't want suicidal fighters.
            }
            else
            {
                var damage = rand.Next(attackingchar.minDamage, attackingchar.maxDamage);
                targetchar.health -= damage;
                if (targetchar.health <= 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{attackingchar.name} eliminated {targetchar.name}!");
                    Console.ResetColor();
                    Console.WriteLine($"{attackingchar.name} has {attackingchar.health} HP left.");
                    deadcharacters.Add(targetchar);
                    alivecharacters.Remove(targetchar);
                    Console.WriteLine($"Remaining players: {string.Join(", ", alivecharacters.Select(c => c.name))}");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"{attackingchar.name} damaged {targetchar.name} by {damage} HP.");
                    Console.WriteLine($"{attackingchar.name} has {attackingchar.health} HP left. {targetchar.name} has {targetchar.health} HP left.");
                }
            }
        }
    }
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"{alivecharacters[0].name} won!");
    Console.ResetColor();
}
else if (cmd != null && cmd.Equals("n", StringComparison.OrdinalIgnoreCase))
{
    var serializer = new YamlDotNet.Serialization.Serializer();
    Console.WriteLine();
    Console.Write("Enter the file path where for the new character list YAML file: ");
    var path = Console.ReadLine();
    string separator = "";
    if (path.Contains('/'))
    {
        separator = "/";
    }
    else if (path.Contains('\\'))
    {
        separator = "\\";
    }
    string[] splitpath = path.Split(separator);
    var dir = Path.GetDirectoryName(path);
    if (!string.IsNullOrEmpty(dir) && Directory.Exists(dir) == false)
    {
        Directory.CreateDirectory(dir);
    }
    // Example characters with all zero stats as placeholders.
    var characters = new List<Character>()
    {
        new("Example1", 0, 0, 0, false, 0, 0), // Placeholder character
        new("Example2", 0, 0, 0, false, 0, 0)  // Placeholder character
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
