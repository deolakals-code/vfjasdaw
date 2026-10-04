// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
internal sealed class SerializationFieldInfo : FieldInfo // TypeDefIndex: 10369
{
	// Fields
	private RuntimeFieldInfo m_field; // 0x10
	private string m_serializationName; // 0x18

	// Properties
	public override Module Module { get; }
	public override int MetadataToken { get; }
	public override string Name { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override Type FieldType { get; }
	internal RuntimeFieldInfo FieldInfo { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override FieldAttributes Attributes { get; }

	// Methods

	// RVA: 0x2F043FC Offset: 0x2F003FC VA: 0x2F043FC Slot: 11
	public override Module get_Module() { }

	// RVA: 0x2F0441C Offset: 0x2F0041C VA: 0x2F0441C Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x2EFCEC8 Offset: 0x2EF8EC8 VA: 0x2EFCEC8
	internal void .ctor(RuntimeFieldInfo field, string namePrefix) { }

	// RVA: 0x2F04440 Offset: 0x2F00440 VA: 0x2F04440 Slot: 8
	public override string get_Name() { }

	// RVA: 0x2F04448 Offset: 0x2F00448 VA: 0x2F04448 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x2F04468 Offset: 0x2F00468 VA: 0x2F04468 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x2F04488 Offset: 0x2F00488 VA: 0x2F04488 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F044B0 Offset: 0x2F004B0 VA: 0x2F044B0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F044D8 Offset: 0x2F004D8 VA: 0x2F044D8 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F044FC Offset: 0x2F004FC VA: 0x2F044FC Slot: 17
	public override Type get_FieldType() { }

	// RVA: 0x2F04520 Offset: 0x2F00520 VA: 0x2F04520 Slot: 25
	public override object GetValue(object obj) { }

	// RVA: 0x2EFDD8C Offset: 0x2EF9D8C VA: 0x2EFDD8C
	internal object InternalGetValue(object obj) { }

	// RVA: 0x2F04544 Offset: 0x2F00544 VA: 0x2F04544 Slot: 27
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x2EFD678 Offset: 0x2EF9678 VA: 0x2EFD678
	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x2F04568 Offset: 0x2F00568 VA: 0x2F04568
	internal RuntimeFieldInfo get_FieldInfo() { }

	// RVA: 0x2F04570 Offset: 0x2F00570 VA: 0x2F04570 Slot: 24
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x2F04594 Offset: 0x2F00594 VA: 0x2F04594 Slot: 16
	public override FieldAttributes get_Attributes() { }
}
