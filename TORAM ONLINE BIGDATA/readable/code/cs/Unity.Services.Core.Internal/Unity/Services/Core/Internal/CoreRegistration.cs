// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
[IsReadOnly]
public struct CoreRegistration // TypeDefIndex: 17559
{
	// Fields
	private readonly IPackageRegistry m_Registry; // 0x0
	private readonly int m_PackageHash; // 0x8

	// Methods

	// RVA: 0x37AB6C4 Offset: 0x37A76C4 VA: 0x37AB6C4
	internal void .ctor(IPackageRegistry registry, int packageHash) { }

	// RVA: -1 Offset: -1
	public CoreRegistration DependsOn<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E3878 Offset: 0x27DF878 VA: 0x27E3878
	|-CoreRegistration.DependsOn<object>
	|
	|-RVA: 0x27E3938 Offset: 0x27DF938 VA: 0x27E3938
	|-CoreRegistration.DependsOn<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public CoreRegistration OptionallyDependsOn<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E39F8 Offset: 0x27DF9F8 VA: 0x27E39F8
	|-CoreRegistration.OptionallyDependsOn<object>
	|
	|-RVA: 0x27E3AB8 Offset: 0x27DFAB8 VA: 0x27E3AB8
	|-CoreRegistration.OptionallyDependsOn<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public CoreRegistration ProvidesComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E3B78 Offset: 0x27DFB78 VA: 0x27E3B78
	|-CoreRegistration.ProvidesComponent<object>
	|
	|-RVA: 0x27E3C38 Offset: 0x27DFC38 VA: 0x27E3C38
	|-CoreRegistration.ProvidesComponent<__Il2CppFullySharedGenericType>
	*/
}
