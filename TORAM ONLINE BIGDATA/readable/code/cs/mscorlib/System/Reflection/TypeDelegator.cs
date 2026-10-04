// Assembly: mscorlib.dll
// Namespace: System.Reflection
public class TypeDelegator : TypeInfo // TypeDefIndex: 10628
{
	// Fields
	protected Type typeImpl; // 0x18

	// Properties
	public override int MetadataToken { get; }
	public override Module Module { get; }
	public override Assembly Assembly { get; }
	public override RuntimeTypeHandle TypeHandle { get; }
	public override string Name { get; }
	public override string FullName { get; }
	public override string Namespace { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override bool IsSZArray { get; }
	public override bool IsGenericMethodParameter { get; }
	public override bool IsConstructedGenericType { get; }
	public override bool IsCollectible { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x2F2B174 Offset: 0x2F27174 VA: 0x2F2B174
	public void .ctor(Type delegatingType) { }

	// RVA: 0x2F2FE70 Offset: 0x2F2BE70 VA: 0x2F2FE70 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x2F2FE94 Offset: 0x2F2BE94 VA: 0x2F2FE94 Slot: 113
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x2F2FEC0 Offset: 0x2F2BEC0 VA: 0x2F2FEC0 Slot: 28
	public override Module get_Module() { }

	// RVA: 0x2F2FEE4 Offset: 0x2F2BEE4 VA: 0x2F2FEE4 Slot: 27
	public override Assembly get_Assembly() { }

	// RVA: 0x2F2FF08 Offset: 0x2F2BF08 VA: 0x2F2FF08 Slot: 110
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x2F2FF2C Offset: 0x2F2BF2C VA: 0x2F2FF2C Slot: 8
	public override string get_Name() { }

	// RVA: 0x2F2FF4C Offset: 0x2F2BF4C VA: 0x2F2FF4C Slot: 26
	public override string get_FullName() { }

	// RVA: 0x2F2FF70 Offset: 0x2F2BF70 VA: 0x2F2FF70 Slot: 24
	public override string get_Namespace() { }

	// RVA: 0x2F2FF94 Offset: 0x2F2BF94 VA: 0x2F2FF94 Slot: 25
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x2F2FFB8 Offset: 0x2F2BFB8 VA: 0x2F2FFB8 Slot: 112
	public override Type get_BaseType() { }

	// RVA: 0x2F2FFDC Offset: 0x2F2BFDC VA: 0x2F2FFDC Slot: 80
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x2F2FFF8 Offset: 0x2F2BFF8 VA: 0x2F2FFF8 Slot: 82
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x2F3001C Offset: 0x2F2C01C VA: 0x2F3001C Slot: 98
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2F30048 Offset: 0x2F2C048 VA: 0x2F30048 Slot: 100
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x2F3006C Offset: 0x2F2C06C VA: 0x2F3006C Slot: 86
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2F30090 Offset: 0x2F2C090 VA: 0x2F30090 Slot: 87
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x2F300B4 Offset: 0x2F2C0B4 VA: 0x2F300B4 Slot: 114
	public override Type[] GetInterfaces() { }

	// RVA: 0x2F300D8 Offset: 0x2F2C0D8 VA: 0x2F300D8 Slot: 84
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2F300FC Offset: 0x2F2C0FC VA: 0x2F300FC Slot: 108
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2F301F0 Offset: 0x2F2C1F0 VA: 0x2F301F0 Slot: 109
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x2F30214 Offset: 0x2F2C214 VA: 0x2F30214 Slot: 101
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2F30238 Offset: 0x2F2C238 VA: 0x2F30238 Slot: 90
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x2F3025C Offset: 0x2F2C25C VA: 0x2F3025C Slot: 91
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x2F30280 Offset: 0x2F2C280 VA: 0x2F30280 Slot: 55
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x2F3029C Offset: 0x2F2C29C VA: 0x2F3029C Slot: 42
	public override bool get_IsSZArray() { }

	// RVA: 0x2F302C0 Offset: 0x2F2C2C0 VA: 0x2F302C0 Slot: 32
	protected override bool IsArrayImpl() { }

	// RVA: 0x2F302DC Offset: 0x2F2C2DC VA: 0x2F302DC Slot: 73
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x2F302F8 Offset: 0x2F2C2F8 VA: 0x2F302F8 Slot: 34
	protected override bool IsByRefImpl() { }

	// RVA: 0x2F30314 Offset: 0x2F2C314 VA: 0x2F30314 Slot: 39
	public override bool get_IsGenericMethodParameter() { }

	// RVA: 0x2F30338 Offset: 0x2F2C338 VA: 0x2F30338 Slot: 36
	protected override bool IsPointerImpl() { }

	// RVA: 0x2F30354 Offset: 0x2F2C354 VA: 0x2F30354 Slot: 75
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x2F30370 Offset: 0x2F2C370 VA: 0x2F30370 Slot: 65
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x2F3038C Offset: 0x2F2C38C VA: 0x2F3038C Slot: 37
	public override bool get_IsConstructedGenericType() { }

	// RVA: 0x2F303B0 Offset: 0x2F2C3B0 VA: 0x2F303B0 Slot: 68
	public override bool get_IsCollectible() { }

	// RVA: 0x2F303D4 Offset: 0x2F2C3D4 VA: 0x2F303D4 Slot: 46
	public override Type GetElementType() { }

	// RVA: 0x2F303F8 Offset: 0x2F2C3F8 VA: 0x2F303F8 Slot: 45
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x2F30414 Offset: 0x2F2C414 VA: 0x2F30414 Slot: 30
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x2F30438 Offset: 0x2F2C438 VA: 0x2F30438 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F30460 Offset: 0x2F2C460 VA: 0x2F30460 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F30488 Offset: 0x2F2C488 VA: 0x2F30488 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}
