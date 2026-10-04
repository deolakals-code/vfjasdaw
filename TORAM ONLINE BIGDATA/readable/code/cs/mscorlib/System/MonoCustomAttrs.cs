// Assembly: mscorlib.dll
// Namespace: System
internal static class MonoCustomAttrs // TypeDefIndex: 9802
{
	// Fields
	private static Assembly corlib; // 0x0
	[ThreadStatic]
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; // 0x80000000
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; // 0x8

	// Methods

	// RVA: 0x30312E8 Offset: 0x302D2E8 VA: 0x30312E8
	private static bool IsUserCattrProvider(object obj) { }

	// RVA: 0x30314C4 Offset: 0x302D4C4 VA: 0x30314C4
	internal static Attribute[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	// RVA: 0x30314CC Offset: 0x302D4CC VA: 0x30314CC
	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x30317CC Offset: 0x302D7CC VA: 0x30317CC
	private static object[] GetPseudoCustomAttributes(Type type) { }

	// RVA: 0x3031948 Offset: 0x302D948 VA: 0x3031948
	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x3031AEC Offset: 0x302DAEC VA: 0x3031AEC
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x3032A2C Offset: 0x302EA2C VA: 0x3032A2C
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	// RVA: 0x3032BA8 Offset: 0x302EBA8 VA: 0x3032BA8
	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	// RVA: 0x3032BAC Offset: 0x302EBAC VA: 0x3032BAC
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, bool inherit = False) { }

	// RVA: 0x3032E98 Offset: 0x302EE98 VA: 0x3032E98
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x3032CDC Offset: 0x302ECDC VA: 0x3032CDC
	internal static IList<CustomAttributeData> GetCustomAttributesDataBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x303425C Offset: 0x303025C VA: 0x303425C
	internal static CustomAttributeData[] GetPseudoCustomAttributesData(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x3034560 Offset: 0x3030560 VA: 0x3034560
	private static CustomAttributeData[] GetPseudoCustomAttributesData(Type type) { }

	// RVA: 0x30347A4 Offset: 0x30307A4 VA: 0x30347A4
	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x3034A38 Offset: 0x3030A38 VA: 0x3034A38
	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	// RVA: 0x3034A3C Offset: 0x3030A3C VA: 0x3034A3C
	private static PropertyInfo GetBasePropertyDefinition(RuntimePropertyInfo property) { }

	// RVA: 0x3034D30 Offset: 0x3030D30 VA: 0x3034D30
	private static EventInfo GetBaseEventDefinition(RuntimeEventInfo evt) { }

	// RVA: 0x30324C4 Offset: 0x302E4C4 VA: 0x30324C4
	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	// RVA: 0x3034F40 Offset: 0x3030F40 VA: 0x3034F40
	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

	// RVA: 0x3032888 Offset: 0x302E888 VA: 0x3032888
	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	// RVA: 0x3035184 Offset: 0x3031184 VA: 0x3035184
	private static void .cctor() { }
}
