// Assembly: System.dll
// Namespace: System
internal static class IriHelper // TypeDefIndex: 14031
{
	// Methods

	// RVA: 0x34639E0 Offset: 0x345F9E0 VA: 0x34639E0
	internal static bool CheckIriUnicodeRange(char unicode, bool isQuery) { }

	// RVA: 0x3463A38 Offset: 0x345FA38 VA: 0x3463A38
	internal static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery) { }

	// RVA: 0x3464068 Offset: 0x3460068 VA: 0x3464068
	internal static bool CheckIsReserved(char ch, UriComponents component) { }

	// RVA: 0x34641AC Offset: 0x34601AC VA: 0x34641AC
	internal static string EscapeUnescapeIri(char* pInput, int start, int end, UriComponents component) { }
}
