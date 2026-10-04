// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
internal class DependencyTree // TypeDefIndex: 17566
{
	// Fields
	public readonly Dictionary<int, IInitializablePackage> PackageTypeHashToInstance; // 0x10
	public readonly Dictionary<int, int> ComponentTypeHashToPackageTypeHash; // 0x18
	public readonly Dictionary<int, List<int>> PackageTypeHashToComponentTypeHashDependencies; // 0x20
	public readonly Dictionary<int, IServiceComponent> ComponentTypeHashToInstance; // 0x28

	// Methods

	// RVA: 0x37AB468 Offset: 0x37A7468 VA: 0x37AB468
	internal void .ctor() { }

	// RVA: 0x37ACED8 Offset: 0x37A8ED8 VA: 0x37ACED8
	internal void .ctor(Dictionary<int, IInitializablePackage> packageToInstance, Dictionary<int, int> componentToPackage, Dictionary<int, List<int>> packageToComponentDependencies, Dictionary<int, IServiceComponent> componentToInstance) { }
}
