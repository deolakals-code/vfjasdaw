// Assembly: mscorlib.dll
// Namespace: System.Reflection.Emit
public sealed class MethodBuilder : MethodInfo // TypeDefIndex: 10671
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override string Name { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x2F3E438 Offset: 0x2F3A438 VA: 0x2F3E438 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x2F3E470 Offset: 0x2F3A470 VA: 0x2F3E470 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x2F3E4A8 Offset: 0x2F3A4A8 VA: 0x2F3E4A8 Slot: 32
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x2F3E4E0 Offset: 0x2F3A4E0 VA: 0x2F3E4E0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x2F3E518 Offset: 0x2F3A518 VA: 0x2F3E518 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x2F3E550 Offset: 0x2F3A550 VA: 0x2F3E550 Slot: 43
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x2F3E588 Offset: 0x2F3A588 VA: 0x2F3E588 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F3E5C0 Offset: 0x2F3A5C0 VA: 0x2F3E5C0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F3E5F8 Offset: 0x2F3A5F8 VA: 0x2F3E5F8 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x2F3E630 Offset: 0x2F3A630 VA: 0x2F3E630 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x2F3E668 Offset: 0x2F3A668 VA: 0x2F3E668 Slot: 31
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x2F3E6A0 Offset: 0x2F3A6A0 VA: 0x2F3E6A0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}
