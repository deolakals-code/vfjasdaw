// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(1)]
public class JsonDynamicContract : JsonContainerContract // TypeDefIndex: 16004
{
	// Fields
	[CompilerGenerated]
	private readonly JsonPropertyCollection <Properties>k__BackingField; // 0xC0
	[Nullable(new[] { 2, 1, 1 })]
	[CompilerGenerated]
	private Func<string, string> <PropertyNameResolver>k__BackingField; // 0xC8
	private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object>>> _callSiteGetters; // 0xD0
	[Nullable(new[] { 1, 1, 1, 1, 1, 1, 2, 1 })]
	private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object, object>>> _callSiteSetters; // 0xD8

	// Properties
	public JsonPropertyCollection Properties { get; }
	[Nullable(new[] { 2, 1, 1 })]
	public Func<string, string> PropertyNameResolver { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x30A7E28 Offset: 0x30A3E28 VA: 0x30A7E28
	public JsonPropertyCollection get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x30A7E30 Offset: 0x30A3E30 VA: 0x30A7E30
	public Func<string, string> get_PropertyNameResolver() { }

	[CompilerGenerated]
	// RVA: 0x30A7E38 Offset: 0x30A3E38 VA: 0x30A7E38
	public void set_PropertyNameResolver(Func<string, string> value) { }

	// RVA: 0x30A7E40 Offset: 0x30A3E40 VA: 0x30A7E40
	private static CallSite<Func<CallSite, object, object>> CreateCallSiteGetter(string name) { }

	// RVA: 0x30A7F6C Offset: 0x30A3F6C VA: 0x30A7F6C
	private static CallSite<Func<CallSite, object, object, object>> CreateCallSiteSetter(string name) { }

	// RVA: 0x30A8098 Offset: 0x30A4098 VA: 0x30A8098
	public void .ctor(Type underlyingType) { }

	// RVA: 0x30A83D8 Offset: 0x30A43D8 VA: 0x30A83D8
	internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, out object value) { }

	// RVA: 0x30A84FC Offset: 0x30A44FC VA: 0x30A84FC
	internal bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, object value) { }
}
