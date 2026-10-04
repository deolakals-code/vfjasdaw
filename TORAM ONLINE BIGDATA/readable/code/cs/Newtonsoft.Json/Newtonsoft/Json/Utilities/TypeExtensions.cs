// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Extension]
[Nullable(0)]
internal static class TypeExtensions // TypeDefIndex: 15966
{
	// Methods

	[Extension]
	// RVA: 0x3094C10 Offset: 0x3090C10 VA: 0x3094C10
	public static MemberTypes MemberType(MemberInfo memberInfo) { }

	[Extension]
	// RVA: 0x309A4E0 Offset: 0x30964E0 VA: 0x309A4E0
	public static bool ContainsGenericParameters(Type type) { }

	[Extension]
	// RVA: 0x3085E8C Offset: 0x3081E8C VA: 0x3085E8C
	public static bool IsInterface(Type type) { }

	[Extension]
	// RVA: 0x3090198 Offset: 0x308C198 VA: 0x3090198
	public static bool IsGenericType(Type type) { }

	[Extension]
	// RVA: 0x3085EA0 Offset: 0x3081EA0 VA: 0x3085EA0
	public static bool IsGenericTypeDefinition(Type type) { }

	[Extension]
	// RVA: 0x30961B0 Offset: 0x30921B0 VA: 0x30961B0
	public static Type BaseType(Type type) { }

	[Extension]
	// RVA: 0x30901C0 Offset: 0x308C1C0 VA: 0x30901C0
	public static Assembly Assembly(Type type) { }

	[Extension]
	// RVA: 0x3083DE4 Offset: 0x307FDE4 VA: 0x3083DE4
	public static bool IsEnum(Type type) { }

	[Extension]
	// RVA: 0x3096080 Offset: 0x3092080 VA: 0x3096080
	public static bool IsClass(Type type) { }

	[Extension]
	// RVA: 0x309A500 Offset: 0x3096500 VA: 0x309A500
	public static bool IsSealed(Type type) { }

	[Extension]
	// RVA: 0x3085EC0 Offset: 0x3081EC0 VA: 0x3085EC0
	public static bool IsAbstract(Type type) { }

	[Extension]
	// RVA: 0x309A514 Offset: 0x3096514 VA: 0x309A514
	public static bool IsVisible(Type type) { }

	[Extension]
	// RVA: 0x309591C Offset: 0x309191C VA: 0x309591C
	public static bool IsValueType(Type type) { }

	[Extension]
	// RVA: 0x309A528 Offset: 0x3096528 VA: 0x309A528
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, out Type match) { }

	[Extension]
	// RVA: 0x309A6B4 Offset: 0x30966B4 VA: 0x309A6B4
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces) { }

	[Extension]
	// RVA: 0x309A6D4 Offset: 0x30966D4 VA: 0x309A6D4
	public static bool ImplementInterface(Type type, Type interfaceType) { }
}
