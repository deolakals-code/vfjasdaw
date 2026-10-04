// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
internal sealed class ContinuationResultTaskFromTask<TResult> : Task<TResult> // TypeDefIndex: 9983
{
	// Fields
	private Task m_antecedent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC7854 Offset: 0x2DC3854 VA: 0x2DC7854
	|-ContinuationResultTaskFromTask<object>..ctor
	|
	|-RVA: 0x2DC7A24 Offset: 0x2DC3A24 VA: 0x2DC7A24
	|-ContinuationResultTaskFromTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC7928 Offset: 0x2DC3928 VA: 0x2DC7928
	|-ContinuationResultTaskFromTask<object>.InnerInvoke
	|
	|-RVA: 0x2DC7B08 Offset: 0x2DC3B08 VA: 0x2DC7B08
	|-ContinuationResultTaskFromTask<__Il2CppFullySharedGenericType>.InnerInvoke
	*/
}
