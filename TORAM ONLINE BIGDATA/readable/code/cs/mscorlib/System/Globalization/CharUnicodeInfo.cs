// Assembly: mscorlib.dll
// Namespace: System.Globalization
public static class CharUnicodeInfo // TypeDefIndex: 10764
{
	// Properties
	private static ReadOnlySpan<byte> CategoryLevel1Index { get; }
	private static ReadOnlySpan<byte> CategoryLevel2Index { get; }
	private static ReadOnlySpan<byte> CategoryLevel3Index { get; }
	private static ReadOnlySpan<byte> CategoriesValue { get; }

	// Methods

	// RVA: 0x2F5F824 Offset: 0x2F5B824 VA: 0x2F5F824
	internal static int InternalConvertToUtf32(string s, int index) { }

	// RVA: 0x2F5F8B8 Offset: 0x2F5B8B8 VA: 0x2F5F8B8
	public static UnicodeCategory GetUnicodeCategory(char ch) { }

	// RVA: 0x2F5F8EC Offset: 0x2F5B8EC VA: 0x2F5F8EC
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x2F5F8D4 Offset: 0x2F5B8D4 VA: 0x2F5F8D4
	public static UnicodeCategory GetUnicodeCategory(int codePoint) { }

	// RVA: 0x2F5F9B0 Offset: 0x2F5B9B0 VA: 0x2F5F9B0
	internal static byte InternalGetCategoryValue(int ch, int offset) { }

	// RVA: 0x2F5F994 Offset: 0x2F5B994 VA: 0x2F5F994
	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index) { }

	// RVA: 0x2F5FBA0 Offset: 0x2F5BBA0 VA: 0x2F5FBA0
	internal static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x2F5FBBC Offset: 0x2F5BBBC VA: 0x2F5FBBC
	internal static bool IsWhiteSpace(char c) { }

	// RVA: 0x2F5FA60 Offset: 0x2F5BA60 VA: 0x2F5FA60
	private static ReadOnlySpan<byte> get_CategoryLevel1Index() { }

	// RVA: 0x2F5FAB0 Offset: 0x2F5BAB0 VA: 0x2F5FAB0
	private static ReadOnlySpan<byte> get_CategoryLevel2Index() { }

	// RVA: 0x2F5FB00 Offset: 0x2F5BB00 VA: 0x2F5FB00
	private static ReadOnlySpan<byte> get_CategoryLevel3Index() { }

	// RVA: 0x2F5FB50 Offset: 0x2F5BB50 VA: 0x2F5FB50
	private static ReadOnlySpan<byte> get_CategoriesValue() { }
}
