// Assembly: mscorlib.dll
// Namespace: System.Reflection.Emit
public sealed class EnumBuilder : TypeInfo // TypeDefIndex: 10665
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

	// RVA: 0x2F3D5B0 Offset: 0x2F395B0 VA: 0x2F3D5B0 Slot: 27
	public override Assembly get_Assembly() { }

	// RVA: 0x2F3D5E8 Offset: 0x2F395E8 VA: 0x2F3D5E8 Slot: 25
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x2F3D620 Offset: 0x2F39620 VA: 0x2F3D620 Slot: 112
	public override Type get_BaseType() { }

	// RVA: 0x2F3D658 Offset: 0x2F39658 VA: 0x2F3D658 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x2F3D690 Offset: 0x2F39690 VA: 0x2F3D690 Slot: 28
	public override Module get_Module() { }

	// RVA: 0x2F3D6C8 Offset: 0x2F396C8 VA: 0x2F3D6C8 Slot: 8
	public override string get_Name() { }

	// RVA: 0x2F3D700 Offset: 0x2F39700 VA: 0x2F3D700 Slot: 24
	public override string get_Namespace() { }

	// RVA: 0x2F3D738 Offset: 0x2F39738 VA: 0x2F3D738 Slot: 30
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x2F3D770 Offset: 0x2F39770 VA: 0x2F3D770 Slot: 55
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x2F3D7A8 Offset: 0x2F397A8 VA: 0x2F3D7A8 Slot: 80
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x2F3D7E0 Offset: 0x2F397E0 VA: 0x2F3D7E0 Slot: 82
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x2F3D818 Offset: 0x2F39818 VA: 0x2F3D818 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F3D850 Offset: 0x2F39850 VA: 0x2F3D850 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F3D888 Offset: 0x2F39888 VA: 0x2F3D888 Slot: 46
	public override Type GetElementType() { }

	// RVA: 0x2F3D8C0 Offset: 0x2F398C0 VA: 0x2F3D8C0 Slot: 84
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2F3D8F8 Offset: 0x2F398F8 VA: 0x2F3D8F8 Slot: 86
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2F3D930 Offset: 0x2F39930 VA: 0x2F3D930 Slot: 87
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x2F3D968 Offset: 0x2F39968 VA: 0x2F3D968 Slot: 114
	public override Type[] GetInterfaces() { }

	// RVA: 0x2F3D9A0 Offset: 0x2F399A0 VA: 0x2F3D9A0 Slot: 91
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x2F3D9D8 Offset: 0x2F399D8 VA: 0x2F3D9D8 Slot: 98
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2F3DA10 Offset: 0x2F39A10 VA: 0x2F3DA10 Slot: 100
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x2F3DA48 Offset: 0x2F39A48 VA: 0x2F3DA48 Slot: 101
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2F3DA80 Offset: 0x2F39A80 VA: 0x2F3DA80 Slot: 109
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x2F3DAB8 Offset: 0x2F39AB8 VA: 0x2F3DAB8 Slot: 108
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2F3DAF0 Offset: 0x2F39AF0 VA: 0x2F3DAF0 Slot: 45
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x2F3DB28 Offset: 0x2F39B28 VA: 0x2F3DB28 Slot: 113
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x2F3DB60 Offset: 0x2F39B60 VA: 0x2F3DB60 Slot: 32
	protected override bool IsArrayImpl() { }

	// RVA: 0x2F3DB98 Offset: 0x2F39B98 VA: 0x2F3DB98 Slot: 34
	protected override bool IsByRefImpl() { }

	// RVA: 0x2F3DBD0 Offset: 0x2F39BD0 VA: 0x2F3DBD0 Slot: 65
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x2F3DC08 Offset: 0x2F39C08 VA: 0x2F3DC08 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F3DC40 Offset: 0x2F39C40 VA: 0x2F3DC40 Slot: 36
	protected override bool IsPointerImpl() { }

	// RVA: 0x2F3DC78 Offset: 0x2F39C78 VA: 0x2F3DC78 Slot: 73
	protected override bool IsPrimitiveImpl() { }
}
