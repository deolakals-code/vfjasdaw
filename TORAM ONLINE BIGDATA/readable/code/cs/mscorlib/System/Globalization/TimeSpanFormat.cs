// Assembly: mscorlib.dll
// Namespace: System.Globalization
internal static class TimeSpanFormat // TypeDefIndex: 10789
{
	// Fields
	internal static readonly TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals; // 0x0
	internal static readonly TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals; // 0x28

	// Methods

	// RVA: 0x2F88E0C Offset: 0x2F84E0C VA: 0x2F88E0C
	private static void AppendNonNegativeInt32(StringBuilder sb, int n, int digits) { }

	// RVA: 0x2F88F04 Offset: 0x2F84F04 VA: 0x2F88F04
	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider) { }

	// RVA: 0x2F89294 Offset: 0x2F85294 VA: 0x2F89294
	internal static bool TryFormat(TimeSpan value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider formatProvider) { }

	// RVA: 0x2F88FBC Offset: 0x2F84FBC VA: 0x2F88FBC
	private static StringBuilder FormatToBuilder(TimeSpan value, ReadOnlySpan<char> format, IFormatProvider formatProvider) { }

	// RVA: 0x2F893B4 Offset: 0x2F853B4 VA: 0x2F893B4
	private static StringBuilder FormatStandard(TimeSpan value, bool isInvariant, ReadOnlySpan<char> format, TimeSpanFormat.Pattern pattern) { }

	// RVA: 0x2F89884 Offset: 0x2F85884 VA: 0x2F89884
	private static StringBuilder FormatCustomized(TimeSpan value, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, StringBuilder result) { }

	// RVA: 0x2F8A4F4 Offset: 0x2F864F4 VA: 0x2F8A4F4
	private static void .cctor() { }
}
