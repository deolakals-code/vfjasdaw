// Assembly: System.dll
// Namespace: System.ComponentModel
internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 14196
{
	// Fields
	private readonly Type _type; // 0x20

	// Properties
	internal TypeDescriptionProvider Provider { get; }

	// Methods

	// RVA: 0x34A7B04 Offset: 0x34A3B04 VA: 0x34A7B04
	internal void .ctor(Type type) { }

	// RVA: 0x34A7B3C Offset: 0x34A3B3C VA: 0x34A7B3C
	internal TypeDescriptionProvider get_Provider() { }

	// RVA: 0x34A7B98 Offset: 0x34A3B98 VA: 0x34A7B98 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x34A7BE8 Offset: 0x34A3BE8 VA: 0x34A7BE8 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x34A7C10 Offset: 0x34A3C10 VA: 0x34A7C10 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x34A7C38 Offset: 0x34A3C38 VA: 0x34A7C38 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x34A7C60 Offset: 0x34A3C60 VA: 0x34A7C60 Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x34A7C98 Offset: 0x34A3C98 VA: 0x34A7C98 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }
}
