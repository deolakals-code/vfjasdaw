// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[Serializable]
public struct Int64 : IComparable, IConvertible, IFormattable, IComparable<long>, IEquatable<long>, ISpanFormattable // TypeDefIndex: 9622
{
	// Fields
	private readonly long m_value; // 0x0
	public const long MaxValue = 9223372036854775807;
	public const long MinValue = -9223372036854775808;

	// Methods

	// RVA: 0x2FE44D0 Offset: 0x2FE04D0 VA: 0x2FE44D0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x2FE459C Offset: 0x2FE059C VA: 0x2FE459C Slot: 23
	public int CompareTo(long value) { }

	// RVA: 0x2FE45B8 Offset: 0x2FE05B8 VA: 0x2FE45B8 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x2FE4630 Offset: 0x2FE0630 VA: 0x2FE4630 Slot: 24
	public bool Equals(long obj) { }

	// RVA: 0x2FE4640 Offset: 0x2FE0640 VA: 0x2FE4640 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FE464C Offset: 0x2FE064C VA: 0x2FE464C Slot: 3
	public override string ToString() { }

	// RVA: 0x2FE4978 Offset: 0x2FE0978 VA: 0x2FE4978 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x2FE4A10 Offset: 0x2FE0A10 VA: 0x2FE4A10
	public string ToString(string format) { }

	// RVA: 0x2FE4AC0 Offset: 0x2FE0AC0 VA: 0x2FE4AC0 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x2FE4B74 Offset: 0x2FE0B74 VA: 0x2FE4B74 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x2FE4EF0 Offset: 0x2FE0EF0 VA: 0x2FE4EF0
	public static long Parse(string s, IFormatProvider provider) { }

	// RVA: 0x2FE5188 Offset: 0x2FE1188 VA: 0x2FE5188
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x2FE5268 Offset: 0x2FE1268 VA: 0x2FE5268
	public static bool TryParse(string s, out long result) { }

	// RVA: 0x2FE54BC Offset: 0x2FE14BC VA: 0x2FE54BC
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	// RVA: 0x2FE55B0 Offset: 0x2FE15B0 VA: 0x2FE55B0 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x2FE55B8 Offset: 0x2FE15B8 VA: 0x2FE55B8 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x2FE5614 Offset: 0x2FE1614 VA: 0x2FE5614 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x2FE5670 Offset: 0x2FE1670 VA: 0x2FE5670 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x2FE56CC Offset: 0x2FE16CC VA: 0x2FE56CC Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x2FE5728 Offset: 0x2FE1728 VA: 0x2FE5728 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x2FE5784 Offset: 0x2FE1784 VA: 0x2FE5784 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x2FE57E0 Offset: 0x2FE17E0 VA: 0x2FE57E0 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x2FE583C Offset: 0x2FE183C VA: 0x2FE583C Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x2FE5898 Offset: 0x2FE1898 VA: 0x2FE5898 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x2FE58A0 Offset: 0x2FE18A0 VA: 0x2FE58A0 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x2FE58FC Offset: 0x2FE18FC VA: 0x2FE58FC Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x2FE5958 Offset: 0x2FE1958 VA: 0x2FE5958 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x2FE59B4 Offset: 0x2FE19B4 VA: 0x2FE59B4 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x2FE5A10 Offset: 0x2FE1A10 VA: 0x2FE5A10 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x2FE5A90 Offset: 0x2FE1A90 VA: 0x2FE5A90 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
