// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
internal static class JavaScriptUtils // TypeDefIndex: 15933
{
	// Fields
	internal static readonly bool[] SingleQuoteCharEscapeFlags; // 0x0
	internal static readonly bool[] DoubleQuoteCharEscapeFlags; // 0x8
	internal static readonly bool[] HtmlCharEscapeFlags; // 0x10

	// Methods

	// RVA: 0x30915B0 Offset: 0x308D5B0 VA: 0x30915B0
	private static void .cctor() { }

	// RVA: 0x3092220 Offset: 0x308E220 VA: 0x3092220
	public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar) { }

	// RVA: 0x30922B8 Offset: 0x308E2B8 VA: 0x30922B8
	public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags) { }

	[NullableContext(2)]
	// RVA: 0x3092340 Offset: 0x308E340 VA: 0x3092340
	public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer) { }

	// RVA: 0x3092A98 Offset: 0x308EA98 VA: 0x3092A98
	public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0x3092928 Offset: 0x308E928 VA: 0x3092928
	private static int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0x3092D84 Offset: 0x308ED84 VA: 0x3092D84
	public static bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, out string errorMessage) { }

	// RVA: 0x30931E8 Offset: 0x308F1E8 VA: 0x30931E8
	private static bool TryGetDateConstructorValue(JsonReader reader, out Nullable<long> integer, out string errorMessage) { }
}
