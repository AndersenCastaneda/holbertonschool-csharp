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
    /// Event handler
    /// </summary>
    private event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// Status property
    /// </summary>
    private string status { get; set; }

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
        this.status = $"{name} is ready to go!";
		this.HPCheck += CheckStatus;
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
        if (damage < 0)
            damage = 0;

        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    /// <summary>
    /// Heal Damage function
    /// </summary>
    /// <param name="heal">Heal ammount</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;

        Console.WriteLine($"{name} takes {heal} HP!");
        ValidateHP(hp + heal);
    }

    /// <summary>
    /// Validate HP function
    /// </summary>
    /// <param name="newHp">new healt</param>
    public void ValidateHP(float newHp)
    {
        if (newHp <= 0)
            hp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;

        HPCheck?.Invoke(this, new CurrentHPArgs(hp));
    }

    /// <summary>
	/// Apply modifier
	/// </summary>
	/// <param name="baseValue"></param>
	/// <param name="modifier"></param>
	/// <returns></returns>
	public float ApplyModifier(float baseValue, Modifier modifier)
	{
		switch (modifier)
		{
			case Modifier.Weak:
				return baseValue * 0.5f;
			case Modifier.Strong:
				return baseValue * 1.5f;
			default:
				return baseValue;
		}
	}

    /// <summary>
    /// CheckStatus
    /// </summary>
    /// <param name="sender">Caller</param>
    /// <param name="e">argument</param>
    private void CheckStatus(object sender, CurrentHPArgs e)
	{
		if (e.currentHp == maxHp)
			status = $"{name} is in perfect health!";
		else if (e.currentHp >= maxHp / 2)
			status = $"{name} is doing well!";
		else if (e.currentHp >= maxHp / 4)
			status = $"{name} isn't doing too great...";
		else if (e.currentHp > 0)
			status = $"{name} needs help!";
		else
			status = $"{name} is knocked out!";

		Console.WriteLine(status);
	}
}

/// <summary>
/// Modifier
/// </summary>
public enum Modifier
{
    Weak,
    Base,
    Strong
}

/// <summary>
/// 
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns></returns>public delegate float CalculateModifier(float baseValue, Modifier modifier)
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Current event args
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// Current Hp property
    /// </summary>
    public float currentHp { get; }

    /// <summary>
    /// CurrentHPArgs
    /// </summary>
    /// <param name="newHp">New Health</param>
    public CurrentHPArgs(float newHp) => currentHp = newHp;
}
