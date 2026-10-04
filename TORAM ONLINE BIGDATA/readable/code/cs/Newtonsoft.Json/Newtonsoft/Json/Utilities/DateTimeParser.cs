// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal struct DateTimeParser // TypeDefIndex: 15891
{
	// Fields
	public int Year; // 0x0
	public int Month; // 0x4
	public int Day; // 0x8
	public int Hour; // 0xC
	public int Minute; // 0x10
	public int Second; // 0x14
	public int Fraction; // 0x18
	public int ZoneHour; // 0x1C
	public int ZoneMinute; // 0x20
	public ParserTimeZone Zone; // 0x24
	private char[] _text; // 0x28
	private int _end; // 0x30
	private static readonly int[] Power10; // 0x0
	private static readonly int Lzyyyy; // 0x8
	private static readonly int Lzyyyy_; // 0xC
	private static readonly int Lzyyyy_MM; // 0x10
	private static readonly int Lzyyyy_MM_; // 0x14
	private static readonly int Lzyyyy_MM_dd; // 0x18
	private static readonly int Lzyyyy_MM_ddT; // 0x1C
	private static readonly int LzHH; // 0x20
	private static readonly int LzHH_; // 0x24
	private static readonly int LzHH_mm; // 0x28
	private static readonly int LzHH_mm_; // 0x2C
	private static readonly int LzHH_mm_ss; // 0x30
	private static readonly int Lz_; // 0x34
	private static readonly int Lz_zz; // 0x38

	// Methods

	// RVA: 0x30881F0 Offset: 0x30841F0 VA: 0x30881F0
	private static void .cctor() { }

	// RVA: 0x3088474 Offset: 0x3084474 VA: 0x3088474
	public bool Parse(char[] text, int startIndex, int length) { }

	// RVA: 0x3088574 Offset: 0x3084574 VA: 0x3088574
	private bool ParseDate(int start) { }

	// RVA: 0x3088768 Offset: 0x3084768 VA: 0x3088768
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x3088990 Offset: 0x3084990 VA: 0x3088990
	private bool ParseTime(ref int start) { }

	// RVA: 0x3088C6C Offset: 0x3084C6C VA: 0x3088C6C
	private bool ParseZone(int start) { }

	// RVA: 0x3088804 Offset: 0x3084804 VA: 0x3088804
	private bool Parse4Digit(int start, out int num) { }

	// RVA: 0x30888F4 Offset: 0x30848F4 VA: 0x30888F4
	private bool Parse2Digit(int start, out int num) { }

	// RVA: 0x308871C Offset: 0x308471C VA: 0x308871C
	private bool ParseChar(int start, char ch) { }
}
