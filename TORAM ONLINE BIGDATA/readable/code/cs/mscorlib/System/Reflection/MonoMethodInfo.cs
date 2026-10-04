// Assembly: mscorlib.dll
// Namespace: System.Reflection
internal struct MonoMethodInfo // TypeDefIndex: 10650
{
	// Fields
	private Type parent; // 0x0
	private Type ret; // 0x8
	internal MethodAttributes attrs; // 0x10
	internal MethodImplAttributes iattrs; // 0x14
	private CallingConventions callconv; // 0x18

	// Methods

	// RVA: 0x2F37F10 Offset: 0x2F33F10 VA: 0x2F37F10
	private static void get_method_info(IntPtr handle, out MonoMethodInfo info) { }

	// RVA: 0x2F37F14 Offset: 0x2F33F14 VA: 0x2F37F14
	private static int get_method_attributes(IntPtr handle) { }

	// RVA: 0x2F37F18 Offset: 0x2F33F18 VA: 0x2F37F18
	internal static MonoMethodInfo GetMethodInfo(IntPtr handle) { }

	// RVA: 0x2F37F48 Offset: 0x2F33F48 VA: 0x2F37F48
	internal static Type GetDeclaringType(IntPtr handle) { }

	// RVA: 0x2F37F70 Offset: 0x2F33F70 VA: 0x2F37F70
	internal static Type GetReturnType(IntPtr handle) { }

	// RVA: 0x2F37F98 Offset: 0x2F33F98 VA: 0x2F37F98
	internal static MethodAttributes GetAttributes(IntPtr handle) { }

	// RVA: 0x2F37F9C Offset: 0x2F33F9C VA: 0x2F37F9C
	internal static CallingConventions GetCallingConvention(IntPtr handle) { }

	// RVA: 0x2F37FC4 Offset: 0x2F33FC4 VA: 0x2F37FC4
	internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle) { }

	// RVA: 0x2F37FEC Offset: 0x2F33FEC VA: 0x2F37FEC
	private static ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member) { }

	// RVA: 0x2F37FF0 Offset: 0x2F33FF0 VA: 0x2F37FF0
	internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member) { }

	// RVA: 0x2F37FF4 Offset: 0x2F33FF4 VA: 0x2F37FF4
	private static MarshalAsAttribute get_retval_marshal(IntPtr handle) { }

	// RVA: 0x2F37FF8 Offset: 0x2F33FF8 VA: 0x2F37FF8
	internal static ParameterInfo GetReturnParameterInfo(RuntimeMethodInfo method) { }
}
