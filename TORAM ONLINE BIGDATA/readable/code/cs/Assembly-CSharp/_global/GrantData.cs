// Assembly: Assembly-CSharp.dll
// Namespace: 
internal static class GrantData // TypeDefIndex: 8487
{
	// Fields
	public static readonly Dictionary<BonusType, EnhanceProperties2> EnhanceCost; // 0x0
	public static readonly Dictionary<ElementType, EnhanceProperties2> EnhanceElementCost; // 0x8
	public const int LimitLevel = 210;

	// Methods

	// RVA: 0x1D81F1C Offset: 0x1D7DF1C VA: 0x1D81F1C
	private static void .cctor() { }

	// RVA: 0x1D83FE0 Offset: 0x1D7FFE0 VA: 0x1D83FE0
	public static int GetUsePotential(BonusType key, int itemUuid, PlayerDataManager playerData) { }

	// RVA: 0x1D8413C Offset: 0x1D8013C VA: 0x1D8413C
	public static int GetUsePotential(ElementType key, int itemUuid, PlayerDataManager playerData) { }
}
