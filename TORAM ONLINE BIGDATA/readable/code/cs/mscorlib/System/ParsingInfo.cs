// Assembly: mscorlib.dll
// Namespace: System
internal struct ParsingInfo // TypeDefIndex: 9599
{
	// Fields
	internal Calendar calendar; // 0x0
	internal int dayOfWeek; // 0x8
	internal DateTimeParse.TM timeMark; // 0xC
	internal bool fUseHour12; // 0x10
	internal bool fUseTwoDigitYear; // 0x11
	internal bool fAllowInnerWhite; // 0x12
	internal bool fAllowTrailingWhite; // 0x13
	internal bool fCustomNumberParser; // 0x14
	internal DateTimeParse.MatchNumberDelegate parseNumberDelegate; // 0x18

	// Methods

	// RVA: 0x2FDE5C4 Offset: 0x2FDA5C4 VA: 0x2FDE5C4
	internal void Init() { }
}
