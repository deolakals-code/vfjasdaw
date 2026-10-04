// Assembly: System.Xml.dll
// Namespace: System.Xml
internal static class ValidateNames // TypeDefIndex: 13440
{
	// Fields
	private static XmlCharType xmlCharType; // 0x0

	// Methods

	// RVA: 0x33D425C Offset: 0x33D025C VA: 0x33D425C
	internal static int ParseNmtoken(string s, int offset) { }

	// RVA: 0x33D4324 Offset: 0x33D0324 VA: 0x33D4324
	internal static int ParseNmtokenNoNamespaces(string s, int offset) { }

	// RVA: 0x33D4408 Offset: 0x33D0408 VA: 0x33D4408
	internal static int ParseNameNoNamespaces(string s, int offset) { }

	// RVA: 0x33D4560 Offset: 0x33D0560 VA: 0x33D4560
	internal static bool IsNameNoNamespaces(string s) { }

	// RVA: 0x33D45E0 Offset: 0x33D05E0 VA: 0x33D45E0
	internal static int ParseNCName(string s, int offset) { }

	// RVA: 0x33D46FC Offset: 0x33D06FC VA: 0x33D46FC
	internal static int ParseNCName(string s) { }

	// RVA: 0x33D4754 Offset: 0x33D0754 VA: 0x33D4754
	internal static int ParseQName(string s, int offset, out int colonOffset) { }

	// RVA: 0x33D4830 Offset: 0x33D0830 VA: 0x33D4830
	internal static void ParseQNameThrow(string s, out string prefix, out string localName) { }

	// RVA: 0x33D4968 Offset: 0x33D0968 VA: 0x33D4968
	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x33D4CC0 Offset: 0x33D0CC0 VA: 0x33D4CC0
	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x33D4E90 Offset: 0x33D0E90 VA: 0x33D4E90
	internal static void SplitQName(string name, out string prefix, out string lname) { }

	// RVA: 0x33D5298 Offset: 0x33D1298 VA: 0x33D5298
	private static void .cctor() { }
}
