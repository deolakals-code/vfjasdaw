// Assembly: mscorlib.dll
// Namespace: System.Globalization
internal static class TimeSpanParse // TypeDefIndex: 10798
{
	// Methods

	// RVA: 0x2F8A360 Offset: 0x2F86360 VA: 0x2F8A360
	internal static long Pow10(int pow) { }

	// RVA: 0x2F8A790 Offset: 0x2F86790 VA: 0x2F8A790
	private static bool TryTimeToTicks(bool positive, TimeSpanParse.TimeSpanToken days, TimeSpanParse.TimeSpanToken hours, TimeSpanParse.TimeSpanToken minutes, TimeSpanParse.TimeSpanToken seconds, TimeSpanParse.TimeSpanToken fraction, out long result) { }

	// RVA: 0x2F8A948 Offset: 0x2F86948 VA: 0x2F8A948
	internal static TimeSpan Parse(ReadOnlySpan<char> input, IFormatProvider formatProvider) { }

	// RVA: 0x2F8AB10 Offset: 0x2F86B10 VA: 0x2F8AB10
	internal static bool TryParse(ReadOnlySpan<char> input, IFormatProvider formatProvider, out TimeSpan result) { }

	// RVA: 0x2F8AB54 Offset: 0x2F86B54 VA: 0x2F8AB54
	internal static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result) { }

	// RVA: 0x2F8A98C Offset: 0x2F8698C VA: 0x2F8A98C
	private static bool TryParseTimeSpan(ReadOnlySpan<char> input, TimeSpanParse.TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x2F8B1F0 Offset: 0x2F871F0 VA: 0x2F8B1F0
	private static bool ProcessTerminalState(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x2F8D3D4 Offset: 0x2F893D4 VA: 0x2F8D3D4
	private static bool ProcessTerminal_DHMSF(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x2F8C820 Offset: 0x2F88820 VA: 0x2F8C820
	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x2F8B9CC Offset: 0x2F879CC VA: 0x2F8B9CC
	private static bool ProcessTerminal_HM_S_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x2F8B694 Offset: 0x2F87694 VA: 0x2F8B694
	private static bool ProcessTerminal_HM(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x2F8B324 Offset: 0x2F87324 VA: 0x2F8B324
	private static bool ProcessTerminal_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x2F8AB90 Offset: 0x2F86B90 VA: 0x2F8AB90
	private static bool TryParseExactTimeSpan(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x2F8F430 Offset: 0x2F8B430 VA: 0x2F8F430
	private static bool TryParseByFormat(ReadOnlySpan<char> input, ReadOnlySpan<char> format, TimeSpanStyles styles, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x2F8FB34 Offset: 0x2F8BB34 VA: 0x2F8FB34
	private static bool ParseExactDigits(ref TimeSpanParse.TimeSpanTokenizer tokenizer, int minDigitLength, out int result) { }

	// RVA: 0x2F8FB64 Offset: 0x2F8BB64 VA: 0x2F8FB64
	private static bool ParseExactDigits(ref TimeSpanParse.TimeSpanTokenizer tokenizer, int minDigitLength, int maxDigitLength, out int zeroes, out int result) { }

	// RVA: 0x2F8FC28 Offset: 0x2F8BC28 VA: 0x2F8FC28
	private static bool ParseExactLiteral(ref TimeSpanParse.TimeSpanTokenizer tokenizer, StringBuilder enquotedString) { }

	// RVA: 0x2F8F3FC Offset: 0x2F8B3FC VA: 0x2F8F3FC
	private static bool TryParseTimeSpanConstant(ReadOnlySpan<char> input, ref TimeSpanParse.TimeSpanResult result) { }
}
