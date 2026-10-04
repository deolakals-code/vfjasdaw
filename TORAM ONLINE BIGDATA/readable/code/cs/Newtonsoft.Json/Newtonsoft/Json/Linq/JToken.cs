// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Linq
[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
public abstract class JToken : IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider // TypeDefIndex: 16053
{
	// Fields
	[Nullable(2)]
	private JContainer _parent; // 0x10
	[Nullable(2)]
	private JToken _previous; // 0x18
	[Nullable(2)]
	private JToken _next; // 0x20
	[Nullable(2)]
	private object _annotations; // 0x28
	private static readonly JTokenType[] BooleanTypes; // 0x0
	private static readonly JTokenType[] NumberTypes; // 0x8
	private static readonly JTokenType[] BigIntegerTypes; // 0x10
	private static readonly JTokenType[] StringTypes; // 0x18
	private static readonly JTokenType[] GuidTypes; // 0x20
	private static readonly JTokenType[] TimeSpanTypes; // 0x28
	private static readonly JTokenType[] UriTypes; // 0x30
	private static readonly JTokenType[] CharTypes; // 0x38
	private static readonly JTokenType[] DateTimeTypes; // 0x40
	private static readonly JTokenType[] BytesTypes; // 0x48

	// Properties
	[Nullable(2)]
	public JContainer Parent { get; set; }
	public JToken Root { get; }
	public abstract JTokenType Type { get; }
	public abstract bool HasValues { get; }
	[Nullable(2)]
	public JToken Next { get; set; }
	[Nullable(2)]
	public JToken Previous { get; set; }
	public string Path { get; }
	[Nullable(2)]
	public virtual JToken First { get; }
	[Nullable(2)]
	public virtual JToken Last { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }

	// Methods

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x30CA71C Offset: 0x30C671C VA: 0x30CA71C
	public JContainer get_Parent() { }

	[NullableContext(2)]
	// RVA: 0x30CA724 Offset: 0x30C6724 VA: 0x30CA724
	internal void set_Parent(JContainer value) { }

	// RVA: 0x30C3AFC Offset: 0x30BFAFC VA: 0x30C3AFC
	public JToken get_Root() { }

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract JToken CloneToken(JsonCloneSettings settings);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract JTokenType get_Type();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool get_HasValues();

	[NullableContext(2)]
	// RVA: 0x30CA72C Offset: 0x30C672C VA: 0x30CA72C
	public JToken get_Next() { }

	[NullableContext(2)]
	// RVA: 0x30CA734 Offset: 0x30C6734 VA: 0x30CA734
	internal void set_Next(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x30CA73C Offset: 0x30C673C VA: 0x30CA73C
	public JToken get_Previous() { }

	[NullableContext(2)]
	// RVA: 0x30CA744 Offset: 0x30C6744 VA: 0x30CA744
	internal void set_Previous(JToken value) { }

	// RVA: 0x30CA74C Offset: 0x30C674C VA: 0x30CA74C
	public string get_Path() { }

	// RVA: 0x30C2F28 Offset: 0x30BEF28 VA: 0x30C2F28
	internal void .ctor() { }

	[NullableContext(2)]
	// RVA: 0x30CAAD8 Offset: 0x30C6AD8 VA: 0x30CAAD8 Slot: 14
	public virtual JToken get_First() { }

	[NullableContext(2)]
	// RVA: 0x30CAB68 Offset: 0x30C6B68 VA: 0x30CAB68 Slot: 15
	public virtual JToken get_Last() { }

	// RVA: 0x30CABF8 Offset: 0x30C6BF8 VA: 0x30CABF8 Slot: 16
	public virtual JEnumerable<JToken> Children() { }

	// RVA: 0x30C755C Offset: 0x30C355C VA: 0x30C755C
	public void Remove() { }

	// RVA: 0x30C6214 Offset: 0x30C2214 VA: 0x30C6214
	public void Replace(JToken value) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters);

	// RVA: 0x30CAC50 Offset: 0x30C6C50 VA: 0x30CAC50 Slot: 3
	public override string ToString() { }

	// RVA: 0x30CACE8 Offset: 0x30C6CE8 VA: 0x30CACE8
	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	// RVA: 0x30CAF40 Offset: 0x30C6F40 VA: 0x30CAF40
	private static JValue EnsureValue(JToken value) { }

	// RVA: 0x30CB054 Offset: 0x30C7054 VA: 0x30CB054
	private static string GetType(JToken token) { }

	// RVA: 0x30CB144 Offset: 0x30C7144 VA: 0x30CB144
	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	// RVA: 0x30CB204 Offset: 0x30C7204 VA: 0x30CB204
	public static bool op_Explicit(JToken value) { }

	// RVA: 0x30CB40C Offset: 0x30C740C VA: 0x30CB40C
	public static DateTimeOffset op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x30CB658 Offset: 0x30C7658 VA: 0x30CB658
	public static Nullable<bool> op_Explicit(JToken value) { }

	// RVA: 0x30CB8A8 Offset: 0x30C78A8 VA: 0x30CB8A8
	public static long op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x30CBA8C Offset: 0x30C7A8C VA: 0x30CBA8C
	public static Nullable<DateTime> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x30CBCB0 Offset: 0x30C7CB0 VA: 0x30CBCB0
	public static Nullable<DateTimeOffset> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x30CBF84 Offset: 0x30C7F84 VA: 0x30CBF84
	public static Nullable<Decimal> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x30CC1C4 Offset: 0x30C81C4 VA: 0x30CC1C4
	public static Nullable<double> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x30CC3E4 Offset: 0x30C83E4 VA: 0x30CC3E4
	public static Nullable<char> op_Explicit(JToken value) { }

	// RVA: 0x30CC608 Offset: 0x30C8608 VA: 0x30CC608
	public static int op_Explicit(JToken value) { }

	// RVA: 0x30CC7EC Offset: 0x30C87EC VA: 0x30CC7EC
	public static short op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x30CC9D0 Offset: 0x30C89D0 VA: 0x30CC9D0
	public static ushort op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x30CCBB4 Offset: 0x30C8BB4 VA: 0x30CCBB4
	public static char op_Explicit(JToken value) { }

	// RVA: 0x30CCD98 Offset: 0x30C8D98 VA: 0x30CCD98
	public static byte op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x30CCF7C Offset: 0x30C8F7C VA: 0x30CCF7C
	public static sbyte op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x30CD160 Offset: 0x30C9160 VA: 0x30CD160
	public static Nullable<int> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x30CD384 Offset: 0x30C9384 VA: 0x30CD384
	public static Nullable<short> op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	[NullableContext(2)]
	// RVA: 0x30CD5A8 Offset: 0x30C95A8 VA: 0x30CD5A8
	public static Nullable<ushort> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x30CD7CC Offset: 0x30C97CC VA: 0x30CD7CC
	public static Nullable<byte> op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	[NullableContext(2)]
	// RVA: 0x30CD9F0 Offset: 0x30C99F0 VA: 0x30CD9F0
	public static Nullable<sbyte> op_Explicit(JToken value) { }

	// RVA: 0x30CDC14 Offset: 0x30C9C14 VA: 0x30CDC14
	public static DateTime op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x30CDE00 Offset: 0x30C9E00 VA: 0x30CDE00
	public static Nullable<long> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x30CE024 Offset: 0x30CA024 VA: 0x30CE024
	public static Nullable<float> op_Explicit(JToken value) { }

	// RVA: 0x30CE244 Offset: 0x30CA244 VA: 0x30CE244
	public static Decimal op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	[NullableContext(2)]
	// RVA: 0x30CE428 Offset: 0x30CA428 VA: 0x30CE428
	public static Nullable<uint> op_Explicit(JToken value) { }

	[NullableContext(2)]
	[CLSCompliant(False)]
	// RVA: 0x30CE64C Offset: 0x30CA64C VA: 0x30CE64C
	public static Nullable<ulong> op_Explicit(JToken value) { }

	// RVA: 0x30CE870 Offset: 0x30CA870 VA: 0x30CE870
	public static double op_Explicit(JToken value) { }

	// RVA: 0x30CEA54 Offset: 0x30CAA54 VA: 0x30CEA54
	public static float op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x30CEC38 Offset: 0x30CAC38 VA: 0x30CEC38
	public static string op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x30CEEB0 Offset: 0x30CAEB0 VA: 0x30CEEB0
	public static uint op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x30CF094 Offset: 0x30CB094 VA: 0x30CF094
	public static ulong op_Explicit(JToken value) { }

	// RVA: 0x30CF278 Offset: 0x30CB278 VA: 0x30CF278
	public static Guid op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x30CF498 Offset: 0x30CB498 VA: 0x30CF498
	public static Nullable<Guid> op_Explicit(JToken value) { }

	// RVA: 0x30CF6FC Offset: 0x30CB6FC VA: 0x30CF6FC
	public static TimeSpan op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x30CF8F8 Offset: 0x30CB8F8 VA: 0x30CF8F8
	public static Nullable<TimeSpan> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x30CFB30 Offset: 0x30CBB30 VA: 0x30CFB30
	public static Uri op_Explicit(JToken value) { }

	// RVA: 0x30CFD2C Offset: 0x30CBD2C VA: 0x30CFD2C
	private static BigInteger ToBigInteger(JToken value) { }

	// RVA: 0x30CFE78 Offset: 0x30CBE78 VA: 0x30CFE78
	private static Nullable<BigInteger> ToBigIntegerNullable(JToken value) { }

	// RVA: 0x30D0024 Offset: 0x30CC024 VA: 0x30D0024 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30D00B8 Offset: 0x30CC0B8 VA: 0x30D00B8 Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	// RVA: 0x30D0150 Offset: 0x30CC150 VA: 0x30D0150
	public JsonReader CreateReader() { }

	// RVA: 0x30D021C Offset: 0x30CC21C VA: 0x30D021C
	public object ToObject(Type objectType) { }

	[NullableContext(2)]
	// RVA: 0x30D0E88 Offset: 0x30CCE88 VA: 0x30D0E88
	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	// RVA: 0x30D10F4 Offset: 0x30CD0F4 VA: 0x30D10F4
	public static JToken ReadFrom(JsonReader reader) { }

	// RVA: 0x30D114C Offset: 0x30CD14C VA: 0x30D114C
	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	[NullableContext(2)]
	// RVA: 0x30C2418 Offset: 0x30BE418 VA: 0x30C2418
	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	// RVA: 0x30D142C Offset: 0x30CD42C VA: 0x30D142C
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x30D1724 Offset: 0x30CD724 VA: 0x30D1724 Slot: 6
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x30D1778 Offset: 0x30CD778 VA: 0x30D1778 Slot: 7
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x30D17CC Offset: 0x30CD7CC VA: 0x30D17CC Slot: 8
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0x30D1820 Offset: 0x30CD820 VA: 0x30D1820 Slot: 18
	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0x30D18E8 Offset: 0x30CD8E8 VA: 0x30D18E8 Slot: 10
	private DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	// RVA: 0x30D18F8 Offset: 0x30CD8F8 VA: 0x30D18F8 Slot: 9
	private object System.ICloneable.Clone() { }

	// RVA: 0x30D1908 Offset: 0x30CD908 VA: 0x30D1908
	public JToken DeepClone() { }

	// RVA: 0x30D14C8 Offset: 0x30CD4C8 VA: 0x30D14C8
	public void AddAnnotation(object annotation) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C6158 Offset: 0x26C2158 VA: 0x26C6158
	|-JToken.Annotation<object>
	*/

	// RVA: 0x30C2F30 Offset: 0x30BEF30 VA: 0x30C2F30
	internal void CopyAnnotations(JToken target, JToken source) { }

	// RVA: 0x30D1918 Offset: 0x30CD918 VA: 0x30D1918
	private static void .cctor() { }
}
