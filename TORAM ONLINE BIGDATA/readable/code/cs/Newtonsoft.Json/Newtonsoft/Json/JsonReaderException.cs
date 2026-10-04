// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json
[Nullable(0)]
[NullableContext(1)]
[Serializable]
public class JsonReaderException : JsonException // TypeDefIndex: 15853
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

	// RVA: 0x3072174 Offset: 0x306E174 VA: 0x3072174
	public void .ctor() { }

	// RVA: 0x3072178 Offset: 0x306E178 VA: 0x3072178
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x307217C Offset: 0x306E17C VA: 0x307217C
	public void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0x306EE08 Offset: 0x306AE08 VA: 0x306EE08
	internal static JsonReaderException Create(JsonReader reader, string message) { }

	// RVA: 0x306F33C Offset: 0x306B33C VA: 0x306F33C
	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0x30721C4 Offset: 0x306E1C4 VA: 0x30721C4
	internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }
}
