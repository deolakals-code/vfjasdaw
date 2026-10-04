// Assembly: mscorlib.dll
// Namespace: System.Globalization
internal class HebrewNumber // TypeDefIndex: 10784
{
	// Fields
	private static readonly HebrewNumber.HebrewValue[] s_hebrewValues; // 0x0
	private static char s_maxHebrewNumberCh; // 0x8
	private static readonly HebrewNumber.HS[] s_numberPasingState; // 0x10

	// Methods

	// RVA: 0x2F8876C Offset: 0x2F8476C VA: 0x2F8876C
	internal static string ToString(int Number) { }

	// RVA: 0x2F86980 Offset: 0x2F82980 VA: 0x2F86980
	internal static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context) { }

	// RVA: 0x2F868A4 Offset: 0x2F828A4 VA: 0x2F868A4
	internal static bool IsDigit(char ch) { }

	// RVA: 0x2F889F0 Offset: 0x2F849F0 VA: 0x2F889F0
	private static void .cctor() { }
}
