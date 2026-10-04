// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
internal struct DependencyTreeInitializeOrderSorter // TypeDefIndex: 17570
{
	// Fields
	public readonly DependencyTree Tree; // 0x0
	public readonly ICollection<int> Target; // 0x8
	private Dictionary<int, DependencyTreeInitializeOrderSorter.ExplorationMark> m_PackageTypeHashExplorationHistory; // 0x10

	// Methods

	// RVA: 0x37AE50C Offset: 0x37AA50C VA: 0x37AE50C
	public void .ctor(DependencyTree tree, ICollection<int> target) { }

	// RVA: 0x37AE54C Offset: 0x37AA54C VA: 0x37AE54C
	public void SortRegisteredPackagesIntoTarget() { }

	// RVA: 0x37AEA34 Offset: 0x37AAA34 VA: 0x37AEA34
	private void RemoveUnprovidedOptionalDependenciesFromTree() { }

	// RVA: 0x37AEECC Offset: 0x37AAECC VA: 0x37AEECC
	private void RemoveUnprovidedOptionalDependencies(IList<int> dependencyTypeHashes) { }

	// RVA: 0x37AEBE4 Offset: 0x37AABE4 VA: 0x37AEBE4
	private void SortTreeThrough(int packageTypeHash) { }

	// RVA: 0x37AF1D4 Offset: 0x37AB1D4 VA: 0x37AF1D4
	private void SortTreeThrough(IEnumerable<int> dependencyTypeHashes) { }

	// RVA: 0x37AF080 Offset: 0x37AB080 VA: 0x37AF080
	private void MarkPackage(int packageTypeHash, DependencyTreeInitializeOrderSorter.ExplorationMark mark) { }

	// RVA: 0x37AEB8C Offset: 0x37AAB8C VA: 0x37AEB8C
	private IReadOnlyCollection<int> GetPackageTypeHashes() { }

	// RVA: 0x37AF4BC Offset: 0x37AB4BC VA: 0x37AF4BC
	private int GetPackageTypeHashFor(int componentTypeHash) { }

	// RVA: 0x37AF0E8 Offset: 0x37AB0E8 VA: 0x37AF0E8
	private IEnumerable<int> GetDependencyTypeHashesFor(int packageTypeHash) { }
}
