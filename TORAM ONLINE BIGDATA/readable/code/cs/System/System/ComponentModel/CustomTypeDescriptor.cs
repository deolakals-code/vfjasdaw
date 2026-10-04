// Assembly: System.dll
// Namespace: System.ComponentModel
public abstract class CustomTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 14191
{
	// Fields
	private readonly ICustomTypeDescriptor _parent; // 0x10

	// Methods

	// RVA: 0x34A6514 Offset: 0x34A2514 VA: 0x34A6514
	protected void .ctor() { }

	// RVA: 0x34A651C Offset: 0x34A251C VA: 0x34A651C Slot: 9
	public virtual AttributeCollection GetAttributes() { }

	// RVA: 0x34A65F4 Offset: 0x34A25F4 VA: 0x34A65F4 Slot: 10
	public virtual TypeConverter GetConverter() { }

	// RVA: 0x34A66CC Offset: 0x34A26CC VA: 0x34A66CC Slot: 11
	public virtual PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x34A67A8 Offset: 0x34A27A8 VA: 0x34A67A8 Slot: 12
	public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	// RVA: 0x34A688C Offset: 0x34A288C VA: 0x34A688C Slot: 13
	public virtual object GetPropertyOwner(PropertyDescriptor pd) { }
}
