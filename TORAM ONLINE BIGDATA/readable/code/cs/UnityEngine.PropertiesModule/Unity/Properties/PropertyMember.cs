// Assembly: UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
[IsReadOnly]
internal struct PropertyMember : IMemberInfo // TypeDefIndex: 17334
{
	// Fields
	internal readonly PropertyInfo m_PropertyInfo; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x8

	// Properties
	public string Name { get; }
	public bool IsReadOnly { get; }
	public Type ValueType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x381D36C Offset: 0x381936C VA: 0x381D36C Slot: 4
	public string get_Name() { }

	// RVA: 0x381D374 Offset: 0x3819374 VA: 0x381D374 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x381D3A4 Offset: 0x38193A4 VA: 0x381D3A4 Slot: 6
	public Type get_ValueType() { }

	// RVA: 0x381D3C8 Offset: 0x38193C8 VA: 0x381D3C8
	public void .ctor(PropertyInfo propertyInfo) { }

	// RVA: 0x381D3F4 Offset: 0x38193F4 VA: 0x381D3F4 Slot: 7
	public IEnumerable<Attribute> GetCustomAttributes() { }
}
