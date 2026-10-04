// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Linq
[NullableContext(2)]
[Nullable(0)]
public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible // TypeDefIndex: 16058
{
	// Fields
	private JTokenType _valueType; // 0x30
	private object _value; // 0x38

	// Properties
	public override bool HasValues { get; }
	public override JTokenType Type { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x30CA200 Offset: 0x30C6200 VA: 0x30CA200
	internal void .ctor(object value, JTokenType type) { }

	[NullableContext(1)]
	// RVA: 0x30CA138 Offset: 0x30C6138 VA: 0x30CA138
	internal void .ctor(JValue other, JsonCloneSettings settings) { }

	// RVA: 0x30D31A8 Offset: 0x30CF1A8 VA: 0x30D31A8
	public void .ctor(long value) { }

	// RVA: 0x30D3938 Offset: 0x30CF938 VA: 0x30D3938
	public void .ctor(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x30D3294 Offset: 0x30CF294 VA: 0x30D3294
	public void .ctor(ulong value) { }

	// RVA: 0x30D345C Offset: 0x30CF45C VA: 0x30D345C
	public void .ctor(double value) { }

	// RVA: 0x30D3378 Offset: 0x30CF378 VA: 0x30D3378
	public void .ctor(float value) { }

	// RVA: 0x30D3A6C Offset: 0x30CFA6C VA: 0x30D3A6C
	public void .ctor(DateTime value) { }

	// RVA: 0x30D3B5C Offset: 0x30CFB5C VA: 0x30D3B5C
	public void .ctor(DateTimeOffset value) { }

	// RVA: 0x30D354C Offset: 0x30CF54C VA: 0x30D354C
	public void .ctor(bool value) { }

	// RVA: 0x30D3028 Offset: 0x30CF028 VA: 0x30D3028
	public void .ctor(string value) { }

	// RVA: 0x30D3DB8 Offset: 0x30CFDB8 VA: 0x30D3DB8
	public void .ctor(Guid value) { }

	// RVA: 0x30D3EA8 Offset: 0x30CFEA8 VA: 0x30D3EA8
	public void .ctor(Uri value) { }

	// RVA: 0x30D3CC8 Offset: 0x30CFCC8 VA: 0x30D3CC8
	public void .ctor(TimeSpan value) { }

	// RVA: 0x30C5898 Offset: 0x30C1898 VA: 0x30C5898
	public void .ctor(object value) { }

	// RVA: 0x30D465C Offset: 0x30D065C VA: 0x30D465C Slot: 13
	public override bool get_HasValues() { }

	[NullableContext(1)]
	// RVA: 0x30D4664 Offset: 0x30D0664 VA: 0x30D4664
	private static int CompareBigInteger(BigInteger i1, object i2) { }

	// RVA: 0x30D4968 Offset: 0x30D0968 VA: 0x30D4968
	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	[NullableContext(1)]
	// RVA: 0x30D53E0 Offset: 0x30D13E0 VA: 0x30D53E0
	private static int CompareFloat(object objA, object objB) { }

	// RVA: 0x30D54D8 Offset: 0x30D14D8 VA: 0x30D54D8
	private static bool Operation(ExpressionType operation, object objA, object objB, out object result) { }

	[NullableContext(1)]
	// RVA: 0x30D5E1C Offset: 0x30D1E1C VA: 0x30D5E1C Slot: 11
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	[NullableContext(1)]
	// RVA: 0x30C5D5C Offset: 0x30C1D5C VA: 0x30C5D5C
	public static JValue CreateComment(string value) { }

	[NullableContext(1)]
	// RVA: 0x30C3AA4 Offset: 0x30BFAA4 VA: 0x30C3AA4
	public static JValue CreateNull() { }

	[NullableContext(1)]
	// RVA: 0x30C5DB8 Offset: 0x30C1DB8 VA: 0x30C5DB8
	public static JValue CreateUndefined() { }

	// RVA: 0x30D4230 Offset: 0x30D0230 VA: 0x30D4230
	private static JTokenType GetValueType(Nullable<JTokenType> current, object value) { }

	// RVA: 0x30D5E84 Offset: 0x30D1E84 VA: 0x30D5E84
	private static JTokenType GetStringValueType(Nullable<JTokenType> current) { }

	// RVA: 0x30D5F00 Offset: 0x30D1F00 VA: 0x30D5F00 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0x30D5F08 Offset: 0x30D1F08 VA: 0x30D5F08
	public object get_Value() { }

	[NullableContext(1)]
	// RVA: 0x30D5F10 Offset: 0x30D1F10 VA: 0x30D5F10 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	[NullableContext(1)]
	// RVA: 0x30D66E0 Offset: 0x30D26E0 VA: 0x30D66E0
	private static bool ValuesEquals(JValue v1, JValue v2) { }

	// RVA: 0x30D673C Offset: 0x30D273C VA: 0x30D673C Slot: 19
	public bool Equals(JValue other) { }

	// RVA: 0x30D674C Offset: 0x30D274C VA: 0x30D674C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x30D67D8 Offset: 0x30D27D8 VA: 0x30D67D8 Slot: 2
	public override int GetHashCode() { }

	[NullableContext(1)]
	// RVA: 0x30D67F0 Offset: 0x30D27F0 VA: 0x30D67F0 Slot: 3
	public override string ToString() { }

	[NullableContext(1)]
	// RVA: 0x30D6858 Offset: 0x30D2858 VA: 0x30D6858 Slot: 38
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0x30D6864 Offset: 0x30D2864 VA: 0x30D6864 Slot: 20
	public string ToString(string format, IFormatProvider formatProvider) { }

	[NullableContext(1)]
	// RVA: 0x30D697C Offset: 0x30D297C VA: 0x30D697C Slot: 18
	protected override DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0x30D6A74 Offset: 0x30D2A74 VA: 0x30D6A74 Slot: 21
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0x30D6B30 Offset: 0x30D2B30 VA: 0x30D6B30 Slot: 22
	public int CompareTo(JValue obj) { }

	// RVA: 0x30D6B74 Offset: 0x30D2B74 VA: 0x30D6B74 Slot: 23
	private TypeCode System.IConvertible.GetTypeCode() { }

	// RVA: 0x30D6C30 Offset: 0x30D2C30 VA: 0x30D6C30 Slot: 24
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x30D6C84 Offset: 0x30D2C84 VA: 0x30D6C84 Slot: 25
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x30D6CD8 Offset: 0x30D2CD8 VA: 0x30D6CD8 Slot: 26
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x30D6D2C Offset: 0x30D2D2C VA: 0x30D6D2C Slot: 27
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x30D6D80 Offset: 0x30D2D80 VA: 0x30D6D80 Slot: 28
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x30D6DD4 Offset: 0x30D2DD4 VA: 0x30D6DD4 Slot: 29
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x30D6E28 Offset: 0x30D2E28 VA: 0x30D6E28 Slot: 30
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x30D6E7C Offset: 0x30D2E7C VA: 0x30D6E7C Slot: 31
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x30D6ED0 Offset: 0x30D2ED0 VA: 0x30D6ED0 Slot: 32
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x30D6F24 Offset: 0x30D2F24 VA: 0x30D6F24 Slot: 33
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x30D6F78 Offset: 0x30D2F78 VA: 0x30D6F78 Slot: 34
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x30D6FCC Offset: 0x30D2FCC VA: 0x30D6FCC Slot: 35
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x30D7020 Offset: 0x30D3020 VA: 0x30D7020 Slot: 36
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x30D7074 Offset: 0x30D3074 VA: 0x30D7074 Slot: 37
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[NullableContext(1)]
	// RVA: 0x30D70C8 Offset: 0x30D30C8 VA: 0x30D70C8 Slot: 39
	private object System.IConvertible.ToType(Type conversionType, IFormatProvider provider) { }
}
