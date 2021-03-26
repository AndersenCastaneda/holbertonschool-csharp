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
	/// print the player's health
	/// </summary>
	public void PrintHealth()
	{
		Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
	}
}