// Assembly: mscorlib.dll
// Namespace: System.Reflection
internal abstract class SignatureType : Type // TypeDefIndex: 10622
{
	// Properties
	public sealed override bool IsSignatureType { get; }
	public abstract override bool IsSZArray { get; }
	public abstract override bool IsVariableBoundArray { get; }
	public sealed override bool IsGenericType { get; }
	public abstract override bool IsGenericTypeDefinition { get; }
	public abstract override bool IsConstructedGenericType { get; }
	public abstract override bool IsGenericParameter { get; }
	public abstract override bool IsGenericMethodParameter { get; }
	public abstract override bool ContainsGenericParameters { get; }
	public sealed override MemberTypes MemberType { get; }
	public abstract override Type[] GenericTypeArguments { get; }
	public abstract override int GenericParameterPosition { get; }
	internal abstract SignatureType ElementType { get; }
	public sealed override Type UnderlyingSystemType { get; }
	public abstract override string Name { get; }
	public abstract override string Namespace { get; }
	public sealed override string FullName { get; }
	public sealed override string AssemblyQualifiedName { get; }
	public sealed override Assembly Assembly { get; }
	public sealed override Module Module { get; }
	public sealed override Type ReflectedType { get; }
	public sealed override Type BaseType { get; }
	public sealed override int MetadataToken { get; }
	public sealed override Type DeclaringType { get; }
	public sealed override MethodBase DeclaringMethod { get; }
	public sealed override GenericParameterAttributes GenericParameterAttributes { get; }
	public sealed override bool IsEnum { get; }
	public sealed override bool IsSerializable { get; }
	public sealed override RuntimeTypeHandle TypeHandle { get; }

	// Methods

	// RVA: 0x2F2E0BC Offset: 0x2F2A0BC VA: 0x2F2E0BC Slot: 76
	public sealed override bool get_IsSignatureType() { }

	// RVA: -1 Offset: -1 Slot: 45
	protected abstract override bool HasElementTypeImpl();

	// RVA: -1 Offset: -1 Slot: 32
	protected abstract override bool IsArrayImpl();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract override bool get_IsSZArray();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract override bool get_IsVariableBoundArray();

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract override bool IsByRefImpl();

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract override bool IsPointerImpl();

	// RVA: 0x2F2E0C4 Offset: 0x2F2A0C4 VA: 0x2F2E0C4 Slot: 40
	public sealed override bool get_IsGenericType() { }

	// RVA: -1 Offset: -1 Slot: 41
	public abstract override bool get_IsGenericTypeDefinition();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract override bool get_IsConstructedGenericType();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract override bool get_IsGenericParameter();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract override bool get_IsGenericMethodParameter();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract override bool get_ContainsGenericParameters();

	// RVA: 0x2F2E104 Offset: 0x2F2A104 VA: 0x2F2E104 Slot: 7
	public sealed override MemberTypes get_MemberType() { }

	// RVA: 0x2F2E10C Offset: 0x2F2A10C VA: 0x2F2E10C Slot: 119
	public sealed override Type MakeArrayType() { }

	// RVA: 0x2F2E17C Offset: 0x2F2A17C VA: 0x2F2E17C Slot: 120
	public sealed override Type MakeArrayType(int rank) { }

	// RVA: 0x2F2E22C Offset: 0x2F2A22C VA: 0x2F2E22C Slot: 121
	public sealed override Type MakeByRefType() { }

	// RVA: 0x2F2E290 Offset: 0x2F2A290 VA: 0x2F2E290 Slot: 123
	public sealed override Type MakePointerType() { }

	// RVA: 0x2F2E2F4 Offset: 0x2F2A2F4 VA: 0x2F2E2F4 Slot: 122
	public sealed override Type MakeGenericType(Type[] typeArguments) { }

	// RVA: 0x2F2E340 Offset: 0x2F2A340 VA: 0x2F2E340 Slot: 46
	public sealed override Type GetElementType() { }

	// RVA: -1 Offset: -1 Slot: 47
	public abstract override int GetArrayRank();

	// RVA: -1 Offset: -1 Slot: 48
	public abstract override Type GetGenericTypeDefinition();

	// RVA: -1 Offset: -1 Slot: 49
	public abstract override Type[] get_GenericTypeArguments();

	// RVA: -1 Offset: -1 Slot: 50
	public abstract override Type[] GetGenericArguments();

	// RVA: -1 Offset: -1 Slot: 51
	public abstract override int get_GenericParameterPosition();

	// RVA: -1 Offset: -1 Slot: 129
	internal abstract SignatureType get_ElementType();

	// RVA: 0x2F2E350 Offset: 0x2F2A350 VA: 0x2F2E350 Slot: 30
	public sealed override Type get_UnderlyingSystemType() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract override string get_Name();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract override string get_Namespace();

	// RVA: 0x2F2E354 Offset: 0x2F2A354 VA: 0x2F2E354 Slot: 26
	public sealed override string get_FullName() { }

	// RVA: 0x2F2E35C Offset: 0x2F2A35C VA: 0x2F2E35C Slot: 25
	public sealed override string get_AssemblyQualifiedName() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract override string ToString();

	// RVA: 0x2F2E364 Offset: 0x2F2A364 VA: 0x2F2E364 Slot: 27
	public sealed override Assembly get_Assembly() { }

	// RVA: 0x2F2E3B0 Offset: 0x2F2A3B0 VA: 0x2F2E3B0 Slot: 28
	public sealed override Module get_Module() { }

	// RVA: 0x2F2E3FC Offset: 0x2F2A3FC VA: 0x2F2E3FC Slot: 10
	public sealed override Type get_ReflectedType() { }

	// RVA: 0x2F2E448 Offset: 0x2F2A448 VA: 0x2F2E448 Slot: 112
	public sealed override Type get_BaseType() { }

	// RVA: 0x2F2E494 Offset: 0x2F2A494 VA: 0x2F2E494 Slot: 114
	public sealed override Type[] GetInterfaces() { }

	// RVA: 0x2F2E4E0 Offset: 0x2F2A4E0 VA: 0x2F2E4E0 Slot: 22
	public sealed override bool IsAssignableFrom(Type c) { }

	// RVA: 0x2F2E52C Offset: 0x2F2A52C VA: 0x2F2E52C Slot: 15
	public sealed override int get_MetadataToken() { }

	// RVA: 0x2F2E578 Offset: 0x2F2A578 VA: 0x2F2E578 Slot: 9
	public sealed override Type get_DeclaringType() { }

	// RVA: 0x2F2E5C4 Offset: 0x2F2A5C4 VA: 0x2F2E5C4 Slot: 29
	public sealed override MethodBase get_DeclaringMethod() { }

	// RVA: 0x2F2E610 Offset: 0x2F2A610 VA: 0x2F2E610 Slot: 53
	public sealed override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x2F2E65C Offset: 0x2F2A65C VA: 0x2F2E65C Slot: 52
	public sealed override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x2F2E6A8 Offset: 0x2F2A6A8 VA: 0x2F2E6A8 Slot: 16
	public sealed override bool IsEnumDefined(object value) { }

	// RVA: 0x2F2E6F4 Offset: 0x2F2A6F4 VA: 0x2F2E6F4 Slot: 17
	public sealed override string GetEnumName(object value) { }

	// RVA: 0x2F2E740 Offset: 0x2F2A740 VA: 0x2F2E740 Slot: 18
	public sealed override string[] GetEnumNames() { }

	// RVA: 0x2F2E78C Offset: 0x2F2A78C VA: 0x2F2E78C Slot: 117
	public sealed override Type GetEnumUnderlyingType() { }

	// RVA: 0x2F2E7D8 Offset: 0x2F2A7D8 VA: 0x2F2E7D8 Slot: 118
	public sealed override Array GetEnumValues() { }

	// RVA: 0x2F2E824 Offset: 0x2F2A824 VA: 0x2F2E824 Slot: 111
	protected sealed override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x2F2E870 Offset: 0x2F2A870 VA: 0x2F2E870 Slot: 55
	protected sealed override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x2F2E8BC Offset: 0x2F2A8BC VA: 0x2F2E8BC Slot: 82
	public sealed override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x2F2E908 Offset: 0x2F2A908 VA: 0x2F2E908 Slot: 84
	public sealed override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2F2E954 Offset: 0x2F2A954 VA: 0x2F2E954 Slot: 86
	public sealed override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2F2E9A0 Offset: 0x2F2A9A0 VA: 0x2F2E9A0 Slot: 87
	public sealed override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x2F2E9EC Offset: 0x2F2A9EC VA: 0x2F2E9EC Slot: 91
	public sealed override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x2F2EA38 Offset: 0x2F2AA38 VA: 0x2F2EA38 Slot: 100
	public sealed override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x2F2EA84 Offset: 0x2F2AA84 VA: 0x2F2EA84 Slot: 101
	public sealed override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2F2EAD0 Offset: 0x2F2AAD0 VA: 0x2F2EAD0 Slot: 109
	public sealed override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x2F2EB1C Offset: 0x2F2AB1C VA: 0x2F2EB1C Slot: 113
	public sealed override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x2F2EB68 Offset: 0x2F2AB68 VA: 0x2F2EB68 Slot: 98
	protected sealed override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2F2EBB4 Offset: 0x2F2ABB4 VA: 0x2F2EBB4 Slot: 108
	protected sealed override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2F2EC00 Offset: 0x2F2AC00 VA: 0x2F2EC00 Slot: 89
	public sealed override MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2F2EC4C Offset: 0x2F2AC4C VA: 0x2F2EC4C Slot: 90
	public sealed override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x2F2EC98 Offset: 0x2F2AC98 VA: 0x2F2EC98 Slot: 13
	public sealed override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F2ECE4 Offset: 0x2F2ACE4 VA: 0x2F2ECE4 Slot: 14
	public sealed override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F2ED30 Offset: 0x2F2AD30 VA: 0x2F2ED30 Slot: 12
	public sealed override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F2ED7C Offset: 0x2F2AD7C VA: 0x2F2ED7C Slot: 80
	protected sealed override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2F2EDC8 Offset: 0x2F2ADC8 VA: 0x2F2EDC8 Slot: 65
	protected sealed override bool IsCOMObjectImpl() { }

	// RVA: 0x2F2EE14 Offset: 0x2F2AE14 VA: 0x2F2EE14 Slot: 73
	protected sealed override bool IsPrimitiveImpl() { }

	// RVA: 0x2F2EE60 Offset: 0x2F2AE60 VA: 0x2F2EE60 Slot: 67
	protected sealed override bool IsContextfulImpl() { }

	// RVA: 0x2F2EEAC Offset: 0x2F2AEAC VA: 0x2F2EEAC Slot: 69
	public sealed override bool get_IsEnum() { }

	// RVA: 0x2F2EEF8 Offset: 0x2F2AEF8 VA: 0x2F2EEF8 Slot: 116
	public sealed override bool IsEquivalentTo(Type other) { }

	// RVA: 0x2F2EF44 Offset: 0x2F2AF44 VA: 0x2F2EF44 Slot: 115
	public sealed override bool IsInstanceOfType(object o) { }

	// RVA: 0x2F2EF90 Offset: 0x2F2AF90 VA: 0x2F2EF90 Slot: 71
	protected sealed override bool IsMarshalByRefImpl() { }

	// RVA: 0x2F2EFDC Offset: 0x2F2AFDC VA: 0x2F2EFDC Slot: 19
	public sealed override bool get_IsSerializable() { }

	// RVA: 0x2F2F028 Offset: 0x2F2B028 VA: 0x2F2F028 Slot: 21
	public sealed override bool IsSubclassOf(Type c) { }

	// RVA: 0x2F2F074 Offset: 0x2F2B074 VA: 0x2F2F074 Slot: 75
	protected sealed override bool IsValueTypeImpl() { }

	// RVA: 0x2F2F0C0 Offset: 0x2F2B0C0 VA: 0x2F2F0C0 Slot: 110
	public sealed override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x2F2D958 Offset: 0x2F29958 VA: 0x2F2D958
	protected void .ctor() { }
}
