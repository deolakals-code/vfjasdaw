// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[Serializable]
public struct Int16 : IComparable, IConvertible, IFormattable, IComparable<short>, IEquatable<short>, ISpanFormattable // TypeDefIndex: 9620
{
	// Fields
	private readonly short m_value; // 0x0
	public const short MaxValue = 32767;
	public const short MinValue = -32768;

	// Methods

	// RVA: 0x2FE1600 Offset: 0x2FDD600 VA: 0x2FE1600 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x2FE16BC Offset: 0x2FDD6BC VA: 0x2FE16BC Slot: 23
	public int CompareTo(short value) { }

	// RVA: 0x2FE16C8 Offset: 0x2FDD6C8 VA: 0x2FE16C8 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x2FE1740 Offset: 0x2FDD740 VA: 0x2FE1740 Slot: 24
	public bool Equals(short obj) { }

	// RVA: 0x2FE1750 Offset: 0x2FDD750 VA: 0x2FE1750 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FE175C Offset: 0x2FDD75C VA: 0x2FE175C Slot: 3
	public override string ToString() { }

	// RVA: 0x2FE1A8C Offset: 0x2FDDA8C VA: 0x2FE1A8C Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x2FE1B24 Offset: 0x2FDDB24 VA: 0x2FE1B24
	public string ToString(string format) { }

	// RVA: 0x2FE1B2C Offset: 0x2FDDB2C VA: 0x2FE1B2C Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x2FE1F04 Offset: 0x2FDDF04 VA: 0x2FE1F04 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x2FE2598 Offset: 0x2FDE598 VA: 0x2FE2598
	public static short Parse(string s) { }

	// RVA: 0x2FE27B8 Offset: 0x2FDE7B8 VA: 0x2FE27B8
	public static short Parse(string s, IFormatProvider provider) { }

	// RVA: 0x2FE2844 Offset: 0x2FDE844 VA: 0x2FE2844
	public static short Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x2FE261C Offset: 0x2FDE61C VA: 0x2FE261C
	private static short Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x2FE2AAC Offset: 0x2FDEAAC VA: 0x2FE2AAC
	public static bool TryParse(string s, out short result) { }

	// RVA: 0x2FE2BF0 Offset: 0x2FDEBF0 VA: 0x2FE2BF0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result) { }

	// RVA: 0x2FE2B2C Offset: 0x2FDEB2C VA: 0x2FE2B2C
	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out short result) { }

	// RVA: 0x2FE2E1C Offset: 0x2FDEE1C VA: 0x2FE2E1C Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x2FE2E24 Offset: 0x2FDEE24 VA: 0x2FE2E24 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x2FE2E80 Offset: 0x2FDEE80 VA: 0x2FE2E80 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x2FE2EDC Offset: 0x2FDEEDC VA: 0x2FE2EDC Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x2FE2F38 Offset: 0x2FDEF38 VA: 0x2FE2F38 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x2FE2F94 Offset: 0x2FDEF94 VA: 0x2FE2F94 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x2FE2F9C Offset: 0x2FDEF9C VA: 0x2FE2F9C Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x2FE2FF8 Offset: 0x2FDEFF8 VA: 0x2FE2FF8 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x2FE3054 Offset: 0x2FDF054 VA: 0x2FE3054 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x2FE30B0 Offset: 0x2FDF0B0 VA: 0x2FE30B0 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x2FE310C Offset: 0x2FDF10C VA: 0x2FE310C Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x2FE3168 Offset: 0x2FDF168 VA: 0x2FE3168 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x2FE31C4 Offset: 0x2FDF1C4 VA: 0x2FE31C4 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x2FE3220 Offset: 0x2FDF220 VA: 0x2FE3220 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x2FE327C Offset: 0x2FDF27C VA: 0x2FE327C Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x2FE3320 Offset: 0x2FDF320 VA: 0x2FE3320 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
