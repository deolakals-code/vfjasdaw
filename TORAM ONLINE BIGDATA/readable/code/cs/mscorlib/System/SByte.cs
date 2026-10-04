// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[CLSCompliant(False)]
[Serializable]
public struct SByte : IComparable, IConvertible, IFormattable, IComparable<sbyte>, IEquatable<sbyte>, ISpanFormattable // TypeDefIndex: 9660
{
	// Fields
	private readonly sbyte m_value; // 0x0

	// Methods

	// RVA: 0x2FF6C3C Offset: 0x2FF2C3C VA: 0x2FF6C3C Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x2FF6CF8 Offset: 0x2FF2CF8 VA: 0x2FF6CF8 Slot: 23
	public int CompareTo(sbyte value) { }

	// RVA: 0x2FF6D04 Offset: 0x2FF2D04 VA: 0x2FF6D04 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x2FF6D7C Offset: 0x2FF2D7C VA: 0x2FF6D7C Slot: 24
	public bool Equals(sbyte obj) { }

	// RVA: 0x2FF6D8C Offset: 0x2FF2D8C VA: 0x2FF6D8C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FF6D98 Offset: 0x2FF2D98 VA: 0x2FF6D98 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FF6E30 Offset: 0x2FF2E30 VA: 0x2FF6E30 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x2FF6ECC Offset: 0x2FF2ECC VA: 0x2FF6ECC Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x2FF7048 Offset: 0x2FF3048 VA: 0x2FF7048 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x2FF7164 Offset: 0x2FF3164 VA: 0x2FF7164
	public static sbyte Parse(string s, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x2FF7398 Offset: 0x2FF3398 VA: 0x2FF7398
	public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x2FF7200 Offset: 0x2FF3200 VA: 0x2FF7200
	private static sbyte Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info) { }

	[CLSCompliant(False)]
	// RVA: 0x2FF7428 Offset: 0x2FF3428 VA: 0x2FF7428
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out sbyte result) { }

	// RVA: 0x2FF74D0 Offset: 0x2FF34D0 VA: 0x2FF74D0
	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out sbyte result) { }

	// RVA: 0x2FF7598 Offset: 0x2FF3598 VA: 0x2FF7598 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x2FF75A0 Offset: 0x2FF35A0 VA: 0x2FF75A0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x2FF75FC Offset: 0x2FF35FC VA: 0x2FF75FC Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x2FF7658 Offset: 0x2FF3658 VA: 0x2FF7658 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x2FF7660 Offset: 0x2FF3660 VA: 0x2FF7660 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x2FF76BC Offset: 0x2FF36BC VA: 0x2FF76BC Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x2FF7718 Offset: 0x2FF3718 VA: 0x2FF7718 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x2FF7774 Offset: 0x2FF3774 VA: 0x2FF7774 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x2FF777C Offset: 0x2FF377C VA: 0x2FF777C Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x2FF77D8 Offset: 0x2FF37D8 VA: 0x2FF77D8 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x2FF7834 Offset: 0x2FF3834 VA: 0x2FF7834 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x2FF7890 Offset: 0x2FF3890 VA: 0x2FF7890 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x2FF78EC Offset: 0x2FF38EC VA: 0x2FF78EC Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x2FF7948 Offset: 0x2FF3948 VA: 0x2FF7948 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x2FF79A4 Offset: 0x2FF39A4 VA: 0x2FF79A4 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x2FF7A28 Offset: 0x2FF3A28 VA: 0x2FF7A28 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
