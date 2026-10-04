// Assembly: mscorlib.dll
// Namespace: System
[CLSCompliant(False)]
[IsReadOnly]
[Serializable]
public struct UInt64 : IComparable, IConvertible, IFormattable, IComparable<ulong>, IEquatable<ulong>, ISpanFormattable // TypeDefIndex: 9692
{
	// Fields
	private readonly ulong m_value; // 0x0
	public const ulong MaxValue = 18446744073709551615;
	public const ulong MinValue = 0;

	// Methods

	// RVA: 0x3002A84 Offset: 0x2FFEA84 VA: 0x3002A84 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x3002B50 Offset: 0x2FFEB50 VA: 0x3002B50 Slot: 23
	public int CompareTo(ulong value) { }

	// RVA: 0x3002B6C Offset: 0x2FFEB6C VA: 0x3002B6C Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x3002BE4 Offset: 0x2FFEBE4 VA: 0x3002BE4 Slot: 24
	public bool Equals(ulong obj) { }

	// RVA: 0x3002BF4 Offset: 0x2FFEBF4 VA: 0x3002BF4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3002C00 Offset: 0x2FFEC00 VA: 0x3002C00 Slot: 3
	public override string ToString() { }

	// RVA: 0x3002C98 Offset: 0x2FFEC98 VA: 0x3002C98 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x3002D34 Offset: 0x2FFED34 VA: 0x3002D34 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x3002DEC Offset: 0x2FFEDEC VA: 0x3002DEC Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x3002E90 Offset: 0x2FFEE90 VA: 0x3002E90
	public static ulong Parse(string s, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x3002F54 Offset: 0x2FFEF54 VA: 0x3002F54
	public static ulong Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x3003028 Offset: 0x2FFF028 VA: 0x3003028
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result) { }

	// RVA: 0x3003120 Offset: 0x2FFF120 VA: 0x3003120 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x3003128 Offset: 0x2FFF128 VA: 0x3003128 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x3003184 Offset: 0x2FFF184 VA: 0x3003184 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x30031E0 Offset: 0x2FFF1E0 VA: 0x30031E0 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x300323C Offset: 0x2FFF23C VA: 0x300323C Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x3003298 Offset: 0x2FFF298 VA: 0x3003298 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x30032F4 Offset: 0x2FFF2F4 VA: 0x30032F4 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x3003350 Offset: 0x2FFF350 VA: 0x3003350 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x30033AC Offset: 0x2FFF3AC VA: 0x30033AC Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3003408 Offset: 0x2FFF408 VA: 0x3003408 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x3003464 Offset: 0x2FFF464 VA: 0x3003464 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x300346C Offset: 0x2FFF46C VA: 0x300346C Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x30034C8 Offset: 0x2FFF4C8 VA: 0x30034C8 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x3003524 Offset: 0x2FFF524 VA: 0x3003524 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x3003580 Offset: 0x2FFF580 VA: 0x3003580 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x3003604 Offset: 0x2FFF604 VA: 0x3003604 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
