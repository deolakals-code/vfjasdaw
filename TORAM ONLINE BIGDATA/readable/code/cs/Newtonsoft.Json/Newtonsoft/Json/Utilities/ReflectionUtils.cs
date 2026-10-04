// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class ReflectionUtils // TypeDefIndex: 15957
{
	// Fields
	public static readonly Type[] EmptyTypes; // 0x0

	// Methods

	// RVA: 0x30952CC Offset: 0x30912CC VA: 0x30952CC
	private static void .cctor() { }

	[Extension]
	// RVA: 0x309534C Offset: 0x309134C VA: 0x309534C
	public static bool IsVirtual(PropertyInfo propertyInfo) { }

	[Extension]
	// RVA: 0x309542C Offset: 0x309142C VA: 0x309542C
	public static MethodInfo GetBaseDefinition(PropertyInfo propertyInfo) { }

	// RVA: 0x30954F0 Offset: 0x30914F0 VA: 0x30954F0
	public static bool IsPublic(PropertyInfo property) { }

	[NullableContext(2)]
	// RVA: 0x3086058 Offset: 0x3082058 VA: 0x3086058
	public static Type GetObjectType(object v) { }

	// RVA: 0x3095580 Offset: 0x3091580 VA: 0x3095580
	public static string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, ISerializationBinder binder) { }

	// RVA: 0x3095658 Offset: 0x3091658 VA: 0x3095658
	private static string GetFullyQualifiedTypeName(Type t, ISerializationBinder binder) { }

	// RVA: 0x3095788 Offset: 0x3091788 VA: 0x3095788
	private static string RemoveAssemblyDetails(string fullyQualifiedTypeName) { }

	// RVA: 0x3094B1C Offset: 0x3090B1C VA: 0x3094B1C
	public static bool HasDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x3095A64 Offset: 0x3091A64 VA: 0x3095A64
	public static ConstructorInfo GetDefaultConstructor(Type t) { }

	// RVA: 0x3095930 Offset: 0x3091930 VA: 0x3095930
	public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x3085BE8 Offset: 0x3081BE8 VA: 0x3085BE8
	public static bool IsNullable(Type t) { }

	// RVA: 0x3083E04 Offset: 0x307FE04 VA: 0x3083E04
	public static bool IsNullableType(Type t) { }

	// RVA: 0x3095ABC Offset: 0x3091ABC VA: 0x3095ABC
	public static Type EnsureNotNullableType(Type t) { }

	// RVA: 0x3095B30 Offset: 0x3091B30 VA: 0x3095B30
	public static Type EnsureNotByRefType(Type t) { }

	// RVA: 0x3095B80 Offset: 0x3091B80 VA: 0x3095B80
	public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x3082D50 Offset: 0x307ED50 VA: 0x3082D50
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x3095C2C Offset: 0x3091C2C VA: 0x3095C2C
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType) { }

	// RVA: 0x3095EB8 Offset: 0x3091EB8 VA: 0x3095EB8
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition) { }

	// RVA: 0x3095F2C Offset: 0x3091F2C VA: 0x3095F2C
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x3096094 Offset: 0x3092094 VA: 0x3096094
	private static bool InheritsGenericDefinitionInternal(Type type, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x30961D0 Offset: 0x30921D0 VA: 0x30961D0
	public static Type GetCollectionItemType(Type type) { }

	[NullableContext(2)]
	// RVA: 0x30963F0 Offset: 0x30923F0 VA: 0x30963F0
	public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType) { }

	// RVA: 0x3094F0C Offset: 0x3090F0C VA: 0x3094F0C
	public static Type GetMemberUnderlyingType(MemberInfo member) { }

	// RVA: 0x3096640 Offset: 0x3092640 VA: 0x3096640
	public static bool IsByRefLikeType(Type type) { }

	// RVA: 0x3096C58 Offset: 0x3092C58 VA: 0x3096C58
	public static bool IsIndexedProperty(PropertyInfo property) { }

	// RVA: 0x3096CD0 Offset: 0x3092CD0 VA: 0x3096CD0
	public static object GetMemberValue(MemberInfo member, object target) { }

	// RVA: 0x3096FDC Offset: 0x3092FDC VA: 0x3096FDC
	public static void SetMemberValue(MemberInfo member, object target, object value) { }

	// RVA: 0x3094C2C Offset: 0x3090C2C VA: 0x3094C2C
	public static bool CanReadMemberValue(MemberInfo member, bool nonPublic) { }

	// RVA: 0x3094D78 Offset: 0x3090D78 VA: 0x3094D78
	public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) { }

	// RVA: 0x30971EC Offset: 0x30931EC VA: 0x30971EC
	public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr) { }

	// RVA: 0x30980B0 Offset: 0x30940B0 VA: 0x30980B0
	private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr) { }

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E6EF4 Offset: 0x26E2EF4 VA: 0x26E6EF4
	|-ReflectionUtils.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E6F5C Offset: 0x26E2F5C VA: 0x26E6F5C
	|-ReflectionUtils.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] GetAttributes<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E6FE4 Offset: 0x26E2FE4 VA: 0x26E6FE4
	|-ReflectionUtils.GetAttributes<object>
	*/

	// RVA: 0x3096748 Offset: 0x3092748 VA: 0x3096748
	public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit) { }

	// RVA: 0x3098288 Offset: 0x3094288 VA: 0x3098288
	public static StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName) { }

	// RVA: 0x309837C Offset: 0x309437C VA: 0x309837C
	private static Nullable<int> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) { }

	// RVA: 0x3098608 Offset: 0x3094608 VA: 0x3098608
	public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo) { }

	// RVA: 0x3097C90 Offset: 0x3093C90 VA: 0x3097C90
	public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x3098874 Offset: 0x3094874 VA: 0x3098874
	private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type type, BindingFlags bindingAttr) { }

	// RVA: 0x3097DA8 Offset: 0x3093DA8 VA: 0x3097DA8
	public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr) { }

	[Extension]
	// RVA: 0x3098A68 Offset: 0x3094A68 VA: 0x3098A68
	public static BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag) { }

	// RVA: 0x3098A78 Offset: 0x3094A78 VA: 0x3098A78
	private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type type, BindingFlags bindingAttr) { }

	// RVA: 0x309904C Offset: 0x309504C VA: 0x309904C
	public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method) { }

	// RVA: 0x3099168 Offset: 0x3095168 VA: 0x3099168
	public static object GetDefaultValue(Type type) { }
}
