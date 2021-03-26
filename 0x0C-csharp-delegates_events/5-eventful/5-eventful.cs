using System;

/// <summary>
/// enum
/// </summary>
public enum Modifier
{
	Weak,
	Base,
	Strong
}

/// <summary>
/// delegate
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// class
/// </summary>
public class Player
{
	private String name { get; set; }
	private float maxHp { get; set; }
	private float hp { get; set; }
	event EventHandler<CurrentHPArgs> HPCheck;
	private String status { get; set; }

	/// <summary>
	/// constructor
	/// </summary>
	public Player(String name = "Player", float maxHp = 100f)
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
		this.status = $"{this.name} is ready to go!";
		this.HPCheck += CheckStatus;
	}

	/// <summary>
	/// Delegate
	/// </summary>
	public delegate void CalculateHealth(float amount);

	/// <summary>
	/// TakeDamage
	/// </summary>
	public void TakeDamage(float damage)
	{
		if (damage < 0)
			damage = 0;

		Console.WriteLine($"{this.name} takes {damage} damage!");
		ValidateHP(this.hp - damage);
	}

	/// <summary>
	/// HealDamage
	/// </summary>
	public void HealDamage(float heal)
	{
		if (heal < 0)
			heal = 0;

		Console.WriteLine($"{this.name} heals {heal} HP!");
		ValidateHP(this.hp + heal);
	}

	/// <summary>
	/// ValidateHP
	/// </summary>
	public void ValidateHP(float newHp)
	{
		if (newHp < 0)
			this.hp = 0;
		else if (newHp > maxHp)
			this.hp = maxHp;
		else
			this.hp = newHp;

		OnCheckStatus(new CurrentHPArgs(this.hp));
	}

	/// <summary>
	/// Print
	/// </summary>
	public void PrintHealth()
	{
		Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
	}

	/// <summary>
	/// ApplyModifier
	/// </summary>
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
	private void CheckStatus(object sender, CurrentHPArgs e)
	{
		if (e.currentHp == this.maxHp)
			this.status = $"{this.name} is in perfect health!";
		else if (e.currentHp >= this.maxHp / 2)
			this.status = $"{this.name} is doing well!";
		else if (e.currentHp >= this.maxHp / 4)
			this.status = $"{this.name} isn't doing too great...";
		else if (e.currentHp > 0)
			this.status = $"{this.name} needs help!";
		else
			this.status = $"{this.name} is knocked out!";

		Console.WriteLine(this.status);
	}

    /// <summary>
    /// HPValueWarning
    /// </summary>
	private void HPValueWarning(object sender, CurrentHPArgs e)
	{
		if (e.currentHp == 0)
		{
			Console.BackgroundColor = ConsoleColor.Red;
			Console.WriteLine("Health has reached zero!");
		}
		else
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Health is low!");
		}

		Console.ResetColor();
	}

    /// <summary>
    /// OnCheckStatus
    /// </summary>
	private void OnCheckStatus(CurrentHPArgs e)
	{
		if (e.currentHp <= this.maxHp / 4)
			HPCheck += HPValueWarning;
		else
			HPCheck -= HPValueWarning;

		HPCheck?.Invoke(this, e);
	}
}

/// <summary>
/// CurrentHPArgs
/// </summary>
public class CurrentHPArgs : EventArgs
{
	/// <summary>
	/// hp
	/// </summary>
	public float currentHp { get; }

	/// <summary>
	/// constructor
	/// </summary>
	public CurrentHPArgs(float newHp)
	{
		currentHp = newHp;
	}
}