// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[Serializable]
public struct Byte : IComparable, IConvertible, IFormattable, IComparable<byte>, IEquatable<byte>, ISpanFormattable // TypeDefIndex: 9559
{
	// Fields
	private readonly byte m_value; // 0x0
	public const byte MaxValue = 255;
	public const byte MinValue = 0;

	// Methods

	// RVA: 0x2F7629C Offset: 0x2F7229C VA: 0x2F7629C Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x2F76354 Offset: 0x2F72354 VA: 0x2F76354 Slot: 23
	public int CompareTo(byte value) { }

	// RVA: 0x2F76360 Offset: 0x2F72360 VA: 0x2F76360 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x2F763D8 Offset: 0x2F723D8 VA: 0x2F763D8 Slot: 24
	public bool Equals(byte obj) { }

	// RVA: 0x2F763E8 Offset: 0x2F723E8 VA: 0x2F763E8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F763F0 Offset: 0x2F723F0 VA: 0x2F763F0
	public static byte Parse(string s) { }

	// RVA: 0x2F76608 Offset: 0x2F72608 VA: 0x2F76608
	public static byte Parse(string s, IFormatProvider provider) { }

	// RVA: 0x2F76694 Offset: 0x2F72694 VA: 0x2F76694
	public static byte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x2F76474 Offset: 0x2F72474 VA: 0x2F76474
	private static byte Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x2F76738 Offset: 0x2F72738 VA: 0x2F76738
	public static bool TryParse(string s, out byte result) { }

	// RVA: 0x2F76874 Offset: 0x2F72874 VA: 0x2F76874
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result) { }

	// RVA: 0x2F767B8 Offset: 0x2F727B8 VA: 0x2F767B8
	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out byte result) { }

	// RVA: 0x2F7691C Offset: 0x2F7291C VA: 0x2F7691C Slot: 3
	public override string ToString() { }

	// RVA: 0x2F769B4 Offset: 0x2F729B4 VA: 0x2F769B4
	public string ToString(string format) { }

	// RVA: 0x2F76A68 Offset: 0x2F72A68 VA: 0x2F76A68 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x2F76B04 Offset: 0x2F72B04 VA: 0x2F76B04 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x2F76BBC Offset: 0x2F72BBC VA: 0x2F76BBC Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x2F76C60 Offset: 0x2F72C60 VA: 0x2F76C60 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x2F76C68 Offset: 0x2F72C68 VA: 0x2F76C68 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x2F76CD0 Offset: 0x2F72CD0 VA: 0x2F76CD0 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x2F76D30 Offset: 0x2F72D30 VA: 0x2F76D30 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x2F76DDC Offset: 0x2F72DDC VA: 0x2F76DDC Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x2F76DE4 Offset: 0x2F72DE4 VA: 0x2F76DE4 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x2F76E44 Offset: 0x2F72E44 VA: 0x2F76E44 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x2F76EA4 Offset: 0x2F72EA4 VA: 0x2F76EA4 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x2F76F04 Offset: 0x2F72F04 VA: 0x2F76F04 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x2F76F64 Offset: 0x2F72F64 VA: 0x2F76F64 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x2F76FC4 Offset: 0x2F72FC4 VA: 0x2F76FC4 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x2F77024 Offset: 0x2F73024 VA: 0x2F77024 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x2F77088 Offset: 0x2F73088 VA: 0x2F77088 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x2F770EC Offset: 0x2F730EC VA: 0x2F770EC Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x2F7719C Offset: 0x2F7319C VA: 0x2F7719C Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x2F77220 Offset: 0x2F73220 VA: 0x2F77220 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
