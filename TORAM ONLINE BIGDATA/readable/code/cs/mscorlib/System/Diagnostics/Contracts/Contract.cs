// Assembly: mscorlib.dll
// Namespace: System.Diagnostics.Contracts
public static class Contract // TypeDefIndex: 10848
{
	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: -1 Offset: -1
	public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E27BC Offset: 0x27DE7BC VA: 0x27E27BC
	|-Contract.ForAll<object>
	|
	|-RVA: 0x27E2B1C Offset: 0x27DEB1C VA: 0x27E2B1C
	|-Contract.ForAll<__Il2CppFullySharedGenericType>
	*/
}
