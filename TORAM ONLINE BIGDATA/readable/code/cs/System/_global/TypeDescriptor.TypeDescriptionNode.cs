// Assembly: System.dll
// Namespace: 
private sealed class TypeDescriptor.TypeDescriptionNode : TypeDescriptionProvider // TypeDefIndex: 14268
{
	// Fields
	internal TypeDescriptor.TypeDescriptionNode Next; // 0x20
	internal TypeDescriptionProvider Provider; // 0x28

	// Methods

	// RVA: 0x34C4A9C Offset: 0x34C0A9C VA: 0x34C4A9C
	internal void .ctor(TypeDescriptionProvider provider) { }

	// RVA: 0x34CC2A0 Offset: 0x34C82A0 VA: 0x34CC2A0 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x34CC418 Offset: 0x34C8418 VA: 0x34CC418 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x34CC484 Offset: 0x34C8484 VA: 0x34CC484 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x34CC590 Offset: 0x34C8590 VA: 0x34CC590 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x34CC5FC Offset: 0x34C85FC VA: 0x34CC5FC Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x34CC6D4 Offset: 0x34C86D4 VA: 0x34CC6D4 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }
}
