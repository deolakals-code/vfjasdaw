// Assembly: mscorlib.dll
// Namespace: System.Reflection.Emit
public sealed class FieldBuilder : FieldInfo // TypeDefIndex: 10667
{
	// Properties
	public override FieldAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type FieldType { get; }
	public override string Name { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x2F3DCB0 Offset: 0x2F39CB0 VA: 0x2F3DCB0 Slot: 16
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x2F3DCB8 Offset: 0x2F39CB8 VA: 0x2F3DCB8 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x2F3DCC0 Offset: 0x2F39CC0 VA: 0x2F3DCC0 Slot: 24
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x2F3DCC8 Offset: 0x2F39CC8 VA: 0x2F3DCC8 Slot: 17
	public override Type get_FieldType() { }

	// RVA: 0x2F3DCD0 Offset: 0x2F39CD0 VA: 0x2F3DCD0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x2F3DCD8 Offset: 0x2F39CD8 VA: 0x2F3DCD8 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x2F3DCE0 Offset: 0x2F39CE0 VA: 0x2F3DCE0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F3DCE8 Offset: 0x2F39CE8 VA: 0x2F3DCE8 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F3DCF0 Offset: 0x2F39CF0 VA: 0x2F3DCF0 Slot: 25
	public override object GetValue(object obj) { }

	// RVA: 0x2F3DCF8 Offset: 0x2F39CF8 VA: 0x2F3DCF8 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F3DD00 Offset: 0x2F39D00 VA: 0x2F3DD00 Slot: 27
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }
}
