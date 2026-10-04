// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(1)]
public abstract class NamingStrategy // TypeDefIndex: 16026
{
	// Fields
	[CompilerGenerated]
	private bool <ProcessDictionaryKeys>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <ProcessExtensionDataNames>k__BackingField; // 0x11
	[CompilerGenerated]
	private bool <OverrideSpecifiedNames>k__BackingField; // 0x12

	// Properties
	public bool ProcessDictionaryKeys { get; set; }
	public bool ProcessExtensionDataNames { get; set; }
	public bool OverrideSpecifiedNames { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x30BEFFC Offset: 0x30BAFFC VA: 0x30BEFFC
	public bool get_ProcessDictionaryKeys() { }

	[CompilerGenerated]
	// RVA: 0x30BF004 Offset: 0x30BB004 VA: 0x30BF004
	public void set_ProcessDictionaryKeys(bool value) { }

	[CompilerGenerated]
	// RVA: 0x30BF010 Offset: 0x30BB010 VA: 0x30BF010
	public bool get_ProcessExtensionDataNames() { }

	[CompilerGenerated]
	// RVA: 0x30BF018 Offset: 0x30BB018 VA: 0x30BF018
	public void set_ProcessExtensionDataNames(bool value) { }

	[CompilerGenerated]
	// RVA: 0x30BF024 Offset: 0x30BB024 VA: 0x30BF024
	public bool get_OverrideSpecifiedNames() { }

	[CompilerGenerated]
	// RVA: 0x30BF02C Offset: 0x30BB02C VA: 0x30BF02C
	public void set_OverrideSpecifiedNames(bool value) { }

	// RVA: 0x30BF038 Offset: 0x30BB038 VA: 0x30BF038 Slot: 4
	public virtual string GetPropertyName(string name, bool hasSpecifiedName) { }

	// RVA: 0x30BF058 Offset: 0x30BB058 VA: 0x30BF058 Slot: 5
	public virtual string GetExtensionDataName(string name) { }

	// RVA: 0x30BF074 Offset: 0x30BB074 VA: 0x30BF074 Slot: 6
	public virtual string GetDictionaryKey(string key) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract string ResolvePropertyName(string name);

	// RVA: 0x30BF090 Offset: 0x30BB090 VA: 0x30BF090 Slot: 2
	public override int GetHashCode() { }

	[NullableContext(2)]
	// RVA: 0x30BF170 Offset: 0x30BB170 VA: 0x30BF170 Slot: 0
	public override bool Equals(object obj) { }

	[NullableContext(2)]
	// RVA: 0x30BF1F0 Offset: 0x30BB1F0 VA: 0x30BF1F0
	protected bool Equals(NamingStrategy other) { }

	// RVA: 0x30BEF94 Offset: 0x30BAF94 VA: 0x30BEF94
	protected void .ctor() { }
}
