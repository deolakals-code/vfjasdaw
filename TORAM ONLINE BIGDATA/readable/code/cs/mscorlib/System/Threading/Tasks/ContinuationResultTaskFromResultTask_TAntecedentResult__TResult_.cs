// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
internal sealed class ContinuationResultTaskFromResultTask<TAntecedentResult, TResult> : Task<TResult> // TypeDefIndex: 9985
{
	// Fields
	private Task<TAntecedentResult> m_antecedent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task<TAntecedentResult> antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC70A0 Offset: 0x2DC30A0 VA: 0x2DC70A0
	|-ContinuationResultTaskFromResultTask<int, Nullable<int>>..ctor
	|
	|-RVA: 0x2DC7258 Offset: 0x2DC3258 VA: 0x2DC7258
	|-ContinuationResultTaskFromResultTask<Int32Enum, object>..ctor
	|
	|-RVA: 0x2DC7428 Offset: 0x2DC3428 VA: 0x2DC7428
	|-ContinuationResultTaskFromResultTask<object, Nullable<int>>..ctor
	|
	|-RVA: 0x2DC75E0 Offset: 0x2DC35E0 VA: 0x2DC75E0
	|-ContinuationResultTaskFromResultTask<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC7174 Offset: 0x2DC3174 VA: 0x2DC7174
	|-ContinuationResultTaskFromResultTask<int, Nullable<int>>.InnerInvoke
	|
	|-RVA: 0x2DC732C Offset: 0x2DC332C VA: 0x2DC732C
	|-ContinuationResultTaskFromResultTask<Int32Enum, object>.InnerInvoke
	|
	|-RVA: 0x2DC74FC Offset: 0x2DC34FC VA: 0x2DC74FC
	|-ContinuationResultTaskFromResultTask<object, Nullable<int>>.InnerInvoke
	|
	|-RVA: 0x2DC76C4 Offset: 0x2DC36C4 VA: 0x2DC76C4
	|-ContinuationResultTaskFromResultTask<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InnerInvoke
	*/
}
