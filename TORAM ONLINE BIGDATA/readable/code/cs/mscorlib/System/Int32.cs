// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[Serializable]
public struct Int32 : IComparable, IConvertible, IFormattable, IComparable<int>, IEquatable<int>, ISpanFormattable // TypeDefIndex: 9621
{
	// Fields
	private readonly int m_value; // 0x0
	public const int MaxValue = 2147483647;
	public const int MinValue = -2147483648;

	// Methods

	// RVA: 0x2FE33CC Offset: 0x2FDF3CC VA: 0x2FE33CC Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x2FE3498 Offset: 0x2FDF498 VA: 0x2FE3498 Slot: 23
	public int CompareTo(int value) { }

	// RVA: 0x2FE34B4 Offset: 0x2FDF4B4 VA: 0x2FE34B4 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x2FE352C Offset: 0x2FDF52C VA: 0x2FE352C Slot: 24
	public bool Equals(int obj) { }

	// RVA: 0x2FE353C Offset: 0x2FDF53C VA: 0x2FE353C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FE3544 Offset: 0x2FDF544 VA: 0x2FE3544 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FE35D8 Offset: 0x2FDF5D8 VA: 0x2FE35D8
	public string ToString(string format) { }

	// RVA: 0x2FE3688 Offset: 0x2FDF688 VA: 0x2FE3688 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x2FE3720 Offset: 0x2FDF720 VA: 0x2FE3720 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x2FE37D4 Offset: 0x2FDF7D4 VA: 0x2FE37D4 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x2FE3874 Offset: 0x2FDF874 VA: 0x2FE3874
	public static int Parse(string s) { }

	// RVA: 0x2FE3934 Offset: 0x2FDF934 VA: 0x2FE3934
	public static int Parse(string s, NumberStyles style) { }

	// RVA: 0x2FE3A0C Offset: 0x2FDFA0C VA: 0x2FE3A0C
	public static int Parse(string s, IFormatProvider provider) { }

	// RVA: 0x2FE3ADC Offset: 0x2FDFADC VA: 0x2FE3ADC
	public static int Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x2FE3BBC Offset: 0x2FDFBBC VA: 0x2FE3BBC
	public static int Parse(ReadOnlySpan<char> s, NumberStyles style = 7, IFormatProvider provider) { }

	// RVA: 0x2FE3C58 Offset: 0x2FDFC58 VA: 0x2FE3C58
	public static bool TryParse(string s, out int result) { }

	// RVA: 0x2FE3D28 Offset: 0x2FDFD28 VA: 0x2FE3D28
	public static bool TryParse(ReadOnlySpan<char> s, out int result) { }

	// RVA: 0x2FE3DAC Offset: 0x2FDFDAC VA: 0x2FE3DAC
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result) { }

	// RVA: 0x2FE3EA0 Offset: 0x2FDFEA0 VA: 0x2FE3EA0
	public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out int result) { }

	// RVA: 0x2FE3F44 Offset: 0x2FDFF44 VA: 0x2FE3F44 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x2FE3F4C Offset: 0x2FDFF4C VA: 0x2FE3F4C Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x2FE3FA8 Offset: 0x2FDFFA8 VA: 0x2FE3FA8 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x2FE4004 Offset: 0x2FE0004 VA: 0x2FE4004 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x2FE4060 Offset: 0x2FE0060 VA: 0x2FE4060 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x2FE40BC Offset: 0x2FE00BC VA: 0x2FE40BC Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x2FE4118 Offset: 0x2FE0118 VA: 0x2FE4118 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x2FE4174 Offset: 0x2FE0174 VA: 0x2FE4174 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x2FE417C Offset: 0x2FE017C VA: 0x2FE417C Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x2FE41D8 Offset: 0x2FE01D8 VA: 0x2FE41D8 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x2FE4234 Offset: 0x2FE0234 VA: 0x2FE4234 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x2FE4290 Offset: 0x2FE0290 VA: 0x2FE4290 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x2FE42EC Offset: 0x2FE02EC VA: 0x2FE42EC Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x2FE4348 Offset: 0x2FE0348 VA: 0x2FE4348 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x2FE43A4 Offset: 0x2FE03A4 VA: 0x2FE43A4 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x2FE4424 Offset: 0x2FE0424 VA: 0x2FE4424 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
