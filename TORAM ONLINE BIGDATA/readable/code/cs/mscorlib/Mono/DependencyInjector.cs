// Assembly: mscorlib.dll
// Namespace: Mono
internal static class DependencyInjector // TypeDefIndex: 9421
{
	// Fields
	private static object locker; // 0x0
	private static ISystemDependencyProvider systemDependency; // 0x8

	// Properties
	internal static ISystemDependencyProvider SystemProvider { get; }

	// Methods

	// RVA: 0x2E652C4 Offset: 0x2E612C4 VA: 0x2E652C4
	internal static ISystemDependencyProvider get_SystemProvider() { }

	// RVA: 0x2E65618 Offset: 0x2E61618 VA: 0x2E65618
	internal static void Register(ISystemDependencyProvider provider) { }

	// RVA: 0x2E654CC Offset: 0x2E614CC VA: 0x2E654CC
	private static ISystemDependencyProvider ReflectionLoad() { }

	// RVA: 0x2E657B8 Offset: 0x2E617B8 VA: 0x2E657B8
	private static void .cctor() { }
}
