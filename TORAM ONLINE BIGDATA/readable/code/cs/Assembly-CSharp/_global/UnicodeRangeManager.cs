// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class UnicodeRangeManager // TypeDefIndex: 5595
{
	// Fields
	private static Dictionary<byte, byte[]> unicodeRange; // 0x0
	[CompilerGenerated]
	private static bool <IsValid>k__BackingField; // 0x8

	// Properties
	public static bool IsValid { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17A32F0 Offset: 0x179F2F0 VA: 0x17A32F0
	public static bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x17A3348 Offset: 0x179F348 VA: 0x17A3348
	private static void set_IsValid(bool value) { }

	// RVA: 0x17A33A8 Offset: 0x179F3A8 VA: 0x17A33A8
	private static void .cctor() { }

	// RVA: 0x17A3480 Offset: 0x179F480 VA: 0x17A3480
	public static bool CreateRangeData(string file) { }

	// RVA: 0x17A3AC0 Offset: 0x179FAC0 VA: 0x17A3AC0
	public static bool CreateRangeData(byte[] buf) { }

	// RVA: 0x17A4104 Offset: 0x17A0104 VA: 0x17A4104
	public static void ClearRangeData() { }

	// RVA: 0x17A41B0 Offset: 0x17A01B0 VA: 0x17A41B0
	public static bool Contains(string str) { }

	// RVA: 0x17A43B4 Offset: 0x17A03B4 VA: 0x17A43B4
	public static bool PartexClusionContains(string str) { }

	// RVA: 0x17A45CC Offset: 0x17A05CC VA: 0x17A45CC
	public static string Remove(string str) { }

	// RVA: 0x17A4870 Offset: 0x17A0870 VA: 0x17A4870
	public static string PartexClusionRemove(string str) { }

	// RVA: 0x17A4B28 Offset: 0x17A0B28 VA: 0x17A4B28
	public static string Replace(string str, string replace) { }
}
