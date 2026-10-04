// Assembly: System.dll
// Namespace: System
internal static class SecurityUtils // TypeDefIndex: 14029
{
	// Methods

	// RVA: 0x34633B4 Offset: 0x345F3B4 VA: 0x34633B4
	private static void DemandReflectionAccess(Type type) { }

	// RVA: 0x34633B8 Offset: 0x345F3B8 VA: 0x34633B8
	private static void DemandGrantSet(Assembly assembly) { }

	// RVA: 0x34633BC Offset: 0x345F3BC VA: 0x34633BC
	private static bool HasReflectionPermission(Type type) { }

	// RVA: 0x34633C4 Offset: 0x345F3C4 VA: 0x34633C4
	internal static object SecureCreateInstance(Type type) { }

	// RVA: 0x34633D0 Offset: 0x345F3D0 VA: 0x34633D0
	internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic) { }

	// RVA: 0x34634C4 Offset: 0x345F4C4 VA: 0x34634C4
	internal static object SecureCreateInstance(Type type, object[] args) { }

	// RVA: 0x34634CC Offset: 0x345F4CC VA: 0x34634CC
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic) { }

	// RVA: 0x34634D8 Offset: 0x345F4D8 VA: 0x34634D8
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags) { }

	// RVA: 0x346364C Offset: 0x345F64C VA: 0x346364C
	private static bool GenericArgumentsAreVisible(MethodInfo method) { }

	// RVA: 0x34636FC Offset: 0x345F6FC VA: 0x34636FC
	internal static object MethodInfoInvoke(MethodInfo method, object target, object[] args) { }
}
