// Assembly: UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
internal class AndroidReflection // TypeDefIndex: 17068
{
	// Fields
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; // 0x0
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; // 0x8
	private static readonly IntPtr s_ReflectionHelperGetMethodID; // 0x10
	private static readonly IntPtr s_ReflectionHelperGetFieldID; // 0x18
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; // 0x20
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; // 0x28
	private static readonly IntPtr s_ReflectionHelperCeateInvocationError; // 0x30
	private static readonly IntPtr s_FieldGetDeclaringClass; // 0x38

	// Methods

	// RVA: 0x37C4D34 Offset: 0x37C0D34 VA: 0x37C4D34
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x37C4D48 Offset: 0x37C0D48 VA: 0x37C4D48
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x37C4D68 Offset: 0x37C0D68 VA: 0x37C4D68
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x37C4E04 Offset: 0x37C0E04 VA: 0x37C4E04
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x37C4EA0 Offset: 0x37C0EA0 VA: 0x37C4EA0
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x37C5028 Offset: 0x37C1028 VA: 0x37C5028
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x37C5224 Offset: 0x37C1224 VA: 0x37C5224
	public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x37C5420 Offset: 0x37C1420 VA: 0x37C5420
	public static IntPtr GetFieldClass(IntPtr field) { }

	// RVA: 0x37C5484 Offset: 0x37C1484 VA: 0x37C5484
	public static string GetFieldSignature(IntPtr field) { }

	// RVA: 0x37C552C Offset: 0x37C152C VA: 0x37C552C
	public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x37C2514 Offset: 0x37BE514 VA: 0x37C2514
	internal static IntPtr CreateInvocationError(Exception ex, bool methodNotFound) { }

	// RVA: 0x37C5610 Offset: 0x37C1610 VA: 0x37C5610
	private static void .cctor() { }
}
