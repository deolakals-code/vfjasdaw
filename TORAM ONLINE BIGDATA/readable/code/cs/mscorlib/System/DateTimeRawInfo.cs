// Assembly: mscorlib.dll
// Namespace: System
internal struct DateTimeRawInfo // TypeDefIndex: 9595
{
	// Fields
	private int* num; // 0x0
	internal int numCount; // 0x8
	internal int month; // 0xC
	internal int year; // 0x10
	internal int dayOfWeek; // 0x14
	internal int era; // 0x18
	internal DateTimeParse.TM timeMark; // 0x1C
	internal double fraction; // 0x20
	internal bool hasSameDateAndTimeSeparators; // 0x28

	// Methods

	// RVA: 0x2FDE3E0 Offset: 0x2FDA3E0 VA: 0x2FDE3E0
	internal void Init(int* numberBuffer) { }

	// RVA: 0x2FDE400 Offset: 0x2FDA400 VA: 0x2FDE400
	internal void AddNumber(int value) { }

	// RVA: 0x2FDE418 Offset: 0x2FDA418 VA: 0x2FDE418
	internal int GetNumber(int index) { }
}
