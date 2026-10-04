// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class DefaultReferenceResolver : IReferenceResolver // TypeDefIndex: 15983
{
	// Fields
	private int _referenceCount; // 0x10

	// Methods

	// RVA: 0x30A303C Offset: 0x309F03C VA: 0x30A303C
	private BidirectionalDictionary<string, object> GetMappings(object context) { }

	// RVA: 0x30A3258 Offset: 0x309F258 VA: 0x30A3258 Slot: 4
	public object ResolveReference(object context, string reference) { }

	// RVA: 0x30A32CC Offset: 0x309F2CC VA: 0x30A32CC Slot: 5
	public string GetReference(object context, object value) { }

	// RVA: 0x30A33C0 Offset: 0x309F3C0 VA: 0x30A33C0 Slot: 7
	public void AddReference(object context, string reference, object value) { }

	// RVA: 0x30A342C Offset: 0x309F42C VA: 0x30A342C Slot: 6
	public bool IsReferenced(object context, object value) { }

	// RVA: 0x30A34A0 Offset: 0x309F4A0 VA: 0x30A34A0
	public void .ctor() { }
}
