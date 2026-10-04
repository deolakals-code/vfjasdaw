// Assembly: System.dll
// Namespace: System.ComponentModel
public sealed class TypeDescriptor // TypeDefIndex: 14271
{
	// Fields
	private static WeakHashtable _providerTable; // 0x0
	private static Hashtable _providerTypeTable; // 0x8
	private static Hashtable _defaultProviders; // 0x10
	private static WeakHashtable _associationTable; // 0x18
	private static int _metadataVersion; // 0x20
	private static int _collisionIndex; // 0x24
	private static BooleanSwitch TraceDescriptor; // 0x28
	private static readonly Guid[] _pipelineInitializeKeys; // 0x30
	private static readonly Guid[] _pipelineMergeKeys; // 0x38
	private static readonly Guid[] _pipelineFilterKeys; // 0x40
	private static readonly Guid[] _pipelineAttributeFilterKeys; // 0x48
	private static object _internalSyncObject; // 0x50
	[CompilerGenerated]
	private static RefreshEventHandler Refreshed; // 0x58

	// Properties
	[EditorBrowsable(2)]
	public static Type ComObjectType { get; }
	[EditorBrowsable(2)]
	public static Type InterfaceType { get; }
	internal static int MetadataVersion { get; }

	// Methods

	// RVA: 0x34C41D8 Offset: 0x34C01D8 VA: 0x34C41D8
	public static Type get_ComObjectType() { }

	// RVA: 0x34C4244 Offset: 0x34C0244 VA: 0x34C4244
	public static Type get_InterfaceType() { }

	// RVA: 0x34C42B0 Offset: 0x34C02B0 VA: 0x34C42B0
	internal static int get_MetadataVersion() { }

	[EditorBrowsable(2)]
	// RVA: 0x34C4308 Offset: 0x34C0308 VA: 0x34C4308
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x34C50C4 Offset: 0x34C10C4 VA: 0x34C50C4
	private static void CheckDefaultProvider(Type type) { }

	// RVA: 0x34C56D4 Offset: 0x34C16D4 VA: 0x34C56D4
	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x34C59E8 Offset: 0x34C19E8 VA: 0x34C59E8
	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	[EditorBrowsable(2)]
	// RVA: 0x34C5DD0 Offset: 0x34C1DD0 VA: 0x34C5DD0
	public static object GetAssociation(Type type, object primary) { }

	// RVA: 0x34C175C Offset: 0x34BD75C VA: 0x34C175C
	public static AttributeCollection GetAttributes(Type componentType) { }

	// RVA: 0x34C200C Offset: 0x34BE00C VA: 0x34C200C
	public static AttributeCollection GetAttributes(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x34C654C Offset: 0x34C254C VA: 0x34C654C
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	// RVA: 0x34C95E8 Offset: 0x34C55E8 VA: 0x34C95E8
	internal static IDictionary GetCache(object instance) { }

	// RVA: 0x34C9DC0 Offset: 0x34C5DC0 VA: 0x34C9DC0
	public static TypeConverter GetConverter(Type type) { }

	// RVA: 0x34C6468 Offset: 0x34C2468 VA: 0x34C6468
	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	// RVA: 0x34C6960 Offset: 0x34C2960 VA: 0x34C6960
	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	// RVA: 0x34C6B68 Offset: 0x34C2B68 VA: 0x34C6B68
	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	// RVA: 0x34C9EEC Offset: 0x34C5EEC VA: 0x34C9EEC
	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	// RVA: 0x34CA204 Offset: 0x34C6204 VA: 0x34CA204
	private static Type GetNodeForBaseType(Type searchType) { }

	// RVA: 0x34CA2D8 Offset: 0x34C62D8 VA: 0x34CA2D8
	public static PropertyDescriptorCollection GetProperties(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x34CA330 Offset: 0x34C6330 VA: 0x34CA330
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	// RVA: 0x34CA9F4 Offset: 0x34C69F4 VA: 0x34CA9F4
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes) { }

	// RVA: 0x34CAA5C Offset: 0x34C6A5C VA: 0x34CAA5C
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x34CA39C Offset: 0x34C639C VA: 0x34CA39C
	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	// RVA: 0x34CB124 Offset: 0x34C7124 VA: 0x34CB124
	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x34CB17C Offset: 0x34C717C VA: 0x34CB17C
	public static Type GetReflectionType(Type type) { }

	// RVA: 0x34C5990 Offset: 0x34C1990 VA: 0x34C5990
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type) { }

	// RVA: 0x34C4594 Offset: 0x34C0594 VA: 0x34C4594
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	// RVA: 0x34C9D68 Offset: 0x34C5D68 VA: 0x34C9D68
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance) { }

	// RVA: 0x34CB264 Offset: 0x34C7264 VA: 0x34CB264
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	// RVA: 0x34CAACC Offset: 0x34C6ACC VA: 0x34CAACC
	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	// RVA: 0x34C7D64 Offset: 0x34C3D64 VA: 0x34C7D64
	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	// RVA: 0x34C9654 Offset: 0x34C5654 VA: 0x34C9654
	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	// RVA: 0x34C6C20 Offset: 0x34C2C20 VA: 0x34C6C20
	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	// RVA: 0x34CB624 Offset: 0x34C7624 VA: 0x34CB624
	private static void RaiseRefresh(Type type) { }

	// RVA: 0x34C4ACC Offset: 0x34C0ACC VA: 0x34C4ACC
	public static void Refresh(Type type) { }

	// RVA: 0x34C5D40 Offset: 0x34C1D40 VA: 0x34C5D40
	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	// RVA: 0x34CB6D0 Offset: 0x34C76D0 VA: 0x34CB6D0
	public static void SortDescriptorArray(IList infos) { }

	// RVA: 0x34CB7A4 Offset: 0x34C77A4 VA: 0x34CB7A4
	private static void .cctor() { }
}
