// Assembly: System.dll
// Namespace: System
internal static class IPv4AddressHelper // TypeDefIndex: 14025
{
	// Methods

	// RVA: 0x31A44EC Offset: 0x31A04EC VA: 0x31A44EC
	internal static int ParseHostNumber(ReadOnlySpan<char> str, int start, int end) { }

	// RVA: 0x31A45AC Offset: 0x31A05AC VA: 0x31A45AC
	internal static bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) { }

	// RVA: 0x31A451C Offset: 0x31A051C VA: 0x31A451C
	private static bool ParseCanonical(ReadOnlySpan<char> name, byte* numbers, int start, int end) { }

	// RVA: 0x31A45DC Offset: 0x31A05DC VA: 0x31A45DC
	internal static bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile) { }

	// RVA: 0x31A4724 Offset: 0x31A0724 VA: 0x31A4724
	internal static long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile) { }

	// RVA: 0x31A4A1C Offset: 0x31A0A1C VA: 0x31A4A1C
	internal static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback) { }

	// RVA: 0x31A4C18 Offset: 0x31A0C18 VA: 0x31A4C18
	private static bool Parse(string name, byte* numbers, int start, int end) { }
}
