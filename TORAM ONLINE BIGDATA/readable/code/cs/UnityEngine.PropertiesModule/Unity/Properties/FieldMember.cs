// Assembly: UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
[IsReadOnly]
internal struct FieldMember : IMemberInfo // TypeDefIndex: 17333
{
	// Fields
	internal readonly FieldInfo m_FieldInfo; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x8

	// Properties
	public string Name { get; }
	public bool IsReadOnly { get; }
	public Type ValueType { get; }

	// Methods

	// RVA: 0x381D1F8 Offset: 0x38191F8 VA: 0x381D1F8
	public void .ctor(FieldInfo fieldInfo) { }

	[CompilerGenerated]
	// RVA: 0x381D318 Offset: 0x3819318 VA: 0x381D318 Slot: 4
	public string get_Name() { }

	// RVA: 0x381D320 Offset: 0x3819320 VA: 0x381D320 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x381D33C Offset: 0x381933C VA: 0x381D33C Slot: 6
	public Type get_ValueType() { }

	// RVA: 0x381D360 Offset: 0x3819360 VA: 0x381D360 Slot: 7
	public IEnumerable<Attribute> GetCustomAttributes() { }
}
