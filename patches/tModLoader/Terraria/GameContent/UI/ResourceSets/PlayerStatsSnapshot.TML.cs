namespace Terraria.GameContent.UI.ResourceSets;

public partial struct PlayerStatsSnapshot
{
	public float LifePerSegment => LifeMax / (float)AmountOfLifeHearts;
	public float ManaPerSegment => ManaMax / (float)AmountOfManaStars;

	/// <summary>
	/// How many life hearts should be drawn
	/// </summary>
	public int AmountOfLifeHearts {
		get => numLifeHearts;
		set => numLifeHearts = Utils.Clamp(value, int.MinValue, 20);
	}

	/// <summary>
	/// How many mana stars should be drawn
	/// </summary>
	public int AmountOfManaStars {
		get => numManaStars;
		set => numManaStars = Utils.Clamp(value, int.MinValue, 20);
	}
}
