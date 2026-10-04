// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
internal interface IPackageRegistry // TypeDefIndex: 17579
{
	// Properties
	[CanBeNull]
	public abstract DependencyTree Tree { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DependencyTree get_Tree();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract CoreRegistration RegisterPackage<TPackage>(TPackage package);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPackageRegistry.RegisterPackage<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void RegisterDependency<TComponent>(int packageTypeHash);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPackageRegistry.RegisterDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void RegisterOptionalDependency<TComponent>(int packageTypeHash);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPackageRegistry.RegisterOptionalDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void RegisterProvision<TComponent>(int packageTypeHash);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPackageRegistry.RegisterProvision<__Il2CppFullySharedGenericType>
	*/
}
