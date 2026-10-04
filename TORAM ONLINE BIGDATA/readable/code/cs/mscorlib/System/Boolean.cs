// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[Serializable]
public struct Boolean : IComparable, IConvertible, IComparable<bool>, IEquatable<bool> // TypeDefIndex: 9558
{
	// Fields
	private readonly bool m_value; // 0x0
	internal const int True = 1;
	internal const int False = 0;
	internal const string TrueLiteral = "True";
	internal const string FalseLiteral = "False";
	public static readonly string TrueString; // 0x0
	public static readonly string FalseString; // 0x8

	// Methods

	// RVA: 0x2F74374 Offset: 0x2F70374 VA: 0x2F74374 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F74384 Offset: 0x2F70384 VA: 0x2F74384 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F743F0 Offset: 0x2F703F0 VA: 0x2F743F0 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x2F74444 Offset: 0x2F70444 VA: 0x2F74444 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x2F744BC Offset: 0x2F704BC VA: 0x2F744BC Slot: 23
	public bool Equals(bool obj) { }

	// RVA: 0x2F744D0 Offset: 0x2F704D0 VA: 0x2F744D0 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x2F745A4 Offset: 0x2F705A4 VA: 0x2F745A4 Slot: 22
	public int CompareTo(bool value) { }

	// RVA: 0x2F745CC Offset: 0x2F705CC VA: 0x2F745CC
	public static bool Parse(string value) { }

	// RVA: 0x2F746A4 Offset: 0x2F706A4 VA: 0x2F746A4
	public static bool Parse(ReadOnlySpan<char> value) { }

	// RVA: 0x2F74A6C Offset: 0x2F70A6C VA: 0x2F74A6C
	public static bool TryParse(string value, out bool result) { }

	// RVA: 0x2F74764 Offset: 0x2F70764 VA: 0x2F74764
	public static bool TryParse(ReadOnlySpan<char> value, out bool result) { }

	// RVA: 0x2F74B28 Offset: 0x2F70B28 VA: 0x2F74B28
	private static ReadOnlySpan<char> TrimWhiteSpaceAndNull(ReadOnlySpan<char> value) { }

	// RVA: 0x2F74D44 Offset: 0x2F70D44 VA: 0x2F74D44 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x2F74D4C Offset: 0x2F70D4C VA: 0x2F74D4C Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x2F74D5C Offset: 0x2F70D5C VA: 0x2F74D5C Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x2F74DE0 Offset: 0x2F70DE0 VA: 0x2F74DE0 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x2F74E44 Offset: 0x2F70E44 VA: 0x2F74E44 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x2F74EA8 Offset: 0x2F70EA8 VA: 0x2F74EA8 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x2F74F0C Offset: 0x2F70F0C VA: 0x2F74F0C Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x2F74F70 Offset: 0x2F70F70 VA: 0x2F74F70 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x2F74FD4 Offset: 0x2F70FD4 VA: 0x2F74FD4 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x2F75038 Offset: 0x2F71038 VA: 0x2F75038 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x2F7509C Offset: 0x2F7109C VA: 0x2F7509C Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x2F75100 Offset: 0x2F71100 VA: 0x2F75100 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x2F75178 Offset: 0x2F71178 VA: 0x2F75178 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x2F751F0 Offset: 0x2F711F0 VA: 0x2F751F0 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x2F752A4 Offset: 0x2F712A4 VA: 0x2F752A4 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x2F75328 Offset: 0x2F71328 VA: 0x2F75328 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x2F76200 Offset: 0x2F72200 VA: 0x2F76200
	private static void .cctor() { }
}
