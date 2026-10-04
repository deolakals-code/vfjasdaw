// Assembly: mscorlib.dll
// Namespace: System.Reflection.Emit
public sealed class TypeBuilder : TypeInfo // TypeDefIndex: 10676
{
	// Fields
	public const int UnspecifiedTypeSize = 0;

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

	// RVA: 0x2F3E9E8 Offset: 0x2F3A9E8 VA: 0x2F3E9E8 Slot: 27
	public override Assembly get_Assembly() { }

	// RVA: 0x2F3EA20 Offset: 0x2F3AA20 VA: 0x2F3EA20 Slot: 25
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x2F3EA58 Offset: 0x2F3AA58 VA: 0x2F3EA58 Slot: 112
	public override Type get_BaseType() { }

	// RVA: 0x2F3EA90 Offset: 0x2F3AA90 VA: 0x2F3EA90 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x2F3EAC8 Offset: 0x2F3AAC8 VA: 0x2F3EAC8 Slot: 28
	public override Module get_Module() { }

	// RVA: 0x2F3EB00 Offset: 0x2F3AB00 VA: 0x2F3EB00 Slot: 8
	public override string get_Name() { }

	// RVA: 0x2F3EB38 Offset: 0x2F3AB38 VA: 0x2F3EB38 Slot: 24
	public override string get_Namespace() { }

	// RVA: 0x2F3EB70 Offset: 0x2F3AB70 VA: 0x2F3EB70 Slot: 30
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x2F3EBA8 Offset: 0x2F3ABA8 VA: 0x2F3EBA8 Slot: 55
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x2F3EBE0 Offset: 0x2F3ABE0 VA: 0x2F3EBE0 Slot: 80
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x2F3EC18 Offset: 0x2F3AC18 VA: 0x2F3EC18 Slot: 82
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x2F3EC50 Offset: 0x2F3AC50 VA: 0x2F3EC50 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F3EC88 Offset: 0x2F3AC88 VA: 0x2F3EC88 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F3ECC0 Offset: 0x2F3ACC0 VA: 0x2F3ECC0 Slot: 46
	public override Type GetElementType() { }

	// RVA: 0x2F3ECF8 Offset: 0x2F3ACF8 VA: 0x2F3ECF8 Slot: 84
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2F3ED30 Offset: 0x2F3AD30 VA: 0x2F3ED30 Slot: 86
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2F3ED68 Offset: 0x2F3AD68 VA: 0x2F3ED68 Slot: 87
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x2F3EDA0 Offset: 0x2F3ADA0 VA: 0x2F3EDA0 Slot: 114
	public override Type[] GetInterfaces() { }

	// RVA: 0x2F3EDD8 Offset: 0x2F3ADD8 VA: 0x2F3EDD8 Slot: 91
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x2F3EE10 Offset: 0x2F3AE10 VA: 0x2F3EE10 Slot: 98
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2F3EE48 Offset: 0x2F3AE48 VA: 0x2F3EE48 Slot: 100
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x2F3EE80 Offset: 0x2F3AE80 VA: 0x2F3EE80 Slot: 101
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2F3EEB8 Offset: 0x2F3AEB8 VA: 0x2F3EEB8 Slot: 109
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x2F3EEF0 Offset: 0x2F3AEF0 VA: 0x2F3EEF0 Slot: 108
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2F3EF28 Offset: 0x2F3AF28 VA: 0x2F3EF28 Slot: 45
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x2F3EF60 Offset: 0x2F3AF60 VA: 0x2F3EF60 Slot: 113
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x2F3EF98 Offset: 0x2F3AF98 VA: 0x2F3EF98 Slot: 32
	protected override bool IsArrayImpl() { }

	// RVA: 0x2F3EFD0 Offset: 0x2F3AFD0 VA: 0x2F3EFD0 Slot: 34
	protected override bool IsByRefImpl() { }

	// RVA: 0x2F3F008 Offset: 0x2F3B008 VA: 0x2F3F008 Slot: 65
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x2F3F040 Offset: 0x2F3B040 VA: 0x2F3F040 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F3F078 Offset: 0x2F3B078 VA: 0x2F3F078 Slot: 36
	protected override bool IsPointerImpl() { }

	// RVA: 0x2F3F0B0 Offset: 0x2F3B0B0 VA: 0x2F3F0B0 Slot: 73
	protected override bool IsPrimitiveImpl() { }
}
