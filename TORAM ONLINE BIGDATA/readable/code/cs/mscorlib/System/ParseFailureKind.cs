// Assembly: mscorlib.dll
// Namespace: System
internal enum ParseFailureKind // TypeDefIndex: 9596
{
	// Fields
	public int value__; // 0x0
	public const ParseFailureKind None = 0;
	public const ParseFailureKind ArgumentNull = 1;
	public const ParseFailureKind Format = 2;
	public const ParseFailureKind FormatWithParameter = 3;
	public const ParseFailureKind FormatWithOriginalDateTime = 4;
	public const ParseFailureKind FormatWithFormatSpecifier = 5;
	public const ParseFailureKind FormatWithOriginalDateTimeAndParameter = 6;
	public const ParseFailureKind FormatBadDateTimeCalendar = 7;
}
