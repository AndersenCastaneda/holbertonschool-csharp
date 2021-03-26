using System;

/// <summary>
/// Player class
/// </summary>
public class Player
{
    /// <summary>
    /// Name property
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// maxHp property
    /// </summary>
    public float maxHp { get; set; }

    /// <summary>
    /// hp property
    /// </summary>
    public float hp { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0)
            this.maxHp = maxHp;
        else
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        this.hp = this.maxHp;
    }

    /// <summary>
    /// PrintHeakth function
    /// </summary>
    public void PrintHealth() => Console.WriteLine($"{name} has {hp} / {maxHp} health");

    /// <summary>
    /// Take Damage function
    /// </summary>
    /// <param name="damage">Damage ammount</param>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
            Console.WriteLine($"{name} takes 0 damage!");
        else
            Console.WriteLine($"{name} takes {damage} damage!");
    }

    /// <summary>
    /// Heal Damage function
    /// </summary>
    /// <param name="heal">Heal ammount</param>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
            Console.WriteLine($"{name} takes 0 HP!");
        else
            Console.WriteLine($"{name} takes {heal} HP!");
    }
}
