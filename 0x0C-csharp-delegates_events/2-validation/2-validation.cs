using System;

/// <summary>
/// class
/// </summary>
public class Player
{
	private String name { get; set; }
	private float maxHp { get; set; }
	private float hp { get; set; }

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

		ValidateHP(this.hp - damage);
		Console.WriteLine($"{this.name} takes {damage} damage!");
	}

	/// <summary>
	/// HealDamage
	/// </summary>
	public void HealDamage(float heal)
	{
		if (heal < 0)
			heal = 0;
		
		ValidateHP(this.hp + heal);
		Console.WriteLine($"{this.name} heals {heal} HP!");
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
	}

	/// <summary>
	/// Print
	/// </summary>
	public void PrintHealth()
	{
		Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
	}
}