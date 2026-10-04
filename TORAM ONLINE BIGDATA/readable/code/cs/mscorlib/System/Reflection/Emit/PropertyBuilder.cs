// Assembly: mscorlib.dll
// Namespace: System.Reflection.Emit
public sealed class PropertyBuilder : PropertyInfo // TypeDefIndex: 10674
{
	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x2F3E6D8 Offset: 0x2F3A6D8 VA: 0x2F3E6D8 Slot: 18
	public override bool get_CanRead() { }

	// RVA: 0x2F3E710 Offset: 0x2F3A710 VA: 0x2F3E710 Slot: 19
	public override bool get_CanWrite() { }

	// RVA: 0x2F3E748 Offset: 0x2F3A748 VA: 0x2F3E748 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x2F3E780 Offset: 0x2F3A780 VA: 0x2F3E780 Slot: 8
	public override string get_Name() { }

	// RVA: 0x2F3E7B8 Offset: 0x2F3A7B8 VA: 0x2F3E7B8 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x2F3E7F0 Offset: 0x2F3A7F0 VA: 0x2F3E7F0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x2F3E828 Offset: 0x2F3A828 VA: 0x2F3E828 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F3E860 Offset: 0x2F3A860 VA: 0x2F3E860 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F3E898 Offset: 0x2F3A898 VA: 0x2F3E898 Slot: 22
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x2F3E8D0 Offset: 0x2F3A8D0 VA: 0x2F3E8D0 Slot: 17
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x2F3E908 Offset: 0x2F3A908 VA: 0x2F3E908 Slot: 24
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x2F3E940 Offset: 0x2F3A940 VA: 0x2F3E940 Slot: 26
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x2F3E978 Offset: 0x2F3A978 VA: 0x2F3E978 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F3E9B0 Offset: 0x2F3A9B0 VA: 0x2F3E9B0 Slot: 28
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }
}
