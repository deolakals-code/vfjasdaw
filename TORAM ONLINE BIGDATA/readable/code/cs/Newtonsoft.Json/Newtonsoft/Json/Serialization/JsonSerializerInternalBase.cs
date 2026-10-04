// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal abstract class JsonSerializerInternalBase // TypeDefIndex: 16013
{
	// Fields
	[Nullable(2)]
	private ErrorContext _currentErrorContext; // 0x10
	[Nullable(new[] { 2, 1, 1 })]
	private BidirectionalDictionary<string, object> _mappings; // 0x18
	internal readonly JsonSerializer Serializer; // 0x20
	[Nullable(2)]
	internal readonly ITraceWriter TraceWriter; // 0x28
	[Nullable(2)]
	protected JsonSerializerProxy InternalSerializer; // 0x30

	// Properties
	internal BidirectionalDictionary<string, object> DefaultReferenceMappings { get; }

	// Methods

	// RVA: 0x30AA0A0 Offset: 0x30A60A0 VA: 0x30AA0A0
	protected void .ctor(JsonSerializer serializer) { }

	// RVA: 0x30A3148 Offset: 0x309F148 VA: 0x30A3148
	internal BidirectionalDictionary<string, object> get_DefaultReferenceMappings() { }

	// RVA: 0x30AA144 Offset: 0x30A6144 VA: 0x30AA144
	protected NullValueHandling ResolvedNullValueHandling(JsonObjectContract containerContract, JsonProperty property) { }

	// RVA: 0x30AA1D0 Offset: 0x30A61D0 VA: 0x30AA1D0
	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	// RVA: 0x30AA2C8 Offset: 0x30A62C8 VA: 0x30AA2C8
	protected void ClearErrorContext() { }

	[NullableContext(2)]
	// RVA: 0x30AA32C Offset: 0x30A632C VA: 0x30AA32C
	protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) { }
}
