// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public abstract class Type : MemberInfo // TypeDefIndex: 9686
{
	// Fields
	private static Binder s_defaultBinder; // 0x0
	public static readonly char Delimiter; // 0x8
	public static readonly Type[] EmptyTypes; // 0x10
	public static readonly object Missing; // 0x18
	public static readonly MemberFilter FilterAttribute; // 0x20
	public static readonly MemberFilter FilterName; // 0x28
	public static readonly MemberFilter FilterNameIgnoreCase; // 0x30
	private const BindingFlags DefaultLookup = 28;
	internal RuntimeTypeHandle _impl; // 0x10
	internal const string DefaultTypeNameWhenMissingMetadata = "UnknownType";

	// Properties
	public virtual bool IsSerializable { get; }
	public virtual bool ContainsGenericParameters { get; }
	public bool IsVisible { get; }
	public override MemberTypes MemberType { get; }
	public abstract string Namespace { get; }
	public abstract string AssemblyQualifiedName { get; }
	public abstract string FullName { get; }
	public abstract Assembly Assembly { get; }
	public abstract Module Module { get; }
	public bool IsNested { get; }
	public override Type DeclaringType { get; }
	public virtual MethodBase DeclaringMethod { get; }
	public override Type ReflectedType { get; }
	public abstract Type UnderlyingSystemType { get; }
	public bool IsArray { get; }
	public bool IsByRef { get; }
	public bool IsPointer { get; }
	public virtual bool IsConstructedGenericType { get; }
	public virtual bool IsGenericParameter { get; }
	public virtual bool IsGenericMethodParameter { get; }
	public virtual bool IsGenericType { get; }
	public virtual bool IsGenericTypeDefinition { get; }
	public virtual bool IsSZArray { get; }
	public virtual bool IsVariableBoundArray { get; }
	public bool HasElementType { get; }
	public virtual Type[] GenericTypeArguments { get; }
	public virtual int GenericParameterPosition { get; }
	public virtual GenericParameterAttributes GenericParameterAttributes { get; }
	public TypeAttributes Attributes { get; }
	public bool IsAbstract { get; }
	public bool IsSealed { get; }
	public bool IsClass { get; }
	public bool IsNestedAssembly { get; }
	public bool IsNestedPublic { get; }
	public bool IsNotPublic { get; }
	public bool IsPublic { get; }
	public bool IsExplicitLayout { get; }
	public bool IsCOMObject { get; }
	public bool IsContextful { get; }
	public virtual bool IsCollectible { get; }
	public virtual bool IsEnum { get; }
	public bool IsMarshalByRef { get; }
	public bool IsPrimitive { get; }
	public bool IsValueType { get; }
	public virtual bool IsSignatureType { get; }
	public virtual RuntimeTypeHandle TypeHandle { get; }
	public abstract Type BaseType { get; }
	public static Binder DefaultBinder { get; }
	internal virtual bool IsSzArray { get; }
	public bool IsInterface { get; }
	internal string FullNameOrDefault { get; }
	internal string InternalNameIfAvailable { get; }
	internal string NameOrDefault { get; }

	// Methods

	// RVA: 0x2FFD020 Offset: 0x2FF9020 VA: 0x2FFD020 Slot: 16
	public virtual bool IsEnumDefined(object value) { }

	// RVA: 0x2FFD784 Offset: 0x2FF9784 VA: 0x2FFD784 Slot: 17
	public virtual string GetEnumName(object value) { }

	// RVA: 0x2FFD974 Offset: 0x2FF9974 VA: 0x2FFD974 Slot: 18
	public virtual string[] GetEnumNames() { }

	// RVA: 0x2FFD624 Offset: 0x2FF9624 VA: 0x2FFD624
	private Array GetEnumRawConstantValues() { }

	// RVA: 0x2FFDA18 Offset: 0x2FF9A18 VA: 0x2FFDA18
	private void GetEnumData(out string[] enumNames, out Array enumValues) { }

	// RVA: 0x2FFD648 Offset: 0x2FF9648 VA: 0x2FFD648
	private static int BinarySearch(Array array, object value) { }

	// RVA: 0x2FFD3A4 Offset: 0x2FF93A4 VA: 0x2FFD3A4
	internal static bool IsIntegerType(Type t) { }

	// RVA: 0x2FFDFA8 Offset: 0x2FF9FA8 VA: 0x2FFDFA8 Slot: 19
	public virtual bool get_IsSerializable() { }

	// RVA: 0x2FFE17C Offset: 0x2FFA17C VA: 0x2FFE17C Slot: 20
	public virtual bool get_ContainsGenericParameters() { }

	// RVA: 0x2FFE28C Offset: 0x2FFA28C VA: 0x2FFE28C
	internal Type GetRootElementType() { }

	// RVA: 0x2FFE2DC Offset: 0x2FFA2DC VA: 0x2FFE2DC
	public bool get_IsVisible() { }

	[ComVisible(True)]
	// RVA: 0x2FFE50C Offset: 0x2FFA50C VA: 0x2FFE50C Slot: 21
	public virtual bool IsSubclassOf(Type c) { }

	// RVA: 0x2FFE5C8 Offset: 0x2FFA5C8 VA: 0x2FFE5C8 Slot: 22
	public virtual bool IsAssignableFrom(Type c) { }

	// RVA: 0x2FFE840 Offset: 0x2FFA840 VA: 0x2FFE840
	internal bool ImplementInterface(Type ifaceType) { }

	// RVA: 0x2FFE984 Offset: 0x2FFA984 VA: 0x2FFE984
	private static bool FilterAttributeImpl(MemberInfo m, object filterCriteria) { }

	// RVA: 0x2FFECE0 Offset: 0x2FFACE0 VA: 0x2FFECE0
	private static bool FilterNameImpl(MemberInfo m, object filterCriteria) { }

	// RVA: 0x2FFEE5C Offset: 0x2FFAE5C VA: 0x2FFEE5C
	private static bool FilterNameIgnoreCaseImpl(MemberInfo m, object filterCriteria) { }

	// RVA: 0x2FFEFEC Offset: 0x2FFAFEC VA: 0x2FFEFEC
	protected void .ctor() { }

	// RVA: 0x2FFEFF4 Offset: 0x2FFAFF4 VA: 0x2FFEFF4 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x2FFEFFC Offset: 0x2FFAFFC VA: 0x2FFEFFC Slot: 23
	public Type GetType() { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract string get_Namespace();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract string get_AssemblyQualifiedName();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string get_FullName();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract Assembly get_Assembly();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract Module get_Module();

	// RVA: 0x2FFE474 Offset: 0x2FFA474 VA: 0x2FFE474
	public bool get_IsNested() { }

	// RVA: 0x2FFF004 Offset: 0x2FFB004 VA: 0x2FFF004 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x2FFF00C Offset: 0x2FFB00C VA: 0x2FFF00C Slot: 29
	public virtual MethodBase get_DeclaringMethod() { }

	// RVA: 0x2FFF014 Offset: 0x2FFB014 VA: 0x2FFF014 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract Type get_UnderlyingSystemType();

	// RVA: 0x2FFF01C Offset: 0x2FFB01C VA: 0x2FFF01C Slot: 31
	public bool get_IsArray() { }

	// RVA: -1 Offset: -1 Slot: 32
	protected abstract bool IsArrayImpl();

	// RVA: 0x2FFF02C Offset: 0x2FFB02C VA: 0x2FFF02C Slot: 33
	public bool get_IsByRef() { }

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract bool IsByRefImpl();

	// RVA: 0x2FFF03C Offset: 0x2FFB03C VA: 0x2FFF03C Slot: 35
	public bool get_IsPointer() { }

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract bool IsPointerImpl();

	// RVA: 0x2FFF04C Offset: 0x2FFB04C VA: 0x2FFF04C Slot: 37
	public virtual bool get_IsConstructedGenericType() { }

	// RVA: 0x2FFF0C4 Offset: 0x2FFB0C4 VA: 0x2FFF0C4 Slot: 38
	public virtual bool get_IsGenericParameter() { }

	// RVA: 0x2FFF0CC Offset: 0x2FFB0CC VA: 0x2FFF0CC Slot: 39
	public virtual bool get_IsGenericMethodParameter() { }

	// RVA: 0x2FFF118 Offset: 0x2FFB118 VA: 0x2FFF118 Slot: 40
	public virtual bool get_IsGenericType() { }

	// RVA: 0x2FFF120 Offset: 0x2FFB120 VA: 0x2FFF120 Slot: 41
	public virtual bool get_IsGenericTypeDefinition() { }

	// RVA: 0x2FFF128 Offset: 0x2FFB128 VA: 0x2FFF128 Slot: 42
	public virtual bool get_IsSZArray() { }

	// RVA: 0x2FFF14C Offset: 0x2FFB14C VA: 0x2FFF14C Slot: 43
	public virtual bool get_IsVariableBoundArray() { }

	// RVA: 0x2FFE27C Offset: 0x2FFA27C VA: 0x2FFE27C Slot: 44
	public bool get_HasElementType() { }

	// RVA: -1 Offset: -1 Slot: 45
	protected abstract bool HasElementTypeImpl();

	// RVA: -1 Offset: -1 Slot: 46
	public abstract Type GetElementType();

	// RVA: 0x2FFF194 Offset: 0x2FFB194 VA: 0x2FFF194 Slot: 47
	public virtual int GetArrayRank() { }

	// RVA: 0x2FFF1E0 Offset: 0x2FFB1E0 VA: 0x2FFF1E0 Slot: 48
	public virtual Type GetGenericTypeDefinition() { }

	// RVA: 0x2FFF22C Offset: 0x2FFB22C VA: 0x2FFF22C Slot: 49
	public virtual Type[] get_GenericTypeArguments() { }

	// RVA: 0x2FFF308 Offset: 0x2FFB308 VA: 0x2FFF308 Slot: 50
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x2FFF354 Offset: 0x2FFB354 VA: 0x2FFF354 Slot: 51
	public virtual int get_GenericParameterPosition() { }

	// RVA: 0x2FFF3A0 Offset: 0x2FFB3A0 VA: 0x2FFF3A0 Slot: 52
	public virtual GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x2FFF3D8 Offset: 0x2FFB3D8 VA: 0x2FFF3D8 Slot: 53
	public virtual Type[] GetGenericParameterConstraints() { }

	// RVA: 0x2FFF450 Offset: 0x2FFB450 VA: 0x2FFF450 Slot: 54
	public TypeAttributes get_Attributes() { }

	// RVA: -1 Offset: -1 Slot: 55
	protected abstract TypeAttributes GetAttributeFlagsImpl();

	// RVA: 0x2FFF460 Offset: 0x2FFB460 VA: 0x2FFF460 Slot: 56
	public bool get_IsAbstract() { }

	// RVA: 0x2FFF480 Offset: 0x2FFB480 VA: 0x2FFF480 Slot: 57
	public bool get_IsSealed() { }

	// RVA: 0x2FFF4A0 Offset: 0x2FFB4A0 VA: 0x2FFF4A0 Slot: 58
	public bool get_IsClass() { }

	// RVA: 0x2FFF4F8 Offset: 0x2FFB4F8 VA: 0x2FFF4F8 Slot: 59
	public bool get_IsNestedAssembly() { }

	// RVA: 0x2FFE44C Offset: 0x2FFA44C VA: 0x2FFE44C Slot: 60
	public bool get_IsNestedPublic() { }

	// RVA: 0x2FFF520 Offset: 0x2FFB520 VA: 0x2FFF520 Slot: 61
	public bool get_IsNotPublic() { }

	// RVA: 0x2FFE4E4 Offset: 0x2FFA4E4 VA: 0x2FFE4E4 Slot: 62
	public bool get_IsPublic() { }

	// RVA: 0x2FFF544 Offset: 0x2FFB544 VA: 0x2FFF544 Slot: 63
	public bool get_IsExplicitLayout() { }

	// RVA: 0x2FFF56C Offset: 0x2FFB56C VA: 0x2FFF56C Slot: 64
	public bool get_IsCOMObject() { }

	// RVA: -1 Offset: -1 Slot: 65
	protected abstract bool IsCOMObjectImpl();

	// RVA: 0x2FFF57C Offset: 0x2FFB57C VA: 0x2FFF57C Slot: 66
	public bool get_IsContextful() { }

	// RVA: 0x2FFF58C Offset: 0x2FFB58C VA: 0x2FFF58C Slot: 67
	protected virtual bool IsContextfulImpl() { }

	// RVA: 0x2FFF61C Offset: 0x2FFB61C VA: 0x2FFF61C Slot: 68
	public virtual bool get_IsCollectible() { }

	// RVA: 0x2FFF624 Offset: 0x2FFB624 VA: 0x2FFF624 Slot: 69
	public virtual bool get_IsEnum() { }

	// RVA: 0x2FFF6B0 Offset: 0x2FFB6B0 VA: 0x2FFF6B0 Slot: 70
	public bool get_IsMarshalByRef() { }

	// RVA: 0x2FFF6C0 Offset: 0x2FFB6C0 VA: 0x2FFF6C0 Slot: 71
	protected virtual bool IsMarshalByRefImpl() { }

	// RVA: 0x2FFF750 Offset: 0x2FFB750 VA: 0x2FFF750 Slot: 72
	public bool get_IsPrimitive() { }

	// RVA: -1 Offset: -1 Slot: 73
	protected abstract bool IsPrimitiveImpl();

	// RVA: 0x2FFF4E8 Offset: 0x2FFB4E8 VA: 0x2FFF4E8 Slot: 74
	public bool get_IsValueType() { }

	// RVA: 0x2FFF760 Offset: 0x2FFB760 VA: 0x2FFF760 Slot: 75
	protected virtual bool IsValueTypeImpl() { }

	// RVA: 0x2FFF7EC Offset: 0x2FFB7EC VA: 0x2FFF7EC Slot: 76
	public virtual bool get_IsSignatureType() { }

	[ComVisible(True)]
	// RVA: 0x2FFF7F4 Offset: 0x2FFB7F4 VA: 0x2FFF7F4 Slot: 77
	public ConstructorInfo GetConstructor(Type[] types) { }

	[ComVisible(True)]
	// RVA: 0x2FFF80C Offset: 0x2FFB80C VA: 0x2FFF80C Slot: 78
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x2FFF81C Offset: 0x2FFB81C VA: 0x2FFF81C Slot: 79
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: -1 Offset: -1 Slot: 80
	protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	[ComVisible(True)]
	// RVA: 0x2FFF948 Offset: 0x2FFB948 VA: 0x2FFF948 Slot: 81
	public ConstructorInfo[] GetConstructors() { }

	[ComVisible(True)]
	// RVA: -1 Offset: -1 Slot: 82
	public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

	// RVA: 0x2FFF95C Offset: 0x2FFB95C VA: 0x2FFF95C Slot: 83
	public EventInfo GetEvent(string name) { }

	// RVA: -1 Offset: -1 Slot: 84
	public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr);

	// RVA: 0x2FFF970 Offset: 0x2FFB970 VA: 0x2FFF970 Slot: 85
	public FieldInfo GetField(string name) { }

	// RVA: -1 Offset: -1 Slot: 86
	public abstract FieldInfo GetField(string name, BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 87
	public abstract FieldInfo[] GetFields(BindingFlags bindingAttr);

	// RVA: 0x2FFF984 Offset: 0x2FFB984 VA: 0x2FFF984 Slot: 88
	public MemberInfo[] GetMember(string name) { }

	// RVA: 0x2FFF998 Offset: 0x2FFB998 VA: 0x2FFF998 Slot: 89
	public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2FFF9B0 Offset: 0x2FFB9B0 VA: 0x2FFF9B0 Slot: 90
	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: -1 Offset: -1 Slot: 91
	public abstract MemberInfo[] GetMembers(BindingFlags bindingAttr);

	// RVA: 0x2FFF9FC Offset: 0x2FFB9FC VA: 0x2FFF9FC Slot: 92
	public MethodInfo GetMethod(string name) { }

	// RVA: 0x2FFFA04 Offset: 0x2FFBA04 VA: 0x2FFFA04 Slot: 93
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2FFFA78 Offset: 0x2FFBA78 VA: 0x2FFFA78 Slot: 94
	public MethodInfo GetMethod(string name, Type[] types) { }

	// RVA: 0x2FFFA90 Offset: 0x2FFBA90 VA: 0x2FFFA90 Slot: 95
	public MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2FFFAA8 Offset: 0x2FFBAA8 VA: 0x2FFFAA8 Slot: 96
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2FFFAB8 Offset: 0x2FFBAB8 VA: 0x2FFFAB8 Slot: 97
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: -1 Offset: -1 Slot: 98
	protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	// RVA: 0x2FFFC10 Offset: 0x2FFBC10 VA: 0x2FFFC10 Slot: 99
	public MethodInfo[] GetMethods() { }

	// RVA: -1 Offset: -1 Slot: 100
	public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 101
	public abstract Type GetNestedType(string name, BindingFlags bindingAttr);

	// RVA: 0x2FFFC24 Offset: 0x2FFBC24 VA: 0x2FFFC24 Slot: 102
	public PropertyInfo GetProperty(string name) { }

	// RVA: 0x2FFFC2C Offset: 0x2FFBC2C VA: 0x2FFFC2C Slot: 103
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2FFFCA0 Offset: 0x2FFBCA0 VA: 0x2FFFCA0 Slot: 104
	public PropertyInfo GetProperty(string name, Type returnType) { }

	// RVA: 0x2FFFD98 Offset: 0x2FFBD98 VA: 0x2FFFD98 Slot: 105
	public PropertyInfo GetProperty(string name, Type returnType, Type[] types) { }

	// RVA: 0x2FFFDB0 Offset: 0x2FFBDB0 VA: 0x2FFFDB0 Slot: 106
	public PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2FFFDC8 Offset: 0x2FFBDC8 VA: 0x2FFFDC8 Slot: 107
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: -1 Offset: -1 Slot: 108
	protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);

	// RVA: -1 Offset: -1 Slot: 109
	public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr);

	// RVA: 0x2FFFE50 Offset: 0x2FFBE50 VA: 0x2FFFE50 Slot: 110
	public virtual RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x2FFFE88 Offset: 0x2FFBE88 VA: 0x2FFFE88
	public static RuntimeTypeHandle GetTypeHandle(object o) { }

	// RVA: 0x2FFFF00 Offset: 0x2FFBF00 VA: 0x2FFFF00
	public static TypeCode GetTypeCode(Type type) { }

	// RVA: 0x2FFFF78 Offset: 0x2FFBF78 VA: 0x2FFFF78 Slot: 111
	protected virtual TypeCode GetTypeCodeImpl() { }

	// RVA: -1 Offset: -1 Slot: 112
	public abstract Type get_BaseType();

	// RVA: -1 Offset: -1 Slot: 113
	public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);

	// RVA: -1 Offset: -1 Slot: 114
	public abstract Type[] GetInterfaces();

	// RVA: 0x3000060 Offset: 0x2FFC060 VA: 0x3000060 Slot: 115
	public virtual bool IsInstanceOfType(object o) { }

	// RVA: 0x300009C Offset: 0x2FFC09C VA: 0x300009C Slot: 116
	public virtual bool IsEquivalentTo(Type other) { }

	// RVA: 0x3000100 Offset: 0x2FFC100 VA: 0x3000100 Slot: 117
	public virtual Type GetEnumUnderlyingType() { }

	// RVA: 0x30001E8 Offset: 0x2FFC1E8 VA: 0x30001E8 Slot: 118
	public virtual Array GetEnumValues() { }

	// RVA: 0x300026C Offset: 0x2FFC26C VA: 0x300026C Slot: 119
	public virtual Type MakeArrayType() { }

	// RVA: 0x30002A4 Offset: 0x2FFC2A4 VA: 0x30002A4 Slot: 120
	public virtual Type MakeArrayType(int rank) { }

	// RVA: 0x30002DC Offset: 0x2FFC2DC VA: 0x30002DC Slot: 121
	public virtual Type MakeByRefType() { }

	// RVA: 0x3000314 Offset: 0x2FFC314 VA: 0x3000314 Slot: 122
	public virtual Type MakeGenericType(Type[] typeArguments) { }

	// RVA: 0x3000360 Offset: 0x2FFC360 VA: 0x3000360 Slot: 123
	public virtual Type MakePointerType() { }

	// RVA: 0x3000398 Offset: 0x2FFC398 VA: 0x3000398
	public static Type MakeGenericSignatureType(Type genericTypeDefinition, Type[] typeArguments) { }

	// RVA: 0x3000404 Offset: 0x2FFC404 VA: 0x3000404 Slot: 3
	public override string ToString() { }

	// RVA: 0x3000464 Offset: 0x2FFC464 VA: 0x3000464 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x3000500 Offset: 0x2FFC500 VA: 0x3000500 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3000548 Offset: 0x2FFC548 VA: 0x3000548 Slot: 124
	public virtual bool Equals(Type o) { }

	// RVA: 0x30005E8 Offset: 0x2FFC5E8 VA: 0x30005E8
	public static Binder get_DefaultBinder() { }

	// RVA: 0x2FF4480 Offset: 0x2FF0480 VA: 0x2FF4480
	public static Type GetTypeFromHandle(RuntimeTypeHandle handle) { }

	// RVA: 0x30006B8 Offset: 0x2FFC6B8 VA: 0x30006B8
	private static Type internal_from_handle(IntPtr handle) { }

	// RVA: 0x30006BC Offset: 0x2FFC6BC VA: 0x30006BC Slot: 125
	internal virtual bool get_IsSzArray() { }

	// RVA: 0x30006C4 Offset: 0x2FFC6C4 VA: 0x30006C4
	internal string FormatTypeName() { }

	// RVA: 0x30006D8 Offset: 0x2FFC6D8 VA: 0x30006D8 Slot: 126
	internal virtual string FormatTypeName(bool serialization) { }

	// RVA: 0x2FFE77C Offset: 0x2FFA77C VA: 0x2FFE77C Slot: 127
	public bool get_IsInterface() { }

	// RVA: 0x3000710 Offset: 0x2FFC710 VA: 0x3000710
	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x300079C Offset: 0x2FFC79C VA: 0x300079C
	public static Type GetType(string typeName, bool throwOnError) { }

	// RVA: 0x300081C Offset: 0x2FFC81C VA: 0x300081C
	public static Type GetType(string typeName) { }

	// RVA: 0x3000898 Offset: 0x2FFC898 VA: 0x3000898
	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError) { }

	// RVA: 0x2FFD398 Offset: 0x2FF9398 VA: 0x2FFD398
	public static bool op_Equality(Type left, Type right) { }

	// RVA: 0x2FFE170 Offset: 0x2FFA170 VA: 0x2FFE170
	public static bool op_Inequality(Type left, Type right) { }

	// RVA: 0x30008C0 Offset: 0x2FFC8C0 VA: 0x30008C0
	internal string get_FullNameOrDefault() { }

	// RVA: 0x2FFE0E4 Offset: 0x2FFA0E4 VA: 0x2FFE0E4
	internal bool IsRuntimeImplemented() { }

	// RVA: 0x30009DC Offset: 0x2FFC9DC VA: 0x30009DC Slot: 128
	internal virtual string InternalGetNameIfAvailable(ref Type rootCauseForFailure) { }

	// RVA: 0x30009B8 Offset: 0x2FFC9B8 VA: 0x30009B8
	internal string get_InternalNameIfAvailable() { }

	// RVA: 0x30009E8 Offset: 0x2FFC9E8 VA: 0x30009E8
	internal string get_NameOrDefault() { }

	// RVA: 0x3000A58 Offset: 0x2FFCA58 VA: 0x3000A58
	private static void .cctor() { }
}
