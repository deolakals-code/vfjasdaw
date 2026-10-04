// Assembly: System.dll
// Namespace: System.Net
internal class IPAddressParser // TypeDefIndex: 14360
{
	// Methods

	// RVA: 0x34DC9D0 Offset: 0x34D89D0 VA: 0x34DC9D0
	internal static IPAddress Parse(ReadOnlySpan<char> ipSpan, bool tryParse) { }

	// RVA: 0x34DD084 Offset: 0x34D9084 VA: 0x34DD084
	internal static string IPv4AddressToString(uint address) { }

	// RVA: 0x34DDCB4 Offset: 0x34D9CB4 VA: 0x34DDCB4
	internal static void IPv4AddressToString(uint address, StringBuilder destination) { }

	// RVA: 0x34DDC18 Offset: 0x34D9C18 VA: 0x34DDC18
	private static int IPv4AddressToStringHelper(uint address, char* addressString) { }

	// RVA: 0x34DD070 Offset: 0x34D9070 VA: 0x34DD070
	internal static string IPv6AddressToString(ushort[] address, uint scopeId) { }

	// RVA: 0x34DDDDC Offset: 0x34D9DDC VA: 0x34DDDDC
	internal static StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId) { }

	// RVA: 0x34DDD24 Offset: 0x34D9D24 VA: 0x34DDD24
	private static void FormatIPv4AddressNumber(int number, char* addressString, ref int offset) { }

	// RVA: 0x34DDB68 Offset: 0x34D9B68 VA: 0x34DDB68
	public static bool Ipv4StringToAddress(ReadOnlySpan<char> ipSpan, out long address) { }

	// RVA: 0x34DD9F4 Offset: 0x34D99F4 VA: 0x34DD9F4
	public static bool Ipv6StringToAddress(ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, out uint scope) { }

	// RVA: 0x34DDEFC Offset: 0x34D9EFC VA: 0x34DDEFC
	private static void AppendSections(ushort[] address, int fromInclusive, int toExclusive, StringBuilder buffer) { }

	// RVA: 0x34DE0E4 Offset: 0x34DA0E4 VA: 0x34DE0E4
	private static void AppendHex(ushort value, StringBuilder buffer) { }

	// RVA: 0x34DE0B0 Offset: 0x34DA0B0 VA: 0x34DE0B0
	private static uint ExtractIPv4Address(ushort[] address) { }

	// RVA: 0x34DE14C Offset: 0x34DA14C VA: 0x34DE14C
	private static ushort Reverse(ushort number) { }
}
