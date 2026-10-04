// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class ColorSynthesisGemDef // TypeDefIndex: 1814
{
	// Fields
	public static readonly int[] MainSlotGemIds; // 0x0
	public static readonly int[] SubSlotGemIds; // 0x8

	// Properties
	public static int SagesStoneId { get; }

	// Methods

	// RVA: 0x20E39CC Offset: 0x20DF9CC VA: 0x20E39CC
	public static int get_SagesStoneId() { }

	// RVA: 0x20E39D4 Offset: 0x20DF9D4 VA: 0x20E39D4
	public static ColorSynthesisGemDef.Kind GetKind(int itemId) { }

	// RVA: 0x20E3AAC Offset: 0x20DFAAC VA: 0x20E3AAC
	public static bool TryGetMainGemCenter(int itemId, out byte paletteId) { }

	// RVA: 0x20E3B14 Offset: 0x20DFB14 VA: 0x20E3B14
	public static bool TryGetFixedPreviewColor(int itemId, out int colorId) { }

	// RVA: 0x20E3B5C Offset: 0x20DFB5C VA: 0x20E3B5C
	public static bool IsValidMainSlot(int itemId) { }

	// RVA: 0x20E3BC8 Offset: 0x20DFBC8 VA: 0x20E3BC8
	public static bool IsValidSubSlot(int itemId) { }

	// RVA: 0x20E3C60 Offset: 0x20DFC60 VA: 0x20E3C60
	private static void .cctor() { }
}
