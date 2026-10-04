// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class IsoDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 16073
{
	// Fields
	private const string DefaultDateTimeFormat = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.FFFFFFFK";
	private DateTimeStyles _dateTimeStyles; // 0x10
	[Nullable(2)]
	private string _dateTimeFormat; // 0x18
	[Nullable(2)]
	private CultureInfo _culture; // 0x20

	// Properties
	public DateTimeStyles DateTimeStyles { get; set; }
	[Nullable(2)]
	public string DateTimeFormat { get; set; }
	public CultureInfo Culture { get; set; }

	// Methods

	// RVA: 0x30DC878 Offset: 0x30D8878 VA: 0x30DC878
	public DateTimeStyles get_DateTimeStyles() { }

	// RVA: 0x30DC880 Offset: 0x30D8880 VA: 0x30DC880
	public void set_DateTimeStyles(DateTimeStyles value) { }

	[NullableContext(2)]
	// RVA: 0x30DC888 Offset: 0x30D8888 VA: 0x30DC888
	public string get_DateTimeFormat() { }

	[NullableContext(2)]
	// RVA: 0x30DC8DC Offset: 0x30D88DC VA: 0x30DC8DC
	public void set_DateTimeFormat(string value) { }

	// RVA: 0x30DC91C Offset: 0x30D891C VA: 0x30DC91C
	public CultureInfo get_Culture() { }

	// RVA: 0x30DC984 Offset: 0x30D8984 VA: 0x30DC984
	public void set_Culture(CultureInfo value) { }

	// RVA: 0x30DC98C Offset: 0x30D898C VA: 0x30DC98C Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x30DCBF4 Offset: 0x30D8BF4 VA: 0x30DCBF4 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x30DD0FC Offset: 0x30D90FC VA: 0x30DD0FC
	public void .ctor() { }
}
