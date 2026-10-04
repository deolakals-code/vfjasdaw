// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[CLSCompliant(False)]
[Serializable]
public struct UInt32 : IComparable, IConvertible, IFormattable, IComparable<uint>, IEquatable<uint>, ISpanFormattable // TypeDefIndex: 9691
{
	// Fields
	private readonly uint m_value; // 0x0
	public const uint MaxValue = 4294967295;
	public const uint MinValue = 0;

	// Methods

	// RVA: 0x3001DA8 Offset: 0x2FFDDA8 VA: 0x3001DA8 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x3001E74 Offset: 0x2FFDE74 VA: 0x3001E74 Slot: 23
	public int CompareTo(uint value) { }

	// RVA: 0x3001E90 Offset: 0x2FFDE90 VA: 0x3001E90 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x3001F08 Offset: 0x2FFDF08 VA: 0x3001F08 Slot: 24
	public bool Equals(uint obj) { }

	// RVA: 0x3001F18 Offset: 0x2FFDF18 VA: 0x3001F18 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3001F20 Offset: 0x2FFDF20 VA: 0x3001F20 Slot: 3
	public override string ToString() { }

	// RVA: 0x3001FB8 Offset: 0x2FFDFB8 VA: 0x3001FB8 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x3002054 Offset: 0x2FFE054 VA: 0x3002054 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x300210C Offset: 0x2FFE10C VA: 0x300210C Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x30021B0 Offset: 0x2FFE1B0 VA: 0x30021B0
	public static uint Parse(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x3002264 Offset: 0x2FFE264 VA: 0x3002264
	public static uint Parse(string s, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x3002328 Offset: 0x2FFE328 VA: 0x3002328
	public static uint Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x30023FC Offset: 0x2FFE3FC VA: 0x30023FC
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result) { }

	// RVA: 0x30024F4 Offset: 0x2FFE4F4 VA: 0x30024F4 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x30024FC Offset: 0x2FFE4FC VA: 0x30024FC Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x3002558 Offset: 0x2FFE558 VA: 0x3002558 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x30025B4 Offset: 0x2FFE5B4 VA: 0x30025B4 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x3002610 Offset: 0x2FFE610 VA: 0x3002610 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x300266C Offset: 0x2FFE66C VA: 0x300266C Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x30026C8 Offset: 0x2FFE6C8 VA: 0x30026C8 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x3002724 Offset: 0x2FFE724 VA: 0x3002724 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x3002780 Offset: 0x2FFE780 VA: 0x3002780 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3002788 Offset: 0x2FFE788 VA: 0x3002788 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x30027E4 Offset: 0x2FFE7E4 VA: 0x30027E4 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x3002840 Offset: 0x2FFE840 VA: 0x3002840 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x300289C Offset: 0x2FFE89C VA: 0x300289C Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x30028F8 Offset: 0x2FFE8F8 VA: 0x30028F8 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x3002954 Offset: 0x2FFE954 VA: 0x3002954 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x30029D8 Offset: 0x2FFE9D8 VA: 0x30029D8 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
