// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Productions
public static class ColorGemUtility // TypeDefIndex: 11354
{
	// Fields
	private static readonly Dictionary<int, byte> MainGemPaletteMap; // 0x0
	private static readonly byte[] WhitePalette; // 0x8
	private static readonly byte[] BlackPalette; // 0x10

	// Methods

	// RVA: 0x36F219C Offset: 0x36EE19C VA: 0x36F219C
	public static bool IsMainGem(int itemId) { }

	// RVA: 0x36F221C Offset: 0x36EE21C VA: 0x36F221C
	public static bool IsSubGem(int itemId) { }

	// RVA: 0x36F22C0 Offset: 0x36EE2C0 VA: 0x36F22C0
	public static bool IsHammer(int itemId) { }

	// RVA: 0x36F22D4 Offset: 0x36EE2D4 VA: 0x36F22D4
	public static bool TryGetMainPaletteNo(int itemId, out byte paletteNo) { }

	// RVA: 0x36F2364 Offset: 0x36EE364 VA: 0x36F2364
	public static List<byte> Calculate(int mainGemId, int[] subGemIds) { }

	// RVA: 0x36F2EE4 Offset: 0x36EEEE4 VA: 0x36F2EE4
	public static int CalcColorSynthesisCost(short itemType, bool specifyColorPosition, bool specifyWeaponType, int skillLevel) { }

	// RVA: 0x36F3098 Offset: 0x36EF098 VA: 0x36F3098
	public static int CalcSuccessRate(int colorSynthesisLv, int colorGuide1Lv, int colorGuide2Lv, int colorGuide3Lv, int subGemCount, bool hasHammer) { }

	// RVA: 0x36F3010 Offset: 0x36EF010 VA: 0x36F3010
	public static long CalcColorSynthesisBaseCost(short itemType, bool specifyColorPosition, bool specifyWeaponType) { }

	// RVA: 0x36F2B20 Offset: 0x36EEB20 VA: 0x36F2B20
	private static void EliminateBright(List<List<byte>> palettes) { }

	// RVA: 0x36F2CA8 Offset: 0x36EECA8 VA: 0x36F2CA8
	private static void EliminateDark(List<List<byte>> palettes) { }

	// RVA: 0x36F2E30 Offset: 0x36EEE30 VA: 0x36F2E30
	private static int ShiftHue(int hue, int targetHue, int slot) { }

	// RVA: 0x36F30C8 Offset: 0x36EF0C8 VA: 0x36F30C8
	private static void .cctor() { }
}
