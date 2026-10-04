// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
internal class LockedPackageRegistry : IPackageRegistry // TypeDefIndex: 17580
{
	// Fields
	[CompilerGenerated]
	private readonly IPackageRegistry <Registry>k__BackingField; // 0x10

	// Properties
	[NotNull]
	internal IPackageRegistry Registry { get; }
	public DependencyTree Tree { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37AF6E0 Offset: 0x37AB6E0 VA: 0x37AF6E0
	internal IPackageRegistry get_Registry() { }

	// RVA: 0x37AB694 Offset: 0x37A7694 VA: 0x37AB694
	public void .ctor(IPackageRegistry registryToLock) { }

	// RVA: 0x37AF6E8 Offset: 0x37AB6E8 VA: 0x37AF6E8 Slot: 4
	public DependencyTree get_Tree() { }

	// RVA: -1 Offset: -1 Slot: 5
	public CoreRegistration RegisterPackage<TPackage>(TPackage package) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D7628 Offset: 0x26D3628 VA: 0x26D7628
	|-LockedPackageRegistry.RegisterPackage<object>
	|
	|-RVA: 0x26D7670 Offset: 0x26D3670 VA: 0x26D7670
	|-LockedPackageRegistry.RegisterPackage<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void RegisterDependency<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D7508 Offset: 0x26D3508 VA: 0x26D7508
	|-LockedPackageRegistry.RegisterDependency<object>
	|
	|-RVA: 0x26D7550 Offset: 0x26D3550 VA: 0x26D7550
	|-LockedPackageRegistry.RegisterDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void RegisterOptionalDependency<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D7598 Offset: 0x26D3598 VA: 0x26D7598
	|-LockedPackageRegistry.RegisterOptionalDependency<object>
	|
	|-RVA: 0x26D75E0 Offset: 0x26D35E0 VA: 0x26D75E0
	|-LockedPackageRegistry.RegisterOptionalDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RegisterProvision<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D76B8 Offset: 0x26D36B8 VA: 0x26D76B8
	|-LockedPackageRegistry.RegisterProvision<object>
	|
	|-RVA: 0x26D7700 Offset: 0x26D3700 VA: 0x26D7700
	|-LockedPackageRegistry.RegisterProvision<__Il2CppFullySharedGenericType>
	*/
}
