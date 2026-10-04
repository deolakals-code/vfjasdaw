// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
public class StringEnumConverter : JsonConverter // TypeDefIndex: 16077
{
	// Fields
	[Nullable(2)]
	[CompilerGenerated]
	private NamingStrategy <NamingStrategy>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <AllowIntegerValues>k__BackingField; // 0x18

	// Properties
	[Obsolete("StringEnumConverter.CamelCaseText is obsolete. Set StringEnumConverter.NamingStrategy with CamelCaseNamingStrategy instead.")]
	public bool CamelCaseText { get; set; }
	[Nullable(2)]
	public NamingStrategy NamingStrategy { get; set; }
	public bool AllowIntegerValues { get; set; }

	// Methods

	// RVA: 0x30DEC10 Offset: 0x30DAC10 VA: 0x30DEC10
	public bool get_CamelCaseText() { }

	// RVA: 0x30DEC8C Offset: 0x30DAC8C VA: 0x30DEC8C
	public void set_CamelCaseText(bool value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x30DED5C Offset: 0x30DAD5C VA: 0x30DED5C
	public NamingStrategy get_NamingStrategy() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x30DED64 Offset: 0x30DAD64 VA: 0x30DED64
	public void set_NamingStrategy(NamingStrategy value) { }

	[CompilerGenerated]
	// RVA: 0x30DED6C Offset: 0x30DAD6C VA: 0x30DED6C
	public bool get_AllowIntegerValues() { }

	[CompilerGenerated]
	// RVA: 0x30DED74 Offset: 0x30DAD74 VA: 0x30DED74
	public void set_AllowIntegerValues(bool value) { }

	// RVA: 0x30DED80 Offset: 0x30DAD80 VA: 0x30DED80
	public void .ctor() { }

	[Obsolete("StringEnumConverter(bool) is obsolete. Create a converter with StringEnumConverter(NamingStrategy, bool) instead.")]
	// RVA: 0x30DED90 Offset: 0x30DAD90 VA: 0x30DED90
	public void .ctor(bool camelCaseText) { }

	// RVA: 0x30DEE18 Offset: 0x30DAE18 VA: 0x30DEE18
	public void .ctor(NamingStrategy namingStrategy, bool allowIntegerValues = True) { }

	// RVA: 0x30DEE60 Offset: 0x30DAE60 VA: 0x30DEE60
	public void .ctor(Type namingStrategyType) { }

	// RVA: 0x30DEF10 Offset: 0x30DAF10 VA: 0x30DEF10
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters) { }

	// RVA: 0x30DEFCC Offset: 0x30DAFCC VA: 0x30DEFCC
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues) { }

	// RVA: 0x30DF098 Offset: 0x30DB098 VA: 0x30DF098 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x30DF288 Offset: 0x30DB288 VA: 0x30DF288 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x30DF6F8 Offset: 0x30DB6F8 VA: 0x30DF6F8 Slot: 6
	public override bool CanConvert(Type objectType) { }
}
