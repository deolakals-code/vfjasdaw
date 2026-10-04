// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal struct XsdDuration // TypeDefIndex: 13870
{
	// Fields
	private int years; // 0x0
	private int months; // 0x4
	private int days; // 0x8
	private int hours; // 0xC
	private int minutes; // 0x10
	private int seconds; // 0x14
	private uint nanoseconds; // 0x18

	// Properties
	public bool IsNegative { get; }
	public int Years { get; }
	public int Months { get; }
	public int Days { get; }
	public int Hours { get; }
	public int Minutes { get; }
	public int Seconds { get; }
	public int Nanoseconds { get; }

	// Methods

	// RVA: 0x337BDCC Offset: 0x3377DCC VA: 0x337BDCC
	public void .ctor(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	// RVA: 0x337BF28 Offset: 0x3377F28 VA: 0x337BF28
	public void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x337BF30 Offset: 0x3377F30 VA: 0x337BF30
	public void .ctor(TimeSpan timeSpan, XsdDuration.DurationType durationType) { }

	// RVA: 0x337C100 Offset: 0x3378100 VA: 0x337C100
	public void .ctor(string s) { }

	// RVA: 0x337C108 Offset: 0x3378108 VA: 0x337C108
	public void .ctor(string s, XsdDuration.DurationType durationType) { }

	// RVA: 0x337C8F0 Offset: 0x33788F0 VA: 0x337C8F0
	public bool get_IsNegative() { }

	// RVA: 0x337C8FC Offset: 0x33788FC VA: 0x337C8FC
	public int get_Years() { }

	// RVA: 0x337C904 Offset: 0x3378904 VA: 0x337C904
	public int get_Months() { }

	// RVA: 0x337C90C Offset: 0x337890C VA: 0x337C90C
	public int get_Days() { }

	// RVA: 0x337C914 Offset: 0x3378914 VA: 0x337C914
	public int get_Hours() { }

	// RVA: 0x337C91C Offset: 0x337891C VA: 0x337C91C
	public int get_Minutes() { }

	// RVA: 0x337C924 Offset: 0x3378924 VA: 0x337C924
	public int get_Seconds() { }

	// RVA: 0x337C8E4 Offset: 0x33788E4 VA: 0x337C8E4
	public int get_Nanoseconds() { }

	// RVA: 0x337C92C Offset: 0x337892C VA: 0x337C92C
	public TimeSpan ToTimeSpan() { }

	// RVA: 0x337C934 Offset: 0x3378934 VA: 0x337C934
	public TimeSpan ToTimeSpan(XsdDuration.DurationType durationType) { }

	// RVA: 0x337CE40 Offset: 0x3378E40 VA: 0x337CE40
	internal Exception TryToTimeSpan(out TimeSpan result) { }

	// RVA: 0x337C97C Offset: 0x337897C VA: 0x337C97C
	internal Exception TryToTimeSpan(XsdDuration.DurationType durationType, out TimeSpan result) { }

	// RVA: 0x337CE4C Offset: 0x3378E4C VA: 0x337CE4C Slot: 3
	public override string ToString() { }

	// RVA: 0x337CE54 Offset: 0x3378E54 VA: 0x337CE54
	internal string ToString(XsdDuration.DurationType durationType) { }

	// RVA: 0x337D280 Offset: 0x3379280 VA: 0x337D280
	internal static Exception TryParse(string s, out XsdDuration result) { }

	// RVA: 0x337C17C Offset: 0x337817C VA: 0x337C17C
	internal static Exception TryParse(string s, XsdDuration.DurationType durationType, out XsdDuration result) { }

	// RVA: 0x337D28C Offset: 0x337928C VA: 0x337D28C
	private static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits) { }
}
