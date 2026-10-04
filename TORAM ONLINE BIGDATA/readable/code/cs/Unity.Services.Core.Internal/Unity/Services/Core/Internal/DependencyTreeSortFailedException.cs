// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
internal class DependencyTreeSortFailedException : Exception // TypeDefIndex: 17567
{
	// Methods

	// RVA: 0x37ACF4C Offset: 0x37A8F4C VA: 0x37ACF4C
	public void .ctor(DependencyTree tree, ICollection<int> target, Exception inner) { }

	// RVA: 0x37ACFE0 Offset: 0x37A8FE0 VA: 0x37ACFE0
	private static string CreateExceptionMessage(DependencyTree tree, ICollection<int> target, Exception inner) { }
}
