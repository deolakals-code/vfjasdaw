// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class BinaryConverter : JsonConverter // TypeDefIndex: 16060
{
	// Fields
	private const string BinaryTypeName = "System.Data.Linq.Binary";
	private const string BinaryToArrayName = "ToArray";
	[Nullable(2)]
	private static ReflectionObject _reflectionObject; // 0x0

	// Methods

	// RVA: 0x30D75E8 Offset: 0x30D35E8 VA: 0x30D75E8 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x30D763C Offset: 0x30D363C VA: 0x30D763C
	private byte[] GetByteArray(object value) { }

	// RVA: 0x30D7824 Offset: 0x30D3824 VA: 0x30D7824
	private static void EnsureReflectionObject(Type t) { }

	// RVA: 0x30D79E4 Offset: 0x30D39E4 VA: 0x30D79E4 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x30D7DDC Offset: 0x30D3DDC VA: 0x30D7DDC
	private byte[] ReadByteArray(JsonReader reader) { }

	// RVA: 0x30D8068 Offset: 0x30D4068 VA: 0x30D8068 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x30D8180 Offset: 0x30D4180 VA: 0x30D8180
	public void .ctor() { }
}
