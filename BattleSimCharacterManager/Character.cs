using System.Diagnostics.Contracts;
using YamlDotNet.Core;

public partial class Character
{
    public string name = "";
    public int maxHealth = 0;
    public int health = 0;
    public int minDamage = 0;
    public int maxDamage = 0;
    public bool healer = false; // the "healer" variable allows this character to randomly heal themselves
    public int minHealing = 0;
    public int maxHealing = 0;


    public Character(string name, int maxHealth, int minDamage, int maxDamage, bool healer, int minHealing, int maxHealing)
    {
        this.name = name;
        this.maxHealth = maxHealth;
        this.health = maxHealth;
        this.minDamage = minDamage;
        this.maxDamage = maxDamage;
        this.healer = healer;
        this.minHealing = minHealing;
        this.maxHealing = maxHealing;
    }

    public Character(string name, int health, int minDamage, int maxDamage)
    {
        this.name = name;
        this.health = health;
        this.minDamage = minDamage;
        this.maxDamage = maxDamage;
        healer = false;
        minHealing = 0;
        maxHealing = 0;
    }
    public Character()
    {

    }
}