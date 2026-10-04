// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
public class RegexConverter : JsonConverter // TypeDefIndex: 16076
{
	// Fields
	private const string PatternName = "Pattern";
	private const string OptionsName = "Options";

	// Methods

	// RVA: 0x30DE1BC Offset: 0x30DA1BC VA: 0x30DE1BC Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x30DE5CC Offset: 0x30DA5CC VA: 0x30DE5CC
	private bool HasFlag(RegexOptions options, RegexOptions flag) { }

	// RVA: 0x30DE2DC Offset: 0x30DA2DC VA: 0x30DE2DC
	private void WriteBson(BsonWriter writer, Regex regex) { }

	// RVA: 0x30DE410 Offset: 0x30DA410 VA: 0x30DE410
	private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) { }

	// RVA: 0x30DE688 Offset: 0x30DA688 VA: 0x30DE688 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x30DE9A0 Offset: 0x30DA9A0 VA: 0x30DE9A0
	private object ReadRegexString(JsonReader reader) { }

	// RVA: 0x30DE734 Offset: 0x30DA734 VA: 0x30DE734
	private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	// RVA: 0x30DEB04 Offset: 0x30DAB04 VA: 0x30DEB04 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x30DEB80 Offset: 0x30DAB80 VA: 0x30DEB80
	private bool IsRegex(Type objectType) { }

	// RVA: 0x30DEC08 Offset: 0x30DAC08 VA: 0x30DEC08
	public void .ctor() { }
}
