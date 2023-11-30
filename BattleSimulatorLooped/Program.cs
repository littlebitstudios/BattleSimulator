internal class Program
{
    private static void Main(string[] args)
    {
        var deserializer = new YamlDotNet.Serialization.Deserializer();
        var alivecharacters = new List<Character>();
        var deadcharacters = new List<Character>();
        var path = "";

        Console.WriteLine("LittleBit's Battle Simulator (Looped Edition)");
        Console.WriteLine("If you don't have a character list YAML file, end this program (Ctrl+C) and make a new YAML using the non-looped version.");
        try
        {
            Console.WriteLine();
            Console.Write("Enter the path to the character list YAML file: ");
            path = Console.ReadLine();
            var characterdb = File.ReadAllText(path);
            alivecharacters = deserializer.Deserialize<List<Character>>(characterdb);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("That's an invalid path (nonexistent directory), try again");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("That's an invalid path (nonexistent file), try again.");
        }
        catch
        {
            System.Console.WriteLine("Something happened, try again.");
        }
        while (true)
        {
            var characterdb = File.ReadAllText(path);
            alivecharacters = deserializer.Deserialize<List<Character>>(characterdb);
            Console.WriteLine();
            Console.WriteLine($"The fight starts with {alivecharacters.Count()} players!");
            Console.WriteLine("If you want to stop the program, use Ctrl+C!");
            while (alivecharacters.Count > 1)
            {
                Thread.Sleep(700);
                Random rand = new Random((int)DateTime.Now.Ticks);
                var attackingchar = alivecharacters[rand.Next(alivecharacters.Count())];
                var targetchar = alivecharacters[rand.Next(alivecharacters.Count())];
                if (attackingchar.healer)
                {
                    if (attackingchar.Equals(targetchar))
                    {
                        Console.WriteLine();
                        var healamount = rand.Next(attackingchar.minHealing, attackingchar.maxHealing);
                        attackingchar.health += healamount;
                        if (attackingchar.health > attackingchar.maxHealth)
                        {
                            attackingchar.health = attackingchar.maxHealth;
                        }
                        Console.WriteLine($"{attackingchar.name} healed themself by {healamount} HP. They now have {attackingchar.health} HP.");
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
                            System.Console.WriteLine($"Remaining players: {string.Join(", ", alivecharacters.Select(c => c.name))}");
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
        }
    }
}