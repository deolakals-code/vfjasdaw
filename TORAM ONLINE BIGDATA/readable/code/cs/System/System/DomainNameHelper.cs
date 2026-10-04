// Assembly: System.dll
// Namespace: System
internal class DomainNameHelper // TypeDefIndex: 14050
{
	// Methods

	// RVA: 0x3467984 Offset: 0x3463984 VA: 0x3467984
	internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback) { }

	// RVA: 0x3467B1C Offset: 0x3463B1C VA: 0x3467B1C
	internal static bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x3467D4C Offset: 0x3463D4C VA: 0x3467D4C
	internal static bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x3467F3C Offset: 0x3463F3C VA: 0x3467F3C
	internal static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	// RVA: 0x34681C8 Offset: 0x34641C8 VA: 0x34681C8
	internal static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost) { }

	// RVA: 0x3468414 Offset: 0x3464414 VA: 0x3468414
	private static bool IsIdnAce(string input, int index) { }

	// RVA: 0x34683C8 Offset: 0x34643C8 VA: 0x34683C8
	private static bool IsIdnAce(char* input, int index) { }

	// RVA: 0x34684AC Offset: 0x34644AC VA: 0x34684AC
	internal static string UnicodeEquivalent(string idnHost, char* hostname, int start, int end) { }

	// RVA: 0x34685C8 Offset: 0x34645C8 VA: 0x34685C8
	internal static string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	// RVA: 0x3467C9C Offset: 0x3463C9C VA: 0x3467C9C
	private static bool IsASCIILetterOrDigit(char character, ref bool notCanonical) { }

	// RVA: 0x3467CE8 Offset: 0x3463CE8 VA: 0x3467CE8
	private static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical) { }
}
