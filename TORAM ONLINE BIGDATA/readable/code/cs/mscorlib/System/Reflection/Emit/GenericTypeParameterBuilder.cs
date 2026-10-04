// Assembly: mscorlib.dll
// Namespace: System.Reflection.Emit
public sealed class GenericTypeParameterBuilder : TypeInfo // TypeDefIndex: 10668
{
	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x2F3DD38 Offset: 0x2F39D38 VA: 0x2F3DD38 Slot: 27
	public override Assembly get_Assembly() { }

	// RVA: 0x2F3DD70 Offset: 0x2F39D70 VA: 0x2F3DD70 Slot: 25
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x2F3DDA8 Offset: 0x2F39DA8 VA: 0x2F3DDA8 Slot: 112
	public override Type get_BaseType() { }

	// RVA: 0x2F3DDE0 Offset: 0x2F39DE0 VA: 0x2F3DDE0 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x2F3DE18 Offset: 0x2F39E18 VA: 0x2F3DE18 Slot: 28
	public override Module get_Module() { }

	// RVA: 0x2F3DE50 Offset: 0x2F39E50 VA: 0x2F3DE50 Slot: 8
	public override string get_Name() { }

	// RVA: 0x2F3DE88 Offset: 0x2F39E88 VA: 0x2F3DE88 Slot: 24
	public override string get_Namespace() { }

	// RVA: 0x2F3DEC0 Offset: 0x2F39EC0 VA: 0x2F3DEC0 Slot: 30
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x2F3DEF8 Offset: 0x2F39EF8 VA: 0x2F3DEF8 Slot: 55
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x2F3DF30 Offset: 0x2F39F30 VA: 0x2F3DF30 Slot: 80
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x2F3DF68 Offset: 0x2F39F68 VA: 0x2F3DF68 Slot: 82
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x2F3DFA0 Offset: 0x2F39FA0 VA: 0x2F3DFA0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F3DFD8 Offset: 0x2F39FD8 VA: 0x2F3DFD8 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F3E010 Offset: 0x2F3A010 VA: 0x2F3E010 Slot: 46
	public override Type GetElementType() { }

	// RVA: 0x2F3E048 Offset: 0x2F3A048 VA: 0x2F3E048 Slot: 84
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2F3E080 Offset: 0x2F3A080 VA: 0x2F3E080 Slot: 86
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2F3E0B8 Offset: 0x2F3A0B8 VA: 0x2F3E0B8 Slot: 87
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x2F3E0F0 Offset: 0x2F3A0F0 VA: 0x2F3E0F0 Slot: 114
	public override Type[] GetInterfaces() { }

	// RVA: 0x2F3E128 Offset: 0x2F3A128 VA: 0x2F3E128 Slot: 91
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x2F3E160 Offset: 0x2F3A160 VA: 0x2F3E160 Slot: 98
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2F3E198 Offset: 0x2F3A198 VA: 0x2F3E198 Slot: 100
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x2F3E1D0 Offset: 0x2F3A1D0 VA: 0x2F3E1D0 Slot: 101
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2F3E208 Offset: 0x2F3A208 VA: 0x2F3E208 Slot: 109
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x2F3E240 Offset: 0x2F3A240 VA: 0x2F3E240 Slot: 108
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2F3E278 Offset: 0x2F3A278 VA: 0x2F3E278 Slot: 45
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x2F3E2B0 Offset: 0x2F3A2B0 VA: 0x2F3E2B0 Slot: 113
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x2F3E2E8 Offset: 0x2F3A2E8 VA: 0x2F3E2E8 Slot: 32
	protected override bool IsArrayImpl() { }

	// RVA: 0x2F3E320 Offset: 0x2F3A320 VA: 0x2F3E320 Slot: 34
	protected override bool IsByRefImpl() { }

	// RVA: 0x2F3E358 Offset: 0x2F3A358 VA: 0x2F3E358 Slot: 65
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x2F3E390 Offset: 0x2F3A390 VA: 0x2F3E390 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F3E3C8 Offset: 0x2F3A3C8 VA: 0x2F3E3C8 Slot: 36
	protected override bool IsPointerImpl() { }

	// RVA: 0x2F3E400 Offset: 0x2F3A400 VA: 0x2F3E400 Slot: 73
	protected override bool IsPrimitiveImpl() { }
}
