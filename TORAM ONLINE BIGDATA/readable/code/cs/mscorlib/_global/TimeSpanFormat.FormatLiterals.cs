// Assembly: mscorlib.dll
// Namespace: 
internal struct TimeSpanFormat.FormatLiterals // TypeDefIndex: 10788
{
	// Fields
	internal string AppCompatLiteral; // 0x0
	internal int dd; // 0x8
	internal int hh; // 0xC
	internal int mm; // 0x10
	internal int ss; // 0x14
	internal int ff; // 0x18
	private string[] _literals; // 0x20

	// Properties
	internal string Start { get; }
	internal string DayHourSep { get; }
	internal string HourMinuteSep { get; }
	internal string MinuteSecondSep { get; }
	internal string SecondFractionSep { get; }
	internal string End { get; }

	// Methods

	// RVA: 0x2F8A3F0 Offset: 0x2F863F0 VA: 0x2F8A3F0
	internal string get_Start() { }

	// RVA: 0x2F8A418 Offset: 0x2F86418 VA: 0x2F8A418
	internal string get_DayHourSep() { }

	// RVA: 0x2F8A444 Offset: 0x2F86444 VA: 0x2F8A444
	internal string get_HourMinuteSep() { }

	// RVA: 0x2F8A470 Offset: 0x2F86470 VA: 0x2F8A470
	internal string get_MinuteSecondSep() { }

	// RVA: 0x2F8A49C Offset: 0x2F8649C VA: 0x2F8A49C
	internal string get_SecondFractionSep() { }

	// RVA: 0x2F8A4C8 Offset: 0x2F864C8 VA: 0x2F8A4C8
	internal string get_End() { }

	// RVA: 0x2F8A5A4 Offset: 0x2F865A4 VA: 0x2F8A5A4
	internal static TimeSpanFormat.FormatLiterals InitInvariant(bool isNegative) { }

	// RVA: 0x2F89FA4 Offset: 0x2F85FA4 VA: 0x2F89FA4
	internal void Init(ReadOnlySpan<char> format, bool useInvariantFieldLengths) { }
}
