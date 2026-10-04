// Assembly: System.dll
// Namespace: System.ComponentModel
internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 14257
{
	// Fields
	private Hashtable _typeData; // 0x20
	private static Type[] _typeConstructor; // 0x0
	private static Hashtable _intrinsicTypeConverters; // 0x8
	private static object _intrinsicReferenceKey; // 0x10
	private static object _intrinsicNullableKey; // 0x18
	private static object _dictionaryKey; // 0x20
	private static Hashtable _propertyCache; // 0x28
	private static Hashtable _attributeCache; // 0x30
	private static Hashtable _extendedPropertyCache; // 0x38
	private static readonly Guid _extenderProviderKey; // 0x40
	private static readonly Guid _extenderPropertiesKey; // 0x50
	private static readonly Guid _extenderProviderPropertiesKey; // 0x60
	private static readonly Type[] _skipInterfaceAttributeList; // 0x70
	private static object _internalSyncObject; // 0x78

	// Properties
	private static Hashtable IntrinsicTypeConverters { get; }

	// Methods

	// RVA: 0x34BBF5C Offset: 0x34B7F5C VA: 0x34BBF5C
	internal void .ctor() { }

	// RVA: 0x34BBF64 Offset: 0x34B7F64 VA: 0x34BBF64
	private static Hashtable get_IntrinsicTypeConverters() { }

	// RVA: 0x34BCA4C Offset: 0x34B8A4C VA: 0x34BCA4C Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x34BCC50 Offset: 0x34B8C50 VA: 0x34BCC50
	private static object CreateInstance(Type objectType, Type callingType) { }

	// RVA: 0x34BCD58 Offset: 0x34B8D58 VA: 0x34BCD58
	internal AttributeCollection GetAttributes(Type type) { }

	// RVA: 0x34BCFF0 Offset: 0x34B8FF0 VA: 0x34BCFF0 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x34BD354 Offset: 0x34B9354 VA: 0x34BD354
	internal TypeConverter GetConverter(Type type, object instance) { }

	// RVA: 0x34BD37C Offset: 0x34B937C VA: 0x34BD37C
	internal AttributeCollection GetExtendedAttributes(object instance) { }

	// RVA: 0x34BD3D4 Offset: 0x34B93D4 VA: 0x34BD3D4
	internal TypeConverter GetExtendedConverter(object instance) { }

	// RVA: 0x34BD410 Offset: 0x34B9410 VA: 0x34BD410
	internal PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	// RVA: 0x34BE8CC Offset: 0x34BA8CC VA: 0x34BE8CC Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x34BED58 Offset: 0x34BAD58 VA: 0x34BED58
	private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	// RVA: 0x34BF874 Offset: 0x34BB874 VA: 0x34BF874
	internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	// RVA: 0x34BF908 Offset: 0x34BB908 VA: 0x34BF908 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x34BF910 Offset: 0x34BB910 VA: 0x34BF910
	internal PropertyDescriptorCollection GetProperties(Type type) { }

	// RVA: 0x34BF8A0 Offset: 0x34BB8A0 VA: 0x34BF8A0
	internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	// RVA: 0x34BF930 Offset: 0x34BB930 VA: 0x34BF930 Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x34BCD78 Offset: 0x34B8D78 VA: 0x34BCD78
	private ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	// RVA: 0x34BF938 Offset: 0x34BB938 VA: 0x34BF938 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x34BF940 Offset: 0x34BB940 VA: 0x34BF940
	private static Type GetTypeFromName(string typeName) { }

	// RVA: 0x34BFA50 Offset: 0x34BBA50 VA: 0x34BFA50
	internal bool IsPopulated(Type type) { }

	// RVA: 0x34BFA74 Offset: 0x34BBA74 VA: 0x34BFA74
	private static Attribute[] ReflectGetAttributes(Type type) { }

	// RVA: 0x34BA6E4 Offset: 0x34B66E4 VA: 0x34BA6E4
	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	// RVA: 0x34BD960 Offset: 0x34B9960 VA: 0x34BD960
	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	// RVA: 0x34BFEB8 Offset: 0x34BBEB8 VA: 0x34BFEB8
	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	// RVA: 0x34C04E0 Offset: 0x34BC4E0 VA: 0x34C04E0
	internal void Refresh(Type type) { }

	// RVA: 0x34C0504 Offset: 0x34BC504 VA: 0x34C0504
	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

	// RVA: 0x34C0E78 Offset: 0x34BCE78 VA: 0x34C0E78
	private static void .cctor() { }
}
