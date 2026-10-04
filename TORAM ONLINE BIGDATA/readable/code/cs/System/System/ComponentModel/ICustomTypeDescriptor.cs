// Assembly: System.dll
// Namespace: System.ComponentModel
public interface ICustomTypeDescriptor // TypeDefIndex: 14209
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AttributeCollection GetAttributes();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TypeConverter GetConverter();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract PropertyDescriptorCollection GetProperties();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract PropertyDescriptorCollection GetProperties(Attribute[] attributes);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetPropertyOwner(PropertyDescriptor pd);
}
