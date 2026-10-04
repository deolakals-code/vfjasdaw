// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
internal class CoreRegistryInitializer // TypeDefIndex: 17565
{
	// Fields
	[NotNull]
	private readonly CoreRegistry m_Registry; // 0x10
	[NotNull]
	private readonly List<int> m_SortedPackageTypeHashes; // 0x18

	// Methods

	// RVA: 0x37AB9DC Offset: 0x37A79DC VA: 0x37AB9DC
	public void .ctor(CoreRegistry registry, List<int> sortedPackageTypeHashes) { }

	[AsyncStateMachine(typeof(CoreRegistryInitializer.<InitializeRegistryAsync>d__3))]
	// RVA: 0x37ABA20 Offset: 0x37A7A20 VA: 0x37ABA20
	public Task<List<PackageInitializationInfo>> InitializeRegistryAsync() { }
}
