// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json
[Nullable(0)]
[NullableContext(1)]
[Serializable]
public class JsonSerializationException : JsonException // TypeDefIndex: 15855
{
	// Fields
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; // 0x8C
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; // 0x90
	[Nullable(2)]
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; // 0x98

	// Methods

	// RVA: 0x30723D0 Offset: 0x306E3D0 VA: 0x30723D0
	public void .ctor() { }

	// RVA: 0x30723D4 Offset: 0x306E3D4 VA: 0x30723D4
	public void .ctor(string message) { }

	// RVA: 0x30723D8 Offset: 0x306E3D8 VA: 0x30723D8
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x30723DC Offset: 0x306E3DC VA: 0x30723DC
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30723E0 Offset: 0x306E3E0 VA: 0x30723E0
	public void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0x3071E14 Offset: 0x306DE14 VA: 0x3071E14
	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	// RVA: 0x3072428 Offset: 0x306E428 VA: 0x3072428
	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0x30724AC Offset: 0x306E4AC VA: 0x30724AC
	internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }
}
