// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 14684
{
	// Fields
	[CompilerGenerated]
	private readonly DataColumn <Column>k__BackingField; // 0x88

	// Properties
	public override AttributeCollection Attributes { get; }
	internal DataColumn Column { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x31E417C Offset: 0x31E017C VA: 0x31E417C
	internal void .ctor(DataColumn dataColumn) { }

	// RVA: 0x31E41BC Offset: 0x31E01BC VA: 0x31E41BC Slot: 6
	public override AttributeCollection get_Attributes() { }

	[CompilerGenerated]
	// RVA: 0x31E4380 Offset: 0x31E0380 VA: 0x31E4380
	internal DataColumn get_Column() { }

	// RVA: 0x31E4388 Offset: 0x31E0388 VA: 0x31E4388 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x31E43F4 Offset: 0x31E03F4 VA: 0x31E43F4 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x31E4410 Offset: 0x31E0410 VA: 0x31E4410 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x31E442C Offset: 0x31E042C VA: 0x31E442C Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x31E449C Offset: 0x31E049C VA: 0x31E449C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x31E44BC Offset: 0x31E04BC VA: 0x31E44BC Slot: 17
	public override bool CanResetValue(object component) { }

	// RVA: 0x31E4604 Offset: 0x31E0604 VA: 0x31E4604 Slot: 18
	public override object GetValue(object component) { }

	// RVA: 0x31E468C Offset: 0x31E068C VA: 0x31E468C Slot: 20
	public override void ResetValue(object component) { }

	// RVA: 0x31E47DC Offset: 0x31E07DC VA: 0x31E47DC Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x31E48BC Offset: 0x31E08BC VA: 0x31E48BC Slot: 22
	public override bool ShouldSerializeValue(object component) { }
}
