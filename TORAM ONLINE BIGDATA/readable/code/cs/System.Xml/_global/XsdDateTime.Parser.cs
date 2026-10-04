// Assembly: System.Xml.dll
// Namespace: 
private struct XsdDateTime.Parser // TypeDefIndex: 13866
{
	// Fields
	public XsdDateTime.DateTimeTypeCode typeCode; // 0x0
	public int year; // 0x4
	public int month; // 0x8
	public int day; // 0xC
	public int hour; // 0x10
	public int minute; // 0x14
	public int second; // 0x18
	public int fraction; // 0x1C
	public XsdDateTime.XsdDateTimeKind kind; // 0x20
	public int zoneHour; // 0x24
	public int zoneMinute; // 0x28
	private string text; // 0x30
	private int length; // 0x38
	private static int[] Power10; // 0x0

	// Methods

	// RVA: 0x33786D0 Offset: 0x33746D0 VA: 0x33786D0
	public bool Parse(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x337B1E0 Offset: 0x33771E0 VA: 0x337B1E0
	private bool ParseDate(int start) { }

	// RVA: 0x337B440 Offset: 0x3377440 VA: 0x337B440
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x337B748 Offset: 0x3377748 VA: 0x337B748
	private bool ParseTimeAndWhitespace(int start) { }

	// RVA: 0x337B9B4 Offset: 0x33779B4 VA: 0x337B9B4
	private bool ParseTime(ref int start) { }

	// RVA: 0x337B4DC Offset: 0x33774DC VA: 0x337B4DC
	private bool ParseZoneAndWhitespace(int start) { }

	// RVA: 0x337B7E4 Offset: 0x33777E4 VA: 0x337B7E4
	private bool Parse4Dig(int start, ref int num) { }

	// RVA: 0x337B90C Offset: 0x337790C VA: 0x337B90C
	private bool Parse2Dig(int start, ref int num) { }

	// RVA: 0x337B3FC Offset: 0x33773FC VA: 0x337B3FC
	private bool ParseChar(int start, char ch) { }

	// RVA: 0x337B1D4 Offset: 0x33771D4 VA: 0x337B1D4
	private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	// RVA: 0x337BD2C Offset: 0x3377D2C VA: 0x337BD2C
	private static void .cctor() { }
}
