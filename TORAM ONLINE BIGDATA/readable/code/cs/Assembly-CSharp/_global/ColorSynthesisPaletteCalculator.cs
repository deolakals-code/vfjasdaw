// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class ColorSynthesisPaletteCalculator // TypeDefIndex: 1815
{
	// Fields
	public const int PaletteRowSize = 16;
	public const int MainRow = 3;

	// Methods

	// RVA: 0x20E3D44 Offset: 0x20DFD44 VA: 0x20E3D44
	public static List<byte> Calculate(int mainGemId, int[] subGemIds) { }

	// RVA: 0x20E3EB0 Offset: 0x20DFEB0 VA: 0x20E3EB0
	public static byte CalculateCenterColor(int mainGemId, int[] subGemIds) { }

	// RVA: 0x20E3EC8 Offset: 0x20DFEC8 VA: 0x20E3EC8
	public static byte CalculateCenterColor(int mainGemId, int[] subGemIds, int lastSubSlotIndex) { }

	// RVA: 0x20E425C Offset: 0x20E025C VA: 0x20E425C
	private static byte PaletteIdAt(int row, int col) { }

	// RVA: 0x20E4240 Offset: 0x20E0240 VA: 0x20E4240
	private static int Clamp(int value, int min, int max) { }

	// RVA: 0x20E40E4 Offset: 0x20E00E4 VA: 0x20E40E4
	private static int MoveCenter(int curCol, int targetCol, int subSlotIndex) { }
}
