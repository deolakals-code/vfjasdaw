// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
[ComVisible(True)]
public static class FormatterServices // TypeDefIndex: 10350
{
	// Fields
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; // 0x0
	private static bool unsafeTypeForwardersIsEnabled; // 0x8
	private static bool unsafeTypeForwardersIsEnabledInitialized; // 0x9
	private static readonly Type[] advancedTypes; // 0x10
	private static Binder s_binder; // 0x18

	// Methods

	// RVA: 0x2EFC054 Offset: 0x2EF8054 VA: 0x2EFC054
	private static void .cctor() { }

	// RVA: 0x2EFC200 Offset: 0x2EF8200 VA: 0x2EFC200
	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	// RVA: 0x2EFC398 Offset: 0x2EF8398 VA: 0x2EFC398
	private static bool CheckSerializable(RuntimeType type) { }

	// RVA: 0x2EFC3B8 Offset: 0x2EF83B8 VA: 0x2EFC3B8
	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	// RVA: 0x2EFCAA8 Offset: 0x2EF8AA8 VA: 0x2EFCAA8
	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	// RVA: 0x2EFCF70 Offset: 0x2EF8F70 VA: 0x2EFCF70
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	// RVA: 0x2EFD218 Offset: 0x2EF9218 VA: 0x2EFD218
	public static object GetUninitializedObject(Type type) { }

	// RVA: 0x2EFD3D0 Offset: 0x2EF93D0 VA: 0x2EFD3D0
	private static object nativeGetUninitializedObject(RuntimeType type) { }

	// RVA: 0x2EFD3D8 Offset: 0x2EF93D8 VA: 0x2EFD3D8
	private static bool GetEnableUnsafeTypeForwarders() { }

	// RVA: 0x2EFD3E0 Offset: 0x2EF93E0 VA: 0x2EFD3E0
	internal static bool UnsafeTypeForwardersIsEnabled() { }

	// RVA: 0x2EFD488 Offset: 0x2EF9488 VA: 0x2EFD488
	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	// RVA: 0x2EFD728 Offset: 0x2EF9728 VA: 0x2EFD728
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data) { }

	// RVA: 0x2EFDA1C Offset: 0x2EF9A1C VA: 0x2EFDA1C
	public static object[] GetObjectData(object obj, MemberInfo[] members) { }

	// RVA: 0x2EFDE0C Offset: 0x2EF9E0C VA: 0x2EFDE0C
	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	// RVA: 0x2EFDEA4 Offset: 0x2EF9EA4 VA: 0x2EFDEA4
	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	// RVA: 0x2EFDEAC Offset: 0x2EF9EAC VA: 0x2EFDEAC
	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	// RVA: 0x2EFDF80 Offset: 0x2EF9F80 VA: 0x2EFDF80
	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	// RVA: 0x2EFE0E8 Offset: 0x2EFA0E8 VA: 0x2EFE0E8
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x2EFE168 Offset: 0x2EFA168 VA: 0x2EFE168
	private static string GetClrTypeFullNameForArray(Type type) { }

	// RVA: 0x2EFE38C Offset: 0x2EFA38C VA: 0x2EFE38C
	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }
}
