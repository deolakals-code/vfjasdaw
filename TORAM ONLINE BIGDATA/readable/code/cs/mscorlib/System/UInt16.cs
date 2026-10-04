// Assembly: mscorlib.dll
// Namespace: System
[CLSCompliant(False)]
[IsReadOnly]
[Serializable]
public struct UInt16 : IComparable, IConvertible, IFormattable, IComparable<ushort>, IEquatable<ushort>, ISpanFormattable // TypeDefIndex: 9690
{
	// Fields
	private readonly ushort m_value; // 0x0
	public const ushort MaxValue = 65535;
	public const ushort MinValue = 0;

	// Methods

	// RVA: 0x3000FB8 Offset: 0x2FFCFB8 VA: 0x3000FB8 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x3001074 Offset: 0x2FFD074 VA: 0x3001074 Slot: 23
	public int CompareTo(ushort value) { }

	// RVA: 0x3001080 Offset: 0x2FFD080 VA: 0x3001080 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x30010F8 Offset: 0x2FFD0F8 VA: 0x30010F8 Slot: 24
	public bool Equals(ushort obj) { }

	// RVA: 0x3001108 Offset: 0x2FFD108 VA: 0x3001108 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3001110 Offset: 0x2FFD110 VA: 0x3001110 Slot: 3
	public override string ToString() { }

	// RVA: 0x30011A8 Offset: 0x2FFD1A8 VA: 0x30011A8 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x3001244 Offset: 0x2FFD244 VA: 0x3001244 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x30012FC Offset: 0x2FFD2FC VA: 0x30012FC Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x30013A0 Offset: 0x2FFD3A0 VA: 0x30013A0
	public static ushort Parse(string s, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x30015A4 Offset: 0x2FFD5A4 VA: 0x30015A4
	public static ushort Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x3001418 Offset: 0x2FFD418 VA: 0x3001418
	private static ushort Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info) { }

	[CLSCompliant(False)]
	// RVA: 0x3001634 Offset: 0x2FFD634 VA: 0x3001634
	public static bool TryParse(string s, out ushort result) { }

	[CLSCompliant(False)]
	// RVA: 0x3001770 Offset: 0x2FFD770 VA: 0x3001770
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result) { }

	// RVA: 0x30016B4 Offset: 0x2FFD6B4 VA: 0x30016B4
	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out ushort result) { }

	// RVA: 0x3001818 Offset: 0x2FFD818 VA: 0x3001818 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x3001820 Offset: 0x2FFD820 VA: 0x3001820 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x300187C Offset: 0x2FFD87C VA: 0x300187C Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x30018D8 Offset: 0x2FFD8D8 VA: 0x30018D8 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x3001934 Offset: 0x2FFD934 VA: 0x3001934 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x3001990 Offset: 0x2FFD990 VA: 0x3001990 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x30019EC Offset: 0x2FFD9EC VA: 0x30019EC Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x30019F4 Offset: 0x2FFD9F4 VA: 0x30019F4 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x3001A50 Offset: 0x2FFDA50 VA: 0x3001A50 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3001AAC Offset: 0x2FFDAAC VA: 0x3001AAC Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x3001B08 Offset: 0x2FFDB08 VA: 0x3001B08 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x3001B64 Offset: 0x2FFDB64 VA: 0x3001B64 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x3001BC0 Offset: 0x2FFDBC0 VA: 0x3001BC0 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x3001C1C Offset: 0x2FFDC1C VA: 0x3001C1C Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x3001C78 Offset: 0x2FFDC78 VA: 0x3001C78 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x3001CFC Offset: 0x2FFDCFC VA: 0x3001CFC Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
