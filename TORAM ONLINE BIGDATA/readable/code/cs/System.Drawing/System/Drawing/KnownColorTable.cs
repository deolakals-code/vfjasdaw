// Assembly: System.Drawing.dll
// Namespace: System.Drawing
internal static class KnownColorTable // TypeDefIndex: 17315
{
	// Fields
	private static int[] s_colorTable; // 0x0
	private static string[] s_colorNameTable; // 0x8

	// Methods

	// RVA: 0x3299B28 Offset: 0x3295B28 VA: 0x3299B28
	private static void EnsureColorTable() { }

	// RVA: 0x3299B80 Offset: 0x3295B80 VA: 0x3299B80
	private static void InitColorTable() { }

	// RVA: 0x329A770 Offset: 0x3296770 VA: 0x329A770
	private static void EnsureColorNameTable() { }

	// RVA: 0x329A7C8 Offset: 0x32967C8 VA: 0x329A7C8
	private static void InitColorNameTable() { }

	// RVA: 0x329C950 Offset: 0x3298950 VA: 0x329C950
	public static int KnownColorToArgb(KnownColor color) { }

	// RVA: 0x329C9C0 Offset: 0x32989C0 VA: 0x329C9C0
	public static string KnownColorToName(KnownColor color) { }

	// RVA: 0x329A63C Offset: 0x329663C VA: 0x329A63C
	private static void UpdateSystemColors(int[] colorTable) { }
}
