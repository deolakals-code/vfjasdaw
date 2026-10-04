// Assembly: System.dll
// Namespace: System.ComponentModel
public abstract class TypeDescriptionProvider // TypeDefIndex: 14236
{
	// Fields
	private readonly TypeDescriptionProvider _parent; // 0x10
	private TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18

	// Methods

	// RVA: 0x34A7B34 Offset: 0x34A3B34 VA: 0x34A7B34
	protected void .ctor() { }

	// RVA: 0x34B2F24 Offset: 0x34AEF24 VA: 0x34B2F24 Slot: 4
	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x34B3030 Offset: 0x34AF030 VA: 0x34B3030 Slot: 5
	public virtual IDictionary GetCache(object instance) { }

	// RVA: 0x34B3048 Offset: 0x34AF048 VA: 0x34B3048 Slot: 6
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x34B30E4 Offset: 0x34AF0E4 VA: 0x34B30E4 Slot: 7
	protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x34B31E4 Offset: 0x34AF1E4 VA: 0x34B31E4
	public Type GetReflectionType(Type objectType) { }

	// RVA: 0x34B31F4 Offset: 0x34AF1F4 VA: 0x34B31F4 Slot: 8
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x34B3210 Offset: 0x34AF210 VA: 0x34B3210
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	// RVA: 0x34B3220 Offset: 0x34AF220 VA: 0x34B3220
	public ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	// RVA: 0x34B32A8 Offset: 0x34AF2A8 VA: 0x34B32A8 Slot: 9
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }
}
