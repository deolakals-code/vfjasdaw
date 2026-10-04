// Assembly: mscorlib.dll
// Namespace: 
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
private struct TimeSpanParse.TimeSpanRawInfo // TypeDefIndex: 10795
{
	// Fields
	internal TimeSpanParse.TTT _lastSeenTTT; // 0x0
	internal int _tokenCount; // 0x4
	internal int _sepCount; // 0x8
	internal int _numCount; // 0xC
	private TimeSpanFormat.FormatLiterals _posLoc; // 0x10
	private TimeSpanFormat.FormatLiterals _negLoc; // 0x38
	private bool _posLocInit; // 0x60
	private bool _negLocInit; // 0x61
	private string _fullPosPattern; // 0x68
	private string _fullNegPattern; // 0x70
	internal TimeSpanParse.TimeSpanToken _numbers0; // 0x78
	internal TimeSpanParse.TimeSpanToken _numbers1; // 0x98
	internal TimeSpanParse.TimeSpanToken _numbers2; // 0xB8
	internal TimeSpanParse.TimeSpanToken _numbers3; // 0xD8
	internal TimeSpanParse.TimeSpanToken _numbers4; // 0xF8
	internal ReadOnlySpan<char> _literals0; // 0x118
	internal ReadOnlySpan<char> _literals1; // 0x128
	internal ReadOnlySpan<char> _literals2; // 0x138
	internal ReadOnlySpan<char> _literals3; // 0x148
	internal ReadOnlySpan<char> _literals4; // 0x158
	internal ReadOnlySpan<char> _literals5; // 0x168

	// Properties
	internal TimeSpanFormat.FormatLiterals PositiveInvariant { get; }
	internal TimeSpanFormat.FormatLiterals NegativeInvariant { get; }
	internal TimeSpanFormat.FormatLiterals PositiveLocalized { get; }
	internal TimeSpanFormat.FormatLiterals NegativeLocalized { get; }

	// Methods

	// RVA: 0x2F8FF84 Offset: 0x2F8BF84 VA: 0x2F8FF84
	internal TimeSpanFormat.FormatLiterals get_PositiveInvariant() { }

	// RVA: 0x2F8FFEC Offset: 0x2F8BFEC VA: 0x2F8FFEC
	internal TimeSpanFormat.FormatLiterals get_NegativeInvariant() { }

	// RVA: 0x2F8DA74 Offset: 0x2F89A74 VA: 0x2F8DA74
	internal TimeSpanFormat.FormatLiterals get_PositiveLocalized() { }

	// RVA: 0x2F8DB24 Offset: 0x2F89B24 VA: 0x2F8DB24
	internal TimeSpanFormat.FormatLiterals get_NegativeLocalized() { }

	// RVA: 0x2F8E33C Offset: 0x2F8A33C VA: 0x2F8E33C
	internal bool FullAppCompatMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x2F8ECE4 Offset: 0x2F8ACE4 VA: 0x2F8ECE4
	internal bool PartialAppCompatMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x2F8D628 Offset: 0x2F89628 VA: 0x2F8D628
	internal bool FullMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x2F8F240 Offset: 0x2F8B240 VA: 0x2F8F240
	internal bool FullDMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x2F8EFE0 Offset: 0x2F8AFE0 VA: 0x2F8EFE0
	internal bool FullHMMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x2F8E9E0 Offset: 0x2F8A9E0 VA: 0x2F8E9E0
	internal bool FullDHMMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x2F8E6DC Offset: 0x2F8A6DC VA: 0x2F8E6DC
	internal bool FullHMSMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x2F8DF94 Offset: 0x2F89F94 VA: 0x2F8DF94
	internal bool FullDHMSMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x2F8DBEC Offset: 0x2F89BEC VA: 0x2F8DBEC
	internal bool FullHMSFMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x2F8AE38 Offset: 0x2F86E38 VA: 0x2F8AE38
	internal void Init(DateTimeFormatInfo dtfi) { }

	// RVA: 0x2F8B0E0 Offset: 0x2F870E0 VA: 0x2F8B0E0
	internal bool ProcessToken(ref TimeSpanParse.TimeSpanToken tok, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x2F90058 Offset: 0x2F8C058 VA: 0x2F90058
	private bool AddSep(ReadOnlySpan<char> sep, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x2F90164 Offset: 0x2F8C164 VA: 0x2F90164
	private bool AddNum(TimeSpanParse.TimeSpanToken num, ref TimeSpanParse.TimeSpanResult result) { }
}
