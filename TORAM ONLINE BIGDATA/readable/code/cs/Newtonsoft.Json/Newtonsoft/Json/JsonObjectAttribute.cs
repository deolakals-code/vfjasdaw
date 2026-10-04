// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json
[Usage(1036, AllowMultiple = False)]
public sealed class JsonObjectAttribute : JsonContainerAttribute // TypeDefIndex: 15847
{
	// Fields
	private MemberSerialization _memberSerialization; // 0x50
	internal Nullable<MissingMemberHandling> _missingMemberHandling; // 0x54
	internal Nullable<Required> _itemRequired; // 0x5C
	internal Nullable<NullValueHandling> _itemNullValueHandling; // 0x64

	// Properties
	public MemberSerialization MemberSerialization { get; }

	// Methods

	// RVA: 0x306DB44 Offset: 0x3069B44 VA: 0x306DB44
	public MemberSerialization get_MemberSerialization() { }
}
