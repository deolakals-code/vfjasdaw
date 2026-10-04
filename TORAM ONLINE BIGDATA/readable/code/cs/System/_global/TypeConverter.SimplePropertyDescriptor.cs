// Assembly: System.dll
// Namespace: 
protected abstract class TypeConverter.SimplePropertyDescriptor : PropertyDescriptor // TypeDefIndex: 14258
{
	// Fields
	private Type componentType; // 0x88
	private Type propertyType; // 0x90

	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x34C3910 Offset: 0x34BF910 VA: 0x34C3910
	protected void .ctor(Type componentType, string name, Type propertyType) { }

	// RVA: 0x34C398C Offset: 0x34BF98C VA: 0x34C398C
	protected void .ctor(Type componentType, string name, Type propertyType, Attribute[] attributes) { }

	// RVA: 0x34C39D8 Offset: 0x34BF9D8 VA: 0x34C39D8 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x34C39E0 Offset: 0x34BF9E0 VA: 0x34C39E0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x34C3A64 Offset: 0x34BFA64 VA: 0x34C3A64 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x34C3A6C Offset: 0x34BFA6C VA: 0x34C3A6C Slot: 17
	public override bool CanResetValue(object component) { }

	// RVA: 0x34C3BB0 Offset: 0x34BFBB0 VA: 0x34C3BB0 Slot: 20
	public override void ResetValue(object component) { }

	// RVA: 0x34C3CDC Offset: 0x34BFCDC VA: 0x34C3CDC Slot: 22
	public override bool ShouldSerializeValue(object component) { }
}
