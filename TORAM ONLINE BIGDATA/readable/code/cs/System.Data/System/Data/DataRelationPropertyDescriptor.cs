// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class DataRelationPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 14692
{
	// Fields
	[CompilerGenerated]
	private readonly DataRelation <Relation>k__BackingField; // 0x88

	// Properties
	internal DataRelation Relation { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x31EBB10 Offset: 0x31E7B10 VA: 0x31EBB10
	internal void .ctor(DataRelation dataRelation) { }

	[CompilerGenerated]
	// RVA: 0x31EBB64 Offset: 0x31E7B64 VA: 0x31EBB64
	internal DataRelation get_Relation() { }

	// RVA: 0x31EBB6C Offset: 0x31E7B6C VA: 0x31EBB6C Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x31EBBD8 Offset: 0x31E7BD8 VA: 0x31EBBD8 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x31EBBE0 Offset: 0x31E7BE0 VA: 0x31EBBE0 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x31EBC4C Offset: 0x31E7C4C VA: 0x31EBC4C Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x31EBCBC Offset: 0x31E7CBC VA: 0x31EBCBC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x31EBCDC Offset: 0x31E7CDC VA: 0x31EBCDC Slot: 17
	public override bool CanResetValue(object component) { }

	// RVA: 0x31EBCE4 Offset: 0x31E7CE4 VA: 0x31EBCE4 Slot: 18
	public override object GetValue(object component) { }

	// RVA: 0x31EBD78 Offset: 0x31E7D78 VA: 0x31EBD78 Slot: 20
	public override void ResetValue(object component) { }

	// RVA: 0x31EBD7C Offset: 0x31E7D7C VA: 0x31EBD7C Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x31EBD80 Offset: 0x31E7D80 VA: 0x31EBD80 Slot: 22
	public override bool ShouldSerializeValue(object component) { }
}
