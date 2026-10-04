// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
[Serializable]
public class JsonWriterException : JsonException // TypeDefIndex: 15864
{
	// Fields
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <Path>k__BackingField; // 0x90

	// Methods

	// RVA: 0x30818AC Offset: 0x307D8AC VA: 0x30818AC
	public void .ctor() { }

	// RVA: 0x30818B4 Offset: 0x307D8B4 VA: 0x30818B4
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30818BC Offset: 0x307D8BC VA: 0x30818BC
	public void .ctor(string message, string path, Exception innerException) { }

	// RVA: 0x30818F0 Offset: 0x307D8F0 VA: 0x30818F0
	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	// RVA: 0x3081924 Offset: 0x307D924 VA: 0x3081924
	internal static JsonWriterException Create(string path, string message, Exception ex) { }
}
