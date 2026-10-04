// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
internal class PackageRegistry : IPackageRegistry // TypeDefIndex: 17581
{
	// Fields
	[CompilerGenerated]
	private DependencyTree <Tree>k__BackingField; // 0x10

	// Properties
	public DependencyTree Tree { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37AF788 Offset: 0x37AB788 VA: 0x37AF788 Slot: 4
	public DependencyTree get_Tree() { }

	[CompilerGenerated]
	// RVA: 0x37AF790 Offset: 0x37AB790 VA: 0x37AF790 Slot: 9
	public void set_Tree(DependencyTree value) { }

	// RVA: 0x37AB5B8 Offset: 0x37A75B8 VA: 0x37AB5B8
	public void .ctor(DependencyTree tree) { }

	// RVA: -1 Offset: -1 Slot: 5
	public CoreRegistration RegisterPackage<TPackage>(TPackage package) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DDA94 Offset: 0x26D9A94 VA: 0x26DDA94
	|-PackageRegistry.RegisterPackage<object>
	|
	|-RVA: 0x26DDBF0 Offset: 0x26D9BF0 VA: 0x26DDBF0
	|-PackageRegistry.RegisterPackage<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void RegisterDependency<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DD674 Offset: 0x26D9674 VA: 0x26DD674
	|-PackageRegistry.RegisterDependency<object>
	|
	|-RVA: 0x26DD784 Offset: 0x26D9784 VA: 0x26DD784
	|-PackageRegistry.RegisterDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void RegisterOptionalDependency<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DD894 Offset: 0x26D9894 VA: 0x26DD894
	|-PackageRegistry.RegisterOptionalDependency<object>
	|
	|-RVA: 0x26DD994 Offset: 0x26D9994 VA: 0x26DD994
	|-PackageRegistry.RegisterOptionalDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RegisterProvision<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DDDD0 Offset: 0x26D9DD0 VA: 0x26DDDD0
	|-PackageRegistry.RegisterProvision<object>
	|
	|-RVA: 0x26DDE84 Offset: 0x26D9E84 VA: 0x26DDE84
	|-PackageRegistry.RegisterProvision<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37AF798 Offset: 0x37AB798 VA: 0x37AF798
	private void AddComponentDependencyToPackage(int componentTypeHash, int packageTypeHash) { }
}
