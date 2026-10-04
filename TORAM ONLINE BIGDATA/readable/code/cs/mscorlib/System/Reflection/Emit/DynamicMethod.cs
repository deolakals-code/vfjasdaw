// Assembly: mscorlib.dll
// Namespace: System.Reflection.Emit
public sealed class DynamicMethod : MethodInfo // TypeDefIndex: 10664
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x2F3D310 Offset: 0x2F39310 VA: 0x2F3D310 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x2F3D348 Offset: 0x2F39348 VA: 0x2F3D348 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x2F3D380 Offset: 0x2F39380 VA: 0x2F3D380 Slot: 8
	public override string get_Name() { }

	// RVA: 0x2F3D3B8 Offset: 0x2F393B8 VA: 0x2F3D3B8 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x2F3D3F0 Offset: 0x2F393F0 VA: 0x2F3D3F0 Slot: 32
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x2F3D428 Offset: 0x2F39428 VA: 0x2F3D428 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x2F3D460 Offset: 0x2F39460 VA: 0x2F3D460 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F3D498 Offset: 0x2F39498 VA: 0x2F3D498 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F3D4D0 Offset: 0x2F394D0 VA: 0x2F3D4D0 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x2F3D508 Offset: 0x2F39508 VA: 0x2F3D508 Slot: 43
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x2F3D540 Offset: 0x2F39540 VA: 0x2F3D540 Slot: 31
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x2F3D578 Offset: 0x2F39578 VA: 0x2F3D578 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}
