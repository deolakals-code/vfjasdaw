// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
internal class RuntimeType : TypeInfo, ISerializable, ICloneable // TypeDefIndex: 9761
{
	// Fields
	internal static readonly RuntimeType ValueType; // 0x0
	internal static readonly RuntimeType EnumType; // 0x8
	private static readonly RuntimeType ObjectType; // 0x10
	private static readonly RuntimeType StringType; // 0x18
	private static readonly RuntimeType DelegateType; // 0x20
	private static Type[] s_SICtorParamTypes; // 0x28
	internal static Func<Type, Type[], Type> MakeTypeBuilderInstantiation; // 0x30
	private const BindingFlags MemberBindingMask = 255;
	private const BindingFlags InvocationMask = 65280;
	private const BindingFlags BinderNonCreateInstance = 15616;
	private const BindingFlags BinderGetSetProperty = 12288;
	private const BindingFlags BinderSetInvokeProperty = 8448;
	private const BindingFlags BinderGetSetField = 3072;
	private const BindingFlags BinderSetInvokeField = 2304;
	private const BindingFlags BinderNonFieldGetSet = 16773888;
	private const BindingFlags ClassicBindingMask = 61696;
	private static RuntimeType s_typedRef; // 0x38
	private MonoTypeInfo type_info; // 0x18
	internal object GenericCache; // 0x20
	private RuntimeConstructorInfo m_serializationCtor; // 0x28
	private const int GenericParameterCountAny = -1;

	// Properties
	public override Module Module { get; }
	public override Assembly Assembly { get; }
	public override RuntimeTypeHandle TypeHandle { get; }
	public override Type BaseType { get; }
	public override Type UnderlyingSystemType { get; }
	public override bool IsEnum { get; }
	public override GenericParameterAttributes GenericParameterAttributes { get; }
	internal override bool IsSzArray { get; }
	public override bool IsGenericTypeDefinition { get; }
	public override bool IsGenericParameter { get; }
	public override int GenericParameterPosition { get; }
	public override bool IsGenericType { get; }
	public override bool IsConstructedGenericType { get; }
	public override MemberTypes MemberType { get; }
	public override Type ReflectedType { get; }
	public override int MetadataToken { get; }
	public override bool ContainsGenericParameters { get; }
	public override MethodBase DeclaringMethod { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override string FullName { get; }
	public override bool IsSZArray { get; }

	// Methods

	// RVA: 0x301E1E8 Offset: 0x301A1E8 VA: 0x301E1E8
	internal static RuntimeType GetType(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark) { }

	// RVA: 0x301E250 Offset: 0x301A250 VA: 0x301E250
	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	// RVA: 0x301E3AC Offset: 0x301A3AC VA: 0x301E3AC
	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	// RVA: 0x301E5C0 Offset: 0x301A5C0 VA: 0x301E5C0
	private static void SplitName(string fullname, out string name, out string ns) { }

	// RVA: 0x301E6F8 Offset: 0x301A6F8 VA: 0x301E6F8
	internal static BindingFlags FilterPreCalculate(bool isPublic, bool isInherited, bool isStatic) { }

	// RVA: 0x301E734 Offset: 0x301A734 VA: 0x301E734
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x301E86C Offset: 0x301A86C VA: 0x301E86C
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x301E8F8 Offset: 0x301A8F8 VA: 0x301E8F8
	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	// RVA: 0x301E958 Offset: 0x301A958 VA: 0x301E958
	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	// RVA: 0x301EB44 Offset: 0x301AB44 VA: 0x301EB44
	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	// RVA: 0x301EC5C Offset: 0x301AC5C VA: 0x301EC5C
	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x301EF3C Offset: 0x301AF3C VA: 0x301EF3C
	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x301ECE4 Offset: 0x301ACE4 VA: 0x301ECE4
	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x301EFC4 Offset: 0x301AFC4 VA: 0x301EFC4
	internal void .ctor() { }

	// RVA: 0x301F004 Offset: 0x301B004 VA: 0x301F004
	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, int genericParamCount, bool allowPrefixLookup) { }

	// RVA: 0x301F55C Offset: 0x301B55C VA: 0x301F55C
	private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x301FA2C Offset: 0x301BA2C VA: 0x301FA2C
	private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x301FF2C Offset: 0x301BF2C VA: 0x301FF2C
	private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x3020374 Offset: 0x301C374 VA: 0x3020374
	private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x3020840 Offset: 0x301C840 VA: 0x3020840
	private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x3020D98 Offset: 0x301CD98 VA: 0x3020D98 Slot: 100
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[ComVisible(True)]
	// RVA: 0x3020E24 Offset: 0x301CE24 VA: 0x3020E24 Slot: 82
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x3020EBC Offset: 0x301CEBC VA: 0x3020EBC Slot: 109
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x3020F40 Offset: 0x301CF40 VA: 0x3020F40 Slot: 87
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x3020FC0 Offset: 0x301CFC0 VA: 0x3020FC0 Slot: 91
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x30212A8 Offset: 0x301D2A8 VA: 0x30212A8 Slot: 80
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x30214DC Offset: 0x301D4DC VA: 0x30214DC Slot: 108
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x3021778 Offset: 0x301D778 VA: 0x3021778 Slot: 84
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x3021938 Offset: 0x301D938 VA: 0x3021938 Slot: 86
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x3021C20 Offset: 0x301DC20 VA: 0x3021C20 Slot: 101
	public override Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	// RVA: 0x3021E0C Offset: 0x301DE0C VA: 0x3021E0C Slot: 90
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x30222BC Offset: 0x301E2BC VA: 0x30222BC Slot: 28
	public override Module get_Module() { }

	// RVA: 0x30222C4 Offset: 0x301E2C4 VA: 0x30222C4
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x30222CC Offset: 0x301E2CC VA: 0x30222CC Slot: 27
	public override Assembly get_Assembly() { }

	// RVA: 0x30222D4 Offset: 0x301E2D4 VA: 0x30222D4
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x30222DC Offset: 0x301E2DC VA: 0x30222DC Slot: 110
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x3022300 Offset: 0x301E300 VA: 0x3022300 Slot: 115
	public override bool IsInstanceOfType(object o) { }

	// RVA: 0x3022308 Offset: 0x301E308 VA: 0x3022308 Slot: 22
	public override bool IsAssignableFrom(Type c) { }

	// RVA: 0x30223E0 Offset: 0x301E3E0 VA: 0x30223E0 Slot: 116
	public override bool IsEquivalentTo(Type other) { }

	// RVA: 0x3022490 Offset: 0x301E490 VA: 0x3022490 Slot: 112
	public override Type get_BaseType() { }

	// RVA: 0x3022494 Offset: 0x301E494 VA: 0x3022494
	private RuntimeType GetBaseType() { }

	// RVA: 0x3022674 Offset: 0x301E674 VA: 0x3022674 Slot: 30
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x3022678 Offset: 0x301E678 VA: 0x3022678 Slot: 55
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x3022680 Offset: 0x301E680 VA: 0x3022680 Slot: 67
	protected override bool IsContextfulImpl() { }

	// RVA: 0x3022688 Offset: 0x301E688 VA: 0x3022688 Slot: 34
	protected override bool IsByRefImpl() { }

	// RVA: 0x3022690 Offset: 0x301E690 VA: 0x3022690 Slot: 73
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x3022698 Offset: 0x301E698 VA: 0x3022698 Slot: 36
	protected override bool IsPointerImpl() { }

	// RVA: 0x30226A0 Offset: 0x301E6A0 VA: 0x30226A0 Slot: 65
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x30226AC Offset: 0x301E6AC VA: 0x30226AC Slot: 75
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x30227CC Offset: 0x301E7CC VA: 0x30227CC Slot: 69
	public override bool get_IsEnum() { }

	// RVA: 0x3022840 Offset: 0x301E840 VA: 0x3022840 Slot: 45
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x3022848 Offset: 0x301E848 VA: 0x3022848 Slot: 52
	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x302290C Offset: 0x301E90C VA: 0x302290C Slot: 125
	internal override bool get_IsSzArray() { }

	// RVA: 0x3022914 Offset: 0x301E914 VA: 0x3022914 Slot: 32
	protected override bool IsArrayImpl() { }

	// RVA: 0x302291C Offset: 0x301E91C VA: 0x302291C Slot: 47
	public override int GetArrayRank() { }

	// RVA: 0x30229A0 Offset: 0x301E9A0 VA: 0x30229A0 Slot: 46
	public override Type GetElementType() { }

	// RVA: 0x30229A8 Offset: 0x301E9A8 VA: 0x30229A8 Slot: 18
	public override string[] GetEnumNames() { }

	// RVA: 0x3022AC4 Offset: 0x301EAC4 VA: 0x3022AC4 Slot: 118
	public override Array GetEnumValues() { }

	// RVA: 0x3022C38 Offset: 0x301EC38 VA: 0x3022C38 Slot: 117
	public override Type GetEnumUnderlyingType() { }

	// RVA: 0x3022D08 Offset: 0x301ED08 VA: 0x3022D08 Slot: 16
	public override bool IsEnumDefined(object value) { }

	// RVA: 0x3023220 Offset: 0x301F220 VA: 0x3023220 Slot: 17
	public override string GetEnumName(object value) { }

	// RVA: 0x3023408 Offset: 0x301F408 VA: 0x3023408
	internal RuntimeType[] GetGenericArgumentsInternal() { }

	// RVA: 0x3023480 Offset: 0x301F480 VA: 0x3023480 Slot: 50
	public override Type[] GetGenericArguments() { }

	// RVA: 0x3023520 Offset: 0x301F520 VA: 0x3023520 Slot: 122
	public override Type MakeGenericType(Type[] instantiation) { }

	// RVA: 0x3023A14 Offset: 0x301FA14 VA: 0x3023A14 Slot: 41
	public override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x3023A1C Offset: 0x301FA1C VA: 0x3023A1C Slot: 38
	public override bool get_IsGenericParameter() { }

	// RVA: 0x3023A24 Offset: 0x301FA24 VA: 0x3023A24 Slot: 51
	public override int get_GenericParameterPosition() { }

	// RVA: 0x3023AA8 Offset: 0x301FAA8 VA: 0x3023AA8 Slot: 48
	public override Type GetGenericTypeDefinition() { }

	// RVA: 0x3023B2C Offset: 0x301FB2C VA: 0x3023B2C Slot: 40
	public override bool get_IsGenericType() { }

	// RVA: 0x3023B34 Offset: 0x301FB34 VA: 0x3023B34 Slot: 37
	public override bool get_IsConstructedGenericType() { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x3023B7C Offset: 0x301FB7C VA: 0x3023B7C Slot: 113
	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) { }

	// RVA: 0x3024E04 Offset: 0x3020E04 VA: 0x3024E04 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x300F040 Offset: 0x300B040 VA: 0x300F040
	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x3011B68 Offset: 0x300DB68 VA: 0x3011B68
	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x3024E10 Offset: 0x3020E10 VA: 0x3024E10 Slot: 132
	public object Clone() { }

	// RVA: 0x3024E14 Offset: 0x3020E14 VA: 0x3024E14 Slot: 131
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3024E78 Offset: 0x3020E78 VA: 0x3024E78 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x3024F18 Offset: 0x3020F18 VA: 0x3024F18 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x30250AC Offset: 0x30210AC VA: 0x30250AC Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x3025240 Offset: 0x3021240 VA: 0x3025240 Slot: 126
	internal override string FormatTypeName(bool serialization) { }

	// RVA: 0x302541C Offset: 0x302141C VA: 0x302541C Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x3025460 Offset: 0x3021460 VA: 0x3025460 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x302546C Offset: 0x302146C VA: 0x302546C Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x3025474 Offset: 0x3021474 VA: 0x3025474
	private void CreateInstanceCheckThis() { }

	// RVA: 0x300F04C Offset: 0x300B04C VA: 0x300F04C
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x300FBC4 Offset: 0x300BBC4 VA: 0x300FBC4
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, bool wrapExceptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x30256C8 Offset: 0x30216C8 VA: 0x30256C8
	internal RuntimeConstructorInfo GetDefaultConstructor() { }

	// RVA: 0x3024D18 Offset: 0x3020D18 VA: 0x3024D18
	private string GetDefaultMemberName() { }

	// RVA: 0x302586C Offset: 0x302186C VA: 0x302586C
	internal RuntimeConstructorInfo GetSerializationCtor() { }

	// RVA: 0x302568C Offset: 0x302168C VA: 0x302568C
	internal object CreateInstanceSlow(bool publicOnly, bool wrapExceptions, bool skipCheckThis, bool fillCache) { }

	// RVA: 0x3025AA8 Offset: 0x3021AA8 VA: 0x3025AA8
	private object CreateInstanceMono(bool nonPublic, bool wrapExceptions) { }

	// RVA: 0x3025D78 Offset: 0x3021D78 VA: 0x3025D78
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x3025ED4 Offset: 0x3021ED4 VA: 0x3025ED4
	private object TryConvertToType(object value, ref bool failed) { }

	// RVA: 0x3026130 Offset: 0x3022130 VA: 0x3026130
	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	// RVA: 0x30253CC Offset: 0x30213CC VA: 0x30253CC
	private string GetCachedName(TypeNameKind kind) { }

	// RVA: 0x3026BD4 Offset: 0x3022BD4 VA: 0x3026BD4
	private Type make_array_type(int rank) { }

	// RVA: 0x3026BD8 Offset: 0x3022BD8 VA: 0x3026BD8 Slot: 119
	public override Type MakeArrayType() { }

	// RVA: 0x3026BE0 Offset: 0x3022BE0 VA: 0x3026BE0 Slot: 120
	public override Type MakeArrayType(int rank) { }

	// RVA: 0x3026C28 Offset: 0x3022C28 VA: 0x3026C28
	private Type make_byref_type() { }

	// RVA: 0x3026C2C Offset: 0x3022C2C VA: 0x3026C2C Slot: 121
	public override Type MakeByRefType() { }

	// RVA: 0x3026C94 Offset: 0x3022C94 VA: 0x3026C94
	private static Type MakePointerType(Type type) { }

	// RVA: 0x3026C98 Offset: 0x3022C98 VA: 0x3026C98 Slot: 123
	public override Type MakePointerType() { }

	// RVA: 0x3026D7C Offset: 0x3022D7C VA: 0x3026D7C Slot: 20
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x3026E78 Offset: 0x3022E78 VA: 0x3026E78 Slot: 53
	public override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x3026F6C Offset: 0x3022F6C VA: 0x3026F6C
	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	// RVA: 0x3023A10 Offset: 0x301FA10 VA: 0x3023A10
	private static Type MakeGenericType(Type gt, Type[] types) { }

	// RVA: 0x302708C Offset: 0x302308C VA: 0x302708C
	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, RuntimeType.MemberListType listType) { }

	// RVA: 0x301F260 Offset: 0x301B260 VA: 0x301F260
	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType) { }

	// RVA: 0x3027090 Offset: 0x3023090 VA: 0x3027090
	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType) { }

	// RVA: 0x3027094 Offset: 0x3023094 VA: 0x3027094
	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	// RVA: 0x301F7E0 Offset: 0x301B7E0 VA: 0x301F7E0
	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x301FC30 Offset: 0x301BC30 VA: 0x301FC30
	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType) { }

	// RVA: 0x3027098 Offset: 0x3023098 VA: 0x3027098 Slot: 111
	protected override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x30270EC Offset: 0x30230EC VA: 0x30270EC
	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	// RVA: 0x30270F0 Offset: 0x30230F0 VA: 0x30270F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3025684 Offset: 0x3021684 VA: 0x3025684
	private bool IsGenericCOMObjectImpl() { }

	// RVA: 0x3025D74 Offset: 0x3021D74 VA: 0x3025D74
	private static object CreateInstanceInternal(Type type) { }

	// RVA: 0x3027108 Offset: 0x3023108 VA: 0x3027108 Slot: 29
	public override MethodBase get_DeclaringMethod() { }

	// RVA: 0x30270FC Offset: 0x30230FC VA: 0x30270FC
	internal string getFullName(bool full_name, bool assembly_qualified) { }

	// RVA: 0x3023478 Offset: 0x301F478 VA: 0x3023478
	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	// RVA: 0x30228C8 Offset: 0x301E8C8 VA: 0x30228C8
	private GenericParameterAttributes GetGenericParameterAttributes() { }

	// RVA: 0x3023AA4 Offset: 0x301FAA4 VA: 0x3023AA4
	private int GetGenericParameterPosition() { }

	// RVA: 0x302710C Offset: 0x302310C VA: 0x302710C
	private IntPtr GetEvents_native(IntPtr name, RuntimeType.MemberListType listType) { }

	// RVA: 0x3027110 Offset: 0x3023110 VA: 0x3027110
	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType) { }

	// RVA: 0x3020544 Offset: 0x301C544 VA: 0x3020544
	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType) { }

	// RVA: 0x30200F8 Offset: 0x301C0F8 VA: 0x30200F8
	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType) { }

	// RVA: 0x3027114 Offset: 0x3023114 VA: 0x3027114 Slot: 114
	public override Type[] GetInterfaces() { }

	// RVA: 0x3027118 Offset: 0x3023118 VA: 0x3027118
	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType) { }

	// RVA: 0x30209F8 Offset: 0x301C9F8 VA: 0x30209F8
	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr, RuntimeType.MemberListType listType) { }

	// RVA: 0x302711C Offset: 0x302311C VA: 0x302711C Slot: 25
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x3027128 Offset: 0x3023128 VA: 0x3027128 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x302712C Offset: 0x302312C VA: 0x302712C Slot: 8
	public override string get_Name() { }

	// RVA: 0x3027130 Offset: 0x3023130 VA: 0x3027130 Slot: 24
	public override string get_Namespace() { }

	// RVA: 0x3027134 Offset: 0x3023134 VA: 0x3027134 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3027200 Offset: 0x3023200 VA: 0x3027200 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x30272F0 Offset: 0x30232F0 VA: 0x30272F0 Slot: 42
	public override bool get_IsSZArray() { }

	[ComVisible(True)]
	// RVA: 0x3027348 Offset: 0x3023348 VA: 0x3027348 Slot: 21
	public override bool IsSubclassOf(Type type) { }

	// RVA: 0x302743C Offset: 0x302343C VA: 0x302743C Slot: 98
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x302746C Offset: 0x302346C VA: 0x302746C
	private MethodInfo GetMethodImplCommon(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x3027738 Offset: 0x3023738 VA: 0x3027738
	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, int genericParameterCount, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x3027944 Offset: 0x3023944 VA: 0x3027944
	private static void .cctor() { }
}
