// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[Serializable]
public struct Single : IComparable, IConvertible, IFormattable, IComparable<float>, IEquatable<float>, ISpanFormattable // TypeDefIndex: 9662
{
	// Fields
	private readonly float m_value; // 0x0
	public const float MinValue = -3.4028235E+38;
	public const float Epsilon = 1E-45;
	public const float MaxValue = 3.4028235E+38;
	public const float PositiveInfinity = ∞;
	public const float NegativeInfinity = -∞;
	public const float NaN = NaN;
	internal const float NegativeZero = -0;

	// Methods

	[NonVersionable]
	// RVA: 0x2FF7ADC Offset: 0x2FF3ADC VA: 0x2FF7ADC
	public static bool IsFinite(float f) { }

	[NonVersionable]
	// RVA: 0x2FF7AF0 Offset: 0x2FF3AF0 VA: 0x2FF7AF0
	public static bool IsInfinity(float f) { }

	[NonVersionable]
	// RVA: 0x2FF7B08 Offset: 0x2FF3B08 VA: 0x2FF7B08
	public static bool IsNaN(float f) { }

	[NonVersionable]
	// RVA: 0x2FF7B20 Offset: 0x2FF3B20 VA: 0x2FF7B20
	public static bool IsNegativeInfinity(float f) { }

	[NonVersionable]
	// RVA: 0x2FF7B34 Offset: 0x2FF3B34 VA: 0x2FF7B34
	public static bool IsPositiveInfinity(float f) { }

	// RVA: 0x2FF7B48 Offset: 0x2FF3B48 VA: 0x2FF7B48 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x2FF7C4C Offset: 0x2FF3C4C VA: 0x2FF7C4C Slot: 23
	public int CompareTo(float value) { }

	// RVA: 0x2FF7CA8 Offset: 0x2FF3CA8 VA: 0x2FF7CA8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2FF7D54 Offset: 0x2FF3D54 VA: 0x2FF7D54 Slot: 24
	public bool Equals(float obj) { }

	// RVA: 0x2FF7DA0 Offset: 0x2FF3DA0 VA: 0x2FF7DA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FF7DB8 Offset: 0x2FF3DB8 VA: 0x2FF7DB8 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FF7E34 Offset: 0x2FF3E34 VA: 0x2FF7E34 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x2FF7EC0 Offset: 0x2FF3EC0 VA: 0x2FF7EC0
	public string ToString(string format) { }

	// RVA: 0x2FF7F48 Offset: 0x2FF3F48 VA: 0x2FF7F48 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x2FF7FD8 Offset: 0x2FF3FD8 VA: 0x2FF7FD8 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x2FF8098 Offset: 0x2FF4098 VA: 0x2FF8098
	public static float Parse(string s, IFormatProvider provider) { }

	// RVA: 0x2FF815C Offset: 0x2FF415C VA: 0x2FF815C
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x2FF8230 Offset: 0x2FF4230 VA: 0x2FF8230
	public static bool TryParse(string s, out float result) { }

	// RVA: 0x2FF8568 Offset: 0x2FF4568 VA: 0x2FF8568
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result) { }

	// RVA: 0x2FF82B0 Offset: 0x2FF42B0 VA: 0x2FF82B0
	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out float result) { }

	// RVA: 0x2FF8610 Offset: 0x2FF4610 VA: 0x2FF8610 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x2FF8618 Offset: 0x2FF4618 VA: 0x2FF8618 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x2FF867C Offset: 0x2FF467C VA: 0x2FF867C Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x2FF8700 Offset: 0x2FF4700 VA: 0x2FF8700 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x2FF8764 Offset: 0x2FF4764 VA: 0x2FF8764 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x2FF87C8 Offset: 0x2FF47C8 VA: 0x2FF87C8 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x2FF882C Offset: 0x2FF482C VA: 0x2FF882C Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x2FF8890 Offset: 0x2FF4890 VA: 0x2FF8890 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x2FF88F4 Offset: 0x2FF48F4 VA: 0x2FF88F4 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x2FF8958 Offset: 0x2FF4958 VA: 0x2FF8958 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x2FF89BC Offset: 0x2FF49BC VA: 0x2FF89BC Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x2FF8A20 Offset: 0x2FF4A20 VA: 0x2FF8A20 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x2FF8A28 Offset: 0x2FF4A28 VA: 0x2FF8A28 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x2FF8A8C Offset: 0x2FF4A8C VA: 0x2FF8A8C Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x2FF8AF0 Offset: 0x2FF4AF0 VA: 0x2FF8AF0 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x2FF8B74 Offset: 0x2FF4B74 VA: 0x2FF8B74 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
