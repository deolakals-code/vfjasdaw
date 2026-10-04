// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
public class UnixDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 16078
{
	// Fields
	internal static readonly DateTime UnixEpoch; // 0x0
	[CompilerGenerated]
	private bool <AllowPreEpoch>k__BackingField; // 0x10

	// Properties
	public bool AllowPreEpoch { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x30DF770 Offset: 0x30DB770 VA: 0x30DF770
	public bool get_AllowPreEpoch() { }

	[CompilerGenerated]
	// RVA: 0x30DF778 Offset: 0x30DB778 VA: 0x30DF778
	public void set_AllowPreEpoch(bool value) { }

	// RVA: 0x30DF784 Offset: 0x30DB784 VA: 0x30DF784
	public void .ctor() { }

	// RVA: 0x30DF7A0 Offset: 0x30DB7A0 VA: 0x30DF7A0
	public void .ctor(bool allowPreEpoch) { }

	// RVA: 0x30DF7CC Offset: 0x30DB7CC VA: 0x30DF7CC Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x30DFA30 Offset: 0x30DBA30 VA: 0x30DFA30 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x30DFE34 Offset: 0x30DBE34 VA: 0x30DFE34
	private static void .cctor() { }
}
