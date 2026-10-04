// Assembly: mscorlib.dll
// Namespace: System.Reflection.Emit
public class ConstructorBuilder : ConstructorInfo // TypeDefIndex: 10663
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x2F3D070 Offset: 0x2F39070 VA: 0x2F3D070 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x2F3D0A8 Offset: 0x2F390A8 VA: 0x2F3D0A8 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x2F3D0E0 Offset: 0x2F390E0 VA: 0x2F3D0E0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x2F3D118 Offset: 0x2F39118 VA: 0x2F3D118 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x2F3D150 Offset: 0x2F39150 VA: 0x2F3D150 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x2F3D188 Offset: 0x2F39188 VA: 0x2F3D188 Slot: 32
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x2F3D1C0 Offset: 0x2F391C0 VA: 0x2F3D1C0 Slot: 39
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x2F3D1F8 Offset: 0x2F391F8 VA: 0x2F3D1F8 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F3D230 Offset: 0x2F39230 VA: 0x2F3D230 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F3D268 Offset: 0x2F39268 VA: 0x2F3D268 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F3D2A0 Offset: 0x2F392A0 VA: 0x2F3D2A0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x2F3D2D8 Offset: 0x2F392D8 VA: 0x2F3D2D8 Slot: 31
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }
}
