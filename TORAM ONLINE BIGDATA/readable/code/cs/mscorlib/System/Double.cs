// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[Serializable]
public struct Double : IComparable, IConvertible, IFormattable, IComparable<double>, IEquatable<double>, ISpanFormattable // TypeDefIndex: 9573
{
	// Fields
	private readonly double m_value; // 0x0
	public const double MinValue = -1.7976931348623157E+308;
	public const double MaxValue = 1.7976931348623157E+308;
	public const double Epsilon = 5E-324;
	public const double NegativeInfinity = -∞;
	public const double PositiveInfinity = ∞;
	public const double NaN = NaN;
	internal const double NegativeZero = -0;

	// Methods

	[NonVersionable]
	// RVA: 0x2FCD94C Offset: 0x2FC994C VA: 0x2FCD94C
	public static bool IsFinite(double d) { }

	[NonVersionable]
	// RVA: 0x2FCD960 Offset: 0x2FC9960 VA: 0x2FCD960
	public static bool IsInfinity(double d) { }

	[NonVersionable]
	// RVA: 0x2FCD978 Offset: 0x2FC9978 VA: 0x2FCD978
	public static bool IsNaN(double d) { }

	[NonVersionable]
	// RVA: 0x2FCD990 Offset: 0x2FC9990 VA: 0x2FCD990
	public static bool IsNegative(double d) { }

	[NonVersionable]
	// RVA: 0x2FCD99C Offset: 0x2FC999C VA: 0x2FCD99C
	public static bool IsNegativeInfinity(double d) { }

	[NonVersionable]
	// RVA: 0x2FCD9B0 Offset: 0x2FC99B0 VA: 0x2FCD9B0
	public static bool IsPositiveInfinity(double d) { }

	// RVA: 0x2FCD9C4 Offset: 0x2FC99C4 VA: 0x2FCD9C4 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x2FCDAC8 Offset: 0x2FC9AC8 VA: 0x2FCDAC8 Slot: 23
	public int CompareTo(double value) { }

	// RVA: 0x2FCDB24 Offset: 0x2FC9B24 VA: 0x2FCDB24 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2FCDBD0 Offset: 0x2FC9BD0 VA: 0x2FCDBD0 Slot: 24
	public bool Equals(double obj) { }

	// RVA: 0x2FCDC1C Offset: 0x2FC9C1C VA: 0x2FCDC1C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FCDC3C Offset: 0x2FC9C3C VA: 0x2FCDC3C Slot: 3
	public override string ToString() { }

	// RVA: 0x2FCDCB8 Offset: 0x2FC9CB8 VA: 0x2FCDCB8
	public string ToString(string format) { }

	// RVA: 0x2FCDD40 Offset: 0x2FC9D40 VA: 0x2FCDD40 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x2FCDDCC Offset: 0x2FC9DCC VA: 0x2FCDDCC Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x2FCDE5C Offset: 0x2FC9E5C VA: 0x2FCDE5C Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x2FCDF1C Offset: 0x2FC9F1C VA: 0x2FCDF1C
	public static double Parse(string s) { }

	// RVA: 0x2FCDFE0 Offset: 0x2FC9FE0 VA: 0x2FCDFE0
	public static double Parse(string s, IFormatProvider provider) { }

	// RVA: 0x2FCE0B4 Offset: 0x2FCA0B4 VA: 0x2FCE0B4
	public static double Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x2FCE198 Offset: 0x2FCA198 VA: 0x2FCE198
	public static bool TryParse(string s, out double result) { }

	// RVA: 0x2FCE4D0 Offset: 0x2FCA4D0 VA: 0x2FCE4D0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result) { }

	// RVA: 0x2FCE218 Offset: 0x2FCA218 VA: 0x2FCE218
	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out double result) { }

	// RVA: 0x2FCE578 Offset: 0x2FCA578 VA: 0x2FCE578 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x2FCE580 Offset: 0x2FCA580 VA: 0x2FCE580 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x2FCE5E4 Offset: 0x2FCA5E4 VA: 0x2FCE5E4 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x2FCE668 Offset: 0x2FCA668 VA: 0x2FCE668 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x2FCE6CC Offset: 0x2FCA6CC VA: 0x2FCE6CC Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x2FCE730 Offset: 0x2FCA730 VA: 0x2FCE730 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x2FCE794 Offset: 0x2FCA794 VA: 0x2FCE794 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x2FCE7F8 Offset: 0x2FCA7F8 VA: 0x2FCE7F8 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x2FCE85C Offset: 0x2FCA85C VA: 0x2FCE85C Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x2FCE8C0 Offset: 0x2FCA8C0 VA: 0x2FCE8C0 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x2FCE924 Offset: 0x2FCA924 VA: 0x2FCE924 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x2FCE988 Offset: 0x2FCA988 VA: 0x2FCE988 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x2FCE9EC Offset: 0x2FCA9EC VA: 0x2FCE9EC Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x2FCE9F4 Offset: 0x2FCA9F4 VA: 0x2FCE9F4 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x2FCEA58 Offset: 0x2FCAA58 VA: 0x2FCEA58 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x2FCEADC Offset: 0x2FCAADC VA: 0x2FCEADC Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
