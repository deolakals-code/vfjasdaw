// Assembly: System.dll
// Namespace: System
internal static class IPv6AddressHelper // TypeDefIndex: 14026
{
	// Methods

	// RVA: 0x3461360 Offset: 0x345D360 VA: 0x3461360
	internal static ValueTuple<int, int> FindCompressionRange(ReadOnlySpan<ushort> numbers) { }

	// RVA: 0x3461440 Offset: 0x345D440 VA: 0x3461440
	internal static bool ShouldHaveIpv4Embedded(ReadOnlySpan<ushort> numbers) { }

	// RVA: 0x3461510 Offset: 0x345D510 VA: 0x3461510
	internal static bool IsValidStrict(char* name, int start, ref int end) { }

	// RVA: 0x3461840 Offset: 0x345D840 VA: 0x3461840
	internal static void Parse(ReadOnlySpan<char> address, ushort* numbers, int start, ref string scopeId) { }

	// RVA: 0x3461CF0 Offset: 0x345DCF0 VA: 0x3461CF0
	internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId) { }

	// RVA: 0x346229C Offset: 0x345E29C VA: 0x346229C
	private static bool IsLoopback(ReadOnlySpan<ushort> numbers) { }

	// RVA: 0x346237C Offset: 0x345E37C VA: 0x346237C
	private static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress) { }

	// RVA: 0x3462640 Offset: 0x345E640 VA: 0x3462640
	internal static bool IsValid(char* name, int start, ref int end) { }
}
