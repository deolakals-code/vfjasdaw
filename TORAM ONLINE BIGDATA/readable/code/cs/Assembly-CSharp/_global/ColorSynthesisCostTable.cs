// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class ColorSynthesisCostTable // TypeDefIndex: 1810
{
	// Fields
	public const int MaxSkillLevel = 10;

	// Methods

	// RVA: 0x20E37B8 Offset: 0x20DF7B8 VA: 0x20E37B8
	public static ColorSynthesisCostTable.Target ResolveTarget(ColorSynthesisCostTable.EquipBase baseType, bool partSpecified, bool weaponKindSpecified) { }

	// RVA: 0x20E381C Offset: 0x20DF81C VA: 0x20E381C
	public static long GetActualCost(ColorSynthesisCostTable.Target target, int colorRefiningLv, int guideILv, int guideIILv) { }

	// RVA: 0x20E3988 Offset: 0x20DF988 VA: 0x20E3988
	private static int GetPriceSkillLv(ColorSynthesisCostTable.Target target, int colorRefiningLv, int guideILv, int guideIILv) { }

	// RVA: 0x20E392C Offset: 0x20DF92C VA: 0x20E392C
	private static short ResolveItemType(ColorSynthesisCostTable.Target target) { }

	// RVA: 0x20E3954 Offset: 0x20DF954 VA: 0x20E3954
	private static bool RequiresPart(ColorSynthesisCostTable.Target target) { }

	// RVA: 0x20E3978 Offset: 0x20DF978 VA: 0x20E3978
	private static bool RequiresWeaponKind(ColorSynthesisCostTable.Target target) { }

	// RVA: 0x20E39BC Offset: 0x20DF9BC VA: 0x20E39BC
	public static bool RequiresGuideI(ColorSynthesisCostTable.Target target) { }

	// RVA: 0x20E39AC Offset: 0x20DF9AC VA: 0x20E39AC
	public static bool RequiresGuideII(ColorSynthesisCostTable.Target target) { }
}
