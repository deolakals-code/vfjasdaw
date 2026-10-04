// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal struct XsdDateTime // TypeDefIndex: 13867
{
	// Fields
	private DateTime dt; // 0x0
	private uint extra; // 0x8
	private static readonly int Lzyyyy; // 0x0
	private static readonly int Lzyyyy_; // 0x4
	private static readonly int Lzyyyy_MM; // 0x8
	private static readonly int Lzyyyy_MM_; // 0xC
	private static readonly int Lzyyyy_MM_dd; // 0x10
	private static readonly int Lzyyyy_MM_ddT; // 0x14
	private static readonly int LzHH; // 0x18
	private static readonly int LzHH_; // 0x1C
	private static readonly int LzHH_mm; // 0x20
	private static readonly int LzHH_mm_; // 0x24
	private static readonly int LzHH_mm_ss; // 0x28
	private static readonly int Lz_; // 0x2C
	private static readonly int Lz_zz; // 0x30
	private static readonly int Lz_zz_; // 0x34
	private static readonly int Lz_zz_zz; // 0x38
	private static readonly int Lz__; // 0x3C
	private static readonly int Lz__mm; // 0x40
	private static readonly int Lz__mm_; // 0x44
	private static readonly int Lz__mm__; // 0x48
	private static readonly int Lz__mm_dd; // 0x4C
	private static readonly int Lz___; // 0x50
	private static readonly int Lz___dd; // 0x54
	private static readonly XmlTypeCode[] typeCodes; // 0x58

	// Properties
	private XsdDateTime.DateTimeTypeCode InternalTypeCode { get; }
	private XsdDateTime.XsdDateTimeKind InternalKind { get; }
	public int Year { get; }
	public int Month { get; }
	public int Day { get; }
	public int Hour { get; }
	public int Minute { get; }
	public int Second { get; }
	public int Fraction { get; }
	public int ZoneHour { get; }
	public int ZoneMinute { get; }

	// Methods

	// RVA: 0x3378528 Offset: 0x3374528 VA: 0x3378528
	public void .ctor(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x33792DC Offset: 0x33752DC VA: 0x33792DC
	private void .ctor(XsdDateTime.Parser parser) { }

	// RVA: 0x3379220 Offset: 0x3375220 VA: 0x3379220
	private void InitiateXsdDateTime(XsdDateTime.Parser parser) { }

	// RVA: 0x3379370 Offset: 0x3375370 VA: 0x3379370
	internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result) { }

	// RVA: 0x3379430 Offset: 0x3375430 VA: 0x3379430
	public void .ctor(DateTime dateTime, XsdDateTimeFlags kinds) { }

	// RVA: 0x33795F4 Offset: 0x33755F4 VA: 0x33795F4
	public void .ctor(DateTimeOffset dateTimeOffset) { }

	// RVA: 0x3379664 Offset: 0x3375664 VA: 0x3379664
	public void .ctor(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	// RVA: 0x33797F4 Offset: 0x33757F4 VA: 0x33797F4
	private XsdDateTime.DateTimeTypeCode get_InternalTypeCode() { }

	// RVA: 0x33797FC Offset: 0x33757FC VA: 0x33797FC
	private XsdDateTime.XsdDateTimeKind get_InternalKind() { }

	// RVA: 0x3379804 Offset: 0x3375804 VA: 0x3379804
	public int get_Year() { }

	// RVA: 0x337985C Offset: 0x337585C VA: 0x337985C
	public int get_Month() { }

	// RVA: 0x33798B4 Offset: 0x33758B4 VA: 0x33798B4
	public int get_Day() { }

	// RVA: 0x337990C Offset: 0x337590C VA: 0x337990C
	public int get_Hour() { }

	// RVA: 0x3379964 Offset: 0x3375964 VA: 0x3379964
	public int get_Minute() { }

	// RVA: 0x33799BC Offset: 0x33759BC VA: 0x33799BC
	public int get_Second() { }

	// RVA: 0x3379A14 Offset: 0x3375A14 VA: 0x3379A14
	public int get_Fraction() { }

	// RVA: 0x3379B2C Offset: 0x3375B2C VA: 0x3379B2C
	public int get_ZoneHour() { }

	// RVA: 0x3379B34 Offset: 0x3375B34 VA: 0x3379B34
	public int get_ZoneMinute() { }

	// RVA: 0x3379B3C Offset: 0x3375B3C VA: 0x3379B3C
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x337A078 Offset: 0x3376078 VA: 0x337A078
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x337A3D4 Offset: 0x33763D4 VA: 0x337A3D4 Slot: 3
	public override string ToString() { }

	// RVA: 0x337A818 Offset: 0x3376818 VA: 0x337A818
	private void PrintDate(StringBuilder sb) { }

	// RVA: 0x337A95C Offset: 0x337695C VA: 0x337A95C
	private void PrintTime(StringBuilder sb) { }

	// RVA: 0x337AC80 Offset: 0x3376C80 VA: 0x337AC80
	private void PrintZone(StringBuilder sb) { }

	// RVA: 0x337ABB0 Offset: 0x3376BB0 VA: 0x337ABB0
	private void IntToCharArray(char[] text, int start, int value, int digits) { }

	// RVA: 0x337AC18 Offset: 0x3376C18 VA: 0x337AC18
	private void ShortToCharArray(char[] text, int start, int value) { }

	// RVA: 0x337AE20 Offset: 0x3376E20 VA: 0x337AE20
	private static void .cctor() { }
}
