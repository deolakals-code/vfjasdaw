// Assembly: mscorlib.dll
// Namespace: 
private sealed class FileSystemEnumerable.DelegateEnumerator<TResult> : FileSystemEnumerator<TResult> // TypeDefIndex: 10755
{
	// Fields
	private readonly FileSystemEnumerable<TResult> _enumerable; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(FileSystemEnumerable<TResult> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCB09C Offset: 0x2DC709C VA: 0x2DCB09C
	|-FileSystemEnumerable.DelegateEnumerator<object>..ctor
	|
	|-RVA: 0x2DCB180 Offset: 0x2DC7180 VA: 0x2DCB180
	|-FileSystemEnumerable.DelegateEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override TResult TransformEntry(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCB0E4 Offset: 0x2DC70E4 VA: 0x2DCB0E4
	|-FileSystemEnumerable.DelegateEnumerator<object>.TransformEntry
	|
	|-RVA: 0x2DCB1DC Offset: 0x2DC71DC VA: 0x2DCB1DC
	|-FileSystemEnumerable.DelegateEnumerator<__Il2CppFullySharedGenericType>.TransformEntry
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override bool ShouldRecurseIntoEntry(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCB110 Offset: 0x2DC7110 VA: 0x2DCB110
	|-FileSystemEnumerable.DelegateEnumerator<object>.ShouldRecurseIntoEntry
	|
	|-RVA: 0x2DCB2B0 Offset: 0x2DC72B0 VA: 0x2DCB2B0
	|-FileSystemEnumerable.DelegateEnumerator<__Il2CppFullySharedGenericType>.ShouldRecurseIntoEntry
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override bool ShouldIncludeEntry(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCB148 Offset: 0x2DC7148 VA: 0x2DCB148
	|-FileSystemEnumerable.DelegateEnumerator<object>.ShouldIncludeEntry
	|
	|-RVA: 0x2DCB328 Offset: 0x2DC7328 VA: 0x2DCB328
	|-FileSystemEnumerable.DelegateEnumerator<__Il2CppFullySharedGenericType>.ShouldIncludeEntry
	*/
}
