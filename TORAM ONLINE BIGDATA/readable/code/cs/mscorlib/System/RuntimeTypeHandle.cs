// Assembly: mscorlib.dll
// Namespace: System
[ComVisible(True)]
[Serializable]
public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 9812
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x30366B0 Offset: 0x30326B0 VA: 0x30366B0
	internal void .ctor(IntPtr val) { }

	// RVA: 0x30366B8 Offset: 0x30326B8 VA: 0x30366B8
	internal void .ctor(RuntimeType type) { }

	// RVA: 0x30366D4 Offset: 0x30326D4 VA: 0x30366D4
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x303685C Offset: 0x303285C VA: 0x303685C
	public IntPtr get_Value() { }

	// RVA: 0x3036864 Offset: 0x3032864 VA: 0x3036864 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x30369F0 Offset: 0x30329F0 VA: 0x30369F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3036AEC Offset: 0x3032AEC VA: 0x3036AEC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3036AF4 Offset: 0x3032AF4 VA: 0x3036AF4
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	// RVA: 0x3036AF8 Offset: 0x3032AF8 VA: 0x3036AF8
	private static int GetMetadataToken(RuntimeType type) { }

	// RVA: 0x3036AFC Offset: 0x3032AFC VA: 0x3036AFC
	internal static int GetToken(RuntimeType type) { }

	// RVA: 0x3036B00 Offset: 0x3032B00 VA: 0x3036B00
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	// RVA: 0x3036B04 Offset: 0x3032B04 VA: 0x3036B04
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x3036B08 Offset: 0x3032B08 VA: 0x3036B08
	internal static bool IsPrimitive(RuntimeType type) { }

	// RVA: 0x3036B44 Offset: 0x3032B44 VA: 0x3036B44
	internal static bool IsByRef(RuntimeType type) { }

	// RVA: 0x3036B60 Offset: 0x3032B60 VA: 0x3036B60
	internal static bool IsPointer(RuntimeType type) { }

	// RVA: 0x3036B7C Offset: 0x3032B7C VA: 0x3036B7C
	internal static bool IsArray(RuntimeType type) { }

	// RVA: 0x3036BA4 Offset: 0x3032BA4 VA: 0x3036BA4
	internal static bool IsSzArray(RuntimeType type) { }

	// RVA: 0x3036BC0 Offset: 0x3032BC0 VA: 0x3036BC0
	internal static bool HasElementType(RuntimeType type) { }

	// RVA: 0x3036B40 Offset: 0x3032B40 VA: 0x3036B40
	internal static CorElementType GetCorElementType(RuntimeType type) { }

	// RVA: 0x3036BFC Offset: 0x3032BFC VA: 0x3036BFC
	internal static bool HasInstantiation(RuntimeType type) { }

	// RVA: 0x3036C00 Offset: 0x3032C00 VA: 0x3036C00
	internal static bool IsComObject(RuntimeType type) { }

	// RVA: 0x3036C04 Offset: 0x3032C04 VA: 0x3036C04
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	// RVA: 0x3036C08 Offset: 0x3032C08 VA: 0x3036C08
	internal static bool HasReferences(RuntimeType type) { }

	// RVA: 0x3036C0C Offset: 0x3032C0C VA: 0x3036C0C
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	// RVA: 0x3036C1C Offset: 0x3032C1C VA: 0x3036C1C
	internal static bool IsContextful(RuntimeType type) { }

	// RVA: 0x3036CB0 Offset: 0x3032CB0 VA: 0x3036CB0
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	// RVA: 0x3036CB8 Offset: 0x3032CB8 VA: 0x3036CB8
	internal static bool IsInterface(RuntimeType type) { }

	// RVA: 0x3036CD8 Offset: 0x3032CD8 VA: 0x3036CD8
	internal static int GetArrayRank(RuntimeType type) { }

	// RVA: 0x3036CDC Offset: 0x3032CDC VA: 0x3036CDC
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	// RVA: 0x3036CE0 Offset: 0x3032CE0 VA: 0x3036CE0
	internal static RuntimeType GetElementType(RuntimeType type) { }

	// RVA: 0x3036CE4 Offset: 0x3032CE4 VA: 0x3036CE4
	internal static RuntimeModule GetModule(RuntimeType type) { }

	// RVA: 0x3036CE8 Offset: 0x3032CE8 VA: 0x3036CE8
	internal static bool IsGenericVariable(RuntimeType type) { }

	// RVA: 0x3036CEC Offset: 0x3032CEC VA: 0x3036CEC
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	// RVA: 0x3036CF0 Offset: 0x3032CF0 VA: 0x3036CF0
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	// RVA: 0x3036D00 Offset: 0x3032D00 VA: 0x3036D00
	private static bool type_is_assignable_from(Type a, Type b) { }

	// RVA: 0x3036D04 Offset: 0x3032D04 VA: 0x3036D04
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x3036D08 Offset: 0x3032D08 VA: 0x3036D08
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }

	// RVA: 0x3036D0C Offset: 0x3032D0C VA: 0x3036D0C
	internal static bool IsSubclassOf(RuntimeType childType, RuntimeType baseType) { }

	// RVA: 0x3036D2C Offset: 0x3032D2C VA: 0x3036D2C
	internal static bool is_subclass_of(IntPtr childType, IntPtr baseType) { }

	// RVA: 0x3036D30 Offset: 0x3032D30 VA: 0x3036D30
	private static RuntimeType internal_from_name(string name, ref StackCrawlMark stackMark, Assembly callerAssembly, bool throwOnError, bool ignoreCase, bool reflectionOnly) { }

	// RVA: 0x3036D40 Offset: 0x3032D40 VA: 0x3036D40
	internal static RuntimeType GetTypeByName(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark, bool loadTypeFromPartialName) { }
}
