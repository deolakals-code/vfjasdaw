// Assembly: mscorlib.dll
// Namespace: 
private sealed class ValueTask.ValueTaskSourceAsTask<TResult> : Task<TResult> // TypeDefIndex: 9954
{
	// Fields
	private static readonly Action<object> s_completionAction; // 0x0
	private IValueTaskSource<TResult> _source; // 0x0
	private readonly short _token; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IValueTaskSource<TResult> source, short token) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D052C0 Offset: 0x2D012C0 VA: 0x2D052C0
	|-ValueTask.ValueTaskSourceAsTask<int>..ctor
	|
	|-RVA: 0x2D05514 Offset: 0x2D01514 VA: 0x2D05514
	|-ValueTask.ValueTaskSourceAsTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D053E4 Offset: 0x2D013E4 VA: 0x2D053E4
	|-ValueTask.ValueTaskSourceAsTask<int>..cctor
	|
	|-RVA: 0x2D05664 Offset: 0x2D01664 VA: 0x2D05664
	|-ValueTask.ValueTaskSourceAsTask<__Il2CppFullySharedGenericType>..cctor
	*/
}
