// Assembly: System.dll
// Namespace: System.ComponentModel
internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 14205
{
	// Fields
	private readonly ReflectPropertyDescriptor _extenderInfo; // 0x88
	private readonly IExtenderProvider _provider; // 0x90

	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	public override string DisplayName { get; }

	// Methods

	// RVA: 0x34A986C Offset: 0x34A586C VA: 0x34A986C
	public void .ctor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	// RVA: 0x34A9B78 Offset: 0x34A5B78 VA: 0x34A9B78 Slot: 17
	public override bool CanResetValue(object comp) { }

	// RVA: 0x34A9E2C Offset: 0x34A5E2C VA: 0x34A9E2C Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x34A9E50 Offset: 0x34A5E50 VA: 0x34A9E50 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x34A9F48 Offset: 0x34A5F48 VA: 0x34A9F48 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x34A9F7C Offset: 0x34A5F7C VA: 0x34A9F7C Slot: 9
	public override string get_DisplayName() { }

	// RVA: 0x34AA374 Offset: 0x34A6374 VA: 0x34AA374 Slot: 18
	public override object GetValue(object comp) { }

	// RVA: 0x34AA4D4 Offset: 0x34A64D4 VA: 0x34AA4D4 Slot: 20
	public override void ResetValue(object comp) { }

	// RVA: 0x34AAA14 Offset: 0x34A6A14 VA: 0x34AAA14 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x34AAEC0 Offset: 0x34A6EC0 VA: 0x34AAEC0 Slot: 22
	public override bool ShouldSerializeValue(object comp) { }
}
