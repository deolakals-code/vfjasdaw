// Assembly: System.dll
// Namespace: 
private sealed class TypeDescriptor.MergedTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 14265
{
	// Fields
	private ICustomTypeDescriptor _primary; // 0x10
	private ICustomTypeDescriptor _secondary; // 0x18

	// Methods

	// RVA: 0x34C9EA8 Offset: 0x34C5EA8 VA: 0x34C9EA8
	internal void .ctor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

	// RVA: 0x34CBD00 Offset: 0x34C7D00 VA: 0x34CBD00 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x34CBE10 Offset: 0x34C7E10 VA: 0x34CBE10 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x34CBF28 Offset: 0x34C7F28 VA: 0x34CBF28 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x34CC040 Offset: 0x34C8040 VA: 0x34CC040 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x34CC170 Offset: 0x34C8170 VA: 0x34CC170 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }
}
