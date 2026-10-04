// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class NameHalfWidthUnicodeRangeManager // TypeDefIndex: 5504
{
	// Fields
	private static readonly int[] ThaiCodeRange; // 0x0
	private static Dictionary<byte, byte[]> unicodeRange; // 0x8
	[CompilerGenerated]
	private static bool <IsValid>k__BackingField; // 0x10

	// Properties
	public static bool IsValid { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x177F554 Offset: 0x177B554 VA: 0x177F554
	public static bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x177F5AC Offset: 0x177B5AC VA: 0x177F5AC
	private static void set_IsValid(bool value) { }

	// RVA: 0x177F60C Offset: 0x177B60C VA: 0x177F60C
	private static void .cctor() { }

	// RVA: 0x177F73C Offset: 0x177B73C VA: 0x177F73C
	public static void Initialize() { }

	// RVA: 0x177FF54 Offset: 0x177BF54 VA: 0x177FF54
	public static bool CreateRangeData(string file) { }

	// RVA: 0x177F910 Offset: 0x177B910 VA: 0x177F910
	public static bool CreateRangeData(byte[] buf) { }

	// RVA: 0x177F864 Offset: 0x177B864 VA: 0x177F864
	public static void ClearRangeData() { }

	// RVA: 0x1780594 Offset: 0x177C594 VA: 0x1780594
	public static bool Contains(char c) { }

	// RVA: 0x178073C Offset: 0x177C73C VA: 0x178073C
	public static bool IsThaiCode(string str) { }

	// RVA: 0x1780848 Offset: 0x177C848 VA: 0x1780848
	public static float GetNameCount(string name, bool isHalfWidth) { }
}
